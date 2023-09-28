using HerenciaPolimorfismoEncapsulacion.Interfaces;

namespace HerenciaPolimorfismoEncapsulacion.Clases.Vehiculos;

class Cohete : VehiculoBase, ITransporte, IAereo
{
    public Cohete(ICombustible combustible)
    {
        Combustible = combustible;
    }

    public ICombustible Combustible { get; }

    public void Moverse()
    {
        Console.WriteLine("El cohete se mueve por aire.");
    }

    public void Volar()
    {
        Console.WriteLine("El cohete está volando!!.");
    }
}