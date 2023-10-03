using Reproductor.Interfaces;

namespace Reproductor.Clases;

/// <summary>
/// Clase base para todos los reproductores multimedia.
/// </summary>
public abstract class ReproductorMultimediaBase : IReproductorMultimedia
{
    public void Reproducir()
    {
        Console.WriteLine("Reproduciendo...");
    }

    public void Pausar()
    {
        Console.WriteLine("Pausando...");
    }

    public abstract void Detener();
    public abstract void Retroceder(int segundos);
    public abstract void Avanzar(int segundos);
}
