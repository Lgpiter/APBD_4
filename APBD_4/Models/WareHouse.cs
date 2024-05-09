using System.ComponentModel.DataAnnotations;
namespace APBD_4.Models;

public class WareHouse
{
    [Required]
    public int IdWarehouse { get; set; } //PK
    [Required]
    [MaxLength(200)]
    public string Name { get; set; }
    [Required]
    [MaxLength(200)]
    public string Address { get; set; }
}