namespace BlogLearn.Screens.ReportScreen;

public static class TagWithPostScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("         Tags x Post         ");
        WriteLine("-----------------------------");
        WriteLine();
        List();
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    public static void List()
    {
        var reportRepository = new ReportRepository<Tag>(Database.Connection);
        var quantities = new List<int>();
        var items = reportRepository.GetQuantityOfPosts(out quantities);

        for (int i = 0; i < items.Count; i++)
        {
            WriteLine($"Tag: {items[i].Id} > {items[i].Name} > Quantidade de posts: {quantities[i]}");
        }
    }
}