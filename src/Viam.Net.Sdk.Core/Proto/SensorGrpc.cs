// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: component/sensor/v1/sensor.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Viam.Component.Sensor.V1 {
  /// <summary>
  /// SensorService services all generic sensors associated with a robot
  /// </summary>
  public static partial class SensorService
  {
    static readonly string __ServiceName = "viam.component.sensor.v1.SensorService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.Common.V1.GetReadingsRequest> __Marshaller_viam_common_v1_GetReadingsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.Common.V1.GetReadingsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.Common.V1.GetReadingsResponse> __Marshaller_viam_common_v1_GetReadingsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.Common.V1.GetReadingsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.Common.V1.DoCommandRequest> __Marshaller_viam_common_v1_DoCommandRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.Common.V1.DoCommandRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.Common.V1.DoCommandResponse> __Marshaller_viam_common_v1_DoCommandResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.Common.V1.DoCommandResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.Common.V1.GetGeometriesRequest> __Marshaller_viam_common_v1_GetGeometriesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.Common.V1.GetGeometriesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.Common.V1.GetGeometriesResponse> __Marshaller_viam_common_v1_GetGeometriesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.Common.V1.GetGeometriesResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Viam.Common.V1.GetReadingsRequest, global::Viam.Common.V1.GetReadingsResponse> __Method_GetReadings = new grpc::Method<global::Viam.Common.V1.GetReadingsRequest, global::Viam.Common.V1.GetReadingsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetReadings",
        __Marshaller_viam_common_v1_GetReadingsRequest,
        __Marshaller_viam_common_v1_GetReadingsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Viam.Common.V1.DoCommandRequest, global::Viam.Common.V1.DoCommandResponse> __Method_DoCommand = new grpc::Method<global::Viam.Common.V1.DoCommandRequest, global::Viam.Common.V1.DoCommandResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DoCommand",
        __Marshaller_viam_common_v1_DoCommandRequest,
        __Marshaller_viam_common_v1_DoCommandResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Viam.Common.V1.GetGeometriesRequest, global::Viam.Common.V1.GetGeometriesResponse> __Method_GetGeometries = new grpc::Method<global::Viam.Common.V1.GetGeometriesRequest, global::Viam.Common.V1.GetGeometriesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetGeometries",
        __Marshaller_viam_common_v1_GetGeometriesRequest,
        __Marshaller_viam_common_v1_GetGeometriesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Viam.Component.Sensor.V1.SensorReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SensorService</summary>
    [grpc::BindServiceMethod(typeof(SensorService), "BindService")]
    public abstract partial class SensorServiceBase
    {
      /// <summary>
      /// GetReadings returns the readings of a sensor of the underlying robot.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Viam.Common.V1.GetReadingsResponse> GetReadings(global::Viam.Common.V1.GetReadingsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// DoCommand sends/receives arbitrary commands
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Viam.Common.V1.DoCommandResponse> DoCommand(global::Viam.Common.V1.DoCommandRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// GetGeometries returns the geometries of the component in their current configuration
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Viam.Common.V1.GetGeometriesResponse> GetGeometries(global::Viam.Common.V1.GetGeometriesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SensorService</summary>
    public partial class SensorServiceClient : grpc::ClientBase<SensorServiceClient>
    {
      /// <summary>Creates a new client for SensorService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SensorServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SensorService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SensorServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SensorServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SensorServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// GetReadings returns the readings of a sensor of the underlying robot.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.Common.V1.GetReadingsResponse GetReadings(global::Viam.Common.V1.GetReadingsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetReadings(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// GetReadings returns the readings of a sensor of the underlying robot.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.Common.V1.GetReadingsResponse GetReadings(global::Viam.Common.V1.GetReadingsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetReadings, null, options, request);
      }
      /// <summary>
      /// GetReadings returns the readings of a sensor of the underlying robot.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.Common.V1.GetReadingsResponse> GetReadingsAsync(global::Viam.Common.V1.GetReadingsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetReadingsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// GetReadings returns the readings of a sensor of the underlying robot.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.Common.V1.GetReadingsResponse> GetReadingsAsync(global::Viam.Common.V1.GetReadingsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetReadings, null, options, request);
      }
      /// <summary>
      /// DoCommand sends/receives arbitrary commands
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.Common.V1.DoCommandResponse DoCommand(global::Viam.Common.V1.DoCommandRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DoCommand(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// DoCommand sends/receives arbitrary commands
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.Common.V1.DoCommandResponse DoCommand(global::Viam.Common.V1.DoCommandRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DoCommand, null, options, request);
      }
      /// <summary>
      /// DoCommand sends/receives arbitrary commands
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.Common.V1.DoCommandResponse> DoCommandAsync(global::Viam.Common.V1.DoCommandRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DoCommandAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// DoCommand sends/receives arbitrary commands
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.Common.V1.DoCommandResponse> DoCommandAsync(global::Viam.Common.V1.DoCommandRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DoCommand, null, options, request);
      }
      /// <summary>
      /// GetGeometries returns the geometries of the component in their current configuration
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.Common.V1.GetGeometriesResponse GetGeometries(global::Viam.Common.V1.GetGeometriesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetGeometries(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// GetGeometries returns the geometries of the component in their current configuration
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.Common.V1.GetGeometriesResponse GetGeometries(global::Viam.Common.V1.GetGeometriesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetGeometries, null, options, request);
      }
      /// <summary>
      /// GetGeometries returns the geometries of the component in their current configuration
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.Common.V1.GetGeometriesResponse> GetGeometriesAsync(global::Viam.Common.V1.GetGeometriesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetGeometriesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// GetGeometries returns the geometries of the component in their current configuration
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.Common.V1.GetGeometriesResponse> GetGeometriesAsync(global::Viam.Common.V1.GetGeometriesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetGeometries, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override SensorServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SensorServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(SensorServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetReadings, serviceImpl.GetReadings)
          .AddMethod(__Method_DoCommand, serviceImpl.DoCommand)
          .AddMethod(__Method_GetGeometries, serviceImpl.GetGeometries).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SensorServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetReadings, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Viam.Common.V1.GetReadingsRequest, global::Viam.Common.V1.GetReadingsResponse>(serviceImpl.GetReadings));
      serviceBinder.AddMethod(__Method_DoCommand, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Viam.Common.V1.DoCommandRequest, global::Viam.Common.V1.DoCommandResponse>(serviceImpl.DoCommand));
      serviceBinder.AddMethod(__Method_GetGeometries, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Viam.Common.V1.GetGeometriesRequest, global::Viam.Common.V1.GetGeometriesResponse>(serviceImpl.GetGeometries));
    }

  }
}
#endregion
