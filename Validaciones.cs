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
    }
}
