using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService
{
    public interface IDepartmentService
    {
        List<DepartmentsDTO> GetList();

        DepartmentsDTO GetById(int Id);

        void Delete(int Id);

        void Update(DepartmentsDTO departmentsDTO);

        void Create(DepartmentsDTO departmentsDTO);
    }
}
