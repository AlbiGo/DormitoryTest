using BusinessLayer.Interfaces;
using DataLayer.DBContext;
using DataLayer.Entities;
using DataLayer.Interfaces;
using DataLayer.Repository;
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
        private readonly IBaseRepository<Student> _baseRepository;

        public StudentService()
        {
            _dormitoryDBContext = new DormitoryDBContext();
            _baseRepository = new BaseRepository<Student>();

        }

        public async Task<List<Student>> GetAllStudents()
        {
            var students = await _baseRepository.GetAll();
            return students;
        }

        public async Task ShtoStudent(Student student)
        {
            await _dormitoryDBContext.Students.AddAsync(student);
            await _dormitoryDBContext.SaveChangesAsync();

        }
    }
}
