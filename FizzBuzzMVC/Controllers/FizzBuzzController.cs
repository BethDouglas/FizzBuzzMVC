using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzzMVC.Controllers
{
    public class FizzBuzzController : Controller
    {
        private string ToFizzBuzz(int value)
        {
            var isDivisibleByFive = value % 5 == 0;
            var isDivisibleByThree = value % 3 == 0;

            if (isDivisibleByFive && isDivisibleByThree) return "FizzBuzz";
            if (isDivisibleByFive) return "Buzz";
            if (isDivisibleByThree) return "Fizz";

            //Other options but not as good
            //return value.ToString();
            //return String.Format("{0}", value);
            return $"{value}";
        }

        // GET: FizzBuzz
        public ActionResult Index()
        {
            var model = Enumerable.Range(1, 100).Select(ToFizzBuzz);
            return View(model);
        }
    }
}