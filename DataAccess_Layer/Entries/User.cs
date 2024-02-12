using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Entries
{
    public class User
    {

        [Key]
        public int User_Id { get; set; }
        public string? User_Name { get; set; }
        public string? User_Email { get; set; }
        public string? User_Password { get; set; }
        public string? User_Phone { get; set; }
        public string? User_Dept { get; set; }

        public List<User> Users { get; set; } = new List<User>();
    }
}
