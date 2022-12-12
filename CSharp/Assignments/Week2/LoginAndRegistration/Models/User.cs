#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LoginAndRegistration.Models;
public class User
{
    [Key]
    public int UserId {get;set;}
    [Required(ErrorMessage = "First Name Required")]
    public string FirstName {get;set;}
    [Required(ErrorMessage = "Last Name Required")]
    public string LastName {get;set;}
    [Required(ErrorMessage = "Email Required")]
    [EmailAddress]
    [UniqueEmail]
    public string Email {get;set;}
    [Required(ErrorMessage = "Password Required")]
    [MinLength(8, ErrorMessage ="Password must be at least 8 characters")]
    [DataType(DataType.Password)]
    public string Password {get;set;}
    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;

    [NotMapped]
    [DataType(DataType.Password)]
    [Compare("Password")]
    [Display(Name = "Confirm Password")]
    public string Confirm {get;set;}
}

public class UniqueEmailAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if(value == null)
        {
            return new ValidationResult("Email required");
        }

        MyContext _context = (MyContext)validationContext.GetService(typeof(MyContext));
        if(_context.Users.Any(e => e.Email == value.ToString()))
        {
            return new ValidationResult("Email already used. Provide new email.");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}