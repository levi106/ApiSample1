using ApiSample1.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemoryController : Controller
    {
        private IMemoryService Service { get; }

        public MemoryController(IMemoryService service)
        {
            Service = service;
        }

        [HttpGet]
        public int Get([FromQuery] int? size)
        {
            if (size == null)
            {
                return Service.TotalSize;
            }
            else
            {
                return Service.Allocate(size.Value * 1024 * 1024);
            }
        }
    }
}
