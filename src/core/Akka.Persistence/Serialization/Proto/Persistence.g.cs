// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Persistence.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Akka.Persistence.Serialization.Proto.Msg {

  /// <summary>Holder for reflection information generated from Persistence.proto</summary>
  internal static partial class PersistenceReflection {

    #region Descriptor
    /// <summary>File descriptor for Persistence.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PersistenceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQZXJzaXN0ZW5jZS5wcm90bxIoQWtrYS5QZXJzaXN0ZW5jZS5TZXJpYWxp",
            "emF0aW9uLlByb3RvLk1zZyLTAQoRUGVyc2lzdGVudE1lc3NhZ2USTAoHcGF5",
            "bG9hZBgBIAEoCzI7LkFra2EuUGVyc2lzdGVuY2UuU2VyaWFsaXphdGlvbi5Q",
            "cm90by5Nc2cuUGVyc2lzdGVudFBheWxvYWQSEgoKc2VxdWVuY2VOchgCIAEo",
            "AxIVCg1wZXJzaXN0ZW5jZUlkGAMgASgJEg8KB2RlbGV0ZWQYBCABKAgSDgoG",
            "c2VuZGVyGAsgASgJEhAKCG1hbmlmZXN0GAwgASgJEhIKCndyaXRlckd1aWQY",
            "DSABKAkiUwoRUGVyc2lzdGVudFBheWxvYWQSFAoMc2VyaWFsaXplcklkGAEg",
            "ASgFEg8KB3BheWxvYWQYAiABKAwSFwoPcGF5bG9hZE1hbmlmZXN0GAMgASgM",
            "IlsKC0F0b21pY1dyaXRlEkwKB3BheWxvYWQYASADKAsyOy5Ba2thLlBlcnNp",
            "c3RlbmNlLlNlcmlhbGl6YXRpb24uUHJvdG8uTXNnLlBlcnNpc3RlbnRNZXNz",
            "YWdlIowBChNVbmNvbmZpcm1lZERlbGl2ZXJ5EhIKCmRlbGl2ZXJ5SWQYASAB",
            "KAMSEwoLZGVzdGluYXRpb24YAiABKAkSTAoHcGF5bG9hZBgDIAEoCzI7LkFr",
            "a2EuUGVyc2lzdGVuY2UuU2VyaWFsaXphdGlvbi5Qcm90by5Nc2cuUGVyc2lz",
            "dGVudFBheWxvYWQilgEKG0F0TGVhc3RPbmNlRGVsaXZlcnlTbmFwc2hvdBIZ",
            "ChFjdXJyZW50RGVsaXZlcnlJZBgBIAEoAxJcChV1bmNvbmZpcm1lZERlbGl2",
            "ZXJpZXMYAiADKAsyPS5Ba2thLlBlcnNpc3RlbmNlLlNlcmlhbGl6YXRpb24u",
            "UHJvdG8uTXNnLlVuY29uZmlybWVkRGVsaXZlcnliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Akka.Persistence.Serialization.Proto.Msg.PersistentMessage), global::Akka.Persistence.Serialization.Proto.Msg.PersistentMessage.Parser, new[]{ "Payload", "SequenceNr", "PersistenceId", "Deleted", "Sender", "Manifest", "WriterGuid" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Akka.Persistence.Serialization.Proto.Msg.PersistentPayload), global::Akka.Persistence.Serialization.Proto.Msg.PersistentPayload.Parser, new[]{ "SerializerId", "Payload", "PayloadManifest" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Akka.Persistence.Serialization.Proto.Msg.AtomicWrite), global::Akka.Persistence.Serialization.Proto.Msg.AtomicWrite.Parser, new[]{ "Payload" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Akka.Persistence.Serialization.Proto.Msg.UnconfirmedDelivery), global::Akka.Persistence.Serialization.Proto.Msg.UnconfirmedDelivery.Parser, new[]{ "DeliveryId", "Destination", "Payload" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Akka.Persistence.Serialization.Proto.Msg.AtLeastOnceDeliverySnapshot), global::Akka.Persistence.Serialization.Proto.Msg.AtLeastOnceDeliverySnapshot.Parser, new[]{ "CurrentDeliveryId", "UnconfirmedDeliveries" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class PersistentMessage : pb::IMessage<PersistentMessage> {
    private static readonly pb::MessageParser<PersistentMessage> _parser = new pb::MessageParser<PersistentMessage>(() => new PersistentMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PersistentMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Akka.Persistence.Serialization.Proto.Msg.PersistenceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PersistentMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PersistentMessage(PersistentMessage other) : this() {
      Payload = other.payload_ != null ? other.Payload.Clone() : null;
      sequenceNr_ = other.sequenceNr_;
      persistenceId_ = other.persistenceId_;
      deleted_ = other.deleted_;
      sender_ = other.sender_;
      manifest_ = other.manifest_;
      writerGuid_ = other.writerGuid_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PersistentMessage Clone() {
      return new PersistentMessage(this);
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 1;
    private global::Akka.Persistence.Serialization.Proto.Msg.PersistentPayload payload_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Akka.Persistence.Serialization.Proto.Msg.PersistentPayload Payload {
      get { return payload_; }
      set {
        payload_ = value;
      }
    }

    /// <summary>Field number for the "sequenceNr" field.</summary>
    public const int SequenceNrFieldNumber = 2;
    private long sequenceNr_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long SequenceNr {
      get { return sequenceNr_; }
      set {
        sequenceNr_ = value;
      }
    }

    /// <summary>Field number for the "persistenceId" field.</summary>
    public const int PersistenceIdFieldNumber = 3;
    private string persistenceId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PersistenceId {
      get { return persistenceId_; }
      set {
        persistenceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "deleted" field.</summary>
    public const int DeletedFieldNumber = 4;
    private bool deleted_;
    /// <summary>
    /// not used in new records from 2.4
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Deleted {
      get { return deleted_; }
      set {
        deleted_ = value;
      }
    }

    /// <summary>Field number for the "sender" field.</summary>
    public const int SenderFieldNumber = 11;
    private string sender_ = "";
    /// <summary>
    /// not stored in journal, needed for remote serialization 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Sender {
      get { return sender_; }
      set {
        sender_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "manifest" field.</summary>
    public const int ManifestFieldNumber = 12;
    private string manifest_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Manifest {
      get { return manifest_; }
      set {
        manifest_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "writerGuid" field.</summary>
    public const int WriterGuidFieldNumber = 13;
    private string writerGuid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string WriterGuid {
      get { return writerGuid_; }
      set {
        writerGuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PersistentMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PersistentMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Payload, other.Payload)) return false;
      if (SequenceNr != other.SequenceNr) return false;
      if (PersistenceId != other.PersistenceId) return false;
      if (Deleted != other.Deleted) return false;
      if (Sender != other.Sender) return false;
      if (Manifest != other.Manifest) return false;
      if (WriterGuid != other.WriterGuid) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (payload_ != null) hash ^= Payload.GetHashCode();
      if (SequenceNr != 0L) hash ^= SequenceNr.GetHashCode();
      if (PersistenceId.Length != 0) hash ^= PersistenceId.GetHashCode();
      if (Deleted != false) hash ^= Deleted.GetHashCode();
      if (Sender.Length != 0) hash ^= Sender.GetHashCode();
      if (Manifest.Length != 0) hash ^= Manifest.GetHashCode();
      if (WriterGuid.Length != 0) hash ^= WriterGuid.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (payload_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Payload);
      }
      if (SequenceNr != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(SequenceNr);
      }
      if (PersistenceId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PersistenceId);
      }
      if (Deleted != false) {
        output.WriteRawTag(32);
        output.WriteBool(Deleted);
      }
      if (Sender.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Sender);
      }
      if (Manifest.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(Manifest);
      }
      if (WriterGuid.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(WriterGuid);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (payload_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Payload);
      }
      if (SequenceNr != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SequenceNr);
      }
      if (PersistenceId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PersistenceId);
      }
      if (Deleted != false) {
        size += 1 + 1;
      }
      if (Sender.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Sender);
      }
      if (Manifest.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Manifest);
      }
      if (WriterGuid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(WriterGuid);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PersistentMessage other) {
      if (other == null) {
        return;
      }
      if (other.payload_ != null) {
        if (payload_ == null) {
          payload_ = new global::Akka.Persistence.Serialization.Proto.Msg.PersistentPayload();
        }
        Payload.MergeFrom(other.Payload);
      }
      if (other.SequenceNr != 0L) {
        SequenceNr = other.SequenceNr;
      }
      if (other.PersistenceId.Length != 0) {
        PersistenceId = other.PersistenceId;
      }
      if (other.Deleted != false) {
        Deleted = other.Deleted;
      }
      if (other.Sender.Length != 0) {
        Sender = other.Sender;
      }
      if (other.Manifest.Length != 0) {
        Manifest = other.Manifest;
      }
      if (other.WriterGuid.Length != 0) {
        WriterGuid = other.WriterGuid;
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
          case 10: {
            if (payload_ == null) {
              payload_ = new global::Akka.Persistence.Serialization.Proto.Msg.PersistentPayload();
            }
            input.ReadMessage(payload_);
            break;
          }
          case 16: {
            SequenceNr = input.ReadInt64();
            break;
          }
          case 26: {
            PersistenceId = input.ReadString();
            break;
          }
          case 32: {
            Deleted = input.ReadBool();
            break;
          }
          case 90: {
            Sender = input.ReadString();
            break;
          }
          case 98: {
            Manifest = input.ReadString();
            break;
          }
          case 106: {
            WriterGuid = input.ReadString();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class PersistentPayload : pb::IMessage<PersistentPayload> {
    private static readonly pb::MessageParser<PersistentPayload> _parser = new pb::MessageParser<PersistentPayload>(() => new PersistentPayload());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PersistentPayload> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Akka.Persistence.Serialization.Proto.Msg.PersistenceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PersistentPayload() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PersistentPayload(PersistentPayload other) : this() {
      serializerId_ = other.serializerId_;
      payload_ = other.payload_;
      payloadManifest_ = other.payloadManifest_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PersistentPayload Clone() {
      return new PersistentPayload(this);
    }

    /// <summary>Field number for the "serializerId" field.</summary>
    public const int SerializerIdFieldNumber = 1;
    private int serializerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SerializerId {
      get { return serializerId_; }
      set {
        serializerId_ = value;
      }
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 2;
    private pb::ByteString payload_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Payload {
      get { return payload_; }
      set {
        payload_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "payloadManifest" field.</summary>
    public const int PayloadManifestFieldNumber = 3;
    private pb::ByteString payloadManifest_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString PayloadManifest {
      get { return payloadManifest_; }
      set {
        payloadManifest_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PersistentPayload);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PersistentPayload other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SerializerId != other.SerializerId) return false;
      if (Payload != other.Payload) return false;
      if (PayloadManifest != other.PayloadManifest) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SerializerId != 0) hash ^= SerializerId.GetHashCode();
      if (Payload.Length != 0) hash ^= Payload.GetHashCode();
      if (PayloadManifest.Length != 0) hash ^= PayloadManifest.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SerializerId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(SerializerId);
      }
      if (Payload.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Payload);
      }
      if (PayloadManifest.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(PayloadManifest);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SerializerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SerializerId);
      }
      if (Payload.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Payload);
      }
      if (PayloadManifest.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(PayloadManifest);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PersistentPayload other) {
      if (other == null) {
        return;
      }
      if (other.SerializerId != 0) {
        SerializerId = other.SerializerId;
      }
      if (other.Payload.Length != 0) {
        Payload = other.Payload;
      }
      if (other.PayloadManifest.Length != 0) {
        PayloadManifest = other.PayloadManifest;
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
            SerializerId = input.ReadInt32();
            break;
          }
          case 18: {
            Payload = input.ReadBytes();
            break;
          }
          case 26: {
            PayloadManifest = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class AtomicWrite : pb::IMessage<AtomicWrite> {
    private static readonly pb::MessageParser<AtomicWrite> _parser = new pb::MessageParser<AtomicWrite>(() => new AtomicWrite());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AtomicWrite> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Akka.Persistence.Serialization.Proto.Msg.PersistenceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AtomicWrite() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AtomicWrite(AtomicWrite other) : this() {
      payload_ = other.payload_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AtomicWrite Clone() {
      return new AtomicWrite(this);
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Akka.Persistence.Serialization.Proto.Msg.PersistentMessage> _repeated_payload_codec
        = pb::FieldCodec.ForMessage(10, global::Akka.Persistence.Serialization.Proto.Msg.PersistentMessage.Parser);
    private readonly pbc::RepeatedField<global::Akka.Persistence.Serialization.Proto.Msg.PersistentMessage> payload_ = new pbc::RepeatedField<global::Akka.Persistence.Serialization.Proto.Msg.PersistentMessage>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Akka.Persistence.Serialization.Proto.Msg.PersistentMessage> Payload {
      get { return payload_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AtomicWrite);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AtomicWrite other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!payload_.Equals(other.payload_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= payload_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      payload_.WriteTo(output, _repeated_payload_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += payload_.CalculateSize(_repeated_payload_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AtomicWrite other) {
      if (other == null) {
        return;
      }
      payload_.Add(other.payload_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            payload_.AddEntriesFrom(input, _repeated_payload_codec);
            break;
          }
        }
      }
    }

  }

  internal sealed partial class UnconfirmedDelivery : pb::IMessage<UnconfirmedDelivery> {
    private static readonly pb::MessageParser<UnconfirmedDelivery> _parser = new pb::MessageParser<UnconfirmedDelivery>(() => new UnconfirmedDelivery());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UnconfirmedDelivery> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Akka.Persistence.Serialization.Proto.Msg.PersistenceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnconfirmedDelivery() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnconfirmedDelivery(UnconfirmedDelivery other) : this() {
      deliveryId_ = other.deliveryId_;
      destination_ = other.destination_;
      Payload = other.payload_ != null ? other.Payload.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnconfirmedDelivery Clone() {
      return new UnconfirmedDelivery(this);
    }

    /// <summary>Field number for the "deliveryId" field.</summary>
    public const int DeliveryIdFieldNumber = 1;
    private long deliveryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long DeliveryId {
      get { return deliveryId_; }
      set {
        deliveryId_ = value;
      }
    }

    /// <summary>Field number for the "destination" field.</summary>
    public const int DestinationFieldNumber = 2;
    private string destination_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Destination {
      get { return destination_; }
      set {
        destination_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 3;
    private global::Akka.Persistence.Serialization.Proto.Msg.PersistentPayload payload_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Akka.Persistence.Serialization.Proto.Msg.PersistentPayload Payload {
      get { return payload_; }
      set {
        payload_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UnconfirmedDelivery);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UnconfirmedDelivery other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DeliveryId != other.DeliveryId) return false;
      if (Destination != other.Destination) return false;
      if (!object.Equals(Payload, other.Payload)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DeliveryId != 0L) hash ^= DeliveryId.GetHashCode();
      if (Destination.Length != 0) hash ^= Destination.GetHashCode();
      if (payload_ != null) hash ^= Payload.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (DeliveryId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(DeliveryId);
      }
      if (Destination.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Destination);
      }
      if (payload_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Payload);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DeliveryId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(DeliveryId);
      }
      if (Destination.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Destination);
      }
      if (payload_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Payload);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UnconfirmedDelivery other) {
      if (other == null) {
        return;
      }
      if (other.DeliveryId != 0L) {
        DeliveryId = other.DeliveryId;
      }
      if (other.Destination.Length != 0) {
        Destination = other.Destination;
      }
      if (other.payload_ != null) {
        if (payload_ == null) {
          payload_ = new global::Akka.Persistence.Serialization.Proto.Msg.PersistentPayload();
        }
        Payload.MergeFrom(other.Payload);
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
            DeliveryId = input.ReadInt64();
            break;
          }
          case 18: {
            Destination = input.ReadString();
            break;
          }
          case 26: {
            if (payload_ == null) {
              payload_ = new global::Akka.Persistence.Serialization.Proto.Msg.PersistentPayload();
            }
            input.ReadMessage(payload_);
            break;
          }
        }
      }
    }

  }

  internal sealed partial class AtLeastOnceDeliverySnapshot : pb::IMessage<AtLeastOnceDeliverySnapshot> {
    private static readonly pb::MessageParser<AtLeastOnceDeliverySnapshot> _parser = new pb::MessageParser<AtLeastOnceDeliverySnapshot>(() => new AtLeastOnceDeliverySnapshot());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AtLeastOnceDeliverySnapshot> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Akka.Persistence.Serialization.Proto.Msg.PersistenceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AtLeastOnceDeliverySnapshot() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AtLeastOnceDeliverySnapshot(AtLeastOnceDeliverySnapshot other) : this() {
      currentDeliveryId_ = other.currentDeliveryId_;
      unconfirmedDeliveries_ = other.unconfirmedDeliveries_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AtLeastOnceDeliverySnapshot Clone() {
      return new AtLeastOnceDeliverySnapshot(this);
    }

    /// <summary>Field number for the "currentDeliveryId" field.</summary>
    public const int CurrentDeliveryIdFieldNumber = 1;
    private long currentDeliveryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long CurrentDeliveryId {
      get { return currentDeliveryId_; }
      set {
        currentDeliveryId_ = value;
      }
    }

    /// <summary>Field number for the "unconfirmedDeliveries" field.</summary>
    public const int UnconfirmedDeliveriesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Akka.Persistence.Serialization.Proto.Msg.UnconfirmedDelivery> _repeated_unconfirmedDeliveries_codec
        = pb::FieldCodec.ForMessage(18, global::Akka.Persistence.Serialization.Proto.Msg.UnconfirmedDelivery.Parser);
    private readonly pbc::RepeatedField<global::Akka.Persistence.Serialization.Proto.Msg.UnconfirmedDelivery> unconfirmedDeliveries_ = new pbc::RepeatedField<global::Akka.Persistence.Serialization.Proto.Msg.UnconfirmedDelivery>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Akka.Persistence.Serialization.Proto.Msg.UnconfirmedDelivery> UnconfirmedDeliveries {
      get { return unconfirmedDeliveries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AtLeastOnceDeliverySnapshot);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AtLeastOnceDeliverySnapshot other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurrentDeliveryId != other.CurrentDeliveryId) return false;
      if(!unconfirmedDeliveries_.Equals(other.unconfirmedDeliveries_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CurrentDeliveryId != 0L) hash ^= CurrentDeliveryId.GetHashCode();
      hash ^= unconfirmedDeliveries_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CurrentDeliveryId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(CurrentDeliveryId);
      }
      unconfirmedDeliveries_.WriteTo(output, _repeated_unconfirmedDeliveries_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CurrentDeliveryId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CurrentDeliveryId);
      }
      size += unconfirmedDeliveries_.CalculateSize(_repeated_unconfirmedDeliveries_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AtLeastOnceDeliverySnapshot other) {
      if (other == null) {
        return;
      }
      if (other.CurrentDeliveryId != 0L) {
        CurrentDeliveryId = other.CurrentDeliveryId;
      }
      unconfirmedDeliveries_.Add(other.unconfirmedDeliveries_);
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
            CurrentDeliveryId = input.ReadInt64();
            break;
          }
          case 18: {
            unconfirmedDeliveries_.AddEntriesFrom(input, _repeated_unconfirmedDeliveries_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
