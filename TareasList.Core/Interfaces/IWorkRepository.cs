using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TareasList.Core.Entities;

namespace TareasList.Core.Interfaces
{
    public interface IWorkRepository
    {
        Task<IEnumerable<Work>> GetWorks();

        Task<Work> GetWork(int id);

        Task InsertWork(Work work);

        Task<bool> UpdateWork(Work work);

        Task<bool> DeleteWork(int id);
    }
} 
