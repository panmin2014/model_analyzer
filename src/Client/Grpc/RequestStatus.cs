﻿// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: request_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbr = global::Google.Protobuf.Reflection;
namespace ModelAnalyzer.Client
{

    /// <summary>Holder for reflection information generated from request_status.proto</summary>
    public static partial class RequestStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for request_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RequestStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRyZXF1ZXN0X3N0YXR1cy5wcm90bxIWbnZpZGlhLmluZmVyZW5jZXNlcnZl",
            "ciJ8Cg1SZXF1ZXN0U3RhdHVzEjcKBGNvZGUYASABKA4yKS5udmlkaWEuaW5m",
            "ZXJlbmNlc2VydmVyLlJlcXVlc3RTdGF0dXNDb2RlEgsKA21zZxgCIAEoCRIR",
            "CglzZXJ2ZXJfaWQYAyABKAkSEgoKcmVxdWVzdF9pZBgEIAEoBCqeAQoRUmVx",
            "dWVzdFN0YXR1c0NvZGUSCwoHSU5WQUxJRBAAEgsKB1NVQ0NFU1MQARILCgdV",
            "TktOT1dOEAISDAoISU5URVJOQUwQAxINCglOT1RfRk9VTkQQBBIPCgtJTlZB",
            "TElEX0FSRxAFEg8KC1VOQVZBSUxBQkxFEAYSDwoLVU5TVVBQT1JURUQQBxIS",
            "Cg5BTFJFQURZX0VYSVNUUxAIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::ModelAnalyzer.Client.RequestStatusCode), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ModelAnalyzer.Client.RequestStatus), global::ModelAnalyzer.Client.RequestStatus.Parser, new[]{ "Code", "Msg", "ServerId", "RequestId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  ///@@
  ///@@.. cpp:enum:: RequestStatusCode
  ///@@
  ///@@   Status codes returned for inference server requests. The
  ///@@   :cpp:enumerator:`RequestStatusCode::SUCCESS` status code indicates
  ///@@   not error, all other codes indicate an error.
  ///@@
  /// </summary>
  public enum RequestStatusCode {
    /// <summary>
    ///@@  .. cpp:enumerator:: RequestStatusCode::INVALID = 0
    ///@@
    ///@@     Invalid status. Used internally but should not be returned as
    ///@@     part of a :cpp:var:`RequestStatus`.
    ///@@
    /// </summary>
    [pbr::OriginalName("INVALID")] Invalid = 0,
    /// <summary>
    ///@@  .. cpp:enumerator:: RequestStatusCode::SUCCESS = 1
    ///@@
    ///@@     Error code indicating success.
    ///@@
    /// </summary>
    [pbr::OriginalName("SUCCESS")] Success = 1,
    /// <summary>
    ///@@  .. cpp:enumerator:: RequestStatusCode::UNKNOWN = 2
    ///@@
    ///@@     Error code indicating an unknown failure.
    ///@@
    /// </summary>
    [pbr::OriginalName("UNKNOWN")] Unknown = 2,
    /// <summary>
    ///@@  .. cpp:enumerator:: RequestStatusCode::INTERNAL = 3
    ///@@
    ///@@     Error code indicating an internal failure.
    ///@@
    /// </summary>
    [pbr::OriginalName("INTERNAL")] Internal = 3,
    /// <summary>
    ///@@  .. cpp:enumerator:: RequestStatusCode::NOT_FOUND = 4
    ///@@
    ///@@     Error code indicating a resource or request was not found.
    ///@@
    /// </summary>
    [pbr::OriginalName("NOT_FOUND")] NotFound = 4,
    /// <summary>
    ///@@  .. cpp:enumerator:: RequestStatusCode::INVALID_ARG = 5
    ///@@
    ///@@     Error code indicating a failure caused by an unknown argument or
    ///@@     value.
    ///@@
    /// </summary>
    [pbr::OriginalName("INVALID_ARG")] InvalidArg = 5,
    /// <summary>
    ///@@  .. cpp:enumerator:: RequestStatusCode::UNAVAILABLE = 6
    ///@@
    ///@@     Error code indicating an unavailable resource.
    ///@@
    /// </summary>
    [pbr::OriginalName("UNAVAILABLE")] Unavailable = 6,
    /// <summary>
    ///@@  .. cpp:enumerator:: RequestStatusCode::UNSUPPORTED = 7
    ///@@
    ///@@     Error code indicating an unsupported request or operation.
    ///@@
    /// </summary>
    [pbr::OriginalName("UNSUPPORTED")] Unsupported = 7,
    /// <summary>
    ///@@  .. cpp:enumerator:: RequestStatusCode::ALREADY_EXISTS = 8
    ///@@
    ///@@     Error code indicating an already existing resource.
    ///@@
    /// </summary>
    [pbr::OriginalName("ALREADY_EXISTS")] AlreadyExists = 8,
  }

  #endregion

  #region Messages
  /// <summary>
  ///@@
  ///@@.. cpp:var:: message RequestStatus
  ///@@
  ///@@   Status returned for all inference server requests. The
  ///@@   RequestStatus provides a :cpp:enum:`RequestStatusCode`, an
  ///@@   optional status message, and server and request IDs.
  ///@@
  /// </summary>
  public sealed partial class RequestStatus : pb::IMessage<RequestStatus> {
    private static readonly pb::MessageParser<RequestStatus> _parser = new pb::MessageParser<RequestStatus>(() => new RequestStatus());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RequestStatus> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ModelAnalyzer.Client.RequestStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestStatus() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestStatus(RequestStatus other) : this() {
      code_ = other.code_;
      msg_ = other.msg_;
      serverId_ = other.serverId_;
      requestId_ = other.requestId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestStatus Clone() {
      return new RequestStatus(this);
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 1;
    private global::ModelAnalyzer.Client.RequestStatusCode code_ = 0;
    /// <summary>
    ///@@  .. cpp:var:: RequestStatusCode code
    ///@@
    ///@@     The status code.
    ///@@
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ModelAnalyzer.Client.RequestStatusCode Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    /// <summary>Field number for the "msg" field.</summary>
    public const int MsgFieldNumber = 2;
    private string msg_ = "";
    /// <summary>
    ///@@  .. cpp:var:: string msg
    ///@@
    ///@@     The optional status message.
    ///@@
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Msg {
      get { return msg_; }
      set {
        msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "server_id" field.</summary>
    public const int ServerIdFieldNumber = 3;
    private string serverId_ = "";
    /// <summary>
    ///@@  .. cpp:var:: string server_id
    ///@@
    ///@@     The identifying string for the server that is returning
    ///@@     this status.
    ///@@
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ServerId {
      get { return serverId_; }
      set {
        serverId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "request_id" field.</summary>
    public const int RequestIdFieldNumber = 4;
    private ulong requestId_;
    /// <summary>
    ///@@  .. cpp:var:: string request_id
    ///@@
    ///@@     Unique identifier for the request assigned by the inference
    ///@@     server. Value 0 (zero) indicates the request ID is not known.
    ///@@
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong RequestId {
      get { return requestId_; }
      set {
        requestId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RequestStatus);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RequestStatus other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Code != other.Code) return false;
      if (Msg != other.Msg) return false;
      if (ServerId != other.ServerId) return false;
      if (RequestId != other.RequestId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Code != 0) hash ^= Code.GetHashCode();
      if (Msg.Length != 0) hash ^= Msg.GetHashCode();
      if (ServerId.Length != 0) hash ^= ServerId.GetHashCode();
      if (RequestId != 0UL) hash ^= RequestId.GetHashCode();
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
      if (Code != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Code);
      }
      if (Msg.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Msg);
      }
      if (ServerId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ServerId);
      }
      if (RequestId != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(RequestId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Code != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Code);
      }
      if (Msg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
      }
      if (ServerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServerId);
      }
      if (RequestId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(RequestId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RequestStatus other) {
      if (other == null) {
        return;
      }
      if (other.Code != 0) {
        Code = other.Code;
      }
      if (other.Msg.Length != 0) {
        Msg = other.Msg;
      }
      if (other.ServerId.Length != 0) {
        ServerId = other.ServerId;
      }
      if (other.RequestId != 0UL) {
        RequestId = other.RequestId;
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
            Code = (global::ModelAnalyzer.Client.RequestStatusCode) input.ReadEnum();
            break;
          }
          case 18: {
            Msg = input.ReadString();
            break;
          }
          case 26: {
            ServerId = input.ReadString();
            break;
          }
          case 32: {
            RequestId = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code