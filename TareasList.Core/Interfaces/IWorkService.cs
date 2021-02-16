using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TareasList.Core.Entities;

namespace TareasList.Core.Interfaces
{
    public interface IWorkService
    {
<<<<<<< HEAD:TareasList.Core/Interfaces/ITareaRepository.cs
        Task<IEnumerable<Tareas>>GetTareas();
=======
        Task<IEnumerable<Work>> GetWorks();

        Task<Work> GetWork(int id);

        Task InsertWork(Work work);
        
>>>>>>> master:TareasList.Core/Interfaces/IWorkService.cs
    }
}
