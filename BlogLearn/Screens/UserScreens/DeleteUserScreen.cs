namespace BlogLearn.Screens.UserScreens;

public static class DeleteUserScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("       Excluir Usuário       ");
        WriteLine("-----------------------------");
        WriteLine();
        Write("Entre com o Id: ");
        var id = ReadLine();
        Delete(int.Parse(id));
        WriteLine();
        Write("Pressione qualquer tecla para voltar...");
        ReadKey();
    }

    private static void Delete(int id)
    {
        if (CheckBindedRoles(id))
            WriteLine($"{Environment.NewLine}Não é possível excluir usuário vinculado a um perfil. Favor desvincular o perfil.");
        else
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Delete(id);
                WriteLine();
                WriteLine();
                WriteLine($"Usuário excluído com sucesso!");
            }
            catch (Exception ex)
            {
                WriteLine();
                WriteLine("Não foi possível excluir o usuário");
                WriteLine(ex.Message);
            }

        }
    }

    private static bool CheckBindedRoles(int id)
    {
        var userRepository = new UserRepository(Database.Connection);
        var user = userRepository.GetWithRoles().Find(u => u.Id == id);
        return user.Roles.Count > 0 ? true : false;
    }
}