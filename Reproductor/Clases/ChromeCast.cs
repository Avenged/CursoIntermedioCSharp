namespace Reproductor.Clases;

public class ChromeCast : ReproductorMultimediaBase
{
    public override void Avanzar(int segundos)
    {
        Console.WriteLine($"Avanzando {segundos} segundos desde el ChromeCast.");
    }

    public override void Detener()
    {
        Console.WriteLine($"Deteniendo reproducción.");
    }

    public override void Pausar()
    {
        throw new NotImplementedException();
    }

    public override void Reproducir()
    {
        throw new NotImplementedException();
    }

    public override void Retroceder(int segundos)
    {
        throw new NotImplementedException();
    }
}
