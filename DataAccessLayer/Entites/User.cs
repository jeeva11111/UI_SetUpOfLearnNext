using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entites
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }
        public string? User_Name { get; set; }
        public string? User_Email { get; set; }
        public string? Depertment { get; set; }
        public List<string>? Roles { get; set; }
        public string? Bio { get; set; }
        public List<Course>? Course { get; set; }
    }
}
