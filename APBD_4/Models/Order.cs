using System.ComponentModel.DataAnnotations;
namespace APBD_4.Models;

public class Order
{
    [Required]
    public int IdOrder { get; set; } //PK
    [Required]
    [MaxLength(200)]
    public string IdProduct { get; set; } //JAK OZNACZYC FK? 
    [Required]
    public int Amount { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    [Required]
    public DateTime FulfilledAt { get; set; }
}