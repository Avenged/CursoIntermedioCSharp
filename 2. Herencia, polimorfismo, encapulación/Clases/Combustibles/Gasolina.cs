namespace HerenciaPolimorfismoEncapsulacion.Clases.Combustibles;

class Gasolina : CombustibleBase
{
    public Gasolina(double densidad, double poderCalorifico) : base("Gasolina", densidad, poderCalorifico)
    {
    }

    public static Gasolina Autos { get; } = new(0.23, 22);

    public override double CalcularEnergia()
    {
        return 0;
    }

    public override string DescribirCombustible()
    {
        return "...";
    }
}