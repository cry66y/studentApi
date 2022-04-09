using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stuManagementApi.Models
{
    public class StudentDetail
    {
        [Key]
        public int StudentDetailId { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string StudentFirstName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string StudentLastName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string MobileNumber { get; set; }


    }
}
