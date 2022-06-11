using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryLibrary;

[Table("InOut")]
public class InOut
{
    [Key]
    public int Id { get; set; }

    public DateTime EnteredAt { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Required]
    public bool IsEntry { get; set; }

    public int StorageId { get; set; }

    [ForeignKey("StorageId")]
    public Storage Storage { get; set; }
}
