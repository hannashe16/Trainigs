using System;

namespace Trainings
{
    public enum VideoFormats
    {
        Unknown,
        Avi,
        Mp4,
        Flv
    }
    internal class VideoMaterial : Training
    {
        
        string _URIVideo;
        public string URIVideo 
        {   
            get => _URIVideo;
            set 
            {
                if (value != null && value.Length > 0)
                    _URIVideo = value;
                else
                    throw new Exception("Video URI is empty string");
            } 
        }
        public string URIImage { get; set; }
        public VideoFormats VideoFormat { get; set; }

        public VideoMaterial(Guid guid, string textDescription, string imageURI, string videoURI, VideoFormats videoFormat) : base(guid, textDescription)
        {
            URIImage = imageURI;
            URIVideo = videoURI;
            VideoFormat = videoFormat;            
        }
        public override string ToString()
        {
            return "Class describes Video Materials";
        }
    }
}
