using System;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public String Products()
        {
            return "List of all products";
        }
        [HttpGet("{id}")]
        public String Product(int id)
        {
            return "1 Product";
        }
    }
}