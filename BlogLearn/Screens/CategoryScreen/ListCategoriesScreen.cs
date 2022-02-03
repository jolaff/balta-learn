namespace BlogLearn.Screens.CategoryScreen;

public static class ListCategoriesScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("     Lista de Categorias     ");
        WriteLine("-----------------------------");
        WriteLine();
        List();
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void List()
    {
        var repository = new Repository<Category>(Database.Connection);
        var category = repository.Get();

        foreach (var item in category)
            WriteLine($"{item.Id} > {item.Name} > ({item.Slug})");
    }
}