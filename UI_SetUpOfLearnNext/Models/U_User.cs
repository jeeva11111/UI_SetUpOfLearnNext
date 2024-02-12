using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerUserModel.Models.Udemy.Models
{
    [Table("User")]
    public class U_User
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "User in Required"), MaxLength(50)]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Email Id Required"), DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Email Id Required"), DataType(DataType.DateTime)]
        public DateTime? integrationDate { get; set; }
        [Required(ErrorMessage = "Password is Required"), DataType(DataType.Password)]
        public string? Password { get; set; }
        public List<Categories>? Categories { get; set; }
        public List<Notifications>? Notifications { get; set; }
        // public Tag Tag { get; set; }
    }
}
