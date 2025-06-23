using Practico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico.Windows.Helpers
{
    public static class GridHelpers
    {
        public static void LimpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }

        public static DataGridViewRow ConstruirFila(DataGridView grid)
        {
            return (DataGridViewRow)grid.RowTemplate.Clone();
        }

        public static void SetearFila(DataGridViewRow fila, Vehiculo v, DataGridView grid)
        {
            fila.CreateCells(grid,
                v.GetType().Name,
                v.Marca,
                v.Modelo,
                v.Anio,
                v.Patente,
                v.Color,
                v switch
                {
                    Auto a => $"{a.CantPuertas} puertas",
                    Camioneta c => $"{c.CapacidadCarga} kg",
                    Moto m => $"{m.Cilindrada} cc",
                    _ => ""
                },
                v.CalcularCostoUso().ToString("C")
            );
        }

        public static void AgregarFila(DataGridViewRow fila, DataGridView grid)
        {
            grid.Rows.Add(fila);
        }

        public static void EliminarFila(DataGridView grid, int index)
        {
            if (index >= 0 && index < grid.Rows.Count)
                grid.Rows.RemoveAt(index);
        }
    }
}

