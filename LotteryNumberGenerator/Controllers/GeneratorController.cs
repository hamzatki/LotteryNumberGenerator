using LotteryNumberGenerator.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LotteryNumberGenerator.Controllers
{
    
    public class GeneratorController : Controller
    {
        private readonly IGenerator _generator;

        // could have use Dependency Injection to over avoid using parameterless constructor
        //public GeneratorController()
        //{

        //}

        public GeneratorController(IGenerator generator)
        {
            _generator = generator;
        }
        // GET: Generator
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult RandomNumbers()
        {
            var total = int.Parse(ConfigurationManager.AppSettings["totalBalls"]);

            // wanted to use DI to inject the method through interface, the main random functionality would have been in a service folder which would hav been easier to re-use somwwhere else.

            var randomBalls = _generator.GenerateNumbers(total); 

            //Random r = new Random();

            //var randomBalls = Enumerable.Range(1, 49).OrderBy(x => r.Next()).Take(total).ToList();

            var sortedBalls = randomBalls.OrderBy(i => i).ToList();

            return View(sortedBalls);

        }
    }
}