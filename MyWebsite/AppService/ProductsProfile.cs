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
    internal class ProductsProfile:Profile
    {
        public ProductsProfile()
        {
            //CreateMap<Product, ProductsDTO>()
            //.ForMember(p => p.Department, Dto => Dto
            //.MapFrom(p => $"{p.Department.Name}")
            //);
        }
    }
}
