using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class PortonAutomatico
    {
       
            // 🔹 CAMPO PRIVADO (protege el valor)
            private int apertura;

            // 🔹 PROPIEDAD CON VALIDACIÓN (0 a 100)
            public int Apertura
            {
                get { return apertura; }
                set
                {
                    if (value < 0)
                        apertura = 0;
                    else if (value > 100)
                        apertura = 100;
                    else
                        apertura = value;
                }
            }

            // 🔹 PROPIEDADES DERIVADAS
            public bool EstaCerrado => Apertura == 0;
            public bool EstaAbiertoCompleto => Apertura == 100;

            // 🔹 CONSTRUCTORES
            public PortonAutomatico()
            {
                Apertura = 0;
            }

            public PortonAutomatico(int aperturaInicial)
            {
                Apertura = aperturaInicial;
            }

            // =========================
            // 🔹 PARTE A - MÉTODOS
            // =========================

            public void Abrir()
            {
                if (EstaAbiertoCompleto)
                    Console.WriteLine("Ya está abierto al 100%");
                else
                    Apertura = 100;
            }

            public void Cerrar()
            {
                if (EstaCerrado)
                    Console.WriteLine("Ya está completamente cerrado");
                else
                    Apertura = 0;
            }

            public void MostrarEstado()
            {
                if (EstaCerrado)
                    Console.WriteLine("Cerrado");
                else if (EstaAbiertoCompleto)
                    Console.WriteLine("Abierto total (100%)");
                else
                    Console.WriteLine("Abierto parcial (" + Apertura + "%)");
            }

            // =========================
            // 🔹 PARTE B - SOBRECARGA
            // =========================

            public void Abrir(int porcentaje)
            {
                if (porcentaje < 1 || porcentaje > 99)
                {
                    Console.WriteLine("Porcentaje inválido. Debe ser 1–99.");
                    return;
                }

                Apertura = porcentaje;
            }

            public void AbrirPeatonal()
            {
                Apertura = 20;
            }

            // =========================
            // 🔹 PARTE C - MEJORAS
            // =========================

            public void Stop()
            {
                Console.WriteLine("Movimiento detenido");
            }

            public bool Toggle()
            {
                if (EstaCerrado)
                {
                    Apertura = 100;
                    return true;
                }
                else
                {
                    Apertura = 0;
                    return false;
                }
            }
        

    }
}
