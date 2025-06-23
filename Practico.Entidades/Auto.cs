using System.ComponentModel.DataAnnotations;

namespace Practico.Entidades
{
    public class Auto : Vehiculo
    {
        public int CantPuertas { get; set; }
        public override decimal CalcularCostoUso()
        {
            int antigüedad = DateTime.Now.Year - Anio;
            return 10 * antigüedad;
        }
        
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            foreach (var result in base.Validate(validationContext))
                yield return result;
            if (CantPuertas < 2 || CantPuertas > 5)
                yield return new ValidationResult("El número de puertas debe estar entre 2 y 5.");
        }
        public override bool Equals(object? obj)
        {
            // Verifica si 'obj' no es del tipo Auto. Si no lo es, retorna false.
            // Si sí es un Auto, lo convierte a una variable local llamada 'other'.
            // Esto se llama pattern matching y permite trabajar con 'other' sin necesidad de hacer cast manuales.
            if (obj is null || !(obj is Auto)) return false;
            return Marca == ((Auto)obj).Marca &&
                   Modelo == ((Auto)obj).Modelo &&
                   Anio == ((Auto)obj).Anio &&
                   Patente == ((Auto)obj).Patente &&
                   Color == ((Auto)obj).Color &&
                   CantPuertas == ((Auto)obj).CantPuertas;
        }
        public override int GetHashCode()
        {
            // Mejor forma de calcular el hash code.
            // Usa HashCode.Combine para generar hash seguro con multiples campos (hasta 8).
            // Si son más de 8, anidar Combine(). Es mejor que sumar GetHashCode() manualmente.
            return HashCode.Combine(Marca, Modelo, Anio, Patente, Color, CantPuertas);
        }
        public override string Informar()
        {
            return base.Informar() + $" | Puertas: {CantPuertas} | Costo Uso: ${CalcularCostoUso():0.00}";
        }
    }
}
