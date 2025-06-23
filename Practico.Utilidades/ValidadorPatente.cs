
using System.Text.RegularExpressions;

namespace Practico.Utilidades
{
    public  static class ValidadorPatente
    {
        private static readonly Regex formatoViejo = new(@"^[A-Z]{3}\d{3}$");
        private static readonly Regex formatoNuevo = new(@"^[A-Z]{2}\d{3}[A-Z]{2}$");

        public static bool EsValida(string patente, int anio, out string? error)
        {
            patente = patente.ToUpper().Trim().Replace(" ", ""); 
            error = null;

            if (string.IsNullOrWhiteSpace(patente))
            {
                error = "La patente no puede estar vacía.";
                return false;
            }

            if (!formatoViejo.IsMatch(patente) && !formatoNuevo.IsMatch(patente))
            {
                error = "Formato inválido. Usá ABC123 (antes de 2016) o AB123CD (desde 2016).";
                return false;
            }

            if (formatoNuevo.IsMatch(patente) && anio < 2016)
            {
                error = "Las patentes nuevas (AB123CD) solo son válidas para vehículos desde 2016.";
                return false;
            }
            if (RepositorioVehiculosLinq.Existe(patente))
            {
                error = "Ya existe un vehículo con esa patente.";
                return false;
            }

            return true;
        }
    }
}
