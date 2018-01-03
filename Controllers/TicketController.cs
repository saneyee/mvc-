using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mvc.Controllers
{
    public class TicketController : Controller
    {
        [HttpGet("/tix")]
        public IActionResult Index()

        {
            var s = new Seat() { Location = "Orchestra", Price = 300 };


            return View(s);
        }

	    public string Index2()
        {
            return "Hello from Tickets!";
         }

    }
}
