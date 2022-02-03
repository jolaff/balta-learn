using BlogLearn.Screens.TagScreens;

namespace BlogLearn.Screens;

public static class MenuTagScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("        Gestão de Tag        ");
        WriteLine("-----------------------------");
        WriteLine("O que deseja fazer?");
        WriteLine();
        WriteLine("1 > Listar tags");
        WriteLine("2 > Cadastrar tag");
        WriteLine("3 > Atualizar tag");
        WriteLine("4 > Excluir tag");
        WriteLine();
        WriteLine("9 > Voltar ao menu principal");
        WriteLine("0 > Sair do sistema");
        WriteLine();
        Write("Digite a opção: ");
        var option = short.Parse(ReadLine());

        switch (option)
        {
            case 1:
                ListTagsScreen.Load();
                Load();
                break;
            case 2:
                CreateTagScreen.Load();
                Load();
                break;
            case 3:
                UpdateTagScreen.Load();
                Load();
                break;
            case 4:
                DeleteTagScreen.Load();
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