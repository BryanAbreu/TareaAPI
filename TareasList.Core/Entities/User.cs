using System;
using System.Collections.Generic;



namespace TareasList.Core.Entities
{
    public partial class User
    {
        public User()
        {
            Tareas = new HashSet<Tarea>();
        }

        public int IdUser { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NombreUsuario { get; set; }

        public virtual ICollection<Tarea> Tareas { get; set; }
    }
}
