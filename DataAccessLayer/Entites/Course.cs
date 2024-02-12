using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entites
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ContentCreator { get; set; }
        public string? Category { get; set; }
        [ForeignKey("C_User_Id")]
        public int? C_User_Id { get; set; }
        public User CourseUser { get; set; } = new User();
    }

}
