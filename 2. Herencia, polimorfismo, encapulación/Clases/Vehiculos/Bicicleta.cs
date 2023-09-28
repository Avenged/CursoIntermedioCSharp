using HerenciaPolimorfismoEncapsulacion.Interfaces;

namespace HerenciaPolimorfismoEncapsulacion.Clases.Vehiculos;

class Bicicleta : VehiculoBase, ITransporte
{
    public int NumeroRuedas { get; set; }
    public int Velocidades { get; set; }

    public void Moverse()
    {
        Console.WriteLine("La bicicleta se mueve por tierra.");
    }
}
