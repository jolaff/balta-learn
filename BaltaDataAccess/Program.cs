using BaldaDataAccess.Models;
using Dapper;
using Microsoft.Data.SqlClient;

// i do WGC, velia, heidel, and glish

Console.Clear();

const string CONNECTION_STRING = "Server=localhost,1433;Database=balta;User ID=sa;Password=1029384756!@#;TrustServerCertificate=True";


using (var connection = new SqlConnection(CONNECTION_STRING))
{
    CreateManyCategory(connection);
    // DeleteCategory(connection);
    ListCategories(connection);
}

static void ListCategories(SqlConnection connection)
{
    var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");

    foreach (var item in categories)
    {
        Console.WriteLine($"{item.Id} - {item.Title}");
    }
}

static void CreateCategory(SqlConnection connection)
{
    var category = new Category();
    category.Id = Guid.NewGuid();
    category.Title = "Amazon AWS";
    category.Url = "amazon";
    category.Description = "Categoria destinada a serviços do AWS";
    category.Order = 8;
    category.Summary = "AWS Cloud";
    category.Featured = false;

    var insertSql = @"INSERT INTO 
        [Category]
    VALUES(
        @Id,
        @Title,
        @Url,
        @Summary,
        @Order,
        @Description,
        @Featured)";

    var rows = connection.Execute(insertSql, new
    {
        category.Id,
        category.Title,
        category.Url,
        category.Summary,
        category.Order,
        category.Description,
        category.Featured
    });

    Console.WriteLine($"{rows} linha(s) inserida(s)");
}

static void UpdateCategory(SqlConnection connection)
{
    var updateQuery = "UPDATE [Category] SET [Title]=@title WHERE [Id]=@id";
    var rows = connection.Execute(updateQuery, new
    {
        id = new Guid("af3407aa-11ae-4621-a2ef-2028b85507c4"),
        title = "Frontend 2021"
    });

    Console.WriteLine($"{rows} registros atualizadas");
}

static void DeleteCategory(SqlConnection connection)
{
    var deleteQuery = "DELETE [Category] WHERE [Id]=@id";
    var rows = connection.Execute(deleteQuery, new
    {
        id = new Guid("39b27204-97b3-4f6b-8f57-deaaf445b478"),
    });

    Console.WriteLine($"{rows} registros excluídos");
}

static void CreateManyCategory(SqlConnection connection)
{
    var category = new Category();
    category.Id = Guid.NewGuid();
    category.Title = "Amazon AWS";
    category.Url = "amazon";
    category.Description = "Categoria destinad a serviços do AWS";
    category.Order = 8;
    category.Summary = "AWS Cloud";
    category.Featured = false;

    var category2 = new Category();
    category2.Id = Guid.NewGuid();
    category2.Title = "Categoria Nova";
    category2.Url = "categoria-nova";
    category2.Description = "Categoria destinada a aprender many";
    category2.Order = 9;
    category2.Summary = "Nova Categoria";
    category2.Featured = false;

    var insertSql = @"INSERT INTO 
        [Category]
    VALUES(
        @Id,
        @Title,
        @Url,
        @Summary,
        @Order,
        @Description,
        @Featured)";

    var rows = connection.Execute(insertSql, new[]{
        new
        {
            category.Id,
            category.Title,
            category.Url,
            category.Summary,
            category.Order,
            category.Description,
            category.Featured
        }, new
        {
            category2.Id,
            category2.Title,
            category2.Url,
            category2.Summary,
            category2.Order,
            category2.Description,
            category2.Featured
        }
    }
    );

    Console.WriteLine($"{rows} linha(s) inserida(s)");
}