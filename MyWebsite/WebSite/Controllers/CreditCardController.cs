using Microsoft.AspNetCore.Mvc;
using Repository.Models;

namespace WebSite.Controllers
{
    public class CreditCardController:BaseController
    {
        StoreContext context;
        public CreditCardController(StoreContext context)
        {
            context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var creditCards=context.CreditCards.ToList();
            return Ok(creditCards);
        }

        [HttpGet("{Id}")]
        //[ActionName("GetProduct")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            //var product = contex.cre//CreditCards.FirstOrDefault(x => x.Id == id);
            var card=context.CreditCards.FirstOrDefault(x=> x.UserId==id);
            if (card != null)
            {
                return Ok(card);
            }
            return NotFound("card not found");
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreditCard card)
        {
            //await context.CreditCards.AddAsync(card);
            await context.CreditCards.AddAsync(card);
            await context.SaveChangesAsync();
            return CreatedAtAction("created", card.UserId, card);
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] CreditCard card)
        {
            var newCard = context.CreditCards.FirstOrDefault(x => x.UserId == id);
            if (newCard != null)
            {
                newCard.Number = card.Number;
                newCard.Cvv = card.Cvv;
                newCard.Validity = card.Validity;
                //product.Department = product.Department;
                await context.SaveChangesAsync();
                return Ok(newCard);
            }
            return NotFound("not found");
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var card1 = context.CreditCards.FirstOrDefault(x => x.UserId == id);
            if (card1 != null)
            {
                context.CreditCards.Remove(card1);
                await context.SaveChangesAsync();
                return Ok(card1);
            }
            return NotFound("cant delete, not found");
        }
    }
}
