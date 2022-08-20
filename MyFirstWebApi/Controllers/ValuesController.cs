using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApi.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private string[] products =["laptop", "shoe", "bag,"};


     [HttpGet]
     [Route("get-all")]
     
    public IActionResult GetAll()
    {

        return Ok(products);
    }
    }
}
