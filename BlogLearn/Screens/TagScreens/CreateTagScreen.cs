namespace BlogLearn.Screens.TagScreens;

public static class CreateTagScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("        Cadastrar Tag        ");
        WriteLine("-----------------------------");
        WriteLine();
        Write("Digite o nome: ");
        var name = ReadLine();
        WriteLine();
        Write("Digite o slug: ");
        var slug = ReadLine();
        Create(new Tag
        {
            Name = name,
            Slug = slug
        });
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void Create(Tag tag)
    {
        try
        {
            var repository = new Repository<Tag>(Database.Connection);
            repository.Create(tag);
            WriteLine();
            WriteLine();
            WriteLine($"Tag {tag.Name} cadastrada com sucesso!");
        }
        catch (Exception ex)
        {
            WriteLine();
            WriteLine("Não foi possível salvar a tag");
            WriteLine(ex.Message);
        }
    }
}