using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TareasList.Core.Entities;

namespace TareasList.Core.Interfaces
{
    public interface ITareaRepository
    {
        Task<IEnumerable<Tarea>> GetTareas();
    }
}
