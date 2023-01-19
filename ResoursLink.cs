using System;

namespace Trainings
{
    public enum LinkTypes
    {
        Unknown,
        Html,
        Image,
        Audio,
        Video
    }
    internal class ResoursLink : Training
    {        
        string _URIContent;
        public string URIContent 
        {
            get => _URIContent;
            set
            {
                if (value != null && value.Length > 0)
                    _URIContent = value;
                else
                    throw new Exception("Content URI is empty string");
            }
        }
        public LinkTypes LinkType { get; set; }
        public ResoursLink(Guid guid, string textDescription, string contentURI, LinkTypes linkType) : base(guid, textDescription)
        {
            URIContent = contentURI;
            LinkType = linkType;

        }
        public override string ToString()
        {
            return "Class describes Resours Links";
        }
    }
}
