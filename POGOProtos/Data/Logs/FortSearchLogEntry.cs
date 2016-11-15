// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Data/Logs/FortSearchLogEntry.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Logs
{

    /// <summary>Holder for reflection information generated from POGOProtos/Data/Logs/FortSearchLogEntry.proto</summary>
    public static partial class FortSearchLogEntryReflection
    {

        #region Descriptor
        /// <summary>File descriptor for POGOProtos/Data/Logs/FortSearchLogEntry.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }
        private static pbr::FileDescriptor descriptor;

        static FortSearchLogEntryReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "Ci1QT0dPUHJvdG9zL0RhdGEvTG9ncy9Gb3J0U2VhcmNoTG9nRW50cnkucHJv",
                  "dG8SFFBPR09Qcm90b3MuRGF0YS5Mb2dzGihQT0dPUHJvdG9zL0ludmVudG9y",
                  "eS9JdGVtL0l0ZW1EYXRhLnByb3RvIsoBChJGb3J0U2VhcmNoTG9nRW50cnkS",
                  "PwoGcmVzdWx0GAEgASgOMi8uUE9HT1Byb3Rvcy5EYXRhLkxvZ3MuRm9ydFNl",
                  "YXJjaExvZ0VudHJ5LlJlc3VsdBIPCgdmb3J0X2lkGAIgASgJEjIKBWl0ZW1z",
                  "GAMgAygLMiMuUE9HT1Byb3Rvcy5JbnZlbnRvcnkuSXRlbS5JdGVtRGF0YRIM",
                  "CgRlZ2dzGAQgASgFIiAKBlJlc3VsdBIJCgVVTlNFVBAAEgsKB1NVQ0NFU1MQ",
                  "AWIGcHJvdG8z"));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { global::POGOProtos.Inventory.Item.ItemDataReflection.Descriptor, },
                new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Logs.FortSearchLogEntry), global::POGOProtos.Data.Logs.FortSearchLogEntry.Parser, new[]{ "Result", "FortId", "Items", "Eggs" }, null, new[]{ typeof(global::POGOProtos.Data.Logs.FortSearchLogEntry.Types.Result) }, null)
                }));
        }
        #endregion

    }
    #region Messages
    public sealed partial class FortSearchLogEntry : pb::IMessage<FortSearchLogEntry>
    {
        private static readonly pb::MessageParser<FortSearchLogEntry> _parser = new pb::MessageParser<FortSearchLogEntry>(() => new FortSearchLogEntry());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<FortSearchLogEntry> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::POGOProtos.Data.Logs.FortSearchLogEntryReflection.Descriptor.MessageTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public FortSearchLogEntry()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public FortSearchLogEntry(FortSearchLogEntry other) : this()
        {
            result_ = other.result_;
            fortId_ = other.fortId_;
            items_ = other.items_.Clone();
            eggs_ = other.eggs_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public FortSearchLogEntry Clone()
        {
            return new FortSearchLogEntry(this);
        }

        /// <summary>Field number for the "result" field.</summary>
        public const int ResultFieldNumber = 1;
        private global::POGOProtos.Data.Logs.FortSearchLogEntry.Types.Result result_ = 0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::POGOProtos.Data.Logs.FortSearchLogEntry.Types.Result Result
        {
            get { return result_; }
            set
            {
                result_ = value;
            }
        }

        /// <summary>Field number for the "fort_id" field.</summary>
        public const int FortIdFieldNumber = 2;
        private string fortId_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string FortId
        {
            get { return fortId_; }
            set
            {
                fortId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "items" field.</summary>
        public const int ItemsFieldNumber = 3;
        private static readonly pb::FieldCodec<global::POGOProtos.Inventory.Item.ItemData> _repeated_items_codec
            = pb::FieldCodec.ForMessage(26, global::POGOProtos.Inventory.Item.ItemData.Parser);
        private readonly pbc::RepeatedField<global::POGOProtos.Inventory.Item.ItemData> items_ = new pbc::RepeatedField<global::POGOProtos.Inventory.Item.ItemData>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::POGOProtos.Inventory.Item.ItemData> Items
        {
            get { return items_; }
        }

        /// <summary>Field number for the "eggs" field.</summary>
        public const int EggsFieldNumber = 4;
        private int eggs_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Eggs
        {
            get { return eggs_; }
            set
            {
                eggs_ = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as FortSearchLogEntry);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(FortSearchLogEntry other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Result != other.Result) return false;
            if (FortId != other.FortId) return false;
            if (!items_.Equals(other.items_)) return false;
            if (Eggs != other.Eggs) return false;
            return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (Result != 0) hash ^= Result.GetHashCode();
            if (FortId.Length != 0) hash ^= FortId.GetHashCode();
            hash ^= items_.GetHashCode();
            if (Eggs != 0) hash ^= Eggs.GetHashCode();
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Result != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)Result);
            }
            if (FortId.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(FortId);
            }
            items_.WriteTo(output, _repeated_items_codec);
            if (Eggs != 0)
            {
                output.WriteRawTag(32);
                output.WriteInt32(Eggs);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (Result != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Result);
            }
            if (FortId.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(FortId);
            }
            size += items_.CalculateSize(_repeated_items_codec);
            if (Eggs != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Eggs);
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(FortSearchLogEntry other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Result != 0)
            {
                Result = other.Result;
            }
            if (other.FortId.Length != 0)
            {
                FortId = other.FortId;
            }
            items_.Add(other.items_);
            if (other.Eggs != 0)
            {
                Eggs = other.Eggs;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            result_ = (global::POGOProtos.Data.Logs.FortSearchLogEntry.Types.Result)input.ReadEnum();
                            break;
                        }
                    case 18:
                        {
                            FortId = input.ReadString();
                            break;
                        }
                    case 26:
                        {
                            items_.AddEntriesFrom(input, _repeated_items_codec);
                            break;
                        }
                    case 32:
                        {
                            Eggs = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        #region Nested types
        /// <summary>Container for nested types declared in the FortSearchLogEntry message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static partial class Types
        {
            public enum Result
            {
                [pbr::OriginalName("UNSET")]
                Unset = 0,
                [pbr::OriginalName("SUCCESS")]
                Success = 1,
            }

        }
        #endregion

    }

    #endregion

}

#endregion Designer generated code