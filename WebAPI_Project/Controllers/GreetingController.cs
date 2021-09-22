using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class GreetingController : ApiController
    {
        public string Get(int id) // after public, need a string not a int bc the output needs a string, inside the () it's the input
        {
            string greeting = "Greeting to " + id + " people!";
            return greeting;
            //http://localhost:65476/api/Greeting/3
            //http://localhost:65476/api/Greeting/6
            //http://localhost:65476/api/Greeting/0
        }

    }
}
