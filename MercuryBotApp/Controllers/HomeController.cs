﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MercuryBotApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Это мой телеграм Бот!";
        }        
    }
}