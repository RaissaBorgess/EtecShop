
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EtecShopAPI.Models;

[Table("Categoria")]
public class Categoria

{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(40)]
    public string Nome { get; set; }

}