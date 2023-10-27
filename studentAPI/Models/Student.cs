using studentAPI.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace studentAPI.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "The StudentName field is required.")]
        [Column(TypeName = "nvarchar(250)")]
        public string StudentName { get; set; }

        public string StudentEmail { get; set; }

        public int StudentStatus { get; set; }

        public int Age { get; set; }
    }
}
