using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico.Utilidades
{
    public static class ExtensionesConsola
    {
        public static void EscribirColor(this string texto, ConsoleColor color)
        {
            var original = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(texto);
            Console.ForegroundColor = original;
        }

        public static void MostrarTitulo(string titulo)
        {
            Console.Clear();
            Console.WriteLine("========== " + titulo.ToUpper() + " ==========\n");
        }

        public static void Separador()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
