namespace HerenciaPolimorfismoEncapsulacion.Clases.Combustibles;

class Queroseno : CombustibleBase
{
    public Queroseno(double densidad, double poderCalorifico) : base("Queroseno", densidad, poderCalorifico)
    {
    }

    /// <summary>
    /// Este tipo de queroseno es especial para aviones.
    /// </summary>
    /// <remarks>
    /// • Densidad: 0.78 (kg/m³) <br/>
    /// • Poder calorífico: 42 (kJ/kg)
    /// </remarks>
    public static Queroseno JetA { get; } = new(0.78, 42);

    public override double CalcularEnergia()
    {
        return 0;
    }

    public override string DescribirCombustible()
    {
        return "...";
    }
}
