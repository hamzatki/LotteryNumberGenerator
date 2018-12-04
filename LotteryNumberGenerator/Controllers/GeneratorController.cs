using LotteryNumberGenerator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LotteryNumberGenerator.Controllers
{
    
    public class GeneratorController : Controller
    {
        private readonly IGenerator _generator;

        public GeneratorController(IGenerator generator)
        {
            _generator = generator;
        }
        // GET: Generator
        public ActionResult Index()
        {
            _generator.GenerateNumbers();


            return View();
        }
    }
}