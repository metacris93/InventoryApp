using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryLibrary;

[Table("Category")]
public class Category
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    public ICollection<Product>? Products { get; set; }
}

