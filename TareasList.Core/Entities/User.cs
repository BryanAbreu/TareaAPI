using System;
using System.Collections.Generic;



namespace TareasList.Core.Entities
{
    public partial class User
    {
        public User()
        {
            Works = new List<Work>();
        }

        public int IdUser { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<Work> Works { get; set; }
    }
}
