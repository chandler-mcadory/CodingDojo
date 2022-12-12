#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LoginAndRegistration.Models;
public class LogUser
{
    [Required]
    [EmailAddress]
    public string LEmail {get;set;}
    [Required]
    [DataType(DataType.Password)]
    public string LPassword {get;set;}
}