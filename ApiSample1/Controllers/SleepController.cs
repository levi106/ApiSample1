using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiSample1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SleepController : ControllerBase
    {
        [HttpGet]
        public async Task<int> Get([FromQuery]int msec)
        {
            await Task.Delay(msec);
            return msec;
        }
    }
}
