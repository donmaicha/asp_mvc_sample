using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sample.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        //public string Welcome()
        //{
        //    return "This is the Welcome action method";
        //}

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web
        // https://localhost:5001/HelloWorld/welcome?name=donmaicha&numTimes=4でアクセスすると...
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, Numtimes is: {numTimes}");
        }

        public string Come()
        {
            return "こんなこと";
        }
    }
}
