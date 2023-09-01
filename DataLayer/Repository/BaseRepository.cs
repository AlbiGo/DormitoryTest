using DataLayer.DBContext;
using DataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DormitoryDBContext _dormitoryDBContext;

        public BaseRepository()
        {
            _dormitoryDBContext = new DormitoryDBContext();
        }

        public async Task<List<T>> GetAll()
        {
            var entities = await _dormitoryDBContext.Set<T>().ToListAsync();
            return entities;
        }

        public async Task AddEntity(T entity)
        {
            await _dormitoryDBContext.Set<T>().AddAsync(entity);
        }

    }
}
