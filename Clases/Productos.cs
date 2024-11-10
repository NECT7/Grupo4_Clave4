using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Clave4.Clases
{
    public class Productos
    {
        int ProductoId, CantidadProducto;
        String NombreProducto, HorarioDisponible, TipoProduto;
        Double PrecioUnitarioProducto;

        public string NombreProducto1 { get => NombreProducto; set => NombreProducto = value; }
        public string HorarioDisponible1 { get => HorarioDisponible; set => HorarioDisponible = value; }
        public string TipoProduto1 { get => TipoProduto; set => TipoProduto = value; }
        public int ProductoId1 { get => ProductoId; set => ProductoId = value; }
        public int CantidadProducto1 { get => CantidadProducto; set => CantidadProducto = value; }
        public double PrecioUnitarioProducto1 { get => PrecioUnitarioProducto; set => PrecioUnitarioProducto = value; }
    }
}
