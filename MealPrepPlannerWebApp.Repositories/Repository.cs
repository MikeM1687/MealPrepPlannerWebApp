using MealPrepPlannerWebApp.Entities;
using MealPrepPlannerWebApp.Entities.Models;
using MealPrepPlannerWebApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

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

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }
    }
}
