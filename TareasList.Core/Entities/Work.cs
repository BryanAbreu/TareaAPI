<<<<<<< HEAD
﻿

namespace TareasList.Core.Entities
{
    public partial class Work 
=======
﻿namespace TareasList.Core.Entities
{
    public partial class Work
>>>>>>> f0694bffa52d050b0edc9f338752aa7abac3884b
    {
        public int WorkID { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public virtual User User { get; set; }
    }
}
