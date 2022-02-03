global using static System.Console;
global using BlogLearn.Models;
global using BlogLearn.Repositories;
using Microsoft.Data.SqlClient;
using BlogLearn.Screens;
using BlogLearn;

const string CONNECTION_STRING = "Server=localhost,1433;Database=BlogLearn;User ID=sa;Password=1029384756!@#;TrustServerCertificate=True";

Database.Connection = new SqlConnection(CONNECTION_STRING);
Database.Connection.Open();

Load();

ReadKey();
Database.Connection.Close();

// SELECT COUNT(*) FROM [Category],[Post] WHERE [Category].[Id] = [Post].[CategoryId] AND [Category].[Id]=1
// Use this select to build a report to list categories with post numbers

static void Load()
{
    Clear();
    WriteLine("-----------------------------");
    WriteLine("          Meu  Blog          ");
    WriteLine("-----------------------------");
    WriteLine("O que deseja fazer?");
    WriteLine();
    WriteLine("1 > Gestão de usuário");
    WriteLine("2 > Gestão de perfil");
    WriteLine("3 > Gestão de categoria");
    WriteLine("4 > Gestão de tag");
    WriteLine("5 > Gestão de post");
    WriteLine("6 > Relatórios");
    WriteLine();
    WriteLine("0 > Sair do sistema");
    WriteLine();
    Write("Digite a opção: ");
    var option = short.Parse(ReadLine()!);

    switch (option)
    {
        case 1:
            MenuUserScreen.Load();
            Load();
            break;
        case 2:
            MenuRoleScreen.Load();
            Load();
            break;
        case 3:
            MenuCategoryScreen.Load();
            Load();
            break;
        case 4:
            MenuTagScreen.Load();
            Load();
            break;
        case 5:
            MenuPostScreen.Load();
            Load();
            break;
        case 6:
            MenuReportScreen.Load();
            Load();
            break;
        case 0:
            Environment.Exit(1);
            break;
        default:
            Load();
            break;
    }
}