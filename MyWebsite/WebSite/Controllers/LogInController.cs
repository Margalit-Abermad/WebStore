using Microsoft.AspNetCore.Mvc;
using Repository.Models;

namespace WebSite.Controllers
{
    public class LogInController:BaseController
    {
        StoreContext context;
        public LogInController(StoreContext context)
        {
            this.context = context;
        }

        //[HttpPost]
        //public async Task<IActionResult> Create([FromBody] KnownUser user)
        //{ 
        //        string email = user.Email;
        //        string password = user.Password;
        //        KnownUser user1 = context.KnownUsers.FirstOrDefault(e => e.Email == email && e.Password == password);
        //        if (user1 == null)
        //            return BadRequest();
        //        if (user1.Email == email)
        //        {
        //            return CreatedAtAction("הסיסמא שהוקשה שגויה", user1);

        //        }
        //        //return CreatedAtAction("created", user.Id, user);
        //    return Ok();
        //}

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] KnownUser user)
        {
            string email = user.Email;
            string password = user.Password;
            KnownUser user1 = context.KnownUsers.FirstOrDefault(e => e.Email == email);
            if (user1 == null)
                return BadRequest("user not exist");
            else if (user1.Password != password)
            {
                return BadRequest("הסיסמא שהוקשה שגויה");

            }
            // return CreatedAtAction("created", user.Id, user);
            return Ok(user1);
        }

        //[HttpGet("{Id}")]
        ////[ActionName("GetProduct")]
        //public async Task<IActionResult> GetById(string email)
        //{
        //    var user = context.KnownUsers.FirstOrDefault(x => x.Email == email);
        //    if (user != null)
        //    {
        //        return Ok(user);
        //    }
        //    return NotFound("user not found");
        //}


        [HttpGet("{email}")]
        //[ActionName("GetProduct")]
        public async Task<IActionResult> GetById([FromRoute] string email)
        {
            var user = context.KnownUsers.FirstOrDefault(x => x.Email == email);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound("user not found");
        }
    }
}
