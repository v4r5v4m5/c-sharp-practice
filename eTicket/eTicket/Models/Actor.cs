﻿using eTicket.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Actor:IEntityBaseRepository
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full name is required")]
        public string FullName { get; set; }
        
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set;}

        // Relationships
        /*public List<Actor_Movie> Actors_Movies { get; set; }*/
    }
}
