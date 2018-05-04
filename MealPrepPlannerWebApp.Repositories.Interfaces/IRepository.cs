using System;
using System.Collections.Generic;
using System.Text;

namespace MealPrepPlannerWebApp.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T entity);
    }
}
