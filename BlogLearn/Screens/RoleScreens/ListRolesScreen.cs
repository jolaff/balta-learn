namespace BlogLearn.Screens.RoleScreens;

public static class ListRolesScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("       Lista de Perfis       ");
        WriteLine("-----------------------------");
        WriteLine();
        List();
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void List()
    {
        var repository = new Repository<Role>(Database.Connection);
        var roles = repository.Get();

        foreach (var item in roles)
            WriteLine($"{item.Id} > {item.Name} ({item.Slug})");
    }
}