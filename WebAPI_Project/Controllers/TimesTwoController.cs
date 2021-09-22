using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class TimesTwoController : ApiController
    {
        public int Get(int id)
        {
            // declaring a variable called product
            int product = id * 2;
            return product;

        }

    }
}
