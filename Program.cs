using Balta.ContentContext;
using Balta.SubscriptionContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre ReactJS", "orientacao-objetos"));
            foreach (var article in articles)
            {
                // Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-C#");
            var courseAspet = new Course("Fundamentos ASP.NET", "fundamentos-.NET");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspet);

            var careerdotnet = new Career("Especialista C#", "DOTNET Specialist");
            var careers = new List<Career>();
            var careerItem = new CareerItem(1, "Comece por aqui", "Descricao aqui", null);



            careers.Add(careerdotnet);
            careerdotnet.Items.Add(careerItem);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items)
                {
                    Console.WriteLine($"{item.Ordem} - {item.Title}");
                    foreach (var notification in item.Notifications)
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                }

            }
            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.Subscriptions.Add(payPalSubscription);


        }
    }
}