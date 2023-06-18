using AutoMapper;
using Common;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService
{
    public class DepartmentService:IDepartmentService
    {
        IDepartmentRepository repo;
        IMapper mapper;
        public DepartmentService(IDepartmentRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public void Create(DepartmentsDTO departmentsDTO)
        {
            Department department = mapper.Map<Department>(departmentsDTO);
            repo.Create(department);
        }

        public void Delete(int Id)
        {
            repo.Delete(Id);
        }

        public DepartmentsDTO GetById(int Id)
        {
            Department department = repo.GetById(Id);
            DepartmentsDTO departmentsDTO = mapper.Map<DepartmentsDTO>(department);
            return departmentsDTO;
        }

        public List<DepartmentsDTO> GetList()
        {
            List<Department> departments = repo.GetAll();
            List<DepartmentsDTO> departmentsDTO = mapper.Map<List<DepartmentsDTO>>(departments);
            return departmentsDTO;
        }

        public void Update(DepartmentsDTO departmentsDTO)
        {
            Department departments = mapper.Map<Department>(departmentsDTO);
            repo.Update(departments);
        }
    }
}
