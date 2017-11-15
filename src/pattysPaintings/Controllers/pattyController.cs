﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pattysPaintings.Controllers
{
    public class pattyController : Controller
    {
        public ActionResult Detail() //redirect and content result are inherited from ActionResult base class so can use for both returns below
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday) 
            {
                return Redirect("/"); // if it's Tuesday then website is redirected to root of website (currently 404 error)
            }
            return Content("Hello from Patty Controller");
            
        }
    }
}