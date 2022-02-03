using BlogLearn.Screens.CategoryScreen;

namespace BlogLearn.Screens;

public static class MenuCategoryScreen
{
    public static void Load()
    {
        Clear();
        WriteLine("-----------------------------");
        WriteLine("     Gestão de Categoria     ");
        WriteLine("-----------------------------");
        WriteLine("O que deseja fazer?");
        WriteLine();
        WriteLine("1 > Listar categorias");
        WriteLine("2 > Cadastrar categoria");
        WriteLine("3 > Atualizar categoria");
        WriteLine("4 > Excluir categoria");
        WriteLine();
        WriteLine("9 > Voltar ao menu principal");
        WriteLine("0 > Sair do sistema");
        WriteLine();
        Write("Digite a opção: ");
        var option = short.Parse(ReadLine());

        switch (option)
        {
            case 1:
                ListCategoriesScreen.Load();
                Load();
                break;
            case 2:
                CreateCategoryScreen.Load();
                Load();
                break;
            case 3:
                UpdateCategoryScreen.Load();
                Load();
                break;
            case 4:
                DeleteCategoryScreen.Load();
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
