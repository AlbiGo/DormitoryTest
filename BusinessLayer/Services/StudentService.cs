using BusinessLayer.Interfaces;
using DataLayer.DBContext;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class StudentService : IStudentService
    {
        private readonly DormitoryDBContext _dormitoryDBContext;

        public StudentService()
        {
            _dormitoryDBContext = new DormitoryDBContext();
        }

        public async Task<List<Student>> GetAllStudents()
        {
            var students =  await _dormitoryDBContext.Students.ToListAsync();
            return students;
        }

        public async Task ShtoStudent(Student student)
        {
            await _dormitoryDBContext.Students.AddAsync(student);
            await _dormitoryDBContext.SaveChangesAsync();

        }
    }
}
