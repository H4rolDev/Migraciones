using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Data.DataBase.Tables
{
    [Table("ventas")]

    public class Venta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public DateTime fechaCompra { get; set; }
        [Required]
        [Precision(7, 2)]
        public decimal totalVenta { get; set; }
        [Required]
        public int id_cliente { get; set; }
        [Required]
        public int id_vendedor { get; set; }
        public int id_delivery { get; set; }
        public int id_tipoPago { get; set; }
        public int id_recojoAlmacen { get; set; }
    }
}