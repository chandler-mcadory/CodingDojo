#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WeddingPlanner.Models;
public class LogUser
{
    [Required]
    [Display(Name = "Email")]
    [EmailAddress]
    public string LEmail {get;set;}
    [Required]
    [Display(Name = "Password")]
    [DataType(DataType.Password)]
    public string LPassword {get;set;}
}