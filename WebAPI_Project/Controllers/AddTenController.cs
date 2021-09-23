using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class AddTenController : ApiController
    {
        public int Get(int id)
        {
            int AddTen = id + 10;
            return AddTen;
            // test github test push to github //
            // another test here
           
          
        }

    }
}
