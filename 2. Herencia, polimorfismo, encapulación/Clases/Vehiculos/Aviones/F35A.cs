using HerenciaPolimorfismoEncapsulacion.Interfaces;

namespace HerenciaPolimorfismoEncapsulacion.Clases.Vehiculos.Aviones;

class F35A : Avion
{
    public F35A(ICombustible combustible) : base(combustible)
    {
    }
}
