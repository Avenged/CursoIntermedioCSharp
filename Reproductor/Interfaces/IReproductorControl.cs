namespace Reproductor.Interfaces;

/// <summary>
/// Reproductor que es capaz de encenderse y apagarse.
/// </summary>
public interface IReproductorControl
{
    void Apagar();
    void Encender();
}
