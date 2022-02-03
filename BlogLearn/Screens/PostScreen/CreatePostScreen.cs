namespace BlogLearn.Screens.PostScreen;

public static class CreatePostScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("     Cadastrar novo Post     ");
        WriteLine("-----------------------------");
        WriteLine("Em qual categoria deseja criar o post?" + Environment.NewLine);
        GetCategories();
        Write(Environment.NewLine + "Digite o Id: ");
        var category = ReadLine();
        WriteLine(Environment.NewLine + "Quem está criando o post?" + Environment.NewLine);
        GetUsers();
        Write(Environment.NewLine + "Digite o Id: ");
        var user = ReadLine();
        Write(Environment.NewLine + "Digite um título: ");
        var title = ReadLine();
        Write(Environment.NewLine + "Entre com o sumário: ");
        var summay = ReadLine();
        Write(Environment.NewLine + "Digite o slug: ");
        var slug = ReadLine();
        WriteLine(Environment.NewLine + "Por fim, realize o seu post!");
        var body = ReadLine();

        Create(new Post
        {
            CategoryId = int.Parse(category),
            AuthorId = int.Parse(user),
            Title = title,
            Summary = summay,
            Slug = slug,
            Body = body
        });

        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void Create(Post post)
    {
        try
        {
            var repository = new Repository<Post>(Database.Connection);
            repository.Create(post);
            WriteLine();
            WriteLine();
            WriteLine($"Post <{post.Title}> cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            WriteLine();
            WriteLine("Não foi possível cadastrar o post");
            WriteLine(ex.Message);
        }
    }

    private static void GetCategories()
    {
        var repository = new Repository<Category>(Database.Connection);
        var categories = repository.Get();

        foreach (var item in categories)
            WriteLine($"{item.Id} > {item.Name}");
    }

    private static void GetUsers()
    {
        var repository = new Repository<User>(Database.Connection);
        var users = repository.Get();

        foreach (var item in users)
            WriteLine($"{item.Id} > {item.Name}");
    }

}