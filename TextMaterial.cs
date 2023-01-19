using System;

namespace Trainings
{
    internal class TextMaterial : Training
    {
        public string Text { get; set; }
        public TextMaterial(Guid guid, string textDescription, string text) : base(guid, textDescription)
        {
            Text = text;
        }
        public override string ToString()
        {
            return "Class describes Text Materials";
        }
        
    }
}
