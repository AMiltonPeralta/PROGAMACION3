using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PortonAutomatico p = new PortonAutomatico();

            for (int i = 0; i <= 100; i += 10)
            {
                p.Abrir(i);
                p.MostrarEstado();

                if (p.Apertura == 50)
                {
                    p.Stop();
                    break;
                }
            }
        }
    }
}
