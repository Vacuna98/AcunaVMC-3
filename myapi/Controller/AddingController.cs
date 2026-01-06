using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myapi.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddingController : ControllerBase
    {
        [HttpGet]
        public string AddingNumber(int num1, int num2)
        {
            return $"The sum of {num1} and {num2} is {num1 + num2}";
        }
        
    }
}
