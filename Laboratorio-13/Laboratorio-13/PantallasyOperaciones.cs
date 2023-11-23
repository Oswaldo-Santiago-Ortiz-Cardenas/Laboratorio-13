using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_13
{
    internal class PantallasyOperaciones
    {
        public static int contador = 0;
        public static int[] encuesta = new int[100];
        public static int contenc = 0;
        public static int opc1;
        public static int PantallaPrincipal()
        {
            Console.Clear();
            Console.WriteLine("" +
            "================================\n" +
            "Encuestas de calidad\n" +
            "================================\n" +
            "1: Realizar Encuesta\n" +
            "2: Ver datos registrados\n" +
            "3: Eliminar un dato\n" +
            "4: Ordenar datos de menor a mayor\n" +
            "5: Salir\n" +
            "================================\n");
            Console.Write("Ingrese una opcion: ");
            opc1 = int.Parse(Console.ReadLine());
            return opc1;
        }
        public static int EncuestasdeSatisfaccion()
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("" +
                "===================================\n" +
                "Nivel de Satisfacción\n" +
                "===================================\n" +
                "Qué tan satisfecho está con la\n" +
                "atención de nuestra tienda?\n" +
                "1: Nada satisfecho\n" +
                "2: No muy satisfecho\n" +
                "3: Tolerable\n" +
                "4: Satisfecho\n" +
                "5: Muy satisfecho\n" +
                "===================================\n");
                Console.Write("Ingrese una opción: ");
                opcion = int.Parse(Console.ReadLine());
                if (opcion >= 1 && opcion <= 5)
                {
                    if (contenc < encuesta.Length)
                    {
                        encuesta[contenc] = opcion;
                        contenc++;
                    }
                    else
                    {
                        Console.WriteLine("Ya has alcanzado el límite de encuestas.");
                    }
                    Console.Clear();
                    Console.WriteLine("" +
                    "===================================\n" +
                    "Nivel de Satisfacción\n" +
                    "===================================\n" +
                    "\n" +
                    "\n" +
                    "¡Gracias por participar!\n" +
                    "\n" +
                    "\n" +
                    "===================================\n" +
                    "Presione una tecla para\n" +
                    "regresar al menú...\n");
                    Console.ReadKey();
                }
            } while (opcion == null);
            return PantallaPrincipal();
        }
        public static int VerDatos()
        {
            Console.Clear();
            Console.WriteLine("" +
            "===================================\n" +
            "Ver datos registrados\n" +
            "===================================\n");
            int contPersonas = 0;
            for (int i = 0; i < contenc; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    Console.WriteLine();
                }
                Console.Write("[" + encuesta[i] + "]");
                contPersonas++;
            }
            int[] contSatisfaccion = new int[5];
            for (int i = 0; i < contenc; i++)
            {
                int nivel = encuesta[i] - 1;
                contSatisfaccion[nivel]++;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{contSatisfaccion[0]} personas: Nada satisfecho");
            Console.WriteLine($"{contSatisfaccion[1]} personas: No muy satisfecho");
            Console.WriteLine($"{contSatisfaccion[2]} personas: Tolerable");
            Console.WriteLine($"{contSatisfaccion[3]} personas: Satisfecho");
            Console.WriteLine($"{contSatisfaccion[4]} personas: Muy satisfecho");
            Console.WriteLine(""+
            "===================================\n"+
            "Presione una tecla para regresar...\n");
            Console.ReadKey();
            return PantallaPrincipal();
        }
        public static void Encuestas()
        {
            for (int i = 0; i < contenc; i++)
            {
                Console.Write($"{i:D3}: [{encuesta[i]}]  ");
                if ((i + 1) % 5 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void EliminarEnc(int posicion)
        {
            for (int i = posicion; i < contenc - 1; i++)
            {
                encuesta[i] = encuesta[i + 1];
            }
            contenc--;
        }
        public static int EliminarDatos()
        {
            Console.Clear();
            Console.WriteLine(""+
            "===================================\n"+
            "Eliminar un dato\n"+
            "===================================\n");
            Encuestas();
            Console.WriteLine("" +
            "===================================");
            Console.Write("Ingrese la posición a eliminar: ");
            int pos;
            while (!int.TryParse(Console.ReadLine(), out pos) || pos < 1 || pos > contenc)
            {
                Console.WriteLine("Posición no válida. Ingrese nuevamente:");
            }
            EliminarEnc(pos);
            Console.WriteLine("===================================");
            Encuestas();
            Console.WriteLine("===================================");
            Console.Write("Presione una tecla para regresar...");
            Console.ReadKey();
            return PantallaPrincipal();
        }
        public static int OrdenarDatos()
        {
            int[] datosOrdenados = new int[contenc];
            Array.Copy(encuesta, datosOrdenados, contenc);
            Array.Sort(datosOrdenados);
            Console.Clear();
            Console.WriteLine("" +
            "===================================\n" +
            "Ordenar datos\n" +
            "===================================\n");
            for (int i = 0; i < contenc; i++)
            {
                Console.Write($"{i:D3}: [{datosOrdenados[i]}]  ");
                if ((i + 1) % 5 == 0)
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("===================================\n");
            Console.Write("Presione una tecla para regresar ...");
            Console.ReadKey();
            return PantallaPrincipal();
        }
    }
}
