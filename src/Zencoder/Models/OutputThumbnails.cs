using System.Runtime.Serialization;

namespace Zencoder.Models
{
    public class OutputThumbnails
    {
        /// <summary>
        /// A number of thumbnails to capture. 
        /// Zencoder will grab evenly-spaced thumbnails across the whole duration of the file. 
        /// So if you ask for 1 thumbnail, it will be near the middle of the file. 
        /// Specifying 3 thumbnails on a 8 minute video will result in thumbnails 
        /// at approximately 2, 4, and 6 minutes. This value must be a positive integer.
        /// </summary>
        [DataMember(Name = "number")]
        public int? Number { get; set; }

        /// <summary>
        /// A thumbnail interval in seconds.
        /// Zencoder will return one thumbnail for every N seconds of the file. 
        /// So if you choose an interval of 60, and your input file is 12 minutes long,
        /// you’ll get back 12 thumbnails, each one on the minute. 
        /// This value must be a positive number.
        /// </summary>
        [DataMember(Name = "interval")]
        public int? Interval { get; set; }

        [DataMember(Name = "start_at_first_frame")]
        public bool? StartAtFirstFrame { get; set; }

        /// <summary>
        /// Make the output publicly readable on S3.
        /// </summary>
        public bool? Public { get; set; }

        [DataMember(Name = "size")]
        public string Size { get; set; }

        [DataMember(Name = "base_url")]
        public string BaseUrl { get; set; }

        [DataMember(Name = "prefix")]
        public string Prefix { get; set; }

        [DataMember(Name = "aspect_mode")]
        public string AspectMode { get; set; }

        [DataMember(Name = "height")]
        public int? Height { get; set; }

        [DataMember(Name = "width")]
        public int? Width { get; set; }

        /// <summary>
        /// {{number}}_{{width}}x{{height}}-thumbnail
        /// </summary>
        [DataMember(Name = "filename")]
        public string FileName { get; set; }

        [DataMember(Name = "format")]
        public string Format { get; set; }
    }
}


/*
Setting					Default		Description
thumbnails				none		Capture thumbnails for a given video.
label					none		label to identify each set of thumbnail groups.
format					png			The format of the thumbnail image.
number					none		A number of thumbnails, evenly-spaced.
start_at_first_frame	false		Start generating the thumbnails starting at the first frame.
interval				none		Take thumbnails at an even interval, in seconds.
interval_in_frames		none		Take thumbnails at an even interval, in frames.
times					none		An array of times, in seconds, at which to grab a thumbnail.
aspect_mode				preserve	How to handle a thumbnail width/height that differs from the aspect ratio of the input file.
size					none		Thumbnail resolution as WxH.
width					none		The maximum width of the thumbnail (in pixels).
height					none		The maximum height of the thumbnail (in pixels).
base_url				none		A base S3, Cloud Files, GCS, FTP, FTPS, or SFTP directory URL where we'll place the thumbnails, without a filename.
prefix					frame		Prefix for thumbnail filenames.
filename				frame		Interpolated thumbnail filename.
public					false		Make the output publicly readable on S3.
access_control			none		Fine-grained access control rules for files sent to S3.
grantee					none		Set the grantee for fine-grained S3 access_control permissions.
permission				none		Set the permission for a grantee when using fine-grained access_control.
rrs						false		Amazon S3's Reduced Redundancy Storage.
headers					none		HTTP headers to send with your thumbnails when we upload them.
credentials				none		References saved credentials by a nickname.
parallel_upload_limit	30 for S3, 10 for all other destinations.	The maximum number of simultaneous uploads to attempt.
*/
