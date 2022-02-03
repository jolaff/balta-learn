namespace BlogLearn.Screens.PostScreen;

public static class DeletePostScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("        Excluir  Post        ");
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
        if (CheckBindedTags(id))
            WriteLine($"{Environment.NewLine}Não é possível excluir post com tag vinculada. Favor desvincular a tag.");
        else
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Delete(id);
                WriteLine();
                WriteLine();
                WriteLine($"Post excluído com sucesso!");
            }
            catch (Exception ex)
            {
                WriteLine();
                WriteLine("Não foi possível excluir o post");
                WriteLine(ex.Message);
            }

        }
    }

    private static bool CheckBindedTags(int id)
    {
        var postRepository = new PostRepository(Database.Connection);
        var user = postRepository.GetWithTags().Find(u => u.Id == id);
        return user.Tags.Count > 0 ? true : false;
    }
}