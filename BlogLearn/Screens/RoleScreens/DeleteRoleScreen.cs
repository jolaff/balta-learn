namespace BlogLearn.Screens.RoleScreens;

public static class DeleteRoleScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("       Excluir  Perfil       ");
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
        try
        {
            var repository = new Repository<Role>(Database.Connection);
            repository.Delete(id);
            WriteLine();
            WriteLine();
            WriteLine($"Perfil excluído com sucesso!");
        }
        catch (Exception ex)
        {
            WriteLine();
            WriteLine("Não foi possível excluir o perfil");
            WriteLine(ex.Message);
        }
    }
}