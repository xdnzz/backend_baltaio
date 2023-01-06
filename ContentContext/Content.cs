namespace Balta.ContentContext
{
    public class Content
    {

         public Content()
         {
            //Método construtor
            Id = Guid.NewGuid(); //SPOF, Single Point of Failure
         }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}