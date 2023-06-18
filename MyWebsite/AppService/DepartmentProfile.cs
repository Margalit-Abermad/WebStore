using AutoMapper;
using Common;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService
{
    public class DepartmentProfile:Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department, DepartmentsDTO>()
            .ForMember(d => d.ProductsInDepartment, Dto =>
              Dto.MapFrom(d => d.Products));
        }
    }
}
