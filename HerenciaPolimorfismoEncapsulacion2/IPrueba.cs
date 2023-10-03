namespace HerenciaPolimorfismoEncapsulacion2;

public class Prueba : IPrueba
{
    public void Blabla()
    {
        throw new NotImplementedException();
    }

    public void Escribir()
    {
        throw new NotImplementedException();
    }

    public void Imprimir()
    {
        Console.WriteLine("Prueba!");
    }
}

internal interface IPrueba : IPrueba2, IPrueba3
{
    void Imprimir();
}

internal interface IPrueba2
{
    void Escribir();
}

internal interface IPrueba3
{
    void Blabla();
}