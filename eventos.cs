using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Clave4
{
    class eventos
    {
        int eventoID, usuarioID;
        Double MontoMinimo, MontoMaximo;
        string EstadoEvento;
        DateTime Fecha;

        public int EventoID { get => eventoID; set => eventoID = value; }
        public int UsuarioID { get => usuarioID; set => usuarioID = value; }
        public double MontoMinimo1 { get => MontoMinimo; set => MontoMinimo = value; }
        public double MontoMaximo1 { get => MontoMaximo; set => MontoMaximo = value; }
        public string EstadoEvento1 { get => EstadoEvento; set => EstadoEvento = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
    }
}
