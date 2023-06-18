using Repository.Models;
//using System.Web.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebSite.Controllers
{
    public class SignInController:BaseController
    {
        StoreContext context;
        public SignInController(StoreContext context)
        {
            this.context = context;
        }

        //[HttpPost]
        //public IHttpActionResult register(KnownUser user)
        //{
        //    //user u1 = DB.UserList.FirstOrDefault(d => d.Name == u.Name && d.Password == u.Password && d.KodUser == u.KodUser && d.Email == u.Email);
        //    KnownUser user1=context.KnownUsers.FirstOrDefault(e=>e.Email==user.Email);  
        //    if (user1 == null)
        //    {
        //        int count=context.KnownUsers.Count();
        //        user.Id=count;
        //        context.KnownUsers.AddAsync(user);
        //        //u.KodUser = counter;
        //        //counter++;
        //        return (IHttpActionResult)Created("התווסף בהצלחה", user);
        //    }
        //    return (IHttpActionResult)Conflict();
        //}


        //[HttpPost]
        //public IHttpActionResult login([FromBody] string email, string password)
        //{
        //    KnownUser user1 = context.KnownUsers.FirstOrDefault(e => e.Email == email&&e.Password==password);
        //    if (user1 == null)
        //        return (IHttpActionResult)NotFound();
        //    if (user1.Email == email)
        //    {
        //        return (IHttpActionResult)Created("הסיסמא שהוקשה שגויה", user1);

        //    }
        //    return (IHttpActionResult)Conflict();
        //}
        //[HttpPost]
        //public IHttpActionResult login([FromBody] KnownUser user)
        //{
        //    string email = user.Email;
        //    string password = user.Password;    
        //    KnownUser user1 = context.KnownUsers.FirstOrDefault(e => e.Email == email && e.Password == password);
        //    if (user1 == null)
        //        return (IHttpActionResult)NotFound();
        //    if (user1.Email == email)
        //    {
        //        return (IHttpActionResult)Created("הסיסמא שהוקשה שגויה", user1);

        //    }
        //    return (IHttpActionResult)Conflict();
        //}


        [HttpPost]
        public async Task<IActionResult> Create([FromBody]KnownUser user)
        {
            string email = user.Email;
            string password = user.Password;
            KnownUser user1 = context.KnownUsers.FirstOrDefault(e => e.Email == email && e.Password == password);
            if (user1 == null)
                return NotFound();
            if (user1.Email == email)
            {
                return Created("הסיסמא שהוקשה שגויה", user1);

            }
            return Conflict();
        }



        //[HttpPost]
        //public async Task<IActionResult> Create([FromBody] KnownUser user)
        //{
        //    bool isExist = IsExist(user.Email);
        //    if (isExist == false)
        //    {
        //        var count = context.KnownUsers.Count();
        //        if (user.SavedCreditCard == "")
        //            user.SavedCreditCard = "N";
        //        user.Id = count + 1;
        //        await context.KnownUsers.AddAsync(user);
        //        await context.SaveChangesAsync();
        //        return CreatedAtAction("created", user.Id, user);
        //    }
        //    return BadRequest("user exist!");

        //}

        //[HttpGet]
        //public async Task<IHttpActionResult> GetAll()
        //{
        //    var KnownUsers = context.KnownUsers.ToList();
        //    return (IHttpActionResult)Ok(KnownUsers);//Ok(KnownUsers);
        //}
    }
}
