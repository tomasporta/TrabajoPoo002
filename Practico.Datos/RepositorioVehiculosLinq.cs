using System.Drawing;
using System.Text.RegularExpressions;

namespace Practico.Datos
{
    public class RepositorioVehiculosLinq
    {
        private static List<Vehiculo> lista = new();

        public static List<Vehiculo> ObtenerTodos() => lista.ToList();

        public static bool Existe(string patente) =>
            lista.Any(v => v.Patente.Equals(patente, StringComparison.OrdinalIgnoreCase));

        public static bool Guardar(Vehiculo v)
        {
            if (Existe(v.Patente)) return false;
            lista.Add(v);
            return true;
        }

        public static bool Eliminar(string patente)
        {
            var v = lista.FirstOrDefault(x => x.Patente == patente);
            if (v == null) return false;
            lista.Remove(v);
            return true;
        }

        public static Vehiculo? BuscarPorPatente(string patente) =>
            lista.FirstOrDefault(v => v.Patente.Equals(patente, StringComparison.OrdinalIgnoreCase));

        public static List<Vehiculo> ListarPorTipo(string tipo) =>
            lista.Where(v => v.GetType().Name == tipo).ToList();
        static RepositorioVehiculosLinq()
        {
            lista.Add(new Auto
            {
                Marca = Marca.Ford,
                Modelo = "Focus",
                Anio = 2010,
                Patente = "RNL321",
                Color = Color.Rojo,
                CantPuertas = 4
            });
            lista.Add(new Moto
            {
                Marca = Marca.Honda,
                Modelo = "CB500",
                Anio = 2012,
                Patente = "JPG214",
                Color = Color.Azul,
                Cilindrada = 500
            });
            lista.Add(new Camioneta
            {
                Marca = Marca.Toyota,
                Modelo = "Hilux",
                Anio = 2016,
                Patente = "AB123CD",
                Color = Color.Negro,
                CapacidadCarga = 1000
            });
        }

    }

}
