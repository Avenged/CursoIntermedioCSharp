using NAudio.Wave;
using Reproductor.Interfaces;
using System.Media;

namespace Reproductor.Clases;

public class ReproductorMP3 : ReproductorMultimediaBase, IReproductorControl
{
    private Cancion _cancionReproduciendo;
    private WaveOutEvent current;

    // HashSet: El tipo de lista HashSet se asegura de que no se repita la misma canción en la lista.
    // readonly: Agregamos la palabra reservada readonly para indicar que no se va a reasignar este campo.
    private readonly HashSet<Cancion> _canciones = new();

    // Retornamos un IEnumerable del tipo Cancion para ser más flexibles. Además, solo queremos que el usuario
    // enumere las canciones, no que agregue ni elimine.
    public IEnumerable<Cancion> ObtenerCanciones()
    {
        return _canciones;
    }

    public override void Reproducir()
    {
        try
        {
            using var mp3Reader = new Mp3FileReader("./Canciones/03 - Doing Time.mp3");
            using var outputDevice = new WaveOutEvent();
            outputDevice.Init(mp3Reader);
            outputDevice.Play();

            current = outputDevice;

            // Mantener la aplicación en ejecución hasta que se complete la reproducción
            while (outputDevice.PlaybackState == PlaybackState.Playing)
            {
                Thread.Sleep(1000);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al reproducir el archivo: " + ex.Message);
        }
    }

    public override void Pausar()
    {
        current?.Pause();
    }

    public void Reproducir(Cancion cancion)
    {
    
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
