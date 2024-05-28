using System.ComponentModel.DataAnnotations;

namespace ProyectoVentasElectronicas.Models
{
    public class Categories
    {
        [Key]
       public int  Category_id { get; set; }
        public String Name { get; set;}
    }
}
