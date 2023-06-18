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
    public class ProductsService:IProductsService
    {
        IProductsRepository repo;
        IMapper mapper;
        public ProductsService(IProductsRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public void Create(ProductsDTO productsDTO)
        {
            Product product = mapper.Map<Product>(productsDTO);
            repo.Create(product);
        }

        public void Delete(int Id)
        {
            repo.Delete(Id);
        }

        public ProductsDTO GetById(int Id)
        {
            Product product = repo.GetById(Id);
            ProductsDTO productsDTO = mapper.Map<ProductsDTO>(product);
            return productsDTO;
        }

        public List<ProductsDTO> GetList()
        {
            //List<Product> products = repo.GetAll();
            //List<ProductsDTO> productsDTO = mapper.Map<List<ProductsDTO>>(products);
            List<ProductsDTO> productDTO = new List<ProductsDTO>();
            foreach (var item in repo.GetAll())
            {
                productDTO.Add(new ProductsDTO
                {
                    //Id = item.Id,
                    Name = item.Name,
                    Image = item.Image,
                    Price = (float)item.Price
                });
            }
            return productDTO;
        }

        public void Update(ProductsDTO productDTO)
        {
            Product product = mapper.Map<Product>(productDTO);
            repo.Update(product);
        }
    }
}
