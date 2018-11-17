using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace E_Market.Controllers
{
    public class E_MarketController : Controller
    {
        // Get: E_Mareket /Random
    
    public string Index()
        {
            return "This iS MY Default Action..xD";
        }

        public string Welcome()
        {
            return "Hello";
        }

    }

}
