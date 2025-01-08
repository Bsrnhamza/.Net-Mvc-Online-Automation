using System.ComponentModel.DataAnnotations;

namespace MvcOnlineAutomation.Models.Classes
{
    public class Currents
    {
        [Key]
        public int CurrentId { get; set; }
        public string CurrentName { get; set; }
        public string CurrentSurname { get; set; }
        public string CurrentCity { get; set; }
        public string CurrentEmail { get; set; }
    }
}
