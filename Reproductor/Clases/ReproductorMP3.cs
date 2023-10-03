using Reproductor.Interfaces;

namespace Reproductor.Clases;

public class ReproductorMP3 : ReproductorMultimediaBase, IReproductorControl
{
    private Cancion _cancionReproduciendo;

    // HashSet: El tipo de lista HashSet se asegura de que no se repita la misma canción en la lista.
    // readonly: Agregamos la palabra reservada readonly para indicar que no se va a reasignar este campo.
    private readonly HashSet<Cancion> _canciones = new();

    // Retornamos un IEnumerable del tipo Cancion para ser más flexibles. Además, solo queremos que el usuario
    // enumere las canciones, no que agregue ni elimine.
    public IEnumerable<Cancion> ObtenerCanciones()
    {
        return _canciones;
    }

    public void Reproducir(Cancion cancion)
    {
        _cancionReproduciendo = cancion;

        Console.WriteLine($"Reproduciendo canción: {cancion.Titulo}.");

        int segundosReproducidos = 0;
        while (segundosReproducidos < cancion.Duracion)
        {
            Console.WriteLine($"Segundo {segundosReproducidos}");
            segundosReproducidos++;

            // Con Thread.Sleep logramos que la aplicación se detenga la cantidad de segundos que le pasamos como argumento.
            // En este caso la aplicación se "dormirá" 1 segundo.
            Thread.Sleep(1000);
        }

        _cancionReproduciendo = null;
    }

    public void AñadirCancion(Cancion cancion)
    {
        _canciones.Add(cancion);
    }

    public void AñadirCanciones(IEnumerable<Cancion> canciones)
    {
        foreach (var cancion in canciones)
        {
            _canciones.Add(cancion);
        }
    }

    public override void Detener()
    {
        Console.WriteLine("Deteniendo la reproducción de MP3.");
    }

    public override void Retroceder(int segundos)
    {
        Console.WriteLine($"Retrocediendo {segundos} segundos en el reproductor de MP3.");
    }

    public override void Avanzar(int segundos)
    {
        Console.WriteLine($"Avanzando {segundos} segundos en el reproductor de MP3.");
    }

    public void Apagar()
    {
        Console.WriteLine("Apagando MP3...");
    }

    public void Encender()
    {
        Console.WriteLine("Encendiendo MP3...");
    }
}
