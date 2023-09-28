using HerenciaPolimorfismoEncapsulacion.Clases.Vehiculos;
using HerenciaPolimorfismoEncapsulacion.Interfaces;

namespace HerenciaPolimorfismoEncapsulacion.Clases;

static class ControladorVehiculos
{
    public static void ActivarLimpiaParabrisas(Automovil automovil)
    {
        automovil.ActivarLimpiaParabrisas();
    }

    public static void Arrancar(VehiculoBase vehiculo)
    {
        vehiculo.Arrancar();
    }

    public static void Volar(IAereo aereo)
    {
        aereo.Volar();
    }

    public static void Moverse(ITransporte transporte)
    {
        transporte.Moverse();
    }
}
