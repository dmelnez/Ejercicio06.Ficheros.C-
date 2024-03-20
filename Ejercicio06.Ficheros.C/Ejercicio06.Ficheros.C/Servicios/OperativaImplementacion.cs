using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06.Ficheros.C.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {

        MenuInterfaz me = new MenuImplementacion();

        string rutaFcihero = "C:\\Users\\dmelnez\\Desktop\\ActividadEjercicioC.txt";



        public void modificarUnFichero()
        {
            
            string[] lineasFichero = File.ReadAllLines(rutaFcihero);


            for (int i = 1; i < lineasFichero.Length; i++)
            {

                Console.WriteLine(lineasFichero[i]);

            }



            Console.WriteLine(lineasFichero.Length);
            Console.WriteLine("NUMERO DE LINEA A MODIFICAR: ");
            int lineaModificacion = Convert.ToInt32(Console.ReadLine());

            

            if (lineaModificacion > 0 && lineaModificacion <= lineasFichero.Length)
            {

              int seleccionMod =  me.menuModificacion();

                switch (seleccionMod)
                {

                    case 0:
                        try { 
                            Console.WriteLine("SE MODIFICARA UNA LINEA");
                            modificacionLinea(lineasFichero, lineaModificacion);
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                            Console.WriteLine("[INFO] -> SE HA PRODUCIDO UN ERROR");
                        }
                    break;

                    case 1:
                        try { 
                            Console.WriteLine("SE INSERTARA EN UNA LINEA");
                            insertarTexto(lineasFichero, lineaModificacion);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                            Console.WriteLine("[INFO] -> SE HA PRODUCIDO UN ERROR");
                        }
                        break;


                }
                   


            }

            else
            {
                Console.WriteLine("EL NUMERO DE LINEA, SE ENCUENTRA FUERA DE RANGO");
            }


           
        }


        private void modificacionLinea(string[] lineasFichero, int lineaModificacion)
        {
            Console.WriteLine("TEXTO POR EL QUE SE REEMPLAZARA");
            string textoRemplazado = Console.ReadLine();

            lineasFichero[lineaModificacion] = textoRemplazado;

            File.WriteAllLines(rutaFcihero, lineasFichero);



        }



        private void insertarTexto(string[] lineasFichero, int lineaModificacion)
        {

            Console.WriteLine("TEXTO A INSERTAR");
            string textoDeInsercion = Console.ReadLine();

            Console.WriteLine("POSICION DE LA LINEA ESPECIFICA");
            int posicionLineaInsercion = Convert.ToInt32(Console.ReadLine());

            if(posicionLineaInsercion <= lineasFichero[lineaModificacion].Length) {


                string textoInsertado = lineasFichero[lineaModificacion - 1].Insert(posicionLineaInsercion, textoDeInsercion);

                lineasFichero[lineaModificacion -1] = textoInsertado;

                File.WriteAllLines(rutaFcihero, lineasFichero);
            
            
            }

            else
            {

                Console.WriteLine("EL NUMERO DE LA POSICION, SE ENCUENTRA FUERA DE RANGO");

            }


        }








    }
}
