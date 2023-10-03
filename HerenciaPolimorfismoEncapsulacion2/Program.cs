using CuentasBancarias;
using HerenciaPolimorfismoEncapsulacion2;
using Reproductor.Clases;

//var cuenta = new CuentaBancaria();
//cuenta.Depositar(1000);
//cuenta.Depositar(10);

//Console.WriteLine(cuenta.ConsultarSaldo());

//IPrueba prueba = new Prueba();
//prueba.Imprimir();

Cancion afterlife = new("Afterlife", "Avenged Sevenfold", 2009, "Avenged Sevenfold", 5, "Heavy Metal");
Cancion gunslinger = new("Gunslinger", "Avenged Sevenfold", 2009, "Avenged Sevenfold", 5, "Heavy Metal");

Cancion[] cancionesEnArray = new Cancion[3];
List<Cancion> cancionesEnLista = new List<Cancion>();

ReproductorMP3 reproductorMp3 = new();

reproductorMp3.AñadirCancion(afterlife);
reproductorMp3.AñadirCanciones(cancionesEnArray);
reproductorMp3.AñadirCanciones(cancionesEnLista);

reproductorMp3.Reproducir(afterlife);

Console.ReadKey();

reproductorMp3.Reproducir(gunslinger);
