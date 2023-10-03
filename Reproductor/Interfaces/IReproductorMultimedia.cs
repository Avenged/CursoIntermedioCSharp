namespace Reproductor.Interfaces;

public interface IReproductorMultimedia
{
    void Reproducir();
    void Pausar();
    void Detener();
    void Avanzar(int segundos);
}
