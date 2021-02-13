using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareasList.Core.DTOS;
using TareasList.Core.Entities;
using TareasList.Core.Interfaces;

namespace TareasList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorksController : ControllerBase
    {
        private readonly IWorkService _workService;
        private readonly IMapper _mapper;

        public WorksController(IWorkService workService, IMapper mapper)
        {
            _workService = workService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkDTO>>> Get()
        {
            var works = await _workService.GetWorks();
            var worksDTO = _mapper.Map<IEnumerable<WorkDTO>>(works);

            return Ok(worksDTO);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var work = await _workService.GetWork(id);
            var workDTO = _mapper.Map<WorkDTO>(work);
            return Ok(workDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Post(WorkDTO workDTO )
        {
            var work = _mapper.Map<Work>(workDTO);

            await _workService.InsertWork(work);

            return Created(nameof(Get), new { id = work.WorkID, workDTO });
        }

    }
}
