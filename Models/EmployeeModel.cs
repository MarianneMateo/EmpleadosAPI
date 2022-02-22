using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpleadosAPI.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string EmployeeName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Department { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string IdentityCard { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Salary { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Status { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ImageName { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [NotMapped]
        public string ImageSrc { get; set; }
    }
}
