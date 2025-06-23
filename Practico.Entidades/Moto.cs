using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico.Entidades
{
    public class Moto:Vehiculo
    {
        public int Cilindrada { get; set; }
        public override decimal CalcularCostoUso() => 5 * (DateTime.Now.Year - Anio) + 0.1m * Cilindrada;
      
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            foreach (var result in base.Validate(validationContext))
                yield return result;
            if (Cilindrada <= 0)
                yield return new ValidationResult("La cilindrada debe ser un número positivo.");
        }
        public override bool Equals(object? obj)
        {
            if (obj is Moto other)
            {
                return Marca == other.Marca &&
                       Modelo == other.Modelo &&
                       Anio == other.Anio &&
                       Patente == other.Patente &&
                       Color == other.Color &&
                       Cilindrada == other.Cilindrada;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Marca, Modelo, Anio, Patente, Color, Cilindrada);
        }
        public override string Informar()
        {
            return base.Informar() + $" | Cilindrada: {Cilindrada}cc | Costo Uso: ${CalcularCostoUso():0.00}";
        }
    }
}
