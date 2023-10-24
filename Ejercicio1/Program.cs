/* Simulador de procesador de pagos: debes crear un programa (de consola) el cual debe generar 
 * 1000 números de tarjeta de crédito (deben ser aleatorios). Debes crear un método llamado 
 * "ProcesarPago(int numeroTarjeta)" el cual va a recibir como argumento un número de tarjeta 
 * de crédito, y debe simular que va a cobrar un monto a esa tarjeta (debes usar Task.Delay de 
 * 10 segundos para simular que está procesando). 
 * 
 * Sabemos que si no usamos async/await este proceso tardaría (10 segundos x 1000 tarjetas = 10.000 segundos) 
 * en procesar todas las tarjetas. 
 * 
 * Por lo tanto, debes usar async/await para procesar todos los pagos en el menor tiempo posible. 
 * Usa la clase StopWatch para medir cuanto tiempo tarda tu proceso e imprime con Console.WriteLine 
 * cuánto duró el proceso en completarse.
 */

using System.Diagnostics;

List<Func<int, Task>> listaDeTareas = new();

List<string> tarjetas = new()
{
    "1234-9390-1320-5679",
    "1234-9390-1320-5680",
    "1234-9390-1320-5681",
    "1234-9390-1320-5682",
};

var tasks = tarjetas.Select(numeroTarjeta => new Func<Task>(() => ProcesarPago(numeroTarjeta)));

Stopwatch sw = Stopwatch.StartNew();

//Espera la finalización de todas las tareas, pero se ejecutarán en paralelo.
await Task.WhenAll(tasks.Select(funcionQueDevuelveUnTask => funcionQueDevuelveUnTask()));

sw.Stop();
Console.WriteLine($"Programa terminado despues de {TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds).TotalSeconds} segundos.!!!");

async Task ProcesarPago(string numeroTarjeta)
{
    Random r = new();
    Console.WriteLine($"NumeroTarjeta: {numeroTarjeta} finalizado.");
    await Task.Delay(r.Next(1000, 4500));
}