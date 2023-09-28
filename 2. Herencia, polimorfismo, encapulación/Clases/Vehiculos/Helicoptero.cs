using HerenciaPolimorfismoEncapsulacion.Interfaces;

namespace HerenciaPolimorfismoEncapsulacion.Clases.Vehiculos;

class Helicoptero : ITransporte, IAereo
{
    public Helicoptero(ICombustible combustible)
    {
        Combustible = combustible;
    }

    public ICombustible Combustible { get; }

    public void Moverse()
    {
        Console.WriteLine("El helicoptero se mueve por aire.");
    }

    public void Volar()
    {
        Console.WriteLine("El helicoptero está volando!!.");
    }
}
