namespace Reproductor.Interfaces;

/// <summary>
/// Define operaciones básicas para cualquier tipo de medio multimedia.
/// </summary>
public interface IMedia
{
    void Reproducir();
    void Pausar();
    void Detener();
}
