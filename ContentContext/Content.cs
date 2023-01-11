using Balta.SharedContext;

namespace Balta.ContentContext
{
    public abstract class Content : Base
    {

         public Content(string title, string url)
         {
            //Método construtor
            Title = title;
            Url = url;
         }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}