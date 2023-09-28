using HerenciaPolimorfismoEncapsulacion.Clases;
using HerenciaPolimorfismoEncapsulacion.Clases.Combustibles;
using HerenciaPolimorfismoEncapsulacion.Clases.Vehiculos;
using HerenciaPolimorfismoEncapsulacion.Interfaces;

VehiculoBase bmw = new Automovil(Gasolina.Autos, "BMW");
VehiculoBase bicicleta = new Bicicleta();
bmw.Arrancar();
bicicleta.Detenerse();

// Operaciones incorrectas ------------------------
//Automovil automovil = new Bicicleta();
//Bicicleta bicicleta = new Automovil();
//Automovil automovil2 = new Vehiculo();
//Bicicleta bicicleta2 = new Vehiculo();
//-------------------------------------------------

VehiculoBase ferrari = new Automovil(Gasolina.Autos, "Ferrari");
Automovil lamborgini = new Automovil(Gasolina.Autos, "Lamborgini");

IAereo avion = new Avion(Queroseno.JetA);
Helicoptero helicoptero = new Helicoptero(Queroseno.JetA);
IAereo cohete = new Cohete(Queroseno.JetA);

ControladorVehiculos.ActivarLimpiaParabrisas((Automovil)ferrari);
ControladorVehiculos.ActivarLimpiaParabrisas(lamborgini);

ControladorVehiculos.Volar(avion);
ControladorVehiculos.Volar(helicoptero);
ControladorVehiculos.Volar(cohete);
//ControladorVehiculos.Volar((ITransporte)cohete); <= Esto no se puede, porque el método espera un IAereo.

ControladorVehiculos.Moverse((ITransporte)avion);
ControladorVehiculos.Moverse(helicoptero);
ControladorVehiculos.Moverse((ITransporte)cohete);

