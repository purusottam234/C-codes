using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        public String Index()
        {
            return "This is the default action";
        }

        public String Welcome(string name, int numtimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is : {numtimes}");

        }
    }
}
