using CursoIntermedioCSharp.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

/* Aquí se añaden los servicios que serán inyectados automáticamente
 * en nuestra aplicación. Esto se hace para seguir el patrón de diseño conocido
 * como inyección de dependencias. Y en este lugar especificamente estamos
 * agregando los servicios en el contenedor de dependencias.
 */
#region Contenedor de dependencias

#region ¿Qué es la inyección de dependencias?
/* Inyección de Dependencias (DI - Dependency Injection):

La Inyección de Dependencias es un principio de diseño y un patrón de programación que se utiliza 
en la programación orientada a objetos y en otros paradigmas de programación. Su objetivo principal 
es reducir las dependencias entre componentes de un sistema, lo que hace que el código sea más 
flexible, mantenible y fácil de probar.

La idea central de la DI es que los objetos no deben crear sus propias dependencias, sino que se 
les deben proporcionar desde el exterior (inyectar) a través de algún mecanismo. Esto se hace 
para evitar que los objetos dependan directamente de otros objetos concretos, lo que los hace 
menos flexibles y más difíciles de probar. En su lugar, los objetos dependen de abstracciones o 
interfaces, y estas dependencias son inyectadas en el objeto en tiempo de ejecución.

En resumen, DI es un principio de diseño que se utiliza para gestionar las dependencias entre 
componentes de un sistema de manera más eficiente y flexible.

Contenedor de Inyección de Dependencias (DI Container):

Un Contenedor de Inyección de Dependencias (DI Container) es una herramienta o biblioteca que 
facilita la implementación de la Inyección de Dependencias en una aplicación. Estos 
contenedores ayudan a gestionar la creación y la resolución de dependencias de manera automática.

En lugar de que los desarrolladores tengan que crear manualmente todas las instancias de objetos 
y gestionar las dependencias, un DI Container se encarga de ello. El contenedor almacena 
configuraciones sobre cómo se deben crear y resolver objetos y sus dependencias. Cuando un 
componente necesita una dependencia, el DI Container se encarga de proporcionarla automáticamente, 
basándose en las configuraciones predefinidas. */
#endregion

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
#endregion

var app = builder.Build();

/* Aquí se configurean los middlewares de nuestra aplicación. Recordar
 * que el orden en que estan es importante, ya que las solicitudes pasan
 * por el orden que estamos indicando acá abajo.
 */
#region Configuración de Middlewares

#region ¿Qué son los middlewares
/* En C# y en el contexto de aplicaciones web y API, un middleware es una componente de software 
 * que procesa las solicitudes HTTP entrantes y las respuestas salientes. Los middlewares actúan 
 * como tuberías o capas intermedias entre el cliente y el servidor, permitiendo realizar tareas 
 * específicas en el procesamiento de solicitudes y respuestas. Los middlewares se utilizan 
 * comúnmente en el framework ASP.NET Core para construir aplicaciones web.
 
 * Aquí hay algunos ejemplos de tareas 
 * que un middleware puede realizar:
 
 * Logging (registro): Un middleware puede registrar información sobre cada solicitud entrante y 
 * respuesta saliente, lo que es útil para la depuración y el monitoreo de la aplicación.

 * Autenticación y autorización: Los middlewares pueden realizar la autenticación de usuarios y 
 * verificar los permisos antes de permitir el acceso a una solicitud.

 * Compresión de respuesta: Un middleware puede comprimir el contenido de la respuesta antes de 
 * enviarlo al cliente para reducir el ancho de banda.

 * Enrutamiento: Los middlewares pueden inspeccionar la URL de la solicitud y enrutarla a diferentes 
 * controladores o acciones en función de las reglas definidas.

 * Caching (almacenamiento en caché): Pueden almacenar en caché respuestas para acelerar futuras 
 * solicitudes similares.

 * Manejo de errores: Los middlewares pueden capturar excepciones no controladas y proporcionar 
 * respuestas de error personalizadas.

 * Seguridad: Pueden implementar medidas de seguridad como la protección contra ataques 
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