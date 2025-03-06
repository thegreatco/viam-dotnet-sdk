﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.Logging;
using Viam.Common.V1;
using Viam.Component.Gantry.V1;
using Viam.Core.Clients;
using Viam.Core.Logging;
using Viam.Core.Utils;

namespace Viam.Core.Resources.Components.Gantry
{
    public class GantryClient(ViamResourceName resourceName, ViamChannel channel, ILogger logger) :
        ComponentBase<GantryClient, Component.Gantry.V1.GantryService.GantryServiceClient>(resourceName, new Component.Gantry.V1.GantryService.GantryServiceClient(channel)),
        IGantry
    {
        static GantryClient() => Registry.RegisterSubtype(new ComponentRegistration(SubType, (name, channel, logger) => new GantryClient(name, channel, logger)));
        public static SubType SubType = SubType.FromRdkComponent("gantry");


        public static IGantry FromRobot(RobotClientBase client, string name)
        {
            var resourceName = new ViamResourceName(SubType, name);
            return client.GetComponent<GantryClient>(resourceName);
        }

        public override DateTime? LastReconfigured => null;

        public override ValueTask StopResource() => Stop();

        public override async ValueTask<IDictionary<string, object?>> DoCommand(IDictionary<string, object?> command,
            TimeSpan? timeout = null,
            CancellationToken cancellationToken = default)
        {
            try
            {
                logger.LogMethodInvocationStart(parameters: command);
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


        public async ValueTask<double[]> GetPosition(Struct? extra = null,
                                                     TimeSpan? timeout = null,
                                                     CancellationToken cancellationToken = default)
        {
            try
            {
                logger.LogMethodInvocationStart();
                var res = await Client.GetPositionAsync(new GetPositionRequest() { Name = Name, Extra = extra },
                                                        deadline: timeout.ToDeadline(),
                                                        cancellationToken: cancellationToken)
                                      .ConfigureAwait(false);

                var positions = res.PositionsMm.ToArray();
                logger.LogMethodInvocationSuccess(results: positions);
                return positions;
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }


        public async ValueTask MoveToPosition(double[] positions,
                                              double[] speeds,
                                              Struct? extra = null,
                                              TimeSpan? timeout = null,
                                              CancellationToken cancellationToken = default)
        {
            try
            {
                logger.LogMethodInvocationStart(parameters: [Name, positions, speeds]);
                await Client.MoveToPositionAsync(new MoveToPositionRequest()
                {
                    Name = Name,
                    PositionsMm = { positions },
                    SpeedsMmPerSec = { speeds },
                    Extra = extra
                },
                                                 deadline: timeout.ToDeadline(),
                                                 cancellationToken: cancellationToken)
                            .ConfigureAwait(false);
                logger.LogMethodInvocationSuccess();
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }


        public async ValueTask Home(Struct? extra = null,
                                    TimeSpan? timeout = null,
                                    CancellationToken cancellationToken = default)
        {
            try
            {
                logger.LogMethodInvocationStart(parameters: Name);
                await Client.HomeAsync(new HomeRequest() { Name = Name, Extra = extra },
                                       deadline: timeout.ToDeadline(),
                                       cancellationToken: cancellationToken)
                            .ConfigureAwait(false);
                logger.LogMethodInvocationSuccess();
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }


        public async ValueTask<double[]> GetLengths(Struct? extra = null,
                                                    TimeSpan? timeout = null,
                                                    CancellationToken cancellationToken = default)
        {
            try
            {
                logger.LogMethodInvocationStart(parameters: Name);
                var res = await Client.GetLengthsAsync(new GetLengthsRequest() { Name = Name, Extra = extra },
                                                       deadline: timeout.ToDeadline(),
                                                       cancellationToken: cancellationToken)
                                      .ConfigureAwait(false);

                var lengths = res.LengthsMm.ToArray();
                logger.LogMethodInvocationSuccess(results: lengths);
                return lengths;
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }


        public async ValueTask Stop(Struct? extra = null,
                                    TimeSpan? timeout = null,
                                    CancellationToken cancellationToken = default)
        {
            try
            {
                logger.LogMethodInvocationStart(parameters: Name);
                await Client.StopAsync(new StopRequest() { Name = Name, Extra = extra },
                                       deadline: timeout.ToDeadline(),
                                       cancellationToken: cancellationToken)
                            .ConfigureAwait(false);
                logger.LogMethodInvocationSuccess();
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }


        public async ValueTask<bool> IsMoving(TimeSpan? timeout = null,
                                              CancellationToken cancellationToken = default)
        {
            try
            {
                logger.LogMethodInvocationStart(parameters: Name);
                var res = await Client.IsMovingAsync(new IsMovingRequest() { Name = Name },
                                                     deadline: timeout.ToDeadline(),
                                                     cancellationToken: cancellationToken)
                                      .ConfigureAwait(false);
                logger.LogMethodInvocationSuccess(results: res.IsMoving);
                return res.IsMoving;
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }


        public async ValueTask<Geometry[]> GetGeometries(Struct? extra = null,
                                                         TimeSpan? timeout = null,
                                                         CancellationToken cancellationToken = default)
        {
            try
            {
                logger.LogMethodInvocationStart(parameters: Name);
                var res = await Client.GetGeometriesAsync(new GetGeometriesRequest() { Name = Name, Extra = extra },
                                                          deadline: timeout.ToDeadline(),
                                                          cancellationToken: cancellationToken)
                                      .ConfigureAwait(false);

                var geometries = res.Geometries.ToArray();
                logger.LogMethodInvocationSuccess(results: geometries);
                return geometries;
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }
    }
}
