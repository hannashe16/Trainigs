using System;

namespace Trainings
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            Training[] training = { new TextMaterial(Guid.NewGuid(), "Text Material description", "Text Material text"), 
                //new VideoMaterial(Guid.NewGuid(), null, "Video Material image URI", "Video Material video URI", VideoFormats.Mp4), 
                new ResoursLink(Guid.NewGuid(), "Resours Link text description", "Resours Link content URI", LinkTypes.Video) };
            Training training2 = new Training(Guid.NewGuid(), null);
            //

            //foreach (Training item in training)                               // как вывести LessonKind.TextLesson ?
            //{
            //    if (item.GetLessonKind(item) == LessonKind.TextLesson)
            //    {
            //        continue;

            //    }                   
            //    else if (item.GetLessonKind(item) == LessonKind.VideoLesson)
            //    {
            //        Console.WriteLine(LessonKind.VideoLesson);
            //        break;
            //    }
            //}
            //
            for (int i = 0; i < training.Length; i++)
            {
                Console.WriteLine((training[i].GetKind(training)).ToString());
            }


            Console.WriteLine(training2.ToString()); // как переопределить метод ToString для массива объектов типа training?
            Console.WriteLine(new TextMaterial(Guid.NewGuid(), "Text Material description", "Text Material text").ToString());

            TextMaterial textm1 = new TextMaterial(Guid.NewGuid(), "Text Material description", "Text Material text");
            TextMaterial textm2 = new TextMaterial(Guid.NewGuid(), null, "Text Material text");
            VideoMaterial vidm = new VideoMaterial(Guid.NewGuid(), null, "Video Material image URI", "Video Material video URI", VideoFormats.Mp4);
            bool res = textm1.Equals(textm2);
            bool res2 = vidm.Equals(textm1);
        }        
    }
}
