using System;

namespace Trainings
{
    public enum LessonKind
    {
        VideoLesson,
        TextLesson
    }
    internal class Training
    {
        public Guid Guid { get; set; }
        string _textDescription;
        public string TextDescription 
        { 
            get => _textDescription;
            set
            {
                if (value == null)
                    _textDescription = null;
                else if (value.Length >= 0 && value.Length < 256)
                    _textDescription = value;               
                else                
                    throw new Exception("Text description is not valid");                
            }
        }
        public Training(Guid guid, string textDescription)
        {
            Guid = guid;
            TextDescription = textDescription;
        }

        //public LessonKind GetLessonKind(Training train)
        //{
        //    if (train is VideoMaterial)                  
        //        return LessonKind.VideoLesson;
        //    else
        //        return LessonKind.TextLesson;
        //}

        //метод, возвращающий вид занятия.
        //Если занятие содержит хотя бы один видеоматериал, то его вид – VideoLesson,
        //иначе – TextLesson (это элементы перечисления LessonKind).
        public LessonKind GetKind(Training[] training)
        {
            foreach (Training item in training)
            {
                if (item is VideoMaterial)
                {
                    return LessonKind.VideoLesson;
                }                    
            }            
            return LessonKind.TextLesson;
        }

        public override string ToString()
        {
            return "Class describes trainigs";
        }

        public override bool Equals(object obj)
        {
            if (obj is Training)
            {
                Training training = obj as Training;
                return Guid.Equals(training.Guid) &&
                    base.Equals(obj);
            }
            return false;
        }
    }
}
