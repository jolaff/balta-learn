namespace BlogLearn.Screens.PostScreen;

public static class UnbindPostTagScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("      Desvincular  Tag       ");
        WriteLine("-----------------------------");
        WriteLine();
        Write("Digite o Id do Post: ");
        var userId = ReadLine();
        WriteLine();
        Write("Digite o Id da Tag: ");
        var roleId = ReadLine();
        Unbind(int.Parse(userId), int.Parse(roleId));
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void Unbind(int userId, int roleId)
    {
        try
        {
            var postRepository = new PostRepository(Database.Connection);
            postRepository.UnbindPostAndTag(userId, roleId);
            WriteLine();
            WriteLine();
            WriteLine($"Tag desvinculada com sucesso!");
        }
        catch (Exception ex)
        {
            WriteLine();
            WriteLine("Não foi possível desvincular a tag");
            WriteLine(ex.Message);
        }
    }
}