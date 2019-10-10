// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: graphql_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace HotChocolate.AspNetCore.Grpc {
  public static partial class GraphqlService
  {
    static readonly string __ServiceName = "hotchocolate.api.v1.GraphqlService";

    static readonly grpc::Marshaller<global::HotChocolate.AspNetCore.Grpc.QueryRequest> __Marshaller_hotchocolate_api_v1_QueryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HotChocolate.AspNetCore.Grpc.QueryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HotChocolate.AspNetCore.Grpc.QueryResponse> __Marshaller_hotchocolate_api_v1_QueryResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HotChocolate.AspNetCore.Grpc.QueryResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::HotChocolate.AspNetCore.Grpc.QueryRequest, global::HotChocolate.AspNetCore.Grpc.QueryResponse> __Method_Query = new grpc::Method<global::HotChocolate.AspNetCore.Grpc.QueryRequest, global::HotChocolate.AspNetCore.Grpc.QueryResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "Query",
        __Marshaller_hotchocolate_api_v1_QueryRequest,
        __Marshaller_hotchocolate_api_v1_QueryResponse);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Ping = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Ping",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HotChocolate.AspNetCore.Grpc.GraphqlServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GraphqlService</summary>
    [grpc::BindServiceMethod(typeof(GraphqlService), "BindService")]
    public abstract partial class GraphqlServiceBase
    {
      /// <summary>
      /// GraphQL query
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task Query(global::HotChocolate.AspNetCore.Grpc.QueryRequest request, grpc::IServerStreamWriter<global::HotChocolate.AspNetCore.Grpc.QueryResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// TODO: Remove - only for testing purpose
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> Ping(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GraphqlService</summary>
    public partial class GraphqlServiceClient : grpc::ClientBase<GraphqlServiceClient>
    {
      /// <summary>Creates a new client for GraphqlService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GraphqlServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GraphqlService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GraphqlServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GraphqlServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GraphqlServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// GraphQL query
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::HotChocolate.AspNetCore.Grpc.QueryResponse> Query(global::HotChocolate.AspNetCore.Grpc.QueryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Query(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// GraphQL query
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::HotChocolate.AspNetCore.Grpc.QueryResponse> Query(global::HotChocolate.AspNetCore.Grpc.QueryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_Query, null, options, request);
      }
      /// <summary>
      /// TODO: Remove - only for testing purpose
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Ping(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Ping(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// TODO: Remove - only for testing purpose
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Ping(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Ping, null, options, request);
      }
      /// <summary>
      /// TODO: Remove - only for testing purpose
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> PingAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// TODO: Remove - only for testing purpose
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> PingAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Ping, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GraphqlServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GraphqlServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GraphqlServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Query, serviceImpl.Query)
          .AddMethod(__Method_Ping, serviceImpl.Ping).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GraphqlServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Query, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::HotChocolate.AspNetCore.Grpc.QueryRequest, global::HotChocolate.AspNetCore.Grpc.QueryResponse>(serviceImpl.Query));
      serviceBinder.AddMethod(__Method_Ping, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.Ping));
    }

  }
}
#endregion
