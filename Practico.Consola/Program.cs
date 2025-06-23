using System.Text.RegularExpressions;

static RepositorioVehiculosOpedadores repo = new();
static void Main(string[] args)
{
    while (true)
    {
        MostrarMenu();
        var opcion = Console.ReadLine();

        Console.Clear();

        switch (opcion)
        {
            case "1": CrearVehiculo(); break;
            case "2": ListarVehiculos(); break;
            case "3": BuscarVehiculo(); break;
            case "4": EliminarVehiculo(); break;
            case "5": EditarVehiculo(); break;
            case "6": MostrarEstadisticas(); break;

            case "0": return;
            default: Console.WriteLine("Opción inválida."); break;
        }

        Console.WriteLine("\nPresioná una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
    }
}

private static void EditarVehiculo()
{
    Console.Write("Patente a editar: ");
    string patente = Console.ReadLine()?.ToUpper().Trim() ?? "";
    var viejo = repo.BuscarPorPatente(patente);

    if (viejo == null)
    {
        Console.WriteLine(" Vehículo no encontrado.");
        return;
    }

    repo -= patente;

    Console.Write("Nuevo modelo: ");
    string nuevoModelo = Console.ReadLine()?.Trim() ?? "";

    viejo.Modelo = nuevoModelo;
    repo += viejo;

    Console.WriteLine(" Vehículo actualizado.");
}

private static void EliminarVehiculo()
{

    Console.Write("Patente a eliminar: ");
    string patente = Console.ReadLine()?.ToUpper().Trim() ?? "";

    repo -= patente;
    Console.WriteLine(" Vehículo eliminado.");
}

private static void BuscarVehiculo()
{

    Console.Write("Ingresá la patente: ");
    string patente = Console.ReadLine()?.Trim().ToUpper() ?? "";

    var encontrado = repo.BuscarPorPatente(patente);

    if (encontrado != null)
        Console.WriteLine("\n▶ Vehículo encontrado:");
    else
    {
        Console.WriteLine(" No se encontró ningún vehículo con esa patente.");
        return;
    }

    Console.WriteLine(encontrado.Informar());
}

private static void ListarVehiculos()
{
    Console.WriteLine(repo.MostrarTodo());
}
static void MostrarEstadisticas()
{
    static void MostrarEstadisticas()
    {
        var lista = repo.ObtenerTodoComoLista();

        decimal total = UtilidadesVehiculo.CalcularCostoTotal(lista);
        double promedio = UtilidadesVehiculo.PromedioAntiguedad(lista);
        var antiguo = UtilidadesVehiculo.BuscarMasAntiguo(lista);

        ExtensionesConsola.MostrarTitulo("ESTADÍSTICAS");

        $"Costo total de uso: ${total:0.00}".EscribirColor(ConsoleColor.Cyan);
        $"Antigüedad promedio: {promedio:0.0} años".EscribirColor(ConsoleColor.Cyan);

        if (antiguo != null)
        {
            Console.WriteLine("\nVehículo más antiguo:");
            antiguo.Informar().EscribirColor(ConsoleColor.Yellow);
        }

        ExtensionesConsola.Separador();
    }
    var lista = repo.ObtenerTodoComoLista();

    decimal total = UtilidadesVehiculo.CalcularCostoTotal(lista);
    double promedio = UtilidadesVehiculo.PromedioAntiguedad(lista);
    var antiguo = UtilidadesVehiculo.BuscarMasAntiguo(lista);

    ExtensionesConsola.MostrarTitulo("ESTADÍSTICAS");

    $"Costo total de uso: ${total:0.00}".EscribirColor(ConsoleColor.Cyan);
    $"Antigüedad promedio: {promedio:0.0} años".EscribirColor(ConsoleColor.Cyan);

    if (antiguo != null)
    {
        Console.WriteLine("\nVehículo más antiguo:");
        antiguo.Informar().EscribirColor(ConsoleColor.Yellow);
    }

    ExtensionesConsola.Separador();
}

static void MostrarMenu()
{
    Console.WriteLine("== CRUD DE VEHÍCULOS ==");
    Console.WriteLine("1 - Agregar vehículo");
    Console.WriteLine("2 - Listar todos");
    Console.WriteLine("3 - Buscar por patente");
    Console.WriteLine("4 - Eliminar por patente");
    Console.WriteLine("5 - Editar vehículo");
    Console.WriteLine("6 - Ver estadísticas globales");

    Console.WriteLine("0 - Salir");
    Console.Write("Opción: ");
}
static void CrearVehiculo()
{
    Console.Write("Tipo (Auto/Camioneta/Moto): ");
    string tipo = Console.ReadLine()?.Trim().ToLower() ?? "";

    Console.Write("Modelo: ");
    string modelo = Console.ReadLine()?.Trim() ?? "";

    Console.Write("Año: ");
    int anio = int.Parse(Console.ReadLine() ?? "0");

    Console.Write("Patente: ");
    string patente = Console.ReadLine()?.Trim().ToUpper() ?? "";

    Console.Write("Costo de uso: ");
    decimal costo = decimal.Parse(Console.ReadLine() ?? "0");

    if (!ValidadorPatente.EsValida(patente, anio, out var error))
    {
        Console.WriteLine($" Error: {error}");
        return;
    }



    int cantPuertas = 0;
    int capacidadCarga = 0;
    int cilindrada = 0;
    Marca marca = Marca.Ford; // valor por defecto
    Entidades.Color color = Entidades.Color.Negro;

    Console.Write("Marca (0=Ford, 1=Chevrolet,3=Honda,4=Fiat, ...): ");
    marca = (Marca)int.Parse(Console.ReadLine()!);

    Console.Write("Color (0=Rojo, 1=Negro, ...): ");
    color = (Entidades.Color)int.Parse(Console.ReadLine()!);


    if (tipo == "auto")
    {
        Console.Write("Cantidad de puertas: ");
        cantPuertas = int.Parse(Console.ReadLine()!);
    }
    else if (tipo == "camioneta")
    {
        Console.Write("Capacidad de carga (kg): ");
        capacidadCarga = int.Parse(Console.ReadLine()!);
    }
    else if (tipo == "moto")
    {
        Console.Write("Cilindrada (cc): ");
        cilindrada = int.Parse(Console.ReadLine()!);
    }


    Vehiculo v = tipo switch
    {
        "auto" => new Auto
        {
            Modelo = modelo,
            Anio = anio,
            Patente = patente,
            Marca = marca,
            Color = color,
            CantPuertas = cantPuertas
        },

        "camioneta" => new Camioneta
        {
            Modelo = modelo,
            Anio = anio,
            Patente = patente,
            Marca = marca,
            Color = color,
            CapacidadCarga = capacidadCarga
        },

        "moto" => new Moto
        {
            Modelo = modelo,
            Anio = anio,
            Patente = patente,
            Marca = marca,
            Color = color,
            Cilindrada = cilindrada
        },

        _ => throw new Exception("Tipo inválido.")
    };

    repo += v;
    Console.WriteLine(" Vehículo agregado.");
}

}