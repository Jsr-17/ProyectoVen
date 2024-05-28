using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoVentasElectronicas.Models
{
    public class Clients
    {
        [Key]
        [Column ("Client_id")]
        public int Client_id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public string Email { get; set; }   
        public string Telephone {  get; set; }
        public string Direction {get;set;}
        public string City { get; set;}
        public string Country { get; set;}
        public string Username { get; set; }
        public string Password { get; set; }

        public bool ? admin { get; set; }

    }
}
