// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: app/dataset/v1/dataset.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Viam.App.Dataset.V1 {
  /// <summary>
  /// DatasetService is used to manage datasets.
  /// </summary>
  public static partial class DatasetService
  {
    static readonly string __ServiceName = "viam.app.dataset.v1.DatasetService";

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
    static readonly grpc::Marshaller<global::Viam.App.Dataset.V1.CreateDatasetRequest> __Marshaller_viam_app_dataset_v1_CreateDatasetRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.App.Dataset.V1.CreateDatasetRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.App.Dataset.V1.CreateDatasetResponse> __Marshaller_viam_app_dataset_v1_CreateDatasetResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.App.Dataset.V1.CreateDatasetResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.App.Dataset.V1.DeleteDatasetRequest> __Marshaller_viam_app_dataset_v1_DeleteDatasetRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.App.Dataset.V1.DeleteDatasetRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.App.Dataset.V1.DeleteDatasetResponse> __Marshaller_viam_app_dataset_v1_DeleteDatasetResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.App.Dataset.V1.DeleteDatasetResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.App.Dataset.V1.RenameDatasetRequest> __Marshaller_viam_app_dataset_v1_RenameDatasetRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.App.Dataset.V1.RenameDatasetRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.App.Dataset.V1.RenameDatasetResponse> __Marshaller_viam_app_dataset_v1_RenameDatasetResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.App.Dataset.V1.RenameDatasetResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDRequest> __Marshaller_viam_app_dataset_v1_ListDatasetsByOrganizationIDRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDResponse> __Marshaller_viam_app_dataset_v1_ListDatasetsByOrganizationIDResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.App.Dataset.V1.ListDatasetsByIDsRequest> __Marshaller_viam_app_dataset_v1_ListDatasetsByIDsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.App.Dataset.V1.ListDatasetsByIDsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Viam.App.Dataset.V1.ListDatasetsByIDsResponse> __Marshaller_viam_app_dataset_v1_ListDatasetsByIDsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Viam.App.Dataset.V1.ListDatasetsByIDsResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Viam.App.Dataset.V1.CreateDatasetRequest, global::Viam.App.Dataset.V1.CreateDatasetResponse> __Method_CreateDataset = new grpc::Method<global::Viam.App.Dataset.V1.CreateDatasetRequest, global::Viam.App.Dataset.V1.CreateDatasetResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateDataset",
        __Marshaller_viam_app_dataset_v1_CreateDatasetRequest,
        __Marshaller_viam_app_dataset_v1_CreateDatasetResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Viam.App.Dataset.V1.DeleteDatasetRequest, global::Viam.App.Dataset.V1.DeleteDatasetResponse> __Method_DeleteDataset = new grpc::Method<global::Viam.App.Dataset.V1.DeleteDatasetRequest, global::Viam.App.Dataset.V1.DeleteDatasetResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteDataset",
        __Marshaller_viam_app_dataset_v1_DeleteDatasetRequest,
        __Marshaller_viam_app_dataset_v1_DeleteDatasetResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Viam.App.Dataset.V1.RenameDatasetRequest, global::Viam.App.Dataset.V1.RenameDatasetResponse> __Method_RenameDataset = new grpc::Method<global::Viam.App.Dataset.V1.RenameDatasetRequest, global::Viam.App.Dataset.V1.RenameDatasetResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RenameDataset",
        __Marshaller_viam_app_dataset_v1_RenameDatasetRequest,
        __Marshaller_viam_app_dataset_v1_RenameDatasetResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDRequest, global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDResponse> __Method_ListDatasetsByOrganizationID = new grpc::Method<global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDRequest, global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListDatasetsByOrganizationID",
        __Marshaller_viam_app_dataset_v1_ListDatasetsByOrganizationIDRequest,
        __Marshaller_viam_app_dataset_v1_ListDatasetsByOrganizationIDResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Viam.App.Dataset.V1.ListDatasetsByIDsRequest, global::Viam.App.Dataset.V1.ListDatasetsByIDsResponse> __Method_ListDatasetsByIDs = new grpc::Method<global::Viam.App.Dataset.V1.ListDatasetsByIDsRequest, global::Viam.App.Dataset.V1.ListDatasetsByIDsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListDatasetsByIDs",
        __Marshaller_viam_app_dataset_v1_ListDatasetsByIDsRequest,
        __Marshaller_viam_app_dataset_v1_ListDatasetsByIDsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Viam.App.Dataset.V1.DatasetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DatasetService</summary>
    [grpc::BindServiceMethod(typeof(DatasetService), "BindService")]
    public abstract partial class DatasetServiceBase
    {
      /// <summary>
      /// CreateDataset makes a new dataset.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Viam.App.Dataset.V1.CreateDatasetResponse> CreateDataset(global::Viam.App.Dataset.V1.CreateDatasetRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// DeleteDatasets deletes an existing dataset.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Viam.App.Dataset.V1.DeleteDatasetResponse> DeleteDataset(global::Viam.App.Dataset.V1.DeleteDatasetRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// RenameDataset modifies the name of an existing dataset.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Viam.App.Dataset.V1.RenameDatasetResponse> RenameDataset(global::Viam.App.Dataset.V1.RenameDatasetRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// ListDatasetsByOrganizationID lists all of the datasets for an organization.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDResponse> ListDatasetsByOrganizationID(global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// ListDatasetsByIDs lists all of the datasets specified by the given dataset IDs.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Viam.App.Dataset.V1.ListDatasetsByIDsResponse> ListDatasetsByIDs(global::Viam.App.Dataset.V1.ListDatasetsByIDsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DatasetService</summary>
    public partial class DatasetServiceClient : grpc::ClientBase<DatasetServiceClient>
    {
      /// <summary>Creates a new client for DatasetService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public DatasetServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DatasetService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public DatasetServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected DatasetServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected DatasetServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// CreateDataset makes a new dataset.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.App.Dataset.V1.CreateDatasetResponse CreateDataset(global::Viam.App.Dataset.V1.CreateDatasetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateDataset(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// CreateDataset makes a new dataset.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.App.Dataset.V1.CreateDatasetResponse CreateDataset(global::Viam.App.Dataset.V1.CreateDatasetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateDataset, null, options, request);
      }
      /// <summary>
      /// CreateDataset makes a new dataset.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.App.Dataset.V1.CreateDatasetResponse> CreateDatasetAsync(global::Viam.App.Dataset.V1.CreateDatasetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateDatasetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// CreateDataset makes a new dataset.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.App.Dataset.V1.CreateDatasetResponse> CreateDatasetAsync(global::Viam.App.Dataset.V1.CreateDatasetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateDataset, null, options, request);
      }
      /// <summary>
      /// DeleteDatasets deletes an existing dataset.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.App.Dataset.V1.DeleteDatasetResponse DeleteDataset(global::Viam.App.Dataset.V1.DeleteDatasetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteDataset(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// DeleteDatasets deletes an existing dataset.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.App.Dataset.V1.DeleteDatasetResponse DeleteDataset(global::Viam.App.Dataset.V1.DeleteDatasetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteDataset, null, options, request);
      }
      /// <summary>
      /// DeleteDatasets deletes an existing dataset.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.App.Dataset.V1.DeleteDatasetResponse> DeleteDatasetAsync(global::Viam.App.Dataset.V1.DeleteDatasetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteDatasetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// DeleteDatasets deletes an existing dataset.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.App.Dataset.V1.DeleteDatasetResponse> DeleteDatasetAsync(global::Viam.App.Dataset.V1.DeleteDatasetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteDataset, null, options, request);
      }
      /// <summary>
      /// RenameDataset modifies the name of an existing dataset.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.App.Dataset.V1.RenameDatasetResponse RenameDataset(global::Viam.App.Dataset.V1.RenameDatasetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RenameDataset(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// RenameDataset modifies the name of an existing dataset.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.App.Dataset.V1.RenameDatasetResponse RenameDataset(global::Viam.App.Dataset.V1.RenameDatasetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RenameDataset, null, options, request);
      }
      /// <summary>
      /// RenameDataset modifies the name of an existing dataset.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.App.Dataset.V1.RenameDatasetResponse> RenameDatasetAsync(global::Viam.App.Dataset.V1.RenameDatasetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RenameDatasetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// RenameDataset modifies the name of an existing dataset.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.App.Dataset.V1.RenameDatasetResponse> RenameDatasetAsync(global::Viam.App.Dataset.V1.RenameDatasetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RenameDataset, null, options, request);
      }
      /// <summary>
      /// ListDatasetsByOrganizationID lists all of the datasets for an organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDResponse ListDatasetsByOrganizationID(global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListDatasetsByOrganizationID(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ListDatasetsByOrganizationID lists all of the datasets for an organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDResponse ListDatasetsByOrganizationID(global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListDatasetsByOrganizationID, null, options, request);
      }
      /// <summary>
      /// ListDatasetsByOrganizationID lists all of the datasets for an organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDResponse> ListDatasetsByOrganizationIDAsync(global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListDatasetsByOrganizationIDAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ListDatasetsByOrganizationID lists all of the datasets for an organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDResponse> ListDatasetsByOrganizationIDAsync(global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListDatasetsByOrganizationID, null, options, request);
      }
      /// <summary>
      /// ListDatasetsByIDs lists all of the datasets specified by the given dataset IDs.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.App.Dataset.V1.ListDatasetsByIDsResponse ListDatasetsByIDs(global::Viam.App.Dataset.V1.ListDatasetsByIDsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListDatasetsByIDs(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ListDatasetsByIDs lists all of the datasets specified by the given dataset IDs.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Viam.App.Dataset.V1.ListDatasetsByIDsResponse ListDatasetsByIDs(global::Viam.App.Dataset.V1.ListDatasetsByIDsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListDatasetsByIDs, null, options, request);
      }
      /// <summary>
      /// ListDatasetsByIDs lists all of the datasets specified by the given dataset IDs.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.App.Dataset.V1.ListDatasetsByIDsResponse> ListDatasetsByIDsAsync(global::Viam.App.Dataset.V1.ListDatasetsByIDsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListDatasetsByIDsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ListDatasetsByIDs lists all of the datasets specified by the given dataset IDs.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Viam.App.Dataset.V1.ListDatasetsByIDsResponse> ListDatasetsByIDsAsync(global::Viam.App.Dataset.V1.ListDatasetsByIDsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListDatasetsByIDs, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override DatasetServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DatasetServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(DatasetServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateDataset, serviceImpl.CreateDataset)
          .AddMethod(__Method_DeleteDataset, serviceImpl.DeleteDataset)
          .AddMethod(__Method_RenameDataset, serviceImpl.RenameDataset)
          .AddMethod(__Method_ListDatasetsByOrganizationID, serviceImpl.ListDatasetsByOrganizationID)
          .AddMethod(__Method_ListDatasetsByIDs, serviceImpl.ListDatasetsByIDs).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DatasetServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateDataset, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Viam.App.Dataset.V1.CreateDatasetRequest, global::Viam.App.Dataset.V1.CreateDatasetResponse>(serviceImpl.CreateDataset));
      serviceBinder.AddMethod(__Method_DeleteDataset, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Viam.App.Dataset.V1.DeleteDatasetRequest, global::Viam.App.Dataset.V1.DeleteDatasetResponse>(serviceImpl.DeleteDataset));
      serviceBinder.AddMethod(__Method_RenameDataset, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Viam.App.Dataset.V1.RenameDatasetRequest, global::Viam.App.Dataset.V1.RenameDatasetResponse>(serviceImpl.RenameDataset));
      serviceBinder.AddMethod(__Method_ListDatasetsByOrganizationID, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDRequest, global::Viam.App.Dataset.V1.ListDatasetsByOrganizationIDResponse>(serviceImpl.ListDatasetsByOrganizationID));
      serviceBinder.AddMethod(__Method_ListDatasetsByIDs, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Viam.App.Dataset.V1.ListDatasetsByIDsRequest, global::Viam.App.Dataset.V1.ListDatasetsByIDsResponse>(serviceImpl.ListDatasetsByIDs));
    }

  }
}
#endregion
