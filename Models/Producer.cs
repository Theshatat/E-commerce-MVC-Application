using System.ComponentModel.DataAnnotations;

namespace E_commerce.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        public string Bio { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
