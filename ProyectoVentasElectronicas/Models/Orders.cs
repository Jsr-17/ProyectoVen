using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoVentasElectronicas.Models
{
    public class Orders
    {
        [Key]
        public int Order_id { get; set; }
        public int Client_id {  get; set; }
        [ForeignKey("Client_id")]
        public Clients Client { get; set; }
        public DateTime Order_date { get; set; }
        public string State { get; set; }
    }
}
