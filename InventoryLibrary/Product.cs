using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryLibrary;

[Table("Product")]
public class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string? Name { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

    [Required]
    public int TotalQuantity { get; set; }

    public int CategoryId { get; set; }

    [ForeignKey("CategoryId")]
    public Category? Category { get; set; }

    public ICollection<Storage>? Storages { get; set; }
}

