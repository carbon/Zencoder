#nullable disable

using System.Text.Json.Serialization;

namespace Zencoder.Models
{
    public class OutputSpecification
    {
        #region General Settings

        /// <summary>
        /// The type of file to output.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

#nullable enable
        /// <summary>
        /// An optional label for this output.
        /// </summary>
        [JsonPropertyName("label")]
        public string? Label { get; set; }

#nullable disable

        /// <summary>
        /// A S3, Cloud Files, GCS, FTP, FTPS, SFTP, Aspera, Azure, HTTP, or RTMP URL where we'll put the transcoded file.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

#nullable enable

        #endregion

        #region Formats & Codecs

        /// <summary>
        /// Determined by the output filename and then video or audio codec. 
        /// Otherwise: mp4 (for standard outputs); ts (for segmented outputs).	
        /// </summary>
        [JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// The output video codec to use. 
        /// Supported: h264 (default), theora, vp6, vp8, mpeg4, and wmv
        /// </summary>
        [JsonPropertyName("video_codec")]
        public string? VideoCodec { get; set; }

        /// <summary>
        /// Supported: aac, ac3, amr, eac3, mp3, pcm, vorbis, and wma
        /// </summary>
        [JsonPropertyName("audio_codec")]
        public string? AudioCodec { get; set; }

        #endregion

        #region Resolution

        /// <summary>
        /// The resolution of the output video (WxH, in pixels).
        /// </summary>
        [JsonPropertyName("size")]
        public string? Size { get; set; }

        [JsonPropertyName("width")]
        public int? Width { get; set; }

        [JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Upscale the output if the input is smaller than the target output resolution.
        /// </summary>
        [JsonPropertyName("upscale")]
        public bool? Upscale { get; set; }

        // AspectMode
        #endregion

        #region Rate Control

        /*
		quality					3		Autoselect the best video bitrate to to match a target visual quality.
		video_bitrate			none	A target video bitrate in kbps. Not necessary if you select a quality setting, unless you want to target a specific bitrate.
		audio_quality			3		Autoselect the best audio bitrate to to match a target sound quality.
		audio_bitrate			none	A target audio bitrate in kbps. Not necessary if you select a audio_quality setting, unless you want to target a specific bitrate.
		max_video_bitrate		none	A maximum average bitrate.
		speed					3		A target transcoding speed. Slower encoding generally allows for more advanced compression.
		decoder_bitrate_cap		none	Max bitrate fed to decoder buffer. Typically used for video intended for streaming, or for targeting specific devices (e.g. Blu-Ray).
		decoder_buffer_size		none	Size of the decoder buffer, used in conjunction with bitrate_cap.
		one_pass				false	Force one-pass encoding.
		audio_constant_bitrate	false	Enable constant bitrate mode for audio if possible.
		*/

        /// <summary>
        /// quality: the desired output video quality, from 1 to 5.
        /// Default: 3.
        /// </summary>
        [JsonPropertyName("quality")]
        public int? Quality { get; set; }

        /// <summary>
        /// speed: a target transcoding speed. 
        /// Slower transcoding allows for better file compression, while faster transcoding is possible by skipping some advanced compression features.
        /// In general, we recommend either 2 or 4. 1-3 often result in similar file sizes, while 2-3 are generally about the same speed, so 2 is a good compromise. 
        /// On the high end, 5 often results in significantly larger files, but is not much faster than 4.
        /// </summary>
        [JsonPropertyName("speed")]
        public int? Speed { get; set; }

        /// <summary>
        /// A target video bitrate in kbps. Not necessary if you select a quality setting, unless you want to target a specific bitrate.
        /// </summary>
        [JsonPropertyName("video_bitrate")]
        public int? VideoBitrate { get; set; }

        /// <summary>
        /// max_video_bitrate
        /// </summary>
        [JsonPropertyName("max_video_bitrate")]
        public int? MaxVideoBitrate { get; set; }

        [JsonPropertyName("audio_bitrate")]
        public int? AudioBitrate { get; set; }

        [JsonPropertyName("decoder_bitrate_cap")]
        public int? DecoderBitrateCap { get; set; }

        [JsonPropertyName("decoder_buffer_size")]
        public int? DecoderBufferSize { get; set; }

        #endregion

        #region Frame Rate

        /*
		frame_rate					source						The frame rate to use.
		max_frame_rate				none						The maximum frame rate to use.
		decimate					none						Reduce the input frame rate by a divisor.
		keyframe_interval			250							The maximum number of frames between each keyframe.
		keyframe_rate				keyframe_interval of 250	The number of keyframes per second.
		fixed_keyframe_interval		false						Enable fixed keyframe interval mode (VP6 and H.264 only).
		forced_keyframe_interval	none						Force keyframes at the specified interval (H.264 only).
		forced_keyframe_rate		none						Specify the number of keyframes per-second, taking frame rate into account (H.264 only).
		generate_frame_index		false						Generate a video frame index file.
		frame_index_filename		none						Override the default filename for the frame index when generate_frame_index is enabled.
		*/

        [JsonPropertyName("frame_rate")]
        public double? FrameRate { get; set; }

        [JsonPropertyName("max_frame_rate")]
        public double? MaxFrameRate { get; set; }

        [JsonPropertyName("keyframe_interval")]
        public int? KeyframeInterval { get; set; }

        #endregion

        #region Video

        /*
		video_reference_frames	3					A number of reference frames to use (H.264, HEVC).
		video_codec_profile		H.264: baseline, HEVC: main	The video codec profile to use (H.264, HEVC).
		video_codec_level							The video codec level to use (H.264, HEVC).
		video_bframes			0			The maximum number of consecutive B-frames (H.264, HEVC)
		color_metadata			preserve	Preserve or discard color metadata information from the input in the output video.
		*/

        [JsonPropertyName("video_reference_frames")]
        public int? VideoReferenceFrames { get; set; }

        [JsonPropertyName("video_codec_profile")]
        public string? VideoCodecProfile { get; set; }

        [JsonPropertyName("video_codec_level")]
        public string? VideoCodecLevel { get; set; }

        [JsonPropertyName("video_bframes")]
        public int? VideoBFrames { get; set; }

#nullable enable

        [JsonPropertyName("color_metadata")]
        public string? ColorMetadata { get; set; }

        #endregion

        #region Audio

        /*
		audio_sample_rate		none	The audio sample rate, in Hz.
		max_audio_sample_rate	none	The max audio sample rate, in Hz.
		audio_channels			1		if the original file is mono; otherwise, 2.	The number of audio channels: 1 or 2.
		audio_bit_depth			16		The number of bits per sample: 16, 24, 32.
		audio_language			none	Describes the language of the audio track.
		*/

        [JsonPropertyName("audio_sample_rate")]
        public int? AudioSampleRate { get; set; }

        [JsonPropertyName("max_audio_sample_rate")]
        public int? MaxSampleRate { get; set; }

        [JsonPropertyName("audio_channels")]
        public int? AudioChannels { get; set; }

        [JsonPropertyName("audio_bit_depth")]
        public int? AudioBitDepth { get; set; }

        [JsonPropertyName("audio_language")]
        public string? AudioLanguage { get; set; }

        #endregion

        #region Thumbnails

        [JsonPropertyName("thumbnails")]
        public OutputThumbnails? Thumbnails { get; set; }

        #endregion

        #region Video Processing

        #endregion

        #region Audio Processing

        #endregion

        #region Clips

        #endregion

        #region S3 Settings

        [JsonPropertyName("public")]
        public bool? Public { get; set; }

        #endregion

        #region Notifications

        [JsonPropertyName("notifications")]
        public NotificationSpecification[]? Notifications { get; set; }

        #endregion

        #region Conditional Outputs

        [JsonPropertyName("skip")]
        public EncodeConditions? Skip { get; set; }

        #endregion

        #region Segmented Streaming

#nullable disable

        [JsonPropertyName("source")]
        public string Source { get; set; }

#nullable enable

        [JsonPropertyName("copy_audio")]
        public bool? CopyAudio { get; set; }

        [JsonPropertyName("copy_video")]
        public bool? CopyVideo { get; set; }

        [JsonPropertyName("segment_seconds")]
        public int? SegmentSeconds { get; set; }

        [JsonPropertyName("generate_keyframe_manifest")]
        public bool? GenerateKeyframeManifest { get; set; }

        [JsonPropertyName("allow_skipped_sources")]
        public bool? AllowSkippedSources { get; set; }

        #endregion

        #region Streaming

        [JsonPropertyName("streaming_delivery_format")]
        public string? StreamingDeliveryFormat { get; set; }

        [JsonPropertyName("prepare_for_segmenting")]
        public string[]? PrepareForSegmenting { get; set; }

        [JsonPropertyName("streams")]
        public StreamSpecification[]? Streams { get; set; }

        #endregion

        #region H264 Settings

        /*
		h264_reference_frames	3			A number of reference frames to use in H.264 video.
		h264_profile			baseline	The H.264 profile to use.
		h264_level				3			The H.264 level to use.
		h264_bframes			0			The maximum number of consecutive B-frames.
		tuning					none		Tune the output video for a specific content type.
		crf						none		Bitrate control setting.
		*/

        [JsonPropertyName("h264_reference_frames")]
        public int? H264ReferenceFrames { get; set; }

        /// <summary>
        /// default: baseline
        /// options: baseline, main, high
        /// </summary>
        [JsonPropertyName("h264_profile")]
        public string? H264Profile { get; set; }

        [JsonPropertyName("h264_level")]
        public string? H264Level { get; set; }

        #endregion
    }
}

/*
"thumbnails": {
      "number": 6,
      "size": "160x120",
      "base_url": "s3://bucket/directory",
      "prefix": "custom"
    }
*/


/*
aspect_mode: if the aspect ratio of the input does not match the requested output aspect ratio, what should the output resolution be? As an example, assume that an input file is 1280×720 (widescreen 16:9), but the target output is 640×480 (standard 4:3). There are four basic approaches to this problem, and Zencoder supports them all. aspect_mode requires that both a width and a height are provided; otherwise, if only one is provided, we’ll calculate the other dimension proportionately.

1. “preserve”: By default, Zencoder will preserve the aspect ratio of the original file, so if you submit widescreen content and ask for standard resolution, the output file will fit keep the widescreen aspect ratio, and will fit within the output size. Presumably, the player will then add black bars to fill up the frame. In our example, the output file will be 640×360 (widescreen 16×9 that fits within the 640×480 target).

2. “stretch”: When the aspect mode is “stretch”, the output video will exactly match the requested width and height, even if it distorts the image. So in our example, the output will be 640×480, but will look vertically stretched. NB: this is not the same as the “upscale” option, above, which governs whether or not a smaller video will be enlarged to a larger frame size.

3. “crop”: This option tells Zencoder to “zoom in” to the video to match the output size, by cropping pixels from the top/bottom or left/right. So if the input is widescreen 1280×720, and the output target is standard 640×480, we will crop roughly 160 pixels from the left and from the right of the input file (creating a 4:3 movie), and then resize that down to 640×480. If you’re old enough to remember non-widescreen VHS (like us), this is the old “pan and scan” option.

4. “pad”: The Pad option tells Zencoder to letterbox the video to match the output frame size exactly. Use this option if your target player doesn’t know how to pad a video; otherwise, you’re just wasting bits by including black bars in the actual file. Following our example, this option would take 1280×720 (16:9) content and convert it to 640×480 (4:3) by creating a 640×360 movie, and then placing 60 pixel black bars at the top and bottom of the movie. So the movie would be 640×480, with black bars at the top and bottom.
*/


/* On video bitrates */
// If you're looking to have better control over the average bitrate of a video you could pass both quality and video_bitrate. 
// In that case, the first pass encoding will use the quality setting like normal, but the 2nd pass will use the video_bitrate 
// setting to act as a limiter on the average bitrate.





/*
VIDEO Formats
mp4 is compatible with h264 (default) and mpeg4 video, and aac (default) and mp3 audio. Valid values and file extensions: mp4, m4a, m4v, f4v, f4a, m4b, m4r, f4b
m4f is compatible with h264 video and aac audio.
ogg is compatible with theora video and vorbis audio. Valid values and file extensions: ogg, oga, ogv, ogx
webm is compatible with vp8 video and vorbis audio. Valid values and file extensions: webm
3gp is compatible with mpeg4 (default) and h264 video, and aac (default) and mp3 audio. Valid values and file extensions: 3gp, 3gp2, 3g2, 3gpp, 3gpp2. Note that the 3gp format can also use a mp4 file extension.
flv is compatible with vp6 (default) and h264 video, and aac (default) and mp3 audio. Valid values and file extensions: flv
ts is compatible with h264 video and aac (default), mp3 or ac3 audio. Valid values and file extensions: ts
mkv is compatible with h264 video and aac (default), mp3, ac3 or eac3 audio. Valid values and file extensions: mkv
wmv is compatible with wmv video and wma (default) or mp3 audio. Valid values and file extensions: wmv, wma
aac is compatible with aac audio and no video. Valid values and file extensions: aac
mp3 is compatible with mp3 audio and no video. Valid values and file extensions: mp3
ac3 is compatible with ac3 audio and no video. Valid values and file extensions: ac3
ec3 is compatible with eac3 audio and no video. Valid values and file extensions: ec3
mj2 is compatible with jp2 video and aac audio. Valid values and file extensions: mj2, mjp2. Requires advanced broadcast
mxf is compatible with h264 video and pcm audio. Valid values and file extensions: mxf. Requires advanced broadcast
*/
