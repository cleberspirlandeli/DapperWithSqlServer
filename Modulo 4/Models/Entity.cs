using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    public class Entity
    {
        [Key] 
        public int Id { get; set; }
    }
}