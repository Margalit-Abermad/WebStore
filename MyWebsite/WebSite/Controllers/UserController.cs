using Microsoft.AspNetCore.Mvc;
using Repository.Models;

namespace WebSite.Controllers
{
    public class UserController:BaseController
    {
        StoreContext context;
        public UserController(StoreContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = context.KnownUsers.ToList();
            return Ok(users);
        }

        [HttpGet("{Id}")]
        //[ActionName("GetProduct")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var user = context.KnownUsers.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound("Product not found");
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] KnownUser user)
        {
            bool isExist=IsExist(user.Email);
            if (isExist == false)
            {
                var count = context.KnownUsers.Count();
                if(user.SavedCreditCard=="")
                    user.SavedCreditCard = "N";
                user.Id = count + 1;
                await context.KnownUsers.AddAsync(user);
                await context.SaveChangesAsync();
                return CreatedAtAction("created", user.Id, user);
            }
            return BadRequest("user exist!");    
           
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] KnownUser user)
        {
            var user1 = context.KnownUsers.FirstOrDefault(x => x.Id == id);
            if (user1 != null)
            {
                //product.Id = id;
                user1.FirstName = user.FirstName;
                user1.LastName = user.LastName;
                user1.Email = user.Email;   
                user1.SavedCreditCard = user.SavedCreditCard;   
                //product.Department = product.Department;
                await context.SaveChangesAsync();
                return Ok(user1);
            }
            return NotFound("not found");
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var user1 = context.KnownUsers.FirstOrDefault(x => x.Id == id);
            if (user1 != null)
            {
                context.KnownUsers.Remove(user1);
                await context.SaveChangesAsync();
                return Ok(user1);
            }
            return NotFound("cant delete, not found");
        }

        public bool IsExist(string email)
        {
            var user = context.KnownUsers.FirstOrDefault(x => x.Email == email);
            if (user != null)
            {
                return true;
            }
            return false;
        }
    }
}
