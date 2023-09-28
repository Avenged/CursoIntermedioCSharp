namespace HerenciaPolimorfismoEncapsulacion.Clases;

/// <summary>
/// Clase base para todos los vehículos.
/// </summary>
abstract class VehiculoBase
{
    public string? Color { get; protected set; }
    public string? Marca { get; protected set; }

    public virtual void Arrancar()
    {
        Console.WriteLine("El vehiculo arrancó.");
    }

    public virtual void Detenerse()
    {
        Console.WriteLine("El vehiculo se detuvo.");
    }
}