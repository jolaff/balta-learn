namespace BlogLearn.Screens.RoleScreens;

public static class CreateRoleScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("      Cadastrar  Perfil      ");
        WriteLine("-----------------------------");
        WriteLine();
        Write("Digite o nome: ");
        var name = ReadLine();
        WriteLine();
        Write("Digite o slug: ");
        var slug = ReadLine();
        Create(new Role
        {
            Name = name,
            Slug = slug
        });
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void Create(Role role)
    {
        try
        {
            var repository = new Repository<Role>(Database.Connection);
            repository.Create(role);
            WriteLine();
            WriteLine();
            WriteLine($"Perfil {role.Name} cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            WriteLine();
            WriteLine("Não foi possível salvar o perfil");
            WriteLine(ex.Message);
        }
    }
}