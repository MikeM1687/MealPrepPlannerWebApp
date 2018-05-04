using MealPrepPlannerWebApp.Entities;
using MealPrepPlannerWebApp.Entities.Models;
using MealPrepPlannerWebApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MealPrepPlannerWebApp.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IBaseEntity
    {
        protected readonly DbContext _context;
        protected DbSet<T> _dbSet;

        public Repository(MealPrepPlannerWebApp_DatabaseContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);

            Save();
        }

        public T Get(int id)
        {
            return _dbSet.SingleOrDefault(s => s.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }

        private void Save()
        {
            _context.SaveChanges();
        }
    }
}
