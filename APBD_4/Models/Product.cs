﻿using System.ComponentModel.DataAnnotations;

namespace APBD_4.Models;

public class Product
{
    [Required]
    public int IdProduct { get; set; } //PK
    [Required]
    [MaxLength(200)]
    public string Name { get; set; }
    [Required]
    [MaxLength(200)]
    public string Description { get; set; }
    [Required]
    public double Price { get; set; }
}