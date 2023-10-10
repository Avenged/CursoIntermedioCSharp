using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reproductor.Interfaces;

namespace ReproductorMP3App;

public class ReproductorControlManager
{
    private bool capturandoTeclas;
    private readonly IMedia media;

    public ReproductorControlManager(IMedia media)
    {
        this.media = media;
    }

    public void ComenzarCapturaTeclas()
    {
        capturandoTeclas = true;

        while (capturandoTeclas)
        {
            Console.WriteLine("Presione: (r) Reproducir - (p) Pausar - (d) Detener");
            Console.Write("> ");
            var key = Console.ReadKey();
            Console.WriteLine();
   
            switch (key.Key)
            {
                case ConsoleKey.R:
                    Task.Run(media.Reproducir);
                    break;
                case ConsoleKey.P:
                    Task.Run(media.Pausar);
                    break;
                case ConsoleKey.D:
                    Task.Run(media.Detener);
                    break;
                default:
                    break;
            }
        }
    }
}
