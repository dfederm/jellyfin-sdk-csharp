// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Jellyfin.Sdk.Generated.Models {
    public class TranscodingInfo : IParsable {
        /// <summary>The AudioChannels property</summary>
        public int? AudioChannels { get; set; }
        /// <summary>The AudioCodec property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AudioCodec { get; set; }
#nullable restore
#else
        public string AudioCodec { get; set; }
#endif
        /// <summary>The Bitrate property</summary>
        public int? Bitrate { get; set; }
        /// <summary>The CompletionPercentage property</summary>
        public double? CompletionPercentage { get; set; }
        /// <summary>The Container property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Container { get; set; }
#nullable restore
#else
        public string Container { get; set; }
#endif
        /// <summary>The Framerate property</summary>
        public float? Framerate { get; set; }
        /// <summary>The HardwareAccelerationType property</summary>
        public HardwareEncodingType? HardwareAccelerationType { get; set; }
        /// <summary>The Height property</summary>
        public int? Height { get; set; }
        /// <summary>The IsAudioDirect property</summary>
        public bool? IsAudioDirect { get; set; }
        /// <summary>The IsVideoDirect property</summary>
        public bool? IsVideoDirect { get; set; }
        /// <summary>The TranscodeReasons property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TranscodeReason?>? TranscodeReasons { get; set; }
#nullable restore
#else
        public List<TranscodeReason?> TranscodeReasons { get; set; }
#endif
        /// <summary>The VideoCodec property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VideoCodec { get; set; }
#nullable restore
#else
        public string VideoCodec { get; set; }
#endif
        /// <summary>The Width property</summary>
        public int? Width { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TranscodingInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TranscodingInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AudioChannels", n => { AudioChannels = n.GetIntValue(); } },
                {"AudioCodec", n => { AudioCodec = n.GetStringValue(); } },
                {"Bitrate", n => { Bitrate = n.GetIntValue(); } },
                {"CompletionPercentage", n => { CompletionPercentage = n.GetDoubleValue(); } },
                {"Container", n => { Container = n.GetStringValue(); } },
                {"Framerate", n => { Framerate = n.GetFloatValue(); } },
                {"HardwareAccelerationType", n => { HardwareAccelerationType = n.GetEnumValue<HardwareEncodingType>(); } },
                {"Height", n => { Height = n.GetIntValue(); } },
                {"IsAudioDirect", n => { IsAudioDirect = n.GetBoolValue(); } },
                {"IsVideoDirect", n => { IsVideoDirect = n.GetBoolValue(); } },
                {"TranscodeReasons", n => { TranscodeReasons = n.GetCollectionOfEnumValues<TranscodeReason>()?.ToList(); } },
                {"VideoCodec", n => { VideoCodec = n.GetStringValue(); } },
                {"Width", n => { Width = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("AudioChannels", AudioChannels);
            writer.WriteStringValue("AudioCodec", AudioCodec);
            writer.WriteIntValue("Bitrate", Bitrate);
            writer.WriteDoubleValue("CompletionPercentage", CompletionPercentage);
            writer.WriteStringValue("Container", Container);
            writer.WriteFloatValue("Framerate", Framerate);
            writer.WriteEnumValue<HardwareEncodingType>("HardwareAccelerationType", HardwareAccelerationType);
            writer.WriteIntValue("Height", Height);
            writer.WriteBoolValue("IsAudioDirect", IsAudioDirect);
            writer.WriteBoolValue("IsVideoDirect", IsVideoDirect);
            writer.WriteCollectionOfEnumValues<TranscodeReason>("TranscodeReasons", TranscodeReasons);
            writer.WriteStringValue("VideoCodec", VideoCodec);
            writer.WriteIntValue("Width", Width);
        }
    }
}