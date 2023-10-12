using System.Diagnostics;

// De esta forma cada tarea se ejecuta en un hilo diferente
//var tarea1 = () => Task.Run(ObtenerPersonasRegistradas);
//var tarea2 = () => Task.Run(ObtenerStock);
//var tarea3 = () => Task.Run(ObtenerProductos);

// De esta forma cada tarea se ejecuta en el mismo hilo haciendo uso de la concurrencia
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
    Console.WriteLine("ObtenerPersonasRegistradas se está ejecutando en el hilo id: " + Environment.CurrentManagedThreadId);
    await Task.Delay(6000);
    Console.WriteLine("ObtenerPersonasRegistradas terminado.");
    return new List<string>();
}

async Task ObtenerProductos()
{
    Console.WriteLine("ObtenerProductos se está ejecutando en el hilo id: " + Environment.CurrentManagedThreadId);
    await Task.Delay(5000);
    Console.WriteLine("ObtenerProductos terminado.");
}

async Task ObtenerStock()
{
    Console.WriteLine("ObtenerStock se está ejecutando en el hilo id: " + Environment.CurrentManagedThreadId);
    await Task.Delay(5000);
    Console.WriteLine("ObtenerStock terminado.");
}

async Task ProcesarX()
{
    await Task.Delay(5000);
    Console.WriteLine("Se procesó el restante de operaciones.");
}