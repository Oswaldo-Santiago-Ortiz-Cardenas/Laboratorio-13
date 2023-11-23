using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_13
{
    public class Program
    {
        static void Main(string[] args)
        {
            PantallasyOperaciones.PantallaPrincipal();
            do
            {
                switch (PantallasyOperaciones.opc1)
                {
                    case 1:
                        PantallasyOperaciones.EncuestasdeSatisfaccion();
                        break;
                    case 2:
                        PantallasyOperaciones.VerDatos();
                        break;
                    case 3:
                        PantallasyOperaciones.EliminarDatos();
                        break;
                    case 4:
                        PantallasyOperaciones.OrdenarDatos();
                        break;
                }
            } while (PantallasyOperaciones.opc1 != 5);
        }
    }
}
