using TareasList.Core.Enumerations;

namespace TareasList.Core.DTOS
{
   public class WorkDTO
    {
        public int WorkID { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
