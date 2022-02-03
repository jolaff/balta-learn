namespace BlogLearn.Screens.CategoryScreen;

public static class DeleteCategoryScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("      Excluir Categoria      ");
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
            var repository = new Repository<Category>(Database.Connection);
            repository.Delete(id);
            WriteLine();
            WriteLine();
            WriteLine($"Categoria excluída com sucesso!");
        }
        catch (Exception ex)
        {
            WriteLine();
            WriteLine("Não foi possível excluir a categoria");
            WriteLine(ex.Message);
        }
    }
}
