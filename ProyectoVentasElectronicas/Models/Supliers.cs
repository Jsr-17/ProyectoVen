using System.ComponentModel.DataAnnotations;

namespace ProyectoVentasElectronicas.Models
{
    public class Supliers
    {
        [Key]
        public int Suplier_id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Direction { get; set; }
    }
}
