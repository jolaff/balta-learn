using var context = new DataContext();

// context.Users.Add(new User
// {
//     Bio = "Always learning",
//     Email = "joel.landgraf@gmail.com",
//     Image = "https://image.eu",
//     Name = "Joel Landgraf Filho",
//     PasswordHash = "123456",
//     Slug = "joel-filho"
// });
// context.SaveChanges();

var user = context.Users.FirstOrDefault();
var post = new Post
{
    Author = user,
    Body = "Meu artigo",
    Category = new Category
    {
        Name = "Backend",
        Slug = "backend"
    },
    CreateDate = System.DateTime.Now,
    Slug = "meu-artigo",
    Summary = "Neste artigo vamos escrever sobre meu artigo...",
    Title = "Meu Artigo"
};
context.Posts.Add(post);
context.SaveChanges();