using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Clave4.Clases
{
    internal class Pedido
    {
        public int PedidoID { get; set; }
        public int UsuarioID { get; set; }
        public int LocalID { get; set; }
        public int? EventoID { get; set; }
        public DateTime FechaHoraPedido { get; set; }
        public TimeSpan HoraReserva { get; set; }
        public string EstadoPedido { get; set; }
        public string TipoPedido { get; set; }
        public decimal TotalPago { get; set; }
        public string TipoPago { get; set; }
    }
}
