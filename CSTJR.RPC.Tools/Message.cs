// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Message.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CSTJR.RPC.Message.Contracts {

  /// <summary>Holder for reflection information generated from Message.proto</summary>
  public static partial class MessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Message.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1NZXNzYWdlLnByb3RvEhtDU1RKUi5SUEMuTWVzc2FnZS5Db250cmFjdHMi",
            "cQoSU2VuZE1lc3NhZ2VSZXF1ZXN0EhAKCENhdGVnb3J5GAEgASgFEhAKCEZy",
            "b21Vc2VyGAIgASgJEg4KBlRvVXNlchgDIAEoCRISCgpBY3Rpb25MaXN0GAQg",
            "AygJEhMKC01lc3NhZ2VMaXN0GAUgAygJIiAKEFNlbmRNZXNzYWdlUmVwbHkS",
            "DAoEZmxhZxgBIAEoCCIRCg9TZW5kVGFza1JlcXVlc3QiRwoNU2VuZFRhc2tS",
            "ZXBseRIUCgxzdWNjZXNzQ291bnQYASABKAUSEAoIZXJyQ291bnQYAiABKAUS",
            "DgoGZXJyTXNnGAMgASgJMvABCg5NZXNzYWdlU2VydmljZRJvCgtTZW5kTWVz",
            "c2FnZRIvLkNTVEpSLlJQQy5NZXNzYWdlLkNvbnRyYWN0cy5TZW5kTWVzc2Fn",
            "ZVJlcXVlc3QaLS5DU1RKUi5SUEMuTWVzc2FnZS5Db250cmFjdHMuU2VuZE1l",
            "c3NhZ2VSZXBseSIAEm0KD1NlbmRUYXNrTWVzc2FnZRIsLkNTVEpSLlJQQy5N",
            "ZXNzYWdlLkNvbnRyYWN0cy5TZW5kVGFza1JlcXVlc3QaKi5DU1RKUi5SUEMu",
            "TWVzc2FnZS5Db250cmFjdHMuU2VuZFRhc2tSZXBseSIAYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CSTJR.RPC.Message.Contracts.SendMessageRequest), global::CSTJR.RPC.Message.Contracts.SendMessageRequest.Parser, new[]{ "Category", "FromUser", "ToUser", "ActionList", "MessageList" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CSTJR.RPC.Message.Contracts.SendMessageReply), global::CSTJR.RPC.Message.Contracts.SendMessageReply.Parser, new[]{ "Flag" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CSTJR.RPC.Message.Contracts.SendTaskRequest), global::CSTJR.RPC.Message.Contracts.SendTaskRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CSTJR.RPC.Message.Contracts.SendTaskReply), global::CSTJR.RPC.Message.Contracts.SendTaskReply.Parser, new[]{ "SuccessCount", "ErrCount", "ErrMsg" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SendMessageRequest : pb::IMessage<SendMessageRequest> {
    private static readonly pb::MessageParser<SendMessageRequest> _parser = new pb::MessageParser<SendMessageRequest>(() => new SendMessageRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SendMessageRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CSTJR.RPC.Message.Contracts.MessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendMessageRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendMessageRequest(SendMessageRequest other) : this() {
      category_ = other.category_;
      fromUser_ = other.fromUser_;
      toUser_ = other.toUser_;
      actionList_ = other.actionList_.Clone();
      messageList_ = other.messageList_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendMessageRequest Clone() {
      return new SendMessageRequest(this);
    }

    /// <summary>Field number for the "Category" field.</summary>
    public const int CategoryFieldNumber = 1;
    private int category_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Category {
      get { return category_; }
      set {
        category_ = value;
      }
    }

    /// <summary>Field number for the "FromUser" field.</summary>
    public const int FromUserFieldNumber = 2;
    private string fromUser_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FromUser {
      get { return fromUser_; }
      set {
        fromUser_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ToUser" field.</summary>
    public const int ToUserFieldNumber = 3;
    private string toUser_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ToUser {
      get { return toUser_; }
      set {
        toUser_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ActionList" field.</summary>
    public const int ActionListFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_actionList_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> actionList_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> ActionList {
      get { return actionList_; }
    }

    /// <summary>Field number for the "MessageList" field.</summary>
    public const int MessageListFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_messageList_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> messageList_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> MessageList {
      get { return messageList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SendMessageRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SendMessageRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Category != other.Category) return false;
      if (FromUser != other.FromUser) return false;
      if (ToUser != other.ToUser) return false;
      if(!actionList_.Equals(other.actionList_)) return false;
      if(!messageList_.Equals(other.messageList_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Category != 0) hash ^= Category.GetHashCode();
      if (FromUser.Length != 0) hash ^= FromUser.GetHashCode();
      if (ToUser.Length != 0) hash ^= ToUser.GetHashCode();
      hash ^= actionList_.GetHashCode();
      hash ^= messageList_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Category != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Category);
      }
      if (FromUser.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FromUser);
      }
      if (ToUser.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ToUser);
      }
      actionList_.WriteTo(output, _repeated_actionList_codec);
      messageList_.WriteTo(output, _repeated_messageList_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Category != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Category);
      }
      if (FromUser.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FromUser);
      }
      if (ToUser.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ToUser);
      }
      size += actionList_.CalculateSize(_repeated_actionList_codec);
      size += messageList_.CalculateSize(_repeated_messageList_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SendMessageRequest other) {
      if (other == null) {
        return;
      }
      if (other.Category != 0) {
        Category = other.Category;
      }
      if (other.FromUser.Length != 0) {
        FromUser = other.FromUser;
      }
      if (other.ToUser.Length != 0) {
        ToUser = other.ToUser;
      }
      actionList_.Add(other.actionList_);
      messageList_.Add(other.messageList_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Category = input.ReadInt32();
            break;
          }
          case 18: {
            FromUser = input.ReadString();
            break;
          }
          case 26: {
            ToUser = input.ReadString();
            break;
          }
          case 34: {
            actionList_.AddEntriesFrom(input, _repeated_actionList_codec);
            break;
          }
          case 42: {
            messageList_.AddEntriesFrom(input, _repeated_messageList_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class SendMessageReply : pb::IMessage<SendMessageReply> {
    private static readonly pb::MessageParser<SendMessageReply> _parser = new pb::MessageParser<SendMessageReply>(() => new SendMessageReply());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SendMessageReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CSTJR.RPC.Message.Contracts.MessageReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendMessageReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendMessageReply(SendMessageReply other) : this() {
      flag_ = other.flag_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendMessageReply Clone() {
      return new SendMessageReply(this);
    }

    /// <summary>Field number for the "flag" field.</summary>
    public const int FlagFieldNumber = 1;
    private bool flag_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Flag {
      get { return flag_; }
      set {
        flag_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SendMessageReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SendMessageReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Flag != other.Flag) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Flag != false) hash ^= Flag.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Flag != false) {
        output.WriteRawTag(8);
        output.WriteBool(Flag);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Flag != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SendMessageReply other) {
      if (other == null) {
        return;
      }
      if (other.Flag != false) {
        Flag = other.Flag;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Flag = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SendTaskRequest : pb::IMessage<SendTaskRequest> {
    private static readonly pb::MessageParser<SendTaskRequest> _parser = new pb::MessageParser<SendTaskRequest>(() => new SendTaskRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SendTaskRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CSTJR.RPC.Message.Contracts.MessageReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendTaskRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendTaskRequest(SendTaskRequest other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendTaskRequest Clone() {
      return new SendTaskRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SendTaskRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SendTaskRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SendTaskRequest other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class SendTaskReply : pb::IMessage<SendTaskReply> {
    private static readonly pb::MessageParser<SendTaskReply> _parser = new pb::MessageParser<SendTaskReply>(() => new SendTaskReply());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SendTaskReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CSTJR.RPC.Message.Contracts.MessageReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendTaskReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendTaskReply(SendTaskReply other) : this() {
      successCount_ = other.successCount_;
      errCount_ = other.errCount_;
      errMsg_ = other.errMsg_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendTaskReply Clone() {
      return new SendTaskReply(this);
    }

    /// <summary>Field number for the "successCount" field.</summary>
    public const int SuccessCountFieldNumber = 1;
    private int successCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SuccessCount {
      get { return successCount_; }
      set {
        successCount_ = value;
      }
    }

    /// <summary>Field number for the "errCount" field.</summary>
    public const int ErrCountFieldNumber = 2;
    private int errCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ErrCount {
      get { return errCount_; }
      set {
        errCount_ = value;
      }
    }

    /// <summary>Field number for the "errMsg" field.</summary>
    public const int ErrMsgFieldNumber = 3;
    private string errMsg_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ErrMsg {
      get { return errMsg_; }
      set {
        errMsg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SendTaskReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SendTaskReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SuccessCount != other.SuccessCount) return false;
      if (ErrCount != other.ErrCount) return false;
      if (ErrMsg != other.ErrMsg) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SuccessCount != 0) hash ^= SuccessCount.GetHashCode();
      if (ErrCount != 0) hash ^= ErrCount.GetHashCode();
      if (ErrMsg.Length != 0) hash ^= ErrMsg.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SuccessCount != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(SuccessCount);
      }
      if (ErrCount != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ErrCount);
      }
      if (ErrMsg.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ErrMsg);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SuccessCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SuccessCount);
      }
      if (ErrCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ErrCount);
      }
      if (ErrMsg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ErrMsg);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SendTaskReply other) {
      if (other == null) {
        return;
      }
      if (other.SuccessCount != 0) {
        SuccessCount = other.SuccessCount;
      }
      if (other.ErrCount != 0) {
        ErrCount = other.ErrCount;
      }
      if (other.ErrMsg.Length != 0) {
        ErrMsg = other.ErrMsg;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            SuccessCount = input.ReadInt32();
            break;
          }
          case 16: {
            ErrCount = input.ReadInt32();
            break;
          }
          case 26: {
            ErrMsg = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code