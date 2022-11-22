using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "Description")]
        public string Description { get; set; }


        [Display(Name = "Ticket Price")]
        public double Price { get; set; }


        [Display(Name = "Image")]
        public string ImageURL { get; set; }


        [Display(Name = "First Showing")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Last Showing")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Category")]
        public MovieCategory MovieCategory { get; set; } //MovieCategory is an enum that is being recognized because of "using.eTickets.Data" We have to create the enum in the Data -> MovieCategory.cs

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
        

        
    }
}
