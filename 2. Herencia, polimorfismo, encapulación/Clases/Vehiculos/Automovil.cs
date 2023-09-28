using HerenciaPolimorfismoEncapsulacion.Interfaces;

namespace HerenciaPolimorfismoEncapsulacion.Clases.Vehiculos;

class Automovil : VehiculoBase, ITransporte
{
    public bool LimpiandoParabrisas { get; private set; }
    public int NumeroPuertas { get; set; }
    public string? TipoCombustible { get; set; }
    public ICombustible Combustible { get; }

    public Automovil(ICombustible combustible, string marca)
    {
        Marca = marca;
        Combustible = combustible;
    }

    public void DesactivarLimpiaParabrisas()
    {
        LimpiandoParabrisas = false;
        Console.WriteLine("Limpia parabrisas desactivado.");
    }

    public void ActivarLimpiaParabrisas()
    {
        LimpiandoParabrisas = true;
        Console.WriteLine("Limpia parabrisas activado.");
    }

    public void Moverse()
    {
        Console.WriteLine("El vehiculo se mueve por tierra.");
    }
}