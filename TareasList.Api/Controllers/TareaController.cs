using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TareasList.Core.Interfaces;
using TareasList.Core.Repositories;

namespace TareasList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        private readonly ITareaRepository _tareaRepository;

        public TareaController(ITareaRepository tareaRepository)
        {
            _tareaRepository = tareaRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetTareas()
        {
            var tareas = await _tareaRepository.GetTareas();

            return Ok(tareas);
        }
    }
}
