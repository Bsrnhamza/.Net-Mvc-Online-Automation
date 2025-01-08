using System.ComponentModel.DataAnnotations;

namespace MvcOnlineAutomation.Models.Classes
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        protected string DepartmentName { get; set; }

    }
}
