
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ <- bisheriger Link

        public IActionResult Index(string answer)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //Login Token
        public ActionResult ProcessForm(string login, string register)
        {
            if(!string.IsNullOrEmpty(login)) //TODO if Login is pressed
            {

            }
            if (!string.IsNullOrEmpty(register))//TODO if Register is pressed
            {

            }
            return View("Index");
        }

        
    }
}
