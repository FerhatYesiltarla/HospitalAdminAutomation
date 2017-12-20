using DAL.ORM.Entity;
using System.Web.Http;
using WebApi.Service;

namespace WebApi.Controllers
{
    public class UserController : ApiController
    {
        [HttpPost]
        public IHttpActionResult UserGet(int Id)
        {
            User user = DataService.Service.UserService.SelectFirst(x => x.Id == Id);
            return Json(user);
        }

        [HttpPost]
        public IHttpActionResult Update(User newUserData)
        {
            DataService.Service.UserService.Update(newUserData);
            return Ok();
        }
    }
}
