using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace XUnitTestProject1
{
    public class HomeController: Controller
    {
		[Route("/")]
		public IActionResult Index()
		{
			return View();
		}
    }
}
