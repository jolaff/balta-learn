namespace BlogLearn.Screens.TagScreens;

public static class ListTagsScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("        Lista de Tags        ");
        WriteLine("-----------------------------");
        WriteLine();
        List();
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void List()
    {
        var repository = new Repository<Tag>(Database.Connection);
        var tags = repository.Get();

        foreach (var item in tags)
            WriteLine($"{item.Id} > {item.Name} ({item.Slug})");
    }
}