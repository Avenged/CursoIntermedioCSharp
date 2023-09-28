namespace HerenciaPolimorfismoEncapsulacion.Interfaces;

interface ICombustible
{
    public string Nombre { get; }

    /// <summary>
    /// En kg/m³.
    /// </summary>
    public double Densidad { get; }

    /// <summary>
    /// En kJ/kg.
    /// </summary>
    double PoderCalorifico { get; }

    // Método abstracto para calcular la energía liberada durante la combustión
    double CalcularEnergia();

    // Método abstracto para describir el tipo de combustible
    string DescribirCombustible();
}
