using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }


        //In the site the ProfilePictureURL will appear as the string you put down. So if you didn't put "Profile Picture URL" it'd default as ProfilePictureURL
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Relationships
        //This has to be nullable because when you create actor you only input profile pic link, name, and bio.
        //Actors_Movie remains empty while it is a parameter for the Actors model even though Actors_Movie is not a column in the data table.
        public List<Actor_Movie>? Actors_Movies { get; set; }

      


        

    }
}
