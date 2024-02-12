using System.ComponentModel.DataAnnotations;

namespace CustomerUserModel.Models.Udemy.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public string? TagName { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
