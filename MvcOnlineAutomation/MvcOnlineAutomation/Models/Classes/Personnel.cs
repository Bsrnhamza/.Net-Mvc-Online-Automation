using System.ComponentModel.DataAnnotations;

namespace MvcOnlineAutomation.Models.Classes
{
    public class Personnel
    {
        [Key]
        public int PersonnelId { get; set; }
        public string PersonnelName { get; set; }
        public string PersonnelSurname { get; set; }
        public string PersonnelImg { get; set; }

    }
}
