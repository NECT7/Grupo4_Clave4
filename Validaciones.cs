using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Grupo4_Clave4
{
    internal class Validaciones
    {
        // Validación de campo vacío
        public static bool EstaVacio(string texto)
        {
            return string.IsNullOrWhiteSpace(texto);
        }

        // Validación de solo letras
        public static bool SoloLetras(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z\s]+$");
        }

        // Validación de solo números
        public static bool SoloNumeros(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }

        // Validación de selección en ComboBox
        public static bool EstaSeleccionado(ComboBox comboBox)
        {
            return comboBox.SelectedIndex != -1;
        }

        // Validación de formato de email
        public static bool EsEmailValido(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        // Validación de horario para "antojitos"
        public static bool EsHorarioAntojitos(DateTime hora)
        {
            return hora.TimeOfDay >= new TimeSpan(14, 0, 0) && hora.TimeOfDay <= new TimeSpan(16, 0, 0);
        }

        // Validación de límite de platillos (solo 3 para antojitos)
        public static bool LímiteDeAntojitos(List<DataGridViewRow> pedidoRows, int maxCantidad)
        {
            int cantidadAntojitos = pedidoRows
                .Where(row => row.Cells[0]?.Value.ToString() == "Antojitos")
                .Sum(row => Convert.ToInt32(row.Cells[1].Value));

            return cantidadAntojitos <= maxCantidad;
        }
    }

}
