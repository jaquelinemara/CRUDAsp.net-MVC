using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asp.netCoreExercicio01Manha.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }
        
        [Column(TypeName ="nvarchar(250)")]
        [Required]
        public string Produto { get; set; }
        
        public int Quantidade { get; set; }

        [Required]
        public double Valor { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        public string Fornecedor { get; set; }
    }
}
