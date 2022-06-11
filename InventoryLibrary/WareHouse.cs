using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryLibrary;

[Table("WareHouse")]
public class WareHouse
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [StringLength(100)]
    public string Address { get; set; }

    public ICollection<Storage> Storages { get; set; }
}
