using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository;

public class DepartmentRepository : IDepartmentRepository
{

    StoreContext context;

    public DepartmentRepository(StoreContext context)
    {
        this.context = context;
    }

    public void Create(Department obj)
    {
        context.Departments.Add(new Department
        {
            Name = obj.Name,  
        });
    }

    public void Delete(int id)
    {
        var department = context.Departments.FirstOrDefault(x => x.Id == id);
        if (department != null)
        {
            context.Remove(department);
        }
    }

    public List<Department> GetAll()
    {
        return context.Departments.Include(p=>p.Products).ToList();
    }

    public Department GetById(int id)
    {
        var department=context.Departments.FirstOrDefault(x => x.Id == id);
        if(department != null)
        {
            return department;
        }
        return null;
    }

    public void Update(Department obj)
    {
        var department= context.Departments.FirstOrDefault(x => x.Id == obj.Id);
        if( department != null)
        {
            department.Name = obj.Name;
        }
    }
}
