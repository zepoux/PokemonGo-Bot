// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Inventory/InventoryDelta.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Inventory
{

    /// <summary>Holder for reflection information generated from POGOProtos/Inventory/InventoryDelta.proto</summary>
    public static partial class InventoryDeltaReflection
    {

        #region Descriptor
        /// <summary>File descriptor for POGOProtos/Inventory/InventoryDelta.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }
        private static pbr::FileDescriptor descriptor;

        static InventoryDeltaReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "CilQT0dPUHJvdG9zL0ludmVudG9yeS9JbnZlbnRvcnlEZWx0YS5wcm90bxIU",
                  "UE9HT1Byb3Rvcy5JbnZlbnRvcnkaKFBPR09Qcm90b3MvSW52ZW50b3J5L0lu",
                  "dmVudG9yeUl0ZW0ucHJvdG8ihwEKDkludmVudG9yeURlbHRhEh0KFW9yaWdp",
                  "bmFsX3RpbWVzdGFtcF9tcxgBIAEoAxIYChBuZXdfdGltZXN0YW1wX21zGAIg",
                  "ASgDEjwKD2ludmVudG9yeV9pdGVtcxgDIAMoCzIjLlBPR09Qcm90b3MuSW52",
                  "ZW50b3J5LkludmVudG9yeUl0ZW1iBnByb3RvMw=="));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { global::POGOProtos.Inventory.InventoryItemReflection.Descriptor, },
                new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Inventory.InventoryDelta), global::POGOProtos.Inventory.InventoryDelta.Parser, new[]{ "OriginalTimestampMs", "NewTimestampMs", "InventoryItems" }, null, null, null)
                }));
        }
        #endregion

    }
    #region Messages
    public sealed partial class InventoryDelta : pb::IMessage<InventoryDelta>
    {
        private static readonly pb::MessageParser<InventoryDelta> _parser = new pb::MessageParser<InventoryDelta>(() => new InventoryDelta());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<InventoryDelta> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::POGOProtos.Inventory.InventoryDeltaReflection.Descriptor.MessageTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public InventoryDelta()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public InventoryDelta(InventoryDelta other) : this()
        {
            originalTimestampMs_ = other.originalTimestampMs_;
            newTimestampMs_ = other.newTimestampMs_;
            inventoryItems_ = other.inventoryItems_.Clone();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public InventoryDelta Clone()
        {
            return new InventoryDelta(this);
        }

        /// <summary>Field number for the "original_timestamp_ms" field.</summary>
        public const int OriginalTimestampMsFieldNumber = 1;
        private long originalTimestampMs_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long OriginalTimestampMs
        {
            get { return originalTimestampMs_; }
            set
            {
                originalTimestampMs_ = value;
            }
        }

        /// <summary>Field number for the "new_timestamp_ms" field.</summary>
        public const int NewTimestampMsFieldNumber = 2;
        private long newTimestampMs_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long NewTimestampMs
        {
            get { return newTimestampMs_; }
            set
            {
                newTimestampMs_ = value;
            }
        }

        /// <summary>Field number for the "inventory_items" field.</summary>
        public const int InventoryItemsFieldNumber = 3;
        private static readonly pb::FieldCodec<global::POGOProtos.Inventory.InventoryItem> _repeated_inventoryItems_codec
            = pb::FieldCodec.ForMessage(26, global::POGOProtos.Inventory.InventoryItem.Parser);
        private readonly pbc::RepeatedField<global::POGOProtos.Inventory.InventoryItem> inventoryItems_ = new pbc::RepeatedField<global::POGOProtos.Inventory.InventoryItem>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::POGOProtos.Inventory.InventoryItem> InventoryItems
        {
            get { return inventoryItems_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as InventoryDelta);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(InventoryDelta other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (OriginalTimestampMs != other.OriginalTimestampMs) return false;
            if (NewTimestampMs != other.NewTimestampMs) return false;
            if (!inventoryItems_.Equals(other.inventoryItems_)) return false;
            return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (OriginalTimestampMs != 0L) hash ^= OriginalTimestampMs.GetHashCode();
            if (NewTimestampMs != 0L) hash ^= NewTimestampMs.GetHashCode();
            hash ^= inventoryItems_.GetHashCode();
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
            if (OriginalTimestampMs != 0L)
            {
                output.WriteRawTag(8);
                output.WriteInt64(OriginalTimestampMs);
            }
            if (NewTimestampMs != 0L)
            {
                output.WriteRawTag(16);
                output.WriteInt64(NewTimestampMs);
            }
            inventoryItems_.WriteTo(output, _repeated_inventoryItems_codec);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (OriginalTimestampMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(OriginalTimestampMs);
            }
            if (NewTimestampMs != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(NewTimestampMs);
            }
            size += inventoryItems_.CalculateSize(_repeated_inventoryItems_codec);
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(InventoryDelta other)
        {
            if (other == null)
            {
                return;
            }
            if (other.OriginalTimestampMs != 0L)
            {
                OriginalTimestampMs = other.OriginalTimestampMs;
            }
            if (other.NewTimestampMs != 0L)
            {
                NewTimestampMs = other.NewTimestampMs;
            }
            inventoryItems_.Add(other.inventoryItems_);
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
                            OriginalTimestampMs = input.ReadInt64();
                            break;
                        }
                    case 16:
                        {
                            NewTimestampMs = input.ReadInt64();
                            break;
                        }
                    case 26:
                        {
                            inventoryItems_.AddEntriesFrom(input, _repeated_inventoryItems_codec);
                            break;
                        }
                }
            }
        }

    }

    #endregion

}

#endregion Designer generated code