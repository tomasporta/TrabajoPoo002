using System.ComponentModel.DataAnnotations;

namespace Practico.Entidades
{
    public class Camioneta : Vehiculo
    {
        public int CapacidadCarga { get; set; }
        public override decimal CalcularCostoUso() => 15 * (DateTime.Now.Year - Anio) + 0.5m * CapacidadCarga;
        public override string Informar()
        {
            return base.Informar() + $" | Carga: {CapacidadCarga}kg | Costo Uso: ${CalcularCostoUso():0.00}";
        }
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            foreach (var result in base.Validate(validationContext))
                yield return result;
            if (CapacidadCarga <= 0)
                yield return new ValidationResult("La capacidad de carga debe ser un número positivo.");
        }
        //aun no esta terminado
    }
}
