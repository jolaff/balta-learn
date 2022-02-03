using Dapper;
using Microsoft.Data.SqlClient;

namespace BlogLearn.Repositories;

public class PostRepository : Repository<Post>
{
    private readonly SqlConnection _connection;

    public PostRepository(SqlConnection connection) : base(connection)
        => _connection = connection;

    public List<Post> GetWithTags()
    {
        var query = @"
                SELECT
                    [Post].*,
                    [Tag].*
                FROM
                    [Post]
                    LEFT JOIN [PostTag] ON [PostTag].[PostId] = [Post].[Id]
                    LEFT JOIN [Tag] ON [PostTag].[TagId] = [Tag].[Id]";

        var posts = new List<Post>();

        var items = _connection.Query<Post, Tag, Post>(
            query,
            (post, tag) =>
            {
                var pst = posts.FirstOrDefault(x => x.Id == post.Id);
                if (pst == null)
                {
                    pst = post;
                    if (tag != null)
                        pst.Tags.Add(tag);

                    posts.Add(pst);
                }
                else
                    pst.Tags.Add(tag);

                return post;
            }, splitOn: "Id");

        return posts;
    }

    public List<PostFromCategory> ListPostsFromCategory(int categoryId)
    {
        var query = @"
                SELECT
                    [Post].[Id],
                    [Post].[Title],
                    [Post].[CategoryId],
                    [User].[Name]
                FROM
                    [Post]
                    INNER JOIN [User] ON [User].[Id] = [Post].[AuthorId]
                WHERE
                    [Post].[CategoryId] = @Id";

        return _connection.Query<PostFromCategory>(query, new { Id = categoryId }).ToList();
    }

    public void BindPostToTag(int postId, int tagId)
    {
        var insertSql = @"INSERT INTO [PostTag] VALUES(@PostId, @TagId)";

        _connection.Execute(insertSql, new
        {
            postId,
            tagId
        });
    }

    public void UnbindPostAndTag(int postId, int tagId)
    {
        var deleteSql = @"DELETE FROM [PostTag] WHERE [PostTag].[PostId]=@PostId AND [PostTag].[TagId]=@TagId";

        _connection.Execute(deleteSql, new
        {
            postId,
            tagId
        });
    }

    public class PostFromCategory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}