// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: component/switch/v1/switch.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Viam.Component.Switch.V1 {
  /// <summary>
  /// A SwitchService services switches associated with a machine.
  /// Switches can have multiple discrete positions - e.g. a simple
  /// switch has 2 positions, but a knob could have 10 positions.
  /// </summary>
  public static partial class SwitchService
  {
    static readonly string __ServiceName = "viam.component.switch.v1.SwitchService";

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
    static readonly grpc::Marshaller<global::Viam.Component.Switch.V1.SetPositionRequest> __Marshaller_viam_component_switch_v1_SetPositionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.Component.Switch.V1.SetPositionRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.Component.Switch.V1.SetPositionResponse> __Marshaller_viam_component_switch_v1_SetPositionResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.Component.Switch.V1.SetPositionResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.Component.Switch.V1.GetPositionRequest> __Marshaller_viam_component_switch_v1_GetPositionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.Component.Switch.V1.GetPositionRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.Component.Switch.V1.GetPositionResponse> __Marshaller_viam_component_switch_v1_GetPositionResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.Component.Switch.V1.GetPositionResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.Component.Switch.V1.GetNumberOfPositionsRequest> __Marshaller_viam_component_switch_v1_GetNumberOfPositionsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.Component.Switch.V1.GetNumberOfPositionsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.Component.Switch.V1.GetNumberOfPositionsResponse> __Marshaller_viam_component_switch_v1_GetNumberOfPositionsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.Component.Switch.V1.GetNumberOfPositionsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.Common.V1.DoCommandRequest> __Marshaller_viam_common_v1_DoCommandRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.Common.V1.DoCommandRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.Common.V1.DoCommandResponse> __Marshaller_viam_common_v1_DoCommandResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.Common.V1.DoCommandResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Viam.Component.Switch.V1.SetPositionRequest, global::Viam.Component.Switch.V1.SetPositionResponse> __Method_SetPosition = new grpc::Method<global::Viam.Component.Switch.V1.SetPositionRequest, global::Viam.Component.Switch.V1.SetPositionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SetPosition",
        __Marshaller_viam_component_switch_v1_SetPositionRequest,
        __Marshaller_viam_component_switch_v1_SetPositionResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Viam.Component.Switch.V1.GetPositionRequest, global::Viam.Component.Switch.V1.GetPositionResponse> __Method_GetPosition = new grpc::Method<global::Viam.Component.Switch.V1.GetPositionRequest, global::Viam.Component.Switch.V1.GetPositionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPosition",
        __Marshaller_viam_component_switch_v1_GetPositionRequest,
        __Marshaller_viam_component_switch_v1_GetPositionResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Viam.Component.Switch.V1.GetNumberOfPositionsRequest, global::Viam.Component.Switch.V1.GetNumberOfPositionsResponse> __Method_GetNumberOfPositions = new grpc::Method<global::Viam.Component.Switch.V1.GetNumberOfPositionsRequest, global::Viam.Component.Switch.V1.GetNumberOfPositionsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetNumberOfPositions",
        __Marshaller_viam_component_switch_v1_GetNumberOfPositionsRequest,
        __Marshaller_viam_component_switch_v1_GetNumberOfPositionsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Viam.Common.V1.DoCommandRequest, global::Viam.Common.V1.DoCommandResponse> __Method_DoCommand = new grpc::Method<global::Viam.Common.V1.DoCommandRequest, global::Viam.Common.V1.DoCommandResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DoCommand",
        __Marshaller_viam_common_v1_DoCommandRequest,
        __Marshaller_viam_common_v1_DoCommandResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Viam.Component.Switch.V1.SwitchReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SwitchService</summary>
    [grpc::BindServiceMethod(typeof(SwitchService), "BindService")]
    public abstract partial class SwitchServiceBase
    {
      /// <summary>
      /// Set the position of the switch
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Viam.Component.Switch.V1.SetPositionResponse> SetPosition(global::Viam.Component.Switch.V1.SetPositionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Get the position of the switch
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Viam.Component.Switch.V1.GetPositionResponse> GetPosition(global::Viam.Component.Switch.V1.GetPositionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Get the number of positions that the switch supports
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Viam.Component.Switch.V1.GetNumberOfPositionsResponse> GetNumberOfPositions(global::Viam.Component.Switch.V1.GetNumberOfPositionsRequest request, grpc::ServerCallContext context)
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

    }

    /// <summary>Client for SwitchService</summary>
    public partial class SwitchServiceClient : grpc::ClientBase<SwitchServiceClient>
    {
      /// <summary>Creates a new client for SwitchService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SwitchServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SwitchService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SwitchServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SwitchServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SwitchServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Set the position of the switch
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.Component.Switch.V1.SetPositionResponse SetPosition(global::Viam.Component.Switch.V1.SetPositionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetPosition(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Set the position of the switch
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.Component.Switch.V1.SetPositionResponse SetPosition(global::Viam.Component.Switch.V1.SetPositionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetPosition, null, options, request);
      }
      /// <summary>
      /// Set the position of the switch
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.Component.Switch.V1.SetPositionResponse> SetPositionAsync(global::Viam.Component.Switch.V1.SetPositionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetPositionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Set the position of the switch
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.Component.Switch.V1.SetPositionResponse> SetPositionAsync(global::Viam.Component.Switch.V1.SetPositionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetPosition, null, options, request);
      }
      /// <summary>
      /// Get the position of the switch
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.Component.Switch.V1.GetPositionResponse GetPosition(global::Viam.Component.Switch.V1.GetPositionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPosition(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get the position of the switch
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.Component.Switch.V1.GetPositionResponse GetPosition(global::Viam.Component.Switch.V1.GetPositionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPosition, null, options, request);
      }
      /// <summary>
      /// Get the position of the switch
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.Component.Switch.V1.GetPositionResponse> GetPositionAsync(global::Viam.Component.Switch.V1.GetPositionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPositionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get the position of the switch
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.Component.Switch.V1.GetPositionResponse> GetPositionAsync(global::Viam.Component.Switch.V1.GetPositionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPosition, null, options, request);
      }
      /// <summary>
      /// Get the number of positions that the switch supports
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.Component.Switch.V1.GetNumberOfPositionsResponse GetNumberOfPositions(global::Viam.Component.Switch.V1.GetNumberOfPositionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetNumberOfPositions(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get the number of positions that the switch supports
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.Component.Switch.V1.GetNumberOfPositionsResponse GetNumberOfPositions(global::Viam.Component.Switch.V1.GetNumberOfPositionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetNumberOfPositions, null, options, request);
      }
      /// <summary>
      /// Get the number of positions that the switch supports
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.Component.Switch.V1.GetNumberOfPositionsResponse> GetNumberOfPositionsAsync(global::Viam.Component.Switch.V1.GetNumberOfPositionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetNumberOfPositionsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get the number of positions that the switch supports
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.Component.Switch.V1.GetNumberOfPositionsResponse> GetNumberOfPositionsAsync(global::Viam.Component.Switch.V1.GetNumberOfPositionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetNumberOfPositions, null, options, request);
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
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override SwitchServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SwitchServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(SwitchServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SetPosition, serviceImpl.SetPosition)
          .AddMethod(__Method_GetPosition, serviceImpl.GetPosition)
          .AddMethod(__Method_GetNumberOfPositions, serviceImpl.GetNumberOfPositions)
          .AddMethod(__Method_DoCommand, serviceImpl.DoCommand).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SwitchServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SetPosition, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Viam.Component.Switch.V1.SetPositionRequest, global::Viam.Component.Switch.V1.SetPositionResponse>(serviceImpl.SetPosition));
      serviceBinder.AddMethod(__Method_GetPosition, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Viam.Component.Switch.V1.GetPositionRequest, global::Viam.Component.Switch.V1.GetPositionResponse>(serviceImpl.GetPosition));
      serviceBinder.AddMethod(__Method_GetNumberOfPositions, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Viam.Component.Switch.V1.GetNumberOfPositionsRequest, global::Viam.Component.Switch.V1.GetNumberOfPositionsResponse>(serviceImpl.GetNumberOfPositions));
      serviceBinder.AddMethod(__Method_DoCommand, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Viam.Common.V1.DoCommandRequest, global::Viam.Common.V1.DoCommandResponse>(serviceImpl.DoCommand));
    }

  }
}
#endregion
