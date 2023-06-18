using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService
{
    public interface IProductsService
    {
        List<ProductsDTO> GetList();

        ProductsDTO GetById(int Id);

        void Delete(int Id);

        void Update(ProductsDTO productsDTO);

        void Create(ProductsDTO productsDTO);
    }
}
