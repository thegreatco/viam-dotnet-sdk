﻿using System;
using System.Threading.Tasks;

using Grpc.Core;

using Microsoft.Extensions.Logging;
using Viam.Common.V1;
using Viam.Component.Motor.V1;
using Viam.Core.Logging;
using Viam.Core.Utils;

namespace Viam.Core.Resources.Components.Motor
{
    internal class MotorService(ILogger<MotorService> logger) : Component.Motor.V1.MotorService.MotorServiceBase, IServiceBase
    {
        public string ServiceName => "viam.component.motor.v1.MotorService";
        public SubType SubType { get; } = SubType.FromRdkComponent("motor");

        public override async Task<DoCommandResponse> DoCommand(DoCommandRequest request, ServerCallContext context)
        {
            try
            {
                logger.LogMethodInvocationStart(parameters: [request]);
                var resource = (IMotor)context.UserState["resource"];
                var res = await resource.DoCommand(request.Command.ToDictionary(),
                                                   context.Deadline.ToTimeout(),
                                                   context.CancellationToken).ConfigureAwait(false);

                var response = new DoCommandResponse() { Result = res.ToStruct() };
                logger.LogMethodInvocationSuccess(results: response);
                return response;
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }

        public override async Task<StopResponse> Stop(StopRequest request, ServerCallContext context)
        {
            try
            {
                logger.LogMethodInvocationStart(parameters: [request]);
                var resource = (IMotor)context.UserState["resource"];
                await resource.Stop(request.Extra, context.Deadline.ToTimeout(), context.CancellationToken).ConfigureAwait(false);
                var response = new StopResponse();
                logger.LogMethodInvocationSuccess(results: response);
                return response;
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }

        public override async Task<IsMovingResponse> IsMoving(IsMovingRequest request, ServerCallContext context)
        {
            try
            {
                logger.LogMethodInvocationStart(parameters: [request]);
                var resource = (IMotor)context.UserState["resource"];
                var res = await resource.IsMoving(context.Deadline.ToTimeout(), context.CancellationToken).ConfigureAwait(false);
                var response = new IsMovingResponse() { IsMoving = res };
                logger.LogMethodInvocationSuccess(results: response);
                return response;
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }

        public override async Task<GetGeometriesResponse> GetGeometries(GetGeometriesRequest request,
                                                                  ServerCallContext context)
        {
            try
            {
                logger.LogMethodInvocationStart(parameters: [request]);
                var resource = (IMotor)context.UserState["resource"];
                var res = await resource.GetGeometries(request.Extra,
                                                       context.Deadline.ToTimeout(),
                                                       context.CancellationToken).ConfigureAwait(false);

                var response = new GetGeometriesResponse() { Geometries = { res } };
                logger.LogMethodInvocationSuccess(results: response);
                return response;
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }

        public override async Task<GetPropertiesResponse> GetProperties(GetPropertiesRequest request,
                                                                        ServerCallContext context)
        {
            try
            {
                logger.LogMethodInvocationStart(parameters: [request]);
                var resource = (IMotor)context.UserState["resource"];
                var res = await resource.GetProperties(request.Extra,
                                                       context.Deadline.ToTimeout(),
                                                       context.CancellationToken).ConfigureAwait(false);

                var response = new GetPropertiesResponse() { PositionReporting = res.PositionReporting };
                logger.LogMethodInvocationSuccess(results: response);
                return response;
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }

        public override async Task<GetPositionResponse> GetPosition(GetPositionRequest request,
                                                                    ServerCallContext context)
        {
            try
            {
                logger.LogMethodInvocationStart(parameters: [request]);
                var resource = (IMotor)context.UserState["resource"];
                var res = await resource.GetPosition(request.Extra,
                                                     context.Deadline.ToTimeout(),
                                                     context.CancellationToken).ConfigureAwait(false);

                var response = new GetPositionResponse() { Position = res };
                logger.LogMethodInvocationSuccess(results: response);
                return response;
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }

        public override async Task<GoForResponse> GoFor(GoForRequest request, ServerCallContext context)
        {
            try
            {
                logger.LogMethodInvocationStart(parameters: [request]);
                var resource = (IMotor)context.UserState["resource"];
                await resource.GoFor(request.Rpm,
                                     request.Revolutions,
                                     request.Extra,
                                     context.Deadline.ToTimeout(),
                                     context.CancellationToken).ConfigureAwait(false);

                var response = new GoForResponse();
                logger.LogMethodInvocationSuccess(results: response);
                return response;
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }

        public override async Task<GoToResponse> GoTo(GoToRequest request, ServerCallContext context)
        {
            try
            {
                logger.LogMethodInvocationStart(parameters: [request]);
                var resource = (IMotor)context.UserState["resource"];
                await resource.GoTo(request.Rpm,
                                    request.PositionRevolutions,
                                    request.Extra,
                                    context.Deadline.ToTimeout(),
                                    context.CancellationToken).ConfigureAwait(false);

                var response = new GoToResponse();
                logger.LogMethodInvocationSuccess(results: response);
                return response;
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }

        public override async Task<IsPoweredResponse> IsPowered(IsPoweredRequest request, ServerCallContext context)
        {
            try
            {
                logger.LogMethodInvocationStart(parameters: [request]);
                var resource = (IMotor)context.UserState["resource"];
                var res = await resource.IsPowered(request.Extra, context.Deadline.ToTimeout(), context.CancellationToken).ConfigureAwait(false);
                var response = new IsPoweredResponse() { IsOn = res.IsOn, PowerPct = res.PowerPct };
                logger.LogMethodInvocationSuccess(results: response);
                return response;
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }

        public override async Task<ResetZeroPositionResponse> ResetZeroPosition(
            ResetZeroPositionRequest request,
            ServerCallContext context)
        {
            try
            {
                logger.LogMethodInvocationStart(parameters: [request]);
                var resource = (IMotor)context.UserState["resource"];
                await resource.ResetZeroPosition(request.Offset,
                                                 request.Extra,
                                                 context.Deadline.ToTimeout(),
                                                 context.CancellationToken).ConfigureAwait(false);

                var response = new ResetZeroPositionResponse();
                logger.LogMethodInvocationSuccess(results: response);
                return response;
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }

        public override async Task<SetPowerResponse> SetPower(SetPowerRequest request, ServerCallContext context)
        {
            try
            {
                logger.LogMethodInvocationStart(parameters: [request]);
                var resource = (IMotor)context.UserState["resource"];
                await resource.SetPower(request.PowerPct,
                                        request.Extra,
                                        context.Deadline.ToTimeout(),
                                        context.CancellationToken).ConfigureAwait(false);

                var response = new SetPowerResponse();
                logger.LogMethodInvocationSuccess(results: response);
                return response;
            }
            catch (Exception ex)
            {
                logger.LogMethodInvocationFailure(ex);
                throw;
            }
        }
    }
}
