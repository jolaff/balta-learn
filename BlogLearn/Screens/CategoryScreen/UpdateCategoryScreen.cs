namespace BlogLearn.Screens.CategoryScreen;

public static class UpdateCategoryScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("     Atualizar Categoria     ");
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
        Update(new Category
        {
            Id = int.Parse(id),
            Name = name,
            Slug = slug
        });
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void Update(Category category)
    {
        try
        {
            var repository = new Repository<Category>(Database.Connection);
            repository.Update(category);
            WriteLine();
            WriteLine();
            WriteLine($"Categoria atualizada para {category.Name} com sucesso!");
        }
        catch (Exception ex)
        {
            WriteLine();
            WriteLine("Não foi possível atualizar a categoria");
            WriteLine(ex.Message);
        }
    }
}