using System;
using System.Collections.Generic;
using System.Text;

namespace TareasList.Core.DTOS
{
    public class UserDTO
    {
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
    }
}
