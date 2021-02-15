using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TareasList.Core.Entities;

namespace TareasList.Core.Interfaces
{
    public interface IWorkService
    {
        Task<IEnumerable<Work>> GetWorks();

        Task<Work> GetWork(int id);

        Task InsertWork(Work work);
        
    }
}
