using Reproductor.Interfaces;

namespace Reproductor.Clases;

/// <summary>
/// Clase base para todos los reproductores multimedia.
/// </summary>
public abstract class ReproductorMultimediaBase : IReproductorMultimedia
{
    public abstract void Reproducir();
    public abstract void Pausar();
    public abstract void Detener();
    public abstract void Retroceder(int segundos);
    public abstract void Avanzar(int segundos);
}
