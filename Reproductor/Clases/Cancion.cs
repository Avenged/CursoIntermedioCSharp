namespace Reproductor.Clases;

public class Cancion
{
    public Cancion(string titulo, string artista, int año, string album, int duracion, string genero)
    {
        Titulo = titulo;
        Artista = artista;
        Año = año;
        Album = album;
        Duracion = duracion;
        Genero = genero;
    }

    public string Titulo { get; }
    public string Artista { get; }
    public int Año { get; }
    public string Album { get; }
    public int Duracion { get; }
    public string Genero { get; }
}
