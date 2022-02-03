namespace BlogLearn.Screens.PostScreen;

public static class EditPostScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("       Atualizar  Post       ");
        WriteLine("-----------------------------");
        WriteLine();

        Write("Entre com o Id: ");
        var id = ReadLine();
        WriteLine();
        WriteLine("Digite o novo conteúdo:");
        var body = ReadLine();
        WriteLine();

        Update(int.Parse(id), body);

        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void Update(int id, string body)
    {
        try
        {
            var repository = new Repository<Post>(Database.Connection);
            var oldPost = repository.Get(id);
            repository.Update(new Post
            {
                Id = id,
                CategoryId = oldPost.CategoryId,
                AuthorId = oldPost.AuthorId,
                Title = oldPost.Title,
                Summary = oldPost.Summary,
                Slug = oldPost.Slug,
                Body = body,
                CreateDate = oldPost.CreateDate,
                LastUpdateDate = DateTime.Now
            });
            WriteLine();
            WriteLine();
            WriteLine($"Post atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            WriteLine();
            WriteLine("Não foi possível atualizar o post");
            WriteLine(ex.Message);
        }
    }
}