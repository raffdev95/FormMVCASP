using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class WebConfig
    {

        public static string DwMail()
        {
            return ConfigurationManager.AppSettings["DwMail"];
        }
    
    }
}