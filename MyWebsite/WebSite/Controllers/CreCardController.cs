using Microsoft.AspNetCore.Mvc;
using Repository.Models;

namespace WebSite.Controllers
{
    public class CreCardController:BaseController
    {
        StoreContext context;
        public CreCardController(StoreContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var creditCards = context.CreditCards.ToList();
            return Ok(creditCards);
        }

        [HttpGet("{Id}")]
        //[ActionName("GetProduct")]
        public async Task<IActionResult> GetById([FromRoute] string number)
        {
            var card = context.CreditCards.FirstOrDefault(x => x.Number == number);
            if (card != null)
            {
                return Ok(card);
            }
            return NotFound("Product not found");
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreditCard card)
        {
            //check the user name from KnownUsers, if exist- take his id,
            //else- create new user with this details
            var count = context.CreditCards.Count();
            card.UserId = count + 1;
            await context.CreditCards.AddAsync(card);
            await context.SaveChangesAsync();
            return CreatedAtAction("created", card.Number, card);
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Update([FromRoute] string number, [FromBody] CreditCard card)
        {
            var card1 = context.CreditCards.FirstOrDefault(x => x.Number == number);
            if (card1 != null)
            {
                //product.Id = id;
                //product1.Name = product.Name;
                //product1.Image = product.Image;
                //product1.Price = product.Price;
                //product.Department = product.Department;
                await context.SaveChangesAsync();
                return Ok(card1);
            }
            return NotFound("not found");
        }

        [HttpDelete("{number}")]
        public async Task<IActionResult> Delete([FromRoute] string number)
        {
            var credit1 = context.CreditCards.FirstOrDefault(x => x.Number == number);
            if (credit1 != null)
            {
                context.CreditCards.Remove(credit1);
                await context.SaveChangesAsync();
                return Ok(credit1);
            }
            return NotFound("cant delete, not found");
        }
    }
}
