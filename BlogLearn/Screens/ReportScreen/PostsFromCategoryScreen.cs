namespace BlogLearn.Screens.ReportScreen;

public static class PostsFromCategoryScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("Listar Posts de uma Categoria");
        WriteLine("-----------------------------");
        WriteLine("De qual categoria deseja listar?" + Environment.NewLine);
        GetCategories();
        Write(Environment.NewLine + "Digite o Id: ");
        var category = ReadLine();
        WriteLine();
        List(int.Parse(category));
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void List(int categoryId)
    {
        var postRepository = new PostRepository(Database.Connection);
        var posts = postRepository.ListPostsFromCategory(categoryId);

        foreach (var post in posts)
            WriteLine($"{post.Id} > {post.Title} > {post.Name}");
    }

    private static void GetCategories()
    {
        var repository = new Repository<Category>(Database.Connection);
        var categories = repository.Get();

        foreach (var item in categories)
            WriteLine($"{item.Id} > {item.Name}");
    }
}