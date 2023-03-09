using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context context = new Context();
        DbSet<T> _object;

        public Repository()
        {
            _object = context.Set<T>();
        }

        public int Delete(T entity)
        {
            _object.Remove(entity);
            return context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetByID(int id)
        {
            return _object.Find(id);
        }

        public int Insert(T entity)
        {
            _object.Add(entity);
            return context.SaveChanges();
        }

        public int Update(T entity)
        {

            return context.SaveChanges();
        }
    }
}
