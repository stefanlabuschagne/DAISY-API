using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAISY_API.Models;
using DAISY_API.Models.DataModel;

namespace DAISY_API.Controllers
{

    // This updates the Daisy Database with the Data passed
    // Using a SP
    public class SPController : ApiController
    {

        public IHttpActionResult AddCase(DaisyCaseNew CreateCaseNew)
        {

            // Calls The SP Here              

            //DAISYEntities DE = new DAISYEntities();
            //DE.CreateCaseWrite(
            //    CreateCaseNew.Name.ToString(), 
            //    CreateCaseNew.Surname.ToString(),
            //    CreateCaseNew.Age.ToString(),
            //    CreateCaseNew.Sex.ToString()
            //    );
            //DE.SaveChanges();

            return Ok();

        }

    }
}
