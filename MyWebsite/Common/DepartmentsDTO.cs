using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common;

public class DepartmentsDTO
{
    public string Name { get; set; }

    public ProductsDTO ProductsInDepartment { get; set; }//AutoMapper -> ProductsInDepartment = $"{item.products}"
}
