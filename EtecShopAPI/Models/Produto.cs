using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtecShopAPI.Models;

[Table("Produto")]
public class Produto

    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Nome { get; set;}

        [StringLength(1000)]
        public string Descricao { get; set; }

        [Required]
        public int Estoque { get; set; }

        [Required]
        [Column(TypeName = "decimal(8,2)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal ValorCusto { get; set; }

        [Required]
        [Column(TypeName = "decimal(8,2)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal ValorVenda { get; set; }

    }
