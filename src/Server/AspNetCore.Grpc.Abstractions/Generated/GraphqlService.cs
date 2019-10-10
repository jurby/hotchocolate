// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: graphql_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HotChocolate.AspNetCore.Grpc {

  /// <summary>Holder for reflection information generated from graphql_service.proto</summary>
  public static partial class GraphqlServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for graphql_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GraphqlServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVncmFwaHFsX3NlcnZpY2UucHJvdG8SE2hvdGNob2NvbGF0ZS5hcGkudjEa",
            "HGdvb2dsZS9wcm90b2J1Zi9zdHJ1Y3QucHJvdG8aG2dvb2dsZS9wcm90b2J1",
            "Zi9lbXB0eS5wcm90byJ2CgdSZXF1ZXN0Eg0KBXF1ZXJ5GAEgASgJEioKCXZh",
            "cmlhYmxlcxgCIAEoCzIXLmdvb2dsZS5wcm90b2J1Zi5TdHJ1Y3QSFgoOb3Bl",
            "cmF0aW9uX25hbWUYAyABKAkSGAoQYmF0Y2hfb3BlcmF0aW9ucxgEIAMoCSJX",
            "CgxCYXRjaFJlcXVlc3QSLQoHcmVxdWVzdBgBIAMoCzIcLmhvdGNob2NvbGF0",
            "ZS5hcGkudjEuUmVxdWVzdBIYChBiYXRjaF9vcGVyYXRpb25zGAIgAygJIrQB",
            "CghSZXNwb25zZRIlCgRkYXRhGAEgASgLMhcuZ29vZ2xlLnByb3RvYnVmLlN0",
            "cnVjdBIoCgRwYXRoGAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLkxpc3RWYWx1",
            "ZRIqCgZlcnJvcnMYAyADKAsyGi5ob3RjaG9jb2xhdGUuYXBpLnYxLkVycm9y",
            "EisKCmV4dGVuc2lvbnMYBCABKAsyFy5nb29nbGUucHJvdG9idWYuU3RydWN0",
            "IqcBCgVFcnJvchIPCgdtZXNzYWdlGAEgASgJEjYKCWxvY2F0aW9ucxgCIAMo",
            "CzIjLmhvdGNob2NvbGF0ZS5hcGkudjEuU291cmNlTG9jYXRpb24SKAoEcGF0",
            "aBgDIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5MaXN0VmFsdWUSKwoKZXh0ZW5z",
            "aW9ucxgEIAEoCzIXLmdvb2dsZS5wcm90b2J1Zi5TdHJ1Y3QiLgoOU291cmNl",
            "TG9jYXRpb24SDAoEbGluZRgBIAEoBRIOCgZjb2x1bW4YAiABKAUy7wEKDkdy",
            "YXBocWxTZXJ2aWNlEkoKB0V4ZWN1dGUSHC5ob3RjaG9jb2xhdGUuYXBpLnYx",
            "LlJlcXVlc3QaHS5ob3RjaG9jb2xhdGUuYXBpLnYxLlJlc3BvbnNlIgAwARJX",
            "Cg1FeGVjdXRlU3RyZWFtEiEuaG90Y2hvY29sYXRlLmFwaS52MS5CYXRjaFJl",
            "cXVlc3QaHS5ob3RjaG9jb2xhdGUuYXBpLnYxLlJlc3BvbnNlIgAoATABEjgK",
            "BFBpbmcSFi5nb29nbGUucHJvdG9idWYuRW1wdHkaFi5nb29nbGUucHJvdG9i",
            "dWYuRW1wdHkiAEIfqgIcSG90Q2hvY29sYXRlLkFzcE5ldENvcmUuR3JwY2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HotChocolate.AspNetCore.Grpc.Request), global::HotChocolate.AspNetCore.Grpc.Request.Parser, new[]{ "Query", "Variables", "OperationName", "BatchOperations" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HotChocolate.AspNetCore.Grpc.BatchRequest), global::HotChocolate.AspNetCore.Grpc.BatchRequest.Parser, new[]{ "Request", "BatchOperations" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HotChocolate.AspNetCore.Grpc.Response), global::HotChocolate.AspNetCore.Grpc.Response.Parser, new[]{ "Data", "Path", "Errors", "Extensions" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HotChocolate.AspNetCore.Grpc.Error), global::HotChocolate.AspNetCore.Grpc.Error.Parser, new[]{ "Message", "Locations", "Path", "Extensions" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HotChocolate.AspNetCore.Grpc.SourceLocation), global::HotChocolate.AspNetCore.Grpc.SourceLocation.Parser, new[]{ "Line", "Column" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Request : pb::IMessage<Request> {
    private static readonly pb::MessageParser<Request> _parser = new pb::MessageParser<Request>(() => new Request());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Request> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HotChocolate.AspNetCore.Grpc.GraphqlServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request(Request other) : this() {
      query_ = other.query_;
      variables_ = other.variables_ != null ? other.variables_.Clone() : null;
      operationName_ = other.operationName_;
      batchOperations_ = other.batchOperations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request Clone() {
      return new Request(this);
    }

    /// <summary>Field number for the "query" field.</summary>
    public const int QueryFieldNumber = 1;
    private string query_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Query {
      get { return query_; }
      set {
        query_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "variables" field.</summary>
    public const int VariablesFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Struct variables_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Struct Variables {
      get { return variables_; }
      set {
        variables_ = value;
      }
    }

    /// <summary>Field number for the "operation_name" field.</summary>
    public const int OperationNameFieldNumber = 3;
    private string operationName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OperationName {
      get { return operationName_; }
      set {
        operationName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "batch_operations" field.</summary>
    public const int BatchOperationsFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_batchOperations_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> batchOperations_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> BatchOperations {
      get { return batchOperations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Request);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Request other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Query != other.Query) return false;
      if (!object.Equals(Variables, other.Variables)) return false;
      if (OperationName != other.OperationName) return false;
      if(!batchOperations_.Equals(other.batchOperations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Query.Length != 0) hash ^= Query.GetHashCode();
      if (variables_ != null) hash ^= Variables.GetHashCode();
      if (OperationName.Length != 0) hash ^= OperationName.GetHashCode();
      hash ^= batchOperations_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Query.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Query);
      }
      if (variables_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Variables);
      }
      if (OperationName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(OperationName);
      }
      batchOperations_.WriteTo(output, _repeated_batchOperations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Query.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Query);
      }
      if (variables_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Variables);
      }
      if (OperationName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OperationName);
      }
      size += batchOperations_.CalculateSize(_repeated_batchOperations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Request other) {
      if (other == null) {
        return;
      }
      if (other.Query.Length != 0) {
        Query = other.Query;
      }
      if (other.variables_ != null) {
        if (variables_ == null) {
          Variables = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        Variables.MergeFrom(other.Variables);
      }
      if (other.OperationName.Length != 0) {
        OperationName = other.OperationName;
      }
      batchOperations_.Add(other.batchOperations_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Query = input.ReadString();
            break;
          }
          case 18: {
            if (variables_ == null) {
              Variables = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(Variables);
            break;
          }
          case 26: {
            OperationName = input.ReadString();
            break;
          }
          case 34: {
            batchOperations_.AddEntriesFrom(input, _repeated_batchOperations_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class BatchRequest : pb::IMessage<BatchRequest> {
    private static readonly pb::MessageParser<BatchRequest> _parser = new pb::MessageParser<BatchRequest>(() => new BatchRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BatchRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HotChocolate.AspNetCore.Grpc.GraphqlServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BatchRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BatchRequest(BatchRequest other) : this() {
      request_ = other.request_.Clone();
      batchOperations_ = other.batchOperations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BatchRequest Clone() {
      return new BatchRequest(this);
    }

    /// <summary>Field number for the "request" field.</summary>
    public const int RequestFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HotChocolate.AspNetCore.Grpc.Request> _repeated_request_codec
        = pb::FieldCodec.ForMessage(10, global::HotChocolate.AspNetCore.Grpc.Request.Parser);
    private readonly pbc::RepeatedField<global::HotChocolate.AspNetCore.Grpc.Request> request_ = new pbc::RepeatedField<global::HotChocolate.AspNetCore.Grpc.Request>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HotChocolate.AspNetCore.Grpc.Request> Request {
      get { return request_; }
    }

    /// <summary>Field number for the "batch_operations" field.</summary>
    public const int BatchOperationsFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_batchOperations_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> batchOperations_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> BatchOperations {
      get { return batchOperations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BatchRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BatchRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!request_.Equals(other.request_)) return false;
      if(!batchOperations_.Equals(other.batchOperations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= request_.GetHashCode();
      hash ^= batchOperations_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      request_.WriteTo(output, _repeated_request_codec);
      batchOperations_.WriteTo(output, _repeated_batchOperations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += request_.CalculateSize(_repeated_request_codec);
      size += batchOperations_.CalculateSize(_repeated_batchOperations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BatchRequest other) {
      if (other == null) {
        return;
      }
      request_.Add(other.request_);
      batchOperations_.Add(other.batchOperations_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            request_.AddEntriesFrom(input, _repeated_request_codec);
            break;
          }
          case 18: {
            batchOperations_.AddEntriesFrom(input, _repeated_batchOperations_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Response : pb::IMessage<Response> {
    private static readonly pb::MessageParser<Response> _parser = new pb::MessageParser<Response>(() => new Response());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Response> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HotChocolate.AspNetCore.Grpc.GraphqlServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response(Response other) : this() {
      data_ = other.data_ != null ? other.data_.Clone() : null;
      path_ = other.path_ != null ? other.path_.Clone() : null;
      errors_ = other.errors_.Clone();
      extensions_ = other.extensions_ != null ? other.extensions_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response Clone() {
      return new Response(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Struct data_;
    /// <summary>
    /// GraphQL Data
    ///   All fields that can be returned by a query, mutation, stream or defer
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Struct Data {
      get { return data_; }
      set {
        data_ = value;
      }
    }

    /// <summary>Field number for the "path" field.</summary>
    public const int PathFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.ListValue path_;
    /// <summary>
    /// TODO: path can be a number or string
    /// GraphQL Path
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.ListValue Path {
      get { return path_; }
      set {
        path_ = value;
      }
    }

    /// <summary>Field number for the "errors" field.</summary>
    public const int ErrorsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::HotChocolate.AspNetCore.Grpc.Error> _repeated_errors_codec
        = pb::FieldCodec.ForMessage(26, global::HotChocolate.AspNetCore.Grpc.Error.Parser);
    private readonly pbc::RepeatedField<global::HotChocolate.AspNetCore.Grpc.Error> errors_ = new pbc::RepeatedField<global::HotChocolate.AspNetCore.Grpc.Error>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HotChocolate.AspNetCore.Grpc.Error> Errors {
      get { return errors_; }
    }

    /// <summary>Field number for the "extensions" field.</summary>
    public const int ExtensionsFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Struct extensions_;
    /// <summary>
    /// GraphQL Extensions
    /// Free-form extensions (starts with a map)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Struct Extensions {
      get { return extensions_; }
      set {
        extensions_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Response);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Response other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Data, other.Data)) return false;
      if (!object.Equals(Path, other.Path)) return false;
      if(!errors_.Equals(other.errors_)) return false;
      if (!object.Equals(Extensions, other.Extensions)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (data_ != null) hash ^= Data.GetHashCode();
      if (path_ != null) hash ^= Path.GetHashCode();
      hash ^= errors_.GetHashCode();
      if (extensions_ != null) hash ^= Extensions.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (data_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Data);
      }
      if (path_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Path);
      }
      errors_.WriteTo(output, _repeated_errors_codec);
      if (extensions_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Extensions);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (data_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Data);
      }
      if (path_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Path);
      }
      size += errors_.CalculateSize(_repeated_errors_codec);
      if (extensions_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Extensions);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Response other) {
      if (other == null) {
        return;
      }
      if (other.data_ != null) {
        if (data_ == null) {
          Data = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        Data.MergeFrom(other.Data);
      }
      if (other.path_ != null) {
        if (path_ == null) {
          Path = new global::Google.Protobuf.WellKnownTypes.ListValue();
        }
        Path.MergeFrom(other.Path);
      }
      errors_.Add(other.errors_);
      if (other.extensions_ != null) {
        if (extensions_ == null) {
          Extensions = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        Extensions.MergeFrom(other.Extensions);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (data_ == null) {
              Data = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(Data);
            break;
          }
          case 18: {
            if (path_ == null) {
              Path = new global::Google.Protobuf.WellKnownTypes.ListValue();
            }
            input.ReadMessage(Path);
            break;
          }
          case 26: {
            errors_.AddEntriesFrom(input, _repeated_errors_codec);
            break;
          }
          case 34: {
            if (extensions_ == null) {
              Extensions = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(Extensions);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// GraphQL Error
  /// </summary>
  public sealed partial class Error : pb::IMessage<Error> {
    private static readonly pb::MessageParser<Error> _parser = new pb::MessageParser<Error>(() => new Error());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Error> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HotChocolate.AspNetCore.Grpc.GraphqlServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Error() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Error(Error other) : this() {
      message_ = other.message_;
      locations_ = other.locations_.Clone();
      path_ = other.path_ != null ? other.path_.Clone() : null;
      extensions_ = other.extensions_ != null ? other.extensions_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Error Clone() {
      return new Error(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    /// <summary>
    /// Description of the error intended for the developer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "locations" field.</summary>
    public const int LocationsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::HotChocolate.AspNetCore.Grpc.SourceLocation> _repeated_locations_codec
        = pb::FieldCodec.ForMessage(18, global::HotChocolate.AspNetCore.Grpc.SourceLocation.Parser);
    private readonly pbc::RepeatedField<global::HotChocolate.AspNetCore.Grpc.SourceLocation> locations_ = new pbc::RepeatedField<global::HotChocolate.AspNetCore.Grpc.SourceLocation>();
    /// <summary>
    /// The source location for the error.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HotChocolate.AspNetCore.Grpc.SourceLocation> Locations {
      get { return locations_; }
    }

    /// <summary>Field number for the "path" field.</summary>
    public const int PathFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.ListValue path_;
    /// <summary>
    /// Path to the `null` value justified by this error.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.ListValue Path {
      get { return path_; }
      set {
        path_ = value;
      }
    }

    /// <summary>Field number for the "extensions" field.</summary>
    public const int ExtensionsFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Struct extensions_;
    /// <summary>
    /// Free-form extensions (starts with a map)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Struct Extensions {
      get { return extensions_; }
      set {
        extensions_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Error);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Error other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      if(!locations_.Equals(other.locations_)) return false;
      if (!object.Equals(Path, other.Path)) return false;
      if (!object.Equals(Extensions, other.Extensions)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      hash ^= locations_.GetHashCode();
      if (path_ != null) hash ^= Path.GetHashCode();
      if (extensions_ != null) hash ^= Extensions.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      locations_.WriteTo(output, _repeated_locations_codec);
      if (path_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Path);
      }
      if (extensions_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Extensions);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      size += locations_.CalculateSize(_repeated_locations_codec);
      if (path_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Path);
      }
      if (extensions_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Extensions);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Error other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      locations_.Add(other.locations_);
      if (other.path_ != null) {
        if (path_ == null) {
          Path = new global::Google.Protobuf.WellKnownTypes.ListValue();
        }
        Path.MergeFrom(other.Path);
      }
      if (other.extensions_ != null) {
        if (extensions_ == null) {
          Extensions = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        Extensions.MergeFrom(other.Extensions);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
          case 18: {
            locations_.AddEntriesFrom(input, _repeated_locations_codec);
            break;
          }
          case 26: {
            if (path_ == null) {
              Path = new global::Google.Protobuf.WellKnownTypes.ListValue();
            }
            input.ReadMessage(Path);
            break;
          }
          case 34: {
            if (extensions_ == null) {
              Extensions = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(Extensions);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The source location of an error.
  /// </summary>
  public sealed partial class SourceLocation : pb::IMessage<SourceLocation> {
    private static readonly pb::MessageParser<SourceLocation> _parser = new pb::MessageParser<SourceLocation>(() => new SourceLocation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SourceLocation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HotChocolate.AspNetCore.Grpc.GraphqlServiceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SourceLocation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SourceLocation(SourceLocation other) : this() {
      line_ = other.line_;
      column_ = other.column_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SourceLocation Clone() {
      return new SourceLocation(this);
    }

    /// <summary>Field number for the "line" field.</summary>
    public const int LineFieldNumber = 1;
    private int line_;
    /// <summary>
    /// The line the error occurred at.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Line {
      get { return line_; }
      set {
        line_ = value;
      }
    }

    /// <summary>Field number for the "column" field.</summary>
    public const int ColumnFieldNumber = 2;
    private int column_;
    /// <summary>
    /// The column the error occurred at.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Column {
      get { return column_; }
      set {
        column_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SourceLocation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SourceLocation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Line != other.Line) return false;
      if (Column != other.Column) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Line != 0) hash ^= Line.GetHashCode();
      if (Column != 0) hash ^= Column.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Line != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Line);
      }
      if (Column != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Column);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Line != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Line);
      }
      if (Column != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Column);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SourceLocation other) {
      if (other == null) {
        return;
      }
      if (other.Line != 0) {
        Line = other.Line;
      }
      if (other.Column != 0) {
        Column = other.Column;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Line = input.ReadInt32();
            break;
          }
          case 16: {
            Column = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
