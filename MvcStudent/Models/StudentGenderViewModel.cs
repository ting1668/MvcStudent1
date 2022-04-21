using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcStudent.Models
{
    public class StudentGenderViewModel
    {
        public List<Student>? Students { get; set; }
        public SelectList? Genders { get; set; }
        public string? StudentGender { get; set; }
        public string? SearchString { get; set; }

    }
}
