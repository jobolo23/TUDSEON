using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tudseon.Controllers.API
{
    [Route("API/[controller]")]
    public class LoginController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Test", "GAAAAAH" };
        }
    }
}
