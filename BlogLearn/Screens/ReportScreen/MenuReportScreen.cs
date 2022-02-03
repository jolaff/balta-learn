using BlogLearn.Screens.ReportScreen;

namespace BlogLearn.Screens;

public static class MenuReportScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("          Relatórios         ");
        WriteLine("-----------------------------");
        WriteLine("O que deseja fazer?");
        WriteLine();
        WriteLine("1 > Listar categorias com quantidade de posts");
        WriteLine("2 > Listar tags com quantidade de posts");
        WriteLine("3 > Listar os posts de uma categoria");
        WriteLine();
        WriteLine("9 > Voltar ao menu principal");
        WriteLine("0 > Sair do sistema");
        WriteLine();
        Write("Digite a opção: ");
        var option = short.Parse(ReadLine());

        switch (option)
        {
            case 1:
                CategoryWithPostScreen.Load();
                Load();
                break;
            case 2:
                TagWithPostScreen.Load();
                Load();
                break;
            case 3:
                PostsFromCategoryScreen.Load();
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