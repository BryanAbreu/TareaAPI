<<<<<<< HEAD
﻿using System.Collections.Generic;
=======
﻿using System;
using System.Collections.Generic;
>>>>>>> 53a6e40fe9b30f21ff077e85c964abec29e460a2



namespace TareasList.Core.Entities
{
    public partial class User
    {
        public User()
        {
<<<<<<< HEAD
            Works = new List<Work>();
        }

        public int IdUser { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<Work> Works { get; set; }
=======
            Tareas = new HashSet<Tarea>();
        }

        public int IdUser { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NombreUsuario { get; set; }

        public virtual ICollection<Tarea> Tareas { get; set; }
>>>>>>> 53a6e40fe9b30f21ff077e85c964abec29e460a2
    }
}
