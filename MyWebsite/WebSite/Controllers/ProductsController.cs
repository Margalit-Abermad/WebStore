using AppService;
using Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;

namespace WebSite.Controllers;

public class ProductsController : BaseController
{
    private readonly StoreContext contex;
    public ProductsController(StoreContext context)
    {
        this.contex = context;
    }
    #region with DAL BLL CTO
    //IProductsService productsService;
    //public ProductsController(IProductsService productsService)
    //{
    //    this.productsService = productsService;
    //}

    //[HttpGet]
    //public ActionResult<List<ProductsDTO>> GetAll()
    //{
    //    var productList = productsService.GetList();
    //    if (productList.Count == 0)
    //    {
    //        return BadRequest();
    //    }
    //    return Ok(productList);
    //}

    //[HttpGet("{Id}")]
    //public ActionResult<ProductsDTO> GetById(int Id)
    //{
    //    var product = productsService.GetById(Id);
    //    if (product == null)
    //    {
    //        return BadRequest();
    //    }
    //    return Ok(product);
    //}

    //[HttpPost] //create a new obj
    //    [Authorize]
    //public ActionResult Create(ProductsDTO productsDTO)
    //{
    //    if (productsDTO != null)
    //    {
    //        productsService.Create(productsDTO);
    //        return Ok();
    //    }
    //    return BadRequest();
    //}


    //[HttpPut] //create a new obj
    //public ActionResult Update(ProductsDTO productsDTO)
    //{
    //    if (productsDTO != null)
    //    {
    //        productsService.Create(productsDTO);
    //        return Ok();
    //    }
    //    return BadRequest();
    //}

    //[HttpDelete]
    //public ActionResult Delete(int Id)
    //{
    //    if (Id != null)
    //    {
    //        productsService.Delete(Id);
    //        return Ok();

    //    }
    //    return BadRequest();
    //}
    #endregion 


    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products= contex.Products.ToList();
        return Ok(products);
    }

    [HttpGet("{Id}")]
    //[ActionName("GetProduct")]
    public async Task<IActionResult> GetById([FromRoute]int id)
    {
        var product = contex.Products.FirstOrDefault(x => x.Id==id);
        if (product != null)
        {
            return Ok(product);
        }
        return NotFound("Product not found");
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody]Product product)
    {
        await contex.Products.AddAsync(product);
        await contex.SaveChangesAsync();
        return CreatedAtAction("created", product.Id, product);
    }

    [HttpPut("{Id}")]
    public async Task<IActionResult> Update([FromRoute] int id,[FromBody] Product product)
    {
        var product1 = contex.Products.FirstOrDefault(x => x.Id == id);
        if(product1 != null)
        {
            //product.Id = id;
            product1.Name = product.Name;
            product1.Image = product.Image;
            product1.Price = product.Price;
            //product.Department = product.Department;
            await contex.SaveChangesAsync();    
            return Ok(product1);
        }
        return NotFound("not found");
    }

    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var product1 = contex.Products.FirstOrDefault(x => x.Id == id);
        if (product1 != null)
        {
           contex.Products.Remove(product1);
            await contex.SaveChangesAsync();
            return Ok(product1);
        }
        return NotFound("cant delete, not found");
    }
}
