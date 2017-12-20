using BLL.Service;
using DAL.ORM.Context;
using DAL.ORM.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Models;
using WebApi.Service;

namespace WebApi.Controllers
{
    [EnableCors("*","*","*")]
    public class AccountController : ApiController
    {
        [HttpPost]
        public IHttpActionResult SignIn(SignInModel credentials)
        {           
            if (DataService.Service.UserService.CheckCredentials(credentials.Email, credentials.Password))
            {
                return Ok();                
            }
            else
            {
                return BadRequest();
            }
        }
        
        [HttpPost]
        public IHttpActionResult SignUp(User userData)
        {
            if (DataService.Service.UserService.ExistingUser(userData.Email))
            {
                DataService.Service.UserService.Insert(userData);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }      
    }
}
