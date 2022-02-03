namespace BlogLearn.Screens.UserScreens;

public static class BindUserRoleScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("       Vincular Perfil       ");
        WriteLine("-----------------------------");
        WriteLine();
        Write("Digite o Id do Usuário: ");
        var userId = ReadLine();
        WriteLine();
        Write("Digite o Id do Perfil: ");
        var roleId = ReadLine();
        Bind(int.Parse(userId), int.Parse(roleId));
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void Bind(int userId, int roleId)
    {
        try
        {
            var userRepository = new UserRepository(Database.Connection);
            userRepository.BindUserToRole(userId, roleId);
            WriteLine();
            WriteLine();
            WriteLine($"Perfil vinculado com sucesso!");
        }
        catch (Exception ex)
        {
            WriteLine();
            WriteLine("Não foi possível vincular o perfil");
            WriteLine(ex.Message);
        }
    }
}