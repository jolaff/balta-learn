namespace BlogLearn.Screens.TagScreens;

public static class DeleteTagScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("         Excluir Tag         ");
        WriteLine("-----------------------------");
        WriteLine();
        Write("Entre com o Id: ");
        var id = ReadLine();
        Delete(int.Parse(id));
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void Delete(int id)
    {
        try
        {
            var repository = new Repository<Tag>(Database.Connection);
            repository.Delete(id);
            WriteLine();
            WriteLine();
            WriteLine($"Tag excluída com sucesso!");
        }
        catch (Exception ex)
        {
            WriteLine();
            WriteLine("Não foi possível excluir a tag");
            WriteLine(ex.Message);
        }
    }
}