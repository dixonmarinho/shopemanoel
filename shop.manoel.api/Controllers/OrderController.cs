using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using shop.manoel.shared.Interfaces;
using shop.manoel.shared.Models.Request;

namespace shop.manoel.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IServiceOrder service;

        public OrderController(IServiceOrder service)
        {
            this.service = service;
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OrderRequest pedidos)
        {
            var response = await service.CalcOrderBoxAsync(pedidos);
            return Ok(response);
        }
    }
}
