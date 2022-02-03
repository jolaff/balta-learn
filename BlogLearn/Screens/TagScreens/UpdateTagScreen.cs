namespace BlogLearn.Screens.TagScreens;

public static class UpdateTagScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("        Atualizar Tag        ");
        WriteLine("-----------------------------");
        WriteLine();
        Write("Entre com o Id: ");
        var id = ReadLine();
        WriteLine();
        Write("Digite o nome: ");
        var name = ReadLine();
        WriteLine();
        Write("Digite o slug: ");
        var slug = ReadLine();
        Update(new Tag
        {
            Id = int.Parse(id),
            Name = name,
            Slug = slug
        });
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void Update(Tag tag)
    {
        try
        {
            var repository = new Repository<Tag>(Database.Connection);
            repository.Update(tag);
            WriteLine();
            WriteLine();
            WriteLine($"Tag atualizada para {tag.Name} com sucesso!");
        }
        catch (Exception ex)
        {
            WriteLine();
            WriteLine("Não foi possível atualizar a tag");
            WriteLine(ex.Message);
        }
    }
}