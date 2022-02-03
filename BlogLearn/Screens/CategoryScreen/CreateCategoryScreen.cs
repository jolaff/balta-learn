namespace BlogLearn.Screens.CategoryScreen;

public static class CreateCategoryScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("     Cadastrar Categoria     ");
        WriteLine("-----------------------------");
        WriteLine();
        Write("Digite o nome: ");
        var name = ReadLine();
        WriteLine();
        Write("Digite o slug: ");
        var slug = ReadLine();
        Create(new Category
        {
            Name = name,
            Slug = slug
        });
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void Create(Category category)
    {
        try
        {
            var repository = new Repository<Category>(Database.Connection);
            repository.Create(category);
            WriteLine();
            WriteLine();
            WriteLine($"Categoria {category.Name} cadastrada com sucesso!");
        }
        catch (Exception ex)
        {
            WriteLine();
            WriteLine("Não foi possível salvar a categoria");
            WriteLine(ex.Message);
        }
    }
}