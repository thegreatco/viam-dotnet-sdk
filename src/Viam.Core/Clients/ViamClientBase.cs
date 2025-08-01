﻿using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Viam.App.V1;
using Viam.Core.App;
using Viam.Provisioning.V1;

namespace Viam.Core.Clients
{
    public class ViamClientBase : IViamClient
    {
        private readonly ILoggerFactory _loggerFactory;
        protected readonly ILogger<ViamClientBase> Logger;
        private readonly ViamChannel _channel;

        protected internal ViamClientBase(ILoggerFactory loggerFactory, ViamChannel channel)
        {
            _loggerFactory = loggerFactory;
            _channel = channel;
            Logger = loggerFactory.CreateLogger<ViamClientBase>();
        }

        public AppClient CreateAppClient() => new(_loggerFactory.CreateLogger<AppClient>(),
            new AppService.AppServiceClient(_channel));

        public DataClient CreateDataClient() =>
            throw new NotImplementedException(); // new(_loggerFactory.CreateLogger<DataClient>(), new DataService.DataServiceClient(_channel));

        public BillingClient CreateBillingClient() => new(_loggerFactory.CreateLogger<BillingClient>(),
            new BillingService.BillingServiceClient(_channel));

        public MlTrainingClient CreateMlTrainingClient() =>
            throw new NotImplementedException(); // new(_loggerFactory.CreateLogger<MlTrainingClient>(), new MLModelService.MLModelServiceClient(_channel));

        public ProvisioningClient CreateProvisioningClient() => new(_loggerFactory.CreateLogger<ProvisioningClient>(),
            new ProvisioningService.ProvisioningServiceClient(_channel));

        public async ValueTask DisposeAsync()
        {
            await CastAndDispose(_loggerFactory);
            await CastAndDispose(_channel);

            GC.SuppressFinalize(this);
            return;

            static async ValueTask CastAndDispose(IDisposable resource)
            {
                if (resource is IAsyncDisposable resourceAsyncDisposable)
                    await resourceAsyncDisposable.DisposeAsync();
                else
                    resource.Dispose();
            }
        }
    }
}