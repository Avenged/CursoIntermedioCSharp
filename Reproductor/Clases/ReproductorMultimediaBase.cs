using Reproductor.Interfaces;

namespace Reproductor.Clases;

public abstract class ReproductorMultimediaBase : IMedia, IReproductorMultimedia
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
    public abstract void Avanzar(int segundos);
}
