﻿using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using Viam.Core;
using Viam.Core.Resources;

namespace Viam.ModularResources
{
    public class ResourceManager : IAsyncDisposable
    {
        private readonly ILogger<ResourceManager> _logger;
        private readonly IServiceProvider _services;
        private readonly ConcurrentDictionary<string, IModularResource> _resources = new();

        public readonly IDictionary<SubType, ResourceInfo>
            RegisteredResources = new Dictionary<SubType, ResourceInfo>();

        public ResourceManager(ILogger<ResourceManager> logger, IServiceProvider services)
        {
            _logger = logger;
            _services = services;
        }

        public IModularResource GetService(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or empty", nameof(name));
            }

            if (_resources.TryGetValue(name, out var resource))
            {
                _logger.LogTrace("Found resource: {ResourceName}", resource.Name);
                return resource;
            }

            throw new ResourceNotFoundException(
                $"Resource {name} not found, resources: {_resources.Select(x => x.Value.Name)}");
        }

        public async Task RemoveResource(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or empty", nameof(name));
            }

            if (_resources.TryRemove(name, out var resource))
            {
                if (resource is IAsyncDisposable asyncDisposable)
                {
                    await asyncDisposable.DisposeAsync();
                }
                else
                {
                    _logger.LogWarning(
                        "Resource {ResourceName} not disposed, does not implement IAsyncDisposable, how did it get injected to start with?",
                        name);
                }

                _logger.LogInformation("Removed service: {ResourceName}", resource.Name);
            }
            else
            {
                _logger.LogWarning("Failed to remove service: {ResourceName}", name);
            }
        }

        public IModularResource ResolveService(string name, SubType subType)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or empty", nameof(name));
            }

            _logger.LogInformation("Getting {ResourceName}", name);
            return _resources.GetOrAdd(name, (s) =>
            {
                var resourceName = new ViamResourceName(subType, name);
                _logger.LogInformation("Creating new instance of {ResourceName}", resourceName);
                var resource = (IModularResource)ActivatorUtilities.CreateInstance(_services,
                    RegisteredResources[subType].Type, resourceName);
                _logger.LogInformation("Created new instance of {ResourceName}", resourceName);
                return resource;
            });
        }

        public void RegisterType<TInterface,
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties |
                                        DynamicallyAccessedMemberTypes.PublicConstructors)]
            TImpl>()
            where TInterface : IComponentBase
            where TImpl : IModularResourceService
        {
            RegisteredResources.Add(TImpl.SubType,
                new(TImpl.SubType, TImpl.Model, Viam.Core.Resources.Service.Lookup<TInterface>(), typeof(TImpl)));
        }

        public async ValueTask DisposeAsync()
        {
            foreach (var resource in _resources.Values)
            {
                if (resource is IAsyncDisposable disposable)
                {
                    await disposable.DisposeAsync();
                }
                else
                {
                    _logger.LogWarning("Resource does not implement IAsyncDisposable");
                }
            }
        }

        public readonly record struct ResourceInfo(
            SubType SubType,
            Model Model,
            Core.Resources.Service ServiceName,
            [property: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]
            Type Type)
        {
            public override string ToString() => $"{Model} - {SubType} - {ServiceName} - {Type.Name}";
        }
    }
}