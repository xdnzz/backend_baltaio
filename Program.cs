using Balta.ContentContext;

namespace Balta
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            var course = new Course();
            course.Level = ContentContext.Enums.EContentLevel.Iniciante; 
            foreach (var item in course.Modules)
            {
                
            }

            var carrer = new Career();
            carrer.Items.Add(new CarrerItem());
            Console.WriteLine(carrer.TotalCourses);
        }
    }
}