using DataAccessLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface ICourseRepositorys
    {
        Task<List<Course>> GetAll(); // Corrected return type

        Task<List<Course>> AddCourse(int id);
        Task DeleteCourse(int id);
        Task<CourseRepository> RemoveCourse(int id);
        Task UpdateCourseAsync(CourseRepository course);

    }
}
