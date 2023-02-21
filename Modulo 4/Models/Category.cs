using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[Category]")]
    public class Category : Entity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}