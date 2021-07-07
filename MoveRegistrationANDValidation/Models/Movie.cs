using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MoveRegistrationANDValidation.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Movie must have a Title")]

        //[StringLength(50, MinimumLength = 1, ErrorMessage = "Title can only have 50 characters")]
        //[MaxLength(50, ErrorMessage ="Title can only have 50 characters")]
        [StringLength(50, ErrorMessage = "title can only have 50 characters")]

        


        public string Title { get; set; }

        public string Genre { get; set; }

        [Required(ErrorMessage ="release year required")]
        [Range(1800, 2021, ErrorMessage ="Please Choose a Year between 1880 and 2021")]
        public string Year { get; set; }
        [Required(ErrorMessage ="Please in put an Actors name.")]
        public string Actors { get; set; }
        [Required(ErrorMessage ="Please input the directors name.")]
        public string Directors { get; set; }
    }
}
