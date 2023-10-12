using System.Diagnostics;

var tarea1 = () => ObtenerPersonasRegistradas();
var tarea2 = () => ObtenerStock();
var tarea3 = () => ObtenerProductos();

List<Func<Task>> lista_de_tareas = new()
{
    tarea1,
    tarea2,
    tarea3,
};

Stopwatch sw = Stopwatch.StartNew();

// Task.WhenAll crea una tarea que espera la finalizacion de todas las tareas en lista_de_tareas:
await Task.WhenAll(lista_de_tareas.Select(async x => await x()));
sw.Stop();

Console.WriteLine($"Terminó al menos 1 tarea despues de: {TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds).TotalSeconds} segundos");

await Task.Delay(10000);

await ProcesarX();

Console.WriteLine("Programa finalizado.");

async Task<List<string>> ObtenerPersonasRegistradas()
{
    await Task.Delay(6000);
    Console.WriteLine("ObtenerPersonasRegistradas terminado.");
    return new List<string>();
}

async Task ObtenerProductos()
{
    await Task.Delay(5000);
    Console.WriteLine("ObtenerProductos terminado.");
}

async Task ObtenerStock()
{
    await Task.Delay(5000);
    Console.WriteLine("ObtenerStock terminado.");
}

async Task ProcesarX()
{
    await Task.Delay(5000);
    Console.WriteLine("Se procesó el restante de operaciones.");
}