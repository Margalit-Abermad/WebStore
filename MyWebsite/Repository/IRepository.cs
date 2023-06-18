using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository;

public interface IRepository<T>
{
   List<T> GetAll();
   T GetById(int id);
   void Update(T obj);
   void Delete(int id);
   void Create(T obj);

}
