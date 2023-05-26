using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage ="E-mail is required.")]
        public string? Email {get; set;} =String.Empty;
        [Required(ErrorMessage ="Frist name is required.")]
        public string? FirstName {get; set;} =String.Empty;
        [Required(ErrorMessage ="Last name is required.")]
        public string? LastName {get; set;} =String.Empty;
        public string? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age {get; set;} 
        public string? SelectedCourse {get; set;} =String.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt=DateTime.Now;
        }


    }
}