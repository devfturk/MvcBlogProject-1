using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<TEntity>
    {
        List<TEntity> GetAll();
        int Insert(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
        TEntity GetByID(int id);

    }
}
