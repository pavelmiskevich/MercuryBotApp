using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MercuryBotApp.Models
{
    public static class AppSettings
    {
        //https://www.youtube.com/watch?v=iOFQ8CyF6wk        
        public static string Url { get; set; } = "https://e53f4f222267.ngrok.io/{0}"; //http://localhost:40739/{0}; //в ролике на Azure

        public static string Name { get; set; } = "mpsmercury_bot"; //"";

        public static string Key { get; set; } = ConfigurationManager.AppSettings.Get("ApiKey");
    }
} 