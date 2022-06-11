using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryLibrary;

[Table("Storage")]
public class Storage
{
    [Key]
    public int Id { get; set; }

    public DateTime LastUpdate { get; set; }

    [Required]
    public int PartialQuantity { get; set; }

    public int ProductId { get; set; }

    [ForeignKey("ProductId")]
    public Product Product { get; set; }

    public int WareHouseId { get; set; }

    [ForeignKey("WareHouseId")]
    public WareHouse WareHouse { get; set; }

    public ICollection<InOut> InOuts { get; set; }

    public string Info()
    {
        return $"{Product.Name} in {WareHouse.Name}";
    }
}
