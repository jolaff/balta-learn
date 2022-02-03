using Dapper;
using Microsoft.Data.SqlClient;

namespace BlogLearn.Repositories;

public class ReportRepository<T>
{
    private readonly SqlConnection _connection;

    public ReportRepository(SqlConnection connection)
        => _connection = connection;

    public List<T> GetQuantityOfPosts(out List<int> values)
    {
        var query = GetQueryType();

        var items = new List<T>();
        var quantities = new List<int>();

        items = _connection.Query<T, int, T>(
            query,
            (item, qt) =>
            {
                quantities.Add(qt);

                items.Add(item);
                return item;
            }, splitOn: "QUANTITY").ToList();
        values = quantities;

        return items;
    }

    private string GetQueryType()
    {
        var categoryQuery = @"
                SELECT
                    [Category].[Id],
                    [Category].[Name],
                    COUNT(*) AS QUANTITY
                FROM
                    [Category],
                    [Post]
                WHERE
                    [Category].[Id] = [Post].[CategoryId]
                GROUP BY
                    [Category].[Id],
                    [Category].[Name]";

        var tagQuery = @"
                SELECT
                    [Tag].[Id],
                    [Tag].[Name],
                    COUNT(*) AS QUANTITY
                FROM
                    [Tag],
                    [PostTag]
                WHERE
                    [Tag].[Id] = [PostTag].[TagId]
                GROUP BY
                    [Tag].[Id],
                    [Tag].[Name]";

        if (typeof(T) == typeof(Category))
            return categoryQuery;
        else if (typeof(T) == typeof(Tag))
            return tagQuery;
        else
            return string.Empty;
    }
}
