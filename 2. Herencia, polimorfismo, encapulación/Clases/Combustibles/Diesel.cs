namespace HerenciaPolimorfismoEncapsulacion.Clases.Combustibles;

class Diesel : CombustibleBase
{
    public static Diesel Instancia { get; } = new();

    private Diesel() : base("Diesel", 100, 200)
    {
    }

    public override double CalcularEnergia()
    {
        return 0;
    }

    public override string DescribirCombustible()
    {
        return "...";
    }
}
