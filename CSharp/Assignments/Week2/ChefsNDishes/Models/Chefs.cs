#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ChefsNDishes.Models;
public class Chef
{
    [Key]
    public int ChefId {get;set;}


    [Required(ErrorMessage = "First Name Required")]
    public string FirstName {get;set;}


    [Required(ErrorMessage = "Last Name Required")]
    public string LastName {get;set;}


    [Required(ErrorMessage = "DoB Required")]
    public DateTime DoB {get;set;}


    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;

    public List<Dish> AllDishes {get;set;} = new List<Dish>();


}