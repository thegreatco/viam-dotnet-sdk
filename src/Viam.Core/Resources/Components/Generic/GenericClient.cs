﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.Logging;
using Viam.Common.V1;
using Viam.Core.Logging;
using Viam.Core.Utils;

namespace Viam.Core.Resources.Components.Generic
{
    public class GenericClient(ResourceName resourceName, ViamChannel channel, ILogger logger) :
        ComponentBase<GenericClient, Component.Generic.V1.GenericService.GenericServiceClient>(resourceName, new Component.Generic.V1.GenericService.GenericServiceClient(channel)),
        IGeneric
    {
        public override DateTime? LastReconfigured { get; }

        public override async ValueTask<IDictionary<string, object?>> DoCommand(
            IDictionary<string, object?> command,
            TimeSpan? timeout = null,
            CancellationToken cancellationToken = default)
        {
            logger.LogMethodInvocationStart(parameters: [Name, command]);
            try
            {
                var res = await Client
                                .DoCommandAsync(
                                    new DoCommandRequest() { Name = ResourceName.Name, Command = command.ToStruct() },
                                    deadline: timeout.ToDeadline(),
                                    cancellationToken: cancellationToken)
                                .ConfigureAwait(false);

                var response = res.Result.ToDictionary();
                logger.LogMethodInvocationSuccess(results: response);
                return response;
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }

        public override ValueTask StopResource() => throw new NotImplementedException();


        public async ValueTask<Geometry[]> GetGeometries(Struct? extra = null,
                                                   TimeSpan? timeout = null,
                                                   CancellationToken cancellationToken = default)
        {
            logger.LogMethodInvocationStart(parameters: [Name]);
            try
            {
                var res = await Client.GetGeometriesAsync(
                                          new GetGeometriesRequest() { Name = ResourceName.Name, Extra = extra },
                                          deadline: timeout.ToDeadline(),
                                          cancellationToken: cancellationToken)
                                      .ConfigureAwait(false);

                var geometry = res.Geometries.ToArray();
                logger.LogMethodInvocationSuccess(results: geometry);
                return geometry;
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }
    }
}
