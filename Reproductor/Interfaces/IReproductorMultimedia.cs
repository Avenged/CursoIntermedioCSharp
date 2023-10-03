namespace Reproductor.Interfaces;

/// <summary>
/// Define operaciones básicas para cualquier tipo de reproductor multimedia.
/// </summary>
public interface IReproductorMultimedia : IMedia
{
    void Retroceder(int segundos);
    void Avanzar(int segundos);
}
