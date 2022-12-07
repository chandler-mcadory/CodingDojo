#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurvey.Models;

public class Ninja
{
    [Required(ErrorMessage = "Name is required")]
    public string Name {get;set;}
    [Required(ErrorMessage = "Dojo selection is required")]
    public string Dojo {get;set;}
    [Required(ErrorMessage = "Language selection is required")]
    public string Language {get;set;}
    public string? Comment {get;set;}
}