using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareasList.Core.Entities;
using TareasList.Core.Interfaces;
using TareasList.Infrastructure.Data;

namespace TareasList.Core.Repositories
{
   public class TareaRespository : ITareaRepository
    {
        private readonly TareaListContext _context;

            public TareaRespository (TareaListContext context)
            {
            _context = context;
            }
        public async Task<IEnumerable<Tarea>> GetTareas()
        {
            var List = await _context.Tareas.ToListAsync();
            return List;
        }

        
    }
}
