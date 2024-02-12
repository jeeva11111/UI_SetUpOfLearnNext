// CourseRepository.cs
using DataAccessLayer.Data;
using DataAccessLayer.Entites;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public class CourseRepository : ICourseRepositorys
    {
        private readonly ApplicationDbContext _context;

        public CourseRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Course>> AddCourse(int id)
        {
            return await _context.Courses.ToListAsync();
        }

        Task<List<Course>> ICourseRepositorys.AddCourse(int id)
        {
            throw new NotImplementedException();
        }

        Task ICourseRepositorys.DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Course>> ICourseRepositorys.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<CourseRepository> ICourseRepositorys.RemoveCourse(int id)
        {
            throw new NotImplementedException();
        }

        Task ICourseRepositorys.UpdateCourseAsync(CourseRepository course)
        {
            throw new NotImplementedException();
        }
    }
}
