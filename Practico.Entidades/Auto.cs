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
        public override string Informar()
        {
            return base.Informar() + $" | Puertas: {CantPuertas} | Costo Uso: ${CalcularCostoUso():0.00}";
        }
        //aun no esta terminado
    }
}
