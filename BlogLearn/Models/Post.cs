using Dapper.Contrib.Extensions;

namespace BlogLearn.Models
{
    [Table("[Post]")]
    public class Post
    {
        public Post()
            => Tags = new List<Tag>();

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime LastUpdateDate { get; set; } = DateTime.Now;

        [Write(false)]
        public List<Tag> Tags { get; set; }

    }
}