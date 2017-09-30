﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    { 
        //
        // GET: /Helloworld/

        public string Index()
        {
            return "this is my default action...";
        }

        //
        // GET: /Welcome/

        public string Welcome(string name, int numTimes=1)
        {
            return System.Text.Encodings.Web.HtmlEncoder.Default.Encode($"Hello {name}, numtimes is {numTimes}");
        }
    }
}
