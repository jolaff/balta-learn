// See https://aka.ms/new-console-template for more information
using JLFOOP.ContentContext;

var articles = new List<Article>();
articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
articles.Add(new Article("Artigo sobre C#", "csharp"));
articles.Add(new Article("Artigo sobre .NET", "dotnet"));

foreach (var article in articles)
{
    Console.WriteLine(article.Id);
    Console.WriteLine(article.Title);
    Console.WriteLine(article.Url);
}

var courses = new List<Course>();
var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
var courseCSharp = new Course("Fundamentos C#", "fundamentos-csharp");
var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

courses.Add(courseOOP);
courses.Add(courseCSharp);
courses.Add(courseAspNet);

var careers = new List<Career>();
var career = new Career("Especialista .NET", "especialista-dotnet");
var careerItem = new CareerItem(1, "Comece por aqui", "", courseCSharp);
career.Items.Add(careerItem);
careers.Add(career);
