using HerenciaPolimorfismoEncapsulacion.Interfaces;

namespace HerenciaPolimorfismoEncapsulacion.Clases;

abstract class CombustibleBase : ICombustible
{
    public string Nombre { get; protected set; }

    /// <summary>
    /// En kg/m³.
    /// </summary>
    public double Densidad { get; protected set; }

    /// <summary>
    /// En kJ/kg.
    /// </summary>
    public double PoderCalorifico { get; protected set; }

    // Constructor
    protected CombustibleBase(string nombre, double densidad, double poderCalorifico)
    {
        Nombre = nombre;
        Densidad = densidad;
        PoderCalorifico = poderCalorifico;
    }

    // Método abstracto para calcular la energía liberada durante la combustión
    public abstract double CalcularEnergia();

    // Método abstracto para describir el tipo de combustible
    public abstract string DescribirCombustible();
}
