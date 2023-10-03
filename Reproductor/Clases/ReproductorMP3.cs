using Reproductor.Interfaces;

namespace Reproductor.Clases;

public class ReproductorMP3 : ReproductorMultimediaBase, IReproductorControl
{
    private Cancion _cancionReproduciendo;
    private HashSet<Cancion> _canciones = new();

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
