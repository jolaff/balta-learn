namespace BlogLearn.Screens.UserScreens;

public static class ListUsersScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("      Lista de Usuários      ");
        WriteLine("-----------------------------");
        WriteLine();
        List();
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void List()
    {
        var userRepository = new UserRepository(Database.Connection);
        var users = userRepository.GetWithRoles();

        foreach (var item in users)
        {
            var roles = string.Join(',', item.Roles.Select(r => r.Name));
            WriteLine($"{item.Id} > {item.Name} > {item.Email} > {item.Bio} > {roles}");
        }

    }
}