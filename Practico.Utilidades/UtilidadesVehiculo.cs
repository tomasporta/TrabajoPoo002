using Practico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico.Utilidades
{
    public static class UtilidadesVehiculo
    {
        public static decimal CalcularCostoTotal(List<Vehiculo> lista)
        {
            return lista.Sum(v => v.CalcularCostoUso());
        }

        public static double PromedioAntiguedad(List<Vehiculo> lista)
        {
            return lista.Count == 0 ? 0 : lista.Average(v => DateTime.Now.Year - v.Anio);
        }

        public static Vehiculo? BuscarMasAntiguo(List<Vehiculo> lista)
        {
            return lista.OrderBy(v => v.Anio).FirstOrDefault();
        }

    }
}
