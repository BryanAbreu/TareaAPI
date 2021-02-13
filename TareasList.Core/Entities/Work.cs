using TareasList.Core.Enumerations;

namespace TareasList.Core.Entities
{
    public partial class Work
    {
        public int WorkID { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public virtual User User { get; set; }
    }
}
