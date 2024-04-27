using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMProductos
{
    public class Validaciones
    {


          public static bool ValidarTextBoxes(List<TextBox> textBoxes)
    {
          
        foreach (TextBox textBox in textBoxes)
        {
            if (string.IsNullOrEmpty(textBox.Text)) 
            {
                return false; // Devuelve falso si encuentra un TextBox vacío o null
            }
        }
        return true; // Devuelve true si todos los TextBox tienen contenido
    }



        public static bool SoloNumeros(string x)
        {
            bool esNumero = true;
            foreach (char c in x)
            {
                if (!char.IsDigit(c))
                {
                    esNumero = false;
                    break;
                }
            }
            return esNumero;
        }

        public static bool SoloLetras(string x)
        {
            bool esLetra = true;
            foreach (char c in x)
            {
                if (!char.IsLetter(c))
                {
                    esLetra = false;
                    break;
                }
            }
            return esLetra;
        }


    }
}
