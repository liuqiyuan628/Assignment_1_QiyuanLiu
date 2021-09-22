using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class NumberMachineController : ApiController
    {
        public int Get(int id)
        {
            int NumberMachine = (id * 2 + 10) / 3 - 20;
            return NumberMachine;
            //http://localhost:65476/api/NumberMachine/10
            //http://localhost:65476/api/NumberMachine/-5
            //http://localhost:65476/api/NumberMachine/30
        }

    }
}
