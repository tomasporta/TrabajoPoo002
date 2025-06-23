using Practico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico.Datos
{
    public class RepositorioVehiculosOpedadores
    {
        private List<Vehiculo> lista = new();


        public static RepositorioVehiculosOpedadores operator +(RepositorioVehiculosOpedadores repo, Vehiculo v)
        {
            if (!repo.lista.Any(x => x.Patente == v.Patente))
                repo.lista.Add(v);
            return repo;
        }


        public static RepositorioVehiculosOpedadores operator -(RepositorioVehiculosOpedadores repo, string patente)
        {
            var v = repo.lista.FirstOrDefault(x => x.Patente == patente);
            if (v != null) repo.lista.Remove(v);
            return repo;
        }


        public static bool operator ==(RepositorioVehiculosOpedadores repo, Vehiculo v)
        {
            return repo.lista.Any(x => x.Patente == v.Patente);
        }

        public static bool operator !=(RepositorioVehiculosOpedadores repo, Vehiculo v)
        {
            return !(repo == v);
        }

        public Vehiculo this[int index]
        {
            get => lista[index];
            set => lista[index] = value;
        }


        public string MostrarTodo()
        {
            if (!lista.Any()) return "No hay vehículos registrados.";

            var sb = new StringBuilder();
            foreach (var v in lista)
                sb.AppendLine(v.Informar());

            return sb.ToString();
        }


        public Vehiculo? BuscarPorPatente(string patente)
        {
            return lista.FirstOrDefault(v => v.Patente == patente);
        }


        public List<Vehiculo> ObtenerTodoComoLista()
        {
            return lista.ToList(); 
        }
    }
}

