using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class TestController : ApiController
    {
        // write more comments  
        // curl -d "" localhost:52387/api/test  this is for post method using Command Prompt
        // public int Get(){}
        // http://localhost:65476/api/test
        public int Get/*here, which is the Get is the name of method */(/*here is for the inputs*/) 
        {
            return 5; // always include the ";"
        }
    }
}
