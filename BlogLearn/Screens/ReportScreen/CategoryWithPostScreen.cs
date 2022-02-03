namespace BlogLearn.Screens.ReportScreen;

public static class CategoryWithPostScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("      Categorias x Post      ");
        WriteLine("-----------------------------");
        WriteLine();
        List();
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    public static void List()
    {
        var reportRepository = new ReportRepository<Category>(Database.Connection);
        var quantities = new List<int>();
        var items = reportRepository.GetQuantityOfPosts(out quantities);

        for (int i = 0; i < items.Count; i++)
        {
            WriteLine($"Categoria: {items[i].Id} > {items[i].Name} > Quantidade de posts: {quantities[i]}");
        }
    }
}