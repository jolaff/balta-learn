namespace BlogLearn.Screens.UserScreens;

public static class UnbindUserRoleScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("     Desvincular Perfil      ");
        WriteLine("-----------------------------");
        WriteLine();
        Write("Digite o Id do Usuário: ");
        var userId = ReadLine();
        WriteLine();
        Write("Digite o Id do Perfil: ");
        var roleId = ReadLine();
        Unbind(int.Parse(userId), int.Parse(roleId));
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void Unbind(int userId, int roleId)
    {
        try
        {
            var userRepository = new UserRepository(Database.Connection);
            userRepository.UnbindUserAndRole(userId, roleId);
            WriteLine();
            WriteLine();
            WriteLine($"Perfil desvinculado com sucesso!");
        }
        catch (Exception ex)
        {
            WriteLine();
            WriteLine("Não foi possível desvincular o perfil");
            WriteLine(ex.Message);
        }
    }
}