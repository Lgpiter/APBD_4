using System.ComponentModel.DataAnnotations;

namespace APBD_4.Models;

public class Product_Warehouse
{
    [Required]
    public int IdProductWareHouse { get; set; }//PK
    [Required]
    public int IdOrder { get; set; } //JAK OZNACZYC FK? 
    [Required]
    [MaxLength(200)]
    public string IdProduct { get; set; } //JAK OZNACZYC FK? 
    [Required]
    public int Amount { get; set; }
    [Required]
    public float Price { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }

}