using Ejercicio06.Ficheros.C.Servicios;

namespace Ejercicio06.Ficheros.C.Controladores
{

    class Program
    {

        static void Main(string[] args)
        {
            

            OperativaInterfaz op = new OperativaImplementacion();

            bool cerrarAplicacion = false;


            try
            {

                op.modificarUnFichero();

            }   

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("[INFO] -> SE HA PRODUCIDO UN ERROR");
            }



        }         
     }


}