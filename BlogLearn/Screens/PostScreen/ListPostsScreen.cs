namespace BlogLearn.Screens.PostScreen;

public static class ListPostsScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("        Lista de Posts       ");
        WriteLine("-----------------------------");
        WriteLine();
        List();
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void List()
    {
        var postRepository = new PostRepository(Database.Connection);
        var posts = postRepository.GetWithTags();

        foreach (var item in posts)
        {
            var tags = string.Join(',', item.Tags.Select(t => t.Name));

            var repository = new Repository<Category>(Database.Connection);
            var category = repository.Get(item.CategoryId);

            WriteLine($"{item.Id} > {item.Title} > {category.Name} > {tags}");
        }

    }
}