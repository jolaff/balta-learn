using BlogLearn.Screens.RoleScreens;

namespace BlogLearn.Screens;

public static class MenuRoleScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("      Gestão de Perfil       ");
        WriteLine("-----------------------------");
        WriteLine("O que deseja fazer?");
        WriteLine();
        WriteLine("1 > Listar perfis");
        WriteLine("2 > Cadastrar perfil");
        WriteLine("3 > Atualizar perfil");
        WriteLine("4 > Excluir perfil");
        WriteLine();
        WriteLine("9 > Voltar ao menu principal");
        WriteLine("0 > Sair do sistema");
        WriteLine();
        Write("Digite a opção: ");
        var option = short.Parse(ReadLine());

        switch (option)
        {
            case 1:
                ListRolesScreen.Load();
                Load();
                break;
            case 2:
                CreateRoleScreen.Load();
                Load();
                break;
            case 3:
                UpdateRoleScreen.Load();
                Load();
                break;
            case 4:
                DeleteRoleScreen.Load();
                Load();
                break;
            case 9:
                break;
            case 0:
                Environment.Exit(1);
                break;
            default:
                Load();
                break;
        }
    }
}