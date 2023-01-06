using Balta.ContentContext.Enums;

namespace Balta.ContentContext {


     public class Course : Content
     {
        public Course() {
            Modules = new List<Module>();
            //método construtor
        }

        public string Tag {get; set;}

        public IList<Module> Modules {get; set;}

        public int DurationInMinutes {get; set;}

        public EContentLevel Level {get; set;}
     }


 

}