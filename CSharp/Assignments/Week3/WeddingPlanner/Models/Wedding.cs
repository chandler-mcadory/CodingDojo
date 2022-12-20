#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WeddingPlanner.Models;
public class Wedding
{
    [Key]
    public int WeddingId {get;set;}
    [Required(ErrorMessage = "Wedder 1 Required")]
    public string Wedder1 {get;set;}
    [Required(ErrorMessage = "Wedder 2 Required")]
    public string Wedder2 {get;set;}
    [Required(ErrorMessage = "Date Required")]
    public DateTime Date {get;set;}
    [Required(ErrorMessage = "Address Required")]
    public string Address {get;set;}

    [Required(ErrorMessage = "UserId Required")]
    public int UserId {get; set;}
    public User? Creator {get; set;}

    public List<Event> EventsCreated {get;set;} = new List<Event>();

    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;
}