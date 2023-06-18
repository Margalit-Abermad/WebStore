using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using System.Web.Http;

namespace WebSite.Controllers
{
    public class CartController:BaseController
    {
        StoreContext context;
        public CartController(StoreContext context)
        {
            this.context = context;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //    var products = contex.Products.ToList();
        //    return Ok(products);
        //}

        //[HttpGet("{Id}")]
        ////[ActionName("GetProduct")]
        //public async Task<IActionResult> GetById([FromRoute] int id)
        //{
        //    var product = contex.Products.FirstOrDefault(x => x.Id == id);
        //    if (product != null)
        //    {
        //        return Ok(product);
        //    }
        //    return NotFound("Product not found");
        //}

        //[System.Web.Http.HttpPost]
        //public async Task<IActionResult> Create([FromBody] Product product)
        //{
        //    await contex.Products.AddAsync(product);
        //    await contex.SaveChangesAsync();
        //    return CreatedAtAction("created", product.Id, product);
        //}

        //[HttpPut("{Id}")]
        //public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Product product)
        //{
        //    var product1 = contex.Products.FirstOrDefault(x => x.Id == id);
        //    if (product1 != null)
        //    {
        //        //product.Id = id;
        //        product1.Name = product.Name;
        //        product1.Image = product.Image;
        //        product1.Price = product.Price;
        //        //product.Department = product.Department;
        //        await contex.SaveChangesAsync();
        //        return Ok(product1);
        //    }
        //    return NotFound("not found");
        //}

        //[HttpDelete("{Id}")]
        //public async Task<IActionResult> Delete([FromRoute] int id)
        //{
        //    var product1 = contex.Products.FirstOrDefault(x => x.Id == id);
        //    if (product1 != null)
        //    {
        //        contex.Products.Remove(product1);
        //        await contex.SaveChangesAsync();
        //        return Ok(product1);
        //    }
        //    return NotFound("cant delete, not found");
        //}
    }
}
