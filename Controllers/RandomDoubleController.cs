using GetRandomDouble.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace GetRandomDouble.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomDoubleController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            RandomDouble rnd = new RandomDouble();

            string json = JsonSerializer.Serialize<RandomDouble>(rnd); ;
            return json;

        }


    }
}
