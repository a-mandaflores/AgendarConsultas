using AgendarConsultas.Data;
using Microsoft.AspNetCore.Mvc;

namespace AgendarConsultas.Controllers
{
    public class ClientController(ScheduleContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetClient()
        {
            return default;
        }

    }
}
