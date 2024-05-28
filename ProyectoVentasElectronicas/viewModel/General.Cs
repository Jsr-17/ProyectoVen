using ProyectoVentasElectronicas.Models;

namespace ProyectoVentasElectronicas.viewModel
{
    public class General
    {
        public Orders Orders { get; set; }
        public Clients Clients { get; set; }
        public Categories Categories { get; set; }
        public Products Products { get; set; }

        public Supliers Supliers { get; set; }
    }
}
