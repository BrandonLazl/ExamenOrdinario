using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinario
{
     class Program
    {
        static void Main(string[] args)
        {
              while (true) 
          {

  Console.WriteLine(" --------------- M E N U ---------------");
  Console.WriteLine("|[1] -      Administracion del centro    |");
  Console.WriteLine("|[2] -    Administracion de adopciones   |");
  Console.WriteLine("|[3] - Administracion de bienestar animal|");
  Console.WriteLine("|[4] -     Simulación de interacciones   |");
  Console.WriteLine("|[5] -         Finalizar programa        |");
  Console.WriteLine(" ----------------------------------------");

  int respuesta = int.Parse(Console.ReadLine());

  switch (respuesta)
  {

      case 1:

          AdministracionCentro();

          break;

   }
  
  }

            void AdministracionCentro(bool checkWhile = true)

            {
            
            }
    }
}
