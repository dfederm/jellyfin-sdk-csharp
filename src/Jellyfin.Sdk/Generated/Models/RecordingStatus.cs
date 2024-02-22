// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    public enum RecordingStatus {
        [EnumMember(Value = "New")]
        New,
        [EnumMember(Value = "InProgress")]
        InProgress,
        [EnumMember(Value = "Completed")]
        Completed,
        [EnumMember(Value = "Cancelled")]
        Cancelled,
        [EnumMember(Value = "ConflictedOk")]
        ConflictedOk,
        [EnumMember(Value = "ConflictedNotOk")]
        ConflictedNotOk,
        [EnumMember(Value = "Error")]
        Error,
    }
}