using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class SquareController : ApiController
    {
        public int Get(int id)
        {
            int square = id * id;
            return square;
            // http://localhost:65476/api/Square/2
            // http://localhost:65476/api/Square/-2
            //http://localhost:65476/api/Square/10
        }
    }
}
