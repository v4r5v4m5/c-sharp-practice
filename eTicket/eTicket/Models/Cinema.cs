using System.ComponentModel.DataAnnotations;
using eTicket.Data.Base;
namespace eTicket.Models
{
    public class Cinema:IEntityBaseRepository
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cinema Logo")]
        [Required(ErrorMessage = "Logo is required")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Cinema description is required")]
        public string Description { get; set; }

        // Relationships
        /*public List<Movie> Movies { get; set; }*/
    }
}
