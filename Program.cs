using CursoIntermedioCSharp.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

/* Aqu� se a�aden los servicios que ser�n inyectados autom�ticamente
 * en nuestra aplicaci�n. Esto se hace para seguir el patr�n de dise�o conocido
 * como inyecci�n de dependencias. Y en este lugar especificamente estamos
 * agregando los servicios en el contenedor de dependencias.
 */
#region Contenedor de dependencias

#region �Qu� es la inyecci�n de dependencias?
/* Inyecci�n de Dependencias (DI - Dependency Injection):

La Inyecci�n de Dependencias es un principio de dise�o y un patr�n de programaci�n que se utiliza 
en la programaci�n orientada a objetos y en otros paradigmas de programaci�n. Su objetivo principal 
es reducir las dependencias entre componentes de un sistema, lo que hace que el c�digo sea m�s 
flexible, mantenible y f�cil de probar.

La idea central de la DI es que los objetos no deben crear sus propias dependencias, sino que se 
les deben proporcionar desde el exterior (inyectar) a trav�s de alg�n mecanismo. Esto se hace 
para evitar que los objetos dependan directamente de otros objetos concretos, lo que los hace 
menos flexibles y m�s dif�ciles de probar. En su lugar, los objetos dependen de abstracciones o 
interfaces, y estas dependencias son inyectadas en el objeto en tiempo de ejecuci�n.

En resumen, DI es un principio de dise�o que se utiliza para gestionar las dependencias entre 
componentes de un sistema de manera m�s eficiente y flexible.

Contenedor de Inyecci�n de Dependencias (DI Container):

Un Contenedor de Inyecci�n de Dependencias (DI Container) es una herramienta o biblioteca que 
facilita la implementaci�n de la Inyecci�n de Dependencias en una aplicaci�n. Estos 
contenedores ayudan a gestionar la creaci�n y la resoluci�n de dependencias de manera autom�tica.

En lugar de que los desarrolladores tengan que crear manualmente todas las instancias de objetos 
y gestionar las dependencias, un DI Container se encarga de ello. El contenedor almacena 
configuraciones sobre c�mo se deben crear y resolver objetos y sus dependencias. Cuando un 
componente necesita una dependencia, el DI Container se encarga de proporcionarla autom�ticamente, 
bas�ndose en las configuraciones predefinidas. */
#endregion

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
#endregion

var app = builder.Build();

/* Aqu� se configurean los middlewares de nuestra aplicaci�n. Recordar
 * que el orden en que estan es importante, ya que las solicitudes pasan
 * por el orden que estamos indicando ac� abajo.
 */
#region Configuraci�n de Middlewares

#region �Qu� son los middlewares
/* En C# y en el contexto de aplicaciones web y API, un middleware es una componente de software 
 * que procesa las solicitudes HTTP entrantes y las respuestas salientes. Los middlewares act�an 
 * como tuber�as o capas intermedias entre el cliente y el servidor, permitiendo realizar tareas 
 * espec�ficas en el procesamiento de solicitudes y respuestas. Los middlewares se utilizan 
 * com�nmente en el framework ASP.NET Core para construir aplicaciones web.
 
 * Aqu� hay algunos ejemplos de tareas 
 * que un middleware puede realizar:
 
 * Logging (registro): Un middleware puede registrar informaci�n sobre cada solicitud entrante y 
 * respuesta saliente, lo que es �til para la depuraci�n y el monitoreo de la aplicaci�n.

 * Autenticaci�n y autorizaci�n: Los middlewares pueden realizar la autenticaci�n de usuarios y 
 * verificar los permisos antes de permitir el acceso a una solicitud.

 * Compresi�n de respuesta: Un middleware puede comprimir el contenido de la respuesta antes de 
 * enviarlo al cliente para reducir el ancho de banda.

 * Enrutamiento: Los middlewares pueden inspeccionar la URL de la solicitud y enrutarla a diferentes 
 * controladores o acciones en funci�n de las reglas definidas.

 * Caching (almacenamiento en cach�): Pueden almacenar en cach� respuestas para acelerar futuras 
 * solicitudes similares.

 * Manejo de errores: Los middlewares pueden capturar excepciones no controladas y proporcionar 
 * respuestas de error personalizadas.

 * Seguridad: Pueden implementar medidas de seguridad como la protecci�n contra ataques 
 * CSRF (Cross-Site Request Forgery) o XSS (Cross-Site Scripting).
 */
#endregion

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
#endregion

app.Run();