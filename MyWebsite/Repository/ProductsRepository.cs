using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository;

public class ProductsRepository : IProductsRepository
{

    StoreContext Context;
    public ProductsRepository(StoreContext storeContext)
    {
        this.Context = storeContext;
    }


    public void Create(Product obj)
    {
        Context.Products.Add(new Product
        {
            //Id = obj.Id,
            Name = obj.Name,
            Image = obj.Image,
            Price=obj.Price,
            //DepartmentId = obj.DepartmentId,
        });
        Context.SaveChanges();
    }

    public void Delete(int id)
    {
        var products = Context.Products.Where(p => p.Id == id).ToList();
        if (products != null)
        {
            Context.Remove(products);
        }
        Context.SaveChanges();
    }

    public List<Product> GetAll()
    {
        return Context.Products.ToList();//.Include(d=>d.Department).ToList();
    }

    public Product GetById(int id)
    {
        var product = Context.Products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            return product;
        }
        return null;
    }

    public void Update(Product obj)
    {
        var ObjToUp=Context.Products.FirstOrDefault(p => p.Id == obj.Id);
        if(ObjToUp != null)
        {
            ObjToUp.Name = obj.Name;
            ObjToUp.Image = obj.Image;
            ObjToUp.Price = obj.Price;
            //ObjToUp.DepartmentId=obj.DepartmentId;        
        }
        Context.SaveChanges();
    }
}
