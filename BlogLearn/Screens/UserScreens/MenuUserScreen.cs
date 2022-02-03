using BlogLearn.Screens.UserScreens;

namespace BlogLearn.Screens;

public static class MenuUserScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("      Gestão de Usuário      ");
        WriteLine("-----------------------------");
        WriteLine("O que deseja fazer?");
        WriteLine();
        WriteLine("1 > Listar usuários");
        WriteLine("2 > Cadastrar usuário");
        WriteLine("3 > Atualizar usuário");
        WriteLine("4 > Excluir usuário");
        WriteLine("5 > Vincular usuário a um perfil");
        WriteLine("6 > Desvincular perfil");
        WriteLine();
        WriteLine("9 > Voltar ao menu principal");
        WriteLine("0 > Sair do sistema");
        WriteLine();
        Write("Digite a opção: ");
        var option = short.Parse(ReadLine());

        switch (option)
        {
            case 1:
                ListUsersScreen.Load();
                Load();
                break;
            case 2:
                CreateUserScreen.Load();
                Load();
                break;
            case 3:
                UpdateUserScreen.Load();
                Load();
                break;
            case 4:
                DeleteUserScreen.Load();
                Load();
                break;
            case 5:
                BindUserRoleScreen.Load();
                Load();
                break;
            case 6:
                UnbindUserRoleScreen.Load();
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