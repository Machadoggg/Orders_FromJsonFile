using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Orders_FromJsonFile.Models;

namespace Orders_FromJsonFile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {


        [HttpGet("sum")]
        public IActionResult GetOrderSums()
        {
            var filePath = "JsonFiles/OrdersFile.json";
            var jsonData = System.IO.File.ReadAllText(filePath);
            var customers = JsonConvert.DeserializeObject<List<Customer>>(jsonData);

            var orderSums = customers.Select(c => new
            {
                CustomerId = c.Id,
                OrderSums = c.Orders.Select(o => new
                {
                    OrderId = o.Id,
                    Sum = o.Details.Sum(d => d.Quantity)
                })
            });

            return Ok(orderSums);
        }
    }
}
