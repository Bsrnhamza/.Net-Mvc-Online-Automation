using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineAutomation.Models.Classes
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; } // Departmanın benzersiz ID'si
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string DepartmentName { get; set; } // Departmanın adı

        public ICollection<Personnel> Personnels { get; set; }
    }
}
