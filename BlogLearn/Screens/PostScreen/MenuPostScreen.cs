using BlogLearn.Screens.PostScreen;

namespace BlogLearn.Screens;

public static class MenuPostScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("        Gestão de Post       ");
        WriteLine("-----------------------------");
        WriteLine("O que deseja fazer?");
        WriteLine();
        WriteLine("1 > Listar post");
        WriteLine("2 > Cadastrar post");
        WriteLine("3 > Atualizar post");
        WriteLine("4 > Excluir post");
        WriteLine("5 > Vincular post a uma tag");
        WriteLine("6 > Desvincular tag");
        WriteLine();
        WriteLine("9 > Voltar ao menu principal");
        WriteLine("0 > Sair do sistema");
        WriteLine();
        Write("Digite a opção: ");
        var option = short.Parse(ReadLine());

        switch (option)
        {
            case 1:
                ListPostsScreen.Load();
                Load();
                break;
            case 2:
                CreatePostScreen.Load();
                Load();
                break;
            case 3:
                EditPostScreen.Load();
                Load();
                break;
            case 4:
                DeletePostScreen.Load();
                Load();
                break;
            case 5:
                BindPostTagScreen.Load();
                Load();
                break;
            case 6:
                UnbindPostTagScreen.Load();
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