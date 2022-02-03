namespace BlogLearn.Screens.PostScreen;

public static class BindPostTagScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("        Vincular  Tag        ");
        WriteLine("-----------------------------");
        WriteLine();
        Write("Digite o Id do Post: ");
        var userId = ReadLine();
        WriteLine();
        Write("Digite o Id da Tag: ");
        var roleId = ReadLine();
        Bind(int.Parse(userId), int.Parse(roleId));
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void Bind(int userId, int roleId)
    {
        try
        {
            var postRepository = new PostRepository(Database.Connection);
            postRepository.BindPostToTag(userId, roleId);
            WriteLine();
            WriteLine();
            WriteLine($"Tag vinculada com sucesso!");
        }
        catch (Exception ex)
        {
            WriteLine();
            WriteLine("Não foi possível vincular a tag");
            WriteLine(ex.Message);
        }
    }
}