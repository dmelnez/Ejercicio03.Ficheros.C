namespace Ejercicio03.Ficheros.C
{

    class Program
    {

      public static void Main(string[] args)
        {
            string rutaArchivo = "C:\\Users\\dmelnez\\Desktop\\ActividadEjercicioC.txt";

            Console.WriteLine("NUMERO DE LINEA: ");
            int numeroLineaUsu = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("TEXTO A REEMPLAZAR: ");
            string textoAReemplazar = Console.ReadLine();


            try { 

            string[] numeroLineas = File.ReadAllLines(rutaArchivo);


             numeroLineas[numeroLineaUsu -1] = textoAReemplazar;



                File.WriteAllLines(rutaArchivo, numeroLineas);

            }

             catch (Exception ex)
            {

                Console.WriteLine("[INFO] -> Se ha Producido Un Fallo");

            }
        }


    }

}
