using AgendarConsultas.Data;
using Microsoft.AspNetCore.Mvc;

namespace AgendarConsultas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController(ScheduleContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetClient()
        {

            return default;
        }

    }
}
