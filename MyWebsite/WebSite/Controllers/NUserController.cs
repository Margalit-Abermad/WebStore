using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace WebSite.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class NUserController:BaseController
    {
       
        //    public static int counter = 2;

        //    [HttpPost]
        //    public IHttpActionResult register(user u)
        //    {
        //        user u1 = DB.UserList.FirstOrDefault(d => d.Name == u.Name && d.Password == u.Password && d.KodUser == u.KodUser && d.Email == u.Email);
        //        if (u1 == null)
        //        {
        //            DB.UserList.Add(u);
        //            u.KodUser = counter;
        //            counter++;
        //            return Created("המשתמש נוסף בהצלחה", u);
        //        }
        //        return Conflict();

        //    }
        //    [HttpPost]
        //    public IHttpActionResult login(string name, string password)
        //    {
        //        user u = DB.UserList.FirstOrDefault(d => d.Name == name && d.Password == password);
        //        if (u == null)
        //            return NotFound();
        //        if (u.Password == password)
        //        {

        //            return Created("פרטי המשתמש נכונים", u);

        //        }
        //        return Conflict();
        //    }
        //    [HttpGet]
        //    public user getLocal(string u)
        //    {
        //        user u1 = DB.UserList.FirstOrDefault(d => d.Password == u);
        //        return u1;

        //    }
        }
}
