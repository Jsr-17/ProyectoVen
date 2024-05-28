using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoVentasElectronicas.Models
{
    public class Products
    {
        [Key]
        public int Product_id { get; set; }
        public string Name { get; set; }
        public string Description { get; set;}
        public decimal Price { get; set;}
        public int Category_id { get; set; }

        [ForeignKey("Category_id")]
        public Categories Category { get; set; }
        public int Suplier_id { get; set; }
        [ForeignKey("Suplier_id")]
        public Supliers Suplier { get; set; }
    }
    
}
