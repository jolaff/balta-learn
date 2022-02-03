namespace BlogLearn.Screens.RoleScreens;

public static class UpdateRoleScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("      Atualizar  Perfil      ");
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
        Update(new Role
        {
            Id = int.Parse(id),
            Name = name,
            Slug = slug
        });
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void Update(Role role)
    {
        try
        {
            var repository = new Repository<Role>(Database.Connection);
            repository.Update(role);
            WriteLine();
            WriteLine();
            WriteLine($"Perfil atualizado para {role.Name} com sucesso!");
        }
        catch (Exception ex)
        {
            WriteLine();
            WriteLine("Não foi possível atualizar o perfil");
            WriteLine(ex.Message);
        }
    }
}