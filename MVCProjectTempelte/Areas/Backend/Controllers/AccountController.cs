using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCProjectTempelte.Areas.Backend.Controllers
{
    public class AccountController : ApiController
    {
        [HttpPost]
        public string Login(string model)
        {
            return "123";
        }
    }
}
