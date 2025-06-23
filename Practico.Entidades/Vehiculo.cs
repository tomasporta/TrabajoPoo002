using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Practico.Entidades
{
    public enum Marca { Ford, Chevrolet, Toyota, Fiat, Honda }
    public enum Color { Rojo, Azul, Negro, Blanco, Gris }
    public abstract class Vehiculo : IValidatableObject
    {
        public Marca Marca { get; set; }
        public string Modelo { get; set; } = "";
        public int Anio { get; set; }
        public string Patente { get; set; } = "";
        public Color Color { get; set; }

        public abstract decimal CalcularCostoUso();
        public virtual string Informar()
        {
            return $"Modelo: {Modelo} | Año: {Anio} | Patente: {Patente} | Costo: ${CalcularCostoUso():0.00}";
        }
        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(Modelo))
                yield return new ValidationResult("El modelo no puede estar vacío.");

            if (Anio < 1990 || Anio > DateTime.Now.Year)
                yield return new ValidationResult($"El año debe estar entre 1990 y {DateTime.Now.Year}.");

            if (!Regex.IsMatch(Patente ?? "", @"^([A-Z]{3}\d{3}|[A-Z]{2}\d{3}[A-Z]{2})$"))
                yield return new ValidationResult("La patente debe tener formato ABC123 o AB123CD.");

            if (Regex.IsMatch(Patente ?? "", @"^[A-Z]{2}\d{3}[A-Z]{2}$") && Anio < 2016)
                yield return new ValidationResult("Las patentes nuevas (AB123CD) son válidas solo desde el año 2016.");
        }
        public abstract override bool Equals(object? obj);
        public abstract override int GetHashCode();

    }
}
