using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; } //MovieCategory is an enum that is being recognized because of "using.eTickets.Data" We have to create the enum in the Data -> MovieCategory.cs
        

        Movie(int id, string name, string description, double price, string imageURL, DateTime startDate, DateTime endDate, MovieCategory movieCategory)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            ImageURL = imageURL;
            StartDate = startDate;
            EndDate = endDate;
            MovieCategory = movieCategory;
        }
    }
}
