using System.Collections.Generic;

namespace Cibertec_Examen_Final.DataAccess
{
    public interface IDataAccess<T>
    {
        List<T> GetList();
        int Add(T entity);
        int Delete(T entity);
        int Update(T entity);
    }
}
