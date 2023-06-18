using AppService;
using Common;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;

namespace WebSite.Controllers
{
    public class SignUpController:BaseController
    {
        //ISignUpService signUpService;
        //public SignUpControllers(ISignUpService signUpService)
        //{
        //    this.signUpService = signUpService;
        //}
        //[HttpPost]
        //public void Create(SignUpDTO signUpDTO)
        //{
        //    //string url = $"{Request.Scheme}://{Request.Host.Value}/{Request.Path}";
        //    //f.Dofile(url);
        //    if (signUpDTO != null)
        //    {
        //        signUpService.Create(signUpDTO);
        //    }
        //    return;
        //}



        StoreContext context;
        public SignUpController(StoreContext context)
        {
            context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var KnownUsers = context.KnownUsers.ToList();
            return Ok(KnownUsers);
        }

        [HttpGet("{Id}")]
        //[ActionName("GetProduct")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            //var product = contex.cre//KnownUsers.FirstOrDefault(x => x.Id == id);
            var user = context.KnownUsers.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound("user not found");
        }

        [HttpPost]
        public async Task<IActionResult> Create(KnownUser user)
        {
            //KnownUser user1=context.KnownUsers.Last();
            var user1=context.KnownUsers.FirstOrDefault(x => x.FirstName == "Margalit");
            user.Id = user1.Id+1;
            await context.KnownUsers.AddAsync(user);
            await context.SaveChangesAsync();
            return CreatedAtAction("created", user.Id, user);
        }

        //[HttpPost]
        //public async Task<ActionResult<PaymentDetail>> PostPaymentDetail(PaymentDetail paymentDetail)
        //{
        //    _context.PaymentDetails.Add(paymentDetail);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetPaymentDetail", new { id = paymentDetail.PaymentDetailId }, paymentDetail);
        //}

        [HttpPut("{Id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] KnownUser user)
        {
            var newUser = context.KnownUsers.FirstOrDefault(x => x.Id == id);
            if (newUser != null)
            {
               newUser.Email = user.Email;
                newUser.FirstName = user.FirstName;
                newUser.LastName = user.LastName;
                newUser.Password = user.Password;
                await context.SaveChangesAsync();
                return Ok(newUser);
            }
            return NotFound("not found");
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var user = context.KnownUsers.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                context.KnownUsers.Remove(user);
                await context.SaveChangesAsync();
                return Ok(user);
            }
            return NotFound("cant delete, not found");
        }
    }

}

