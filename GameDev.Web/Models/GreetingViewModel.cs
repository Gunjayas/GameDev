using GameDev.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameDev.Web.Models
{
    public class GreetingViewModel
    {
        public IEnumerable<Company> Companies { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
    }
}