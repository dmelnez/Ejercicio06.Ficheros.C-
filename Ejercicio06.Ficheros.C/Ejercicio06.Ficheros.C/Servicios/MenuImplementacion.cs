using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06.Ficheros.C.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {


        public int menuModificacion()
        {

            Console.WriteLine("[0] -> MODIFICACION DE UNA LINEA");
            Console.WriteLine("[1] -> INSERTAR TEXTO");

            int seleccionModificacion = Convert.ToInt32(Console.ReadLine());

            return seleccionModificacion;


        }


    }
}
