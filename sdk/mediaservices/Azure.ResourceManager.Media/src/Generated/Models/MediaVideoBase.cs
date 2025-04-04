// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Describes the basic properties for encoding the input video.
    /// Please note <see cref="MediaVideoBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="H264Video"/>, <see cref="H265Video"/>, <see cref="MediaImageBase"/>, <see cref="JpgImage"/> and <see cref="PngImage"/>.
    /// </summary>
    public partial class MediaVideoBase : MediaCodecBase
    {
        /// <summary> Initializes a new instance of MediaVideoBase. </summary>
        public MediaVideoBase()
        {
            OdataType = "#Microsoft.Media.Video";
        }

        /// <summary> Initializes a new instance of MediaVideoBase. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="label"> An optional label for the codec. The label can be used to control muxing behavior. </param>
        /// <param name="keyFrameInterval"> The distance between two key frames. The value should be non-zero in the range [0.5, 20] seconds, specified in ISO 8601 format. The default is 2 seconds(PT2S). Note that this setting is ignored if VideoSyncMode.Passthrough is set, where the KeyFrameInterval value will follow the input source setting. </param>
        /// <param name="stretchMode"> The resizing mode - how the input video will be resized to fit the desired output resolution(s). Default is AutoSize. </param>
        /// <param name="syncMode"> The Video Sync Mode. </param>
        internal MediaVideoBase(string odataType, string label, TimeSpan? keyFrameInterval, InputVideoStretchMode? stretchMode, VideoSyncMode? syncMode) : base(odataType, label)
        {
            KeyFrameInterval = keyFrameInterval;
            StretchMode = stretchMode;
            SyncMode = syncMode;
            OdataType = odataType ?? "#Microsoft.Media.Video";
        }

        /// <summary> The distance between two key frames. The value should be non-zero in the range [0.5, 20] seconds, specified in ISO 8601 format. The default is 2 seconds(PT2S). Note that this setting is ignored if VideoSyncMode.Passthrough is set, where the KeyFrameInterval value will follow the input source setting. </summary>
        public TimeSpan? KeyFrameInterval { get; set; }
        /// <summary> The resizing mode - how the input video will be resized to fit the desired output resolution(s). Default is AutoSize. </summary>
        public InputVideoStretchMode? StretchMode { get; set; }
        /// <summary> The Video Sync Mode. </summary>
        public VideoSyncMode? SyncMode { get; set; }
    }
}
