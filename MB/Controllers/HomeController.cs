﻿namespace MB.Controllers
{
    using System;

    using Microsoft.AspNetCore.Mvc;

    using Base;

    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult PostSubscribe(string email)
        {
            throw new NotImplementedException();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
