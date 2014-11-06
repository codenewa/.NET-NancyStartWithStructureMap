using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace NancyStart.Modules
{
    public class CarModule: NancyModule
    {
        public CarModule()
        {
            Get["/"] = _ => "Hello World";
        }
    }
}