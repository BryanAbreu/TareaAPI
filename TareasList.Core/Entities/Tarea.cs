using System;
using System.Collections.Generic;



namespace TareasList.Core.Entities
{
    public partial class Tarea
    {
        public int TareaId { get; set; }
        public int UserId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        public virtual User User { get; set; }
    }
}
