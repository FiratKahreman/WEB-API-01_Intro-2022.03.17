using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// Reflection

namespace _01_Intro.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ValuesController()
        {
            //ValuesController vc = new ValuesController();
            //vc.GetValues();
        }

        // Http Method / Verb
        public IActionResult GetValues()
        {
            List<string> cities = new List<string>() { "İstanbul", "Ankara", "İzmir" };
            return Ok(cities);
        }

        public IActionResult GetCities()
        {
            List<string> cities = new List<string>() { "İstanbul", "Ankara", "İzmir" };
            return Ok(cities);
        }
    }
}