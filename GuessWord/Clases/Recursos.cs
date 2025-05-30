using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace GuessWord.Clases
{
    public static class Recursos
    {
        public static List<string> listadepalabras;
        public static string ruta = Path.Combine(Application.StartupPath, "Recursos", "palabras_wordle_simples.txt");
        public static List<string> Historial;

        public static void InicializarPalabras()
        {
            listadepalabras = CargarPalabras();
        }
        private static List<string> CargarPalabras()
        {
            if (!File.Exists(Recursos.ruta))
            {
                return new List<string>();
            }
            return File.ReadAllLines(Recursos.ruta).Where(lineas => !string.IsNullOrWhiteSpace(lineas)).Select(lineas => lineas.Trim()).ToList();
        }
    }
}
