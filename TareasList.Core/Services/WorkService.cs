using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareasList.Core.Entities;
using TareasList.Core.Enumerations;
using TareasList.Core.Exeptions;
using TareasList.Core.Interfaces;

namespace TareasList.Core.Services
{
    public class WorkService : IWorkService
    {

        private readonly IWorkRepository _workRepository;
        public WorkService(IWorkRepository workRepository)
        {
            _workRepository = workRepository;
        }

        public async Task<IEnumerable<Work>> GetWorks()
        {
            return await _workRepository.GetWorks();
        }

        public async Task<Work> GetWork(int id) 
        {
            return await _workRepository.GetWork(id) ?? throw new ErrorException("Work Not Found", 404);
        }

       

        public async Task InsertWork(Work work)
        {
            work.WorkID = 0;
            var works = await GetWorks();
            if(works.Where(x=>x.Title.ToLower() == work.Title.ToLower()).Any())
            {
                throw new ErrorException("Work Already exists", 400);
            }

            var statusType = Enum.GetNames(typeof(StatusType));
            var result = work.Status.ToLower().Contains(statusType[0].ToLower()) || work.Status.ToLower().Contains(statusType[1].ToLower()) || work.Status.ToLower().Contains(statusType[2].ToLower());
            if(!result)
            {
                throw new ErrorException("Status Invalid", 400);
            }

            await _workRepository.InsertWork(work);
        }

    }
}
