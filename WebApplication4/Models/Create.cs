using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Create

    {
        [ScaffoldColumn(false)]
        public int id { get; set; }
        [StringLength(30)]
        [Required(ErrorMessage = "Musisz wprowadzić Imię")]
        public string name { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Musisz wprowadzić Nazwisko")]
        public string surname { get; set; }

        [Required(ErrorMessage = "Musisz wprowadzić Email")]
        [EmailAddress]
        public string email { get; set; }
        public string text { get; set; }
        [StringLength(30)]
        [Required(ErrorMessage = "Musisz wybrać temat")]
        public string subject { get; set; }
        
       
    }
}