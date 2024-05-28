using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoVentasElectronicas.Models
{
    public class DetailsOrders
    {
        [Key]
        public int Detail_id { get; set; }

        public int Order_id { get; set; }

        [ForeignKey("Order_id")]
        public Orders Order { get; set; }
       
        public int Product_id { get; set; }

        [ForeignKey("Product_id")]
        public  Products Product {  get; set; }
        public int Quantity { get; set; }
        public decimal Prize {  get; set; }


    }
}
