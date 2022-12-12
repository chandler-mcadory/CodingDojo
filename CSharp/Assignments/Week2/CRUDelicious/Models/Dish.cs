#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace CRUDelicious.Models;
public class Dish
{
    [Key]
    public int DishId {get; set;}
    [Required(ErrorMessage = "Name is Required")]
    public string Name {get; set;}
    [Required(ErrorMessage = "Chef's name is Required")]
    public string Chef {get; set;}
    [Required(ErrorMessage = "Tastiness level is Required")]
    public int Tastiness {get; set;}
    [Required(ErrorMessage = "Number of Calories is Required")]
    public int Calories {get; set;}
    [Required(ErrorMessage = "Description is Required")]
    public string Description {get; set;}
    public DateTime CreatedAt {get; set;} = DateTime.Now;
    public DateTime UpdatedAt {get; set;} = DateTime.Now;
    
}