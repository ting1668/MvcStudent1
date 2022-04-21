using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcStudent.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "姓名")]
        [StringLength(300)]
        [Required]
        public string? Name { get; set; }
        [Display(Name = "性别")]
        [StringLength(1)]
        [Required]
        public string? Gender { get; set; }
        [Display(Name = "年龄")]
        [Range(1, 200)]

        public int Age { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "出生日期")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "手机")]
        [StringLength(13)]
        [RegularExpression(@"^[0-9]*[1-9][0-9]*$")]
        [Required]
        public string? Phone { get; set; }
        [Display(Name = "体温")]
        [Range(30, 50)]
        //[DataType(DataType.Currency)]
        //[Column(TypeName = "decimal(18,2)")]
        public float Temperature { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "填表日期")]
        public DateTime Dateoffilling { get; set; }


    }
}
