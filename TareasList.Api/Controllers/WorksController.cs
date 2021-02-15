using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareasList.Api.Responses;
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
        private readonly IWorkRepository _workRepository;
        
        public WorksController(IWorkService workService, IMapper mapper, IWorkRepository workRepository)
        {
            _workService = workService;
            _mapper = mapper;
            _workRepository = workRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkDTO>>> Get()
        {
            var works = await _workService.GetWorks();
            var worksDTO = _mapper.Map<IEnumerable<WorkDTO>>(works);
            var response = new ApiResponse<IEnumerable<WorkDTO>>(worksDTO);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var work = await _workService.GetWork(id);
            var workDTO = _mapper.Map<WorkDTO>(work);
            var response = new ApiResponse<WorkDTO>(workDTO);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(WorkDTO workDTO)
        {
            var work = _mapper.Map<Work>(workDTO);

            await _workService.InsertWork(work);
          
            workDTO = _mapper.Map<WorkDTO>(work);

            var response = new ApiResponse<WorkDTO>(workDTO);

            return Ok (response);
        }

        [HttpPut]
        public async Task<IActionResult>Put(int id ,WorkDTO workDTO)
        {
            var work = _mapper.Map<Work>(workDTO);
            work.WorkID = id;

          var result=  await _workRepository.UpdateWork(work);
            var response = new ApiResponse<bool>(result);
           

            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delet (int id)
        {
            
          var result= await _workRepository.DeleteWork(id);
            var response = new ApiResponse<bool>(result);

            return Ok(result);
        }

    }
}
