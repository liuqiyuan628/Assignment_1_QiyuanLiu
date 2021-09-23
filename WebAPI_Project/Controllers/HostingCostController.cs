using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class HostingCostController : ApiController
    {

        public string Get(int id)
        {
            int fn = id / 14;
            //

            /*
            DateTime startDate = DateTime.Now;
            TimeSpan fortnight = TimeSpan.FromDays(14);

            for (int i = 0; i < 6; i++)
            {
                startDate += fortnight;
                Console.WriteLine($"Date for fortnight {i}: {startDate:D}");
            } // got this on https://stackoverflow.com/questions/35377602/calculate-14-days-sequence-order
            */
            // need more help to complete this question.
        }
    }
}
