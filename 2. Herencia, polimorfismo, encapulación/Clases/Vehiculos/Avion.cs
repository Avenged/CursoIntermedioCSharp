using HerenciaPolimorfismoEncapsulacion.Interfaces;

namespace HerenciaPolimorfismoEncapsulacion.Clases.Vehiculos;

class Avion : VehiculoBase, ITransporte, IAereo
{
    public Avion(ICombustible combustible)
    {
        Combustible = combustible;
    }

    public ICombustible Combustible { get; }

    public void Moverse()
    {
        Console.WriteLine("El avión se mueve por aire.");
    }

    public void Volar()
    {
        Console.WriteLine("El avión está volando!!.");
    }
}
