using DataAccessLayer.Data;
using DataAccessLayer.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public class CourseRepo : ICourseRepositorys

    {
        private readonly ApplicationDbContext _context;
        public CourseRepo(ApplicationDbContext context)
        {
            _context = context;
        }


        public Task<List<Course>> AddCourse(int id)
        {
            return _context.Courses.Where(x=> x.Id == id).ToListAsync();
        }

        public Task DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Course>> GetAll()
        {
           return _context.Courses.ToListAsync();
        }

        public Task<CourseRepository> RemoveCourse(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCourseAsync(CourseRepository course)
        {
            throw new NotImplementedException();
        }
    }
    //Get


}

