using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CustomerUserModel.Models.Udemy.Models
{
    public class Notifications
    {
        [Key]

        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public string? Message { get; set; }
        [ForeignKey("UserId")]
        public U_User? User { get; set; }

    }
}
