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
             
            List<string> personas = new List<string>();
         
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

                     case 2:

                        AdmintracionDeAdopcion();

                     break;

                     case 3:



                     break;

                    default:
                        break;


             }
            
            }


            void AdministracionCentro(bool checkWhile = true, bool checkWhile_2 = true)

            {

                while (checkWhile)
                {

                    Console.WriteLine(" ------- A D M I N _ C E N T R O --------");
                    Console.WriteLine("|[1] -     Administracion de personas    |");
                    Console.WriteLine("|[2] -     Administracion de mascotas    |");
                    Console.WriteLine("|[3] -     Regresar a menú principal     |");
                    Console.WriteLine(" ----------------------------------------");

                    int respuesta_ADMINCentro = int.Parse(Console.ReadLine());

                    switch (respuesta_ADMINCentro)
                    {

                        case 1:

                            while (checkWhile_2) 
                            {
                                
                            Console.WriteLine(" ----- A D M I N _ P E R S O N A S ------");
                            Console.WriteLine("|[1] -     Mostrar todas las personas    |");
                            Console.WriteLine("|[2] -      Registrar persona nueva      |");
                            Console.WriteLine("|[3] -     Buscar persona por nombre     |");
                            Console.WriteLine("|[4] -         Examinar persona          |");
                            Console.WriteLine("|[5] -     Regresar al menu anterior     |");
                            Console.WriteLine(" ----------------------------------------");

                            int respuesta_ADMINPeronas = int.Parse(Console.ReadLine());

                            switch (respuesta_ADMINPeronas)
                            {

                                case 1:
                                      Console.Writeline($"personas");
                                    break;

                                case 2:
                                             Persona persona = new Persona();
                                        personas.Add(persona.nombre);
                                    break;

                                case 3:
                                    break;

                                case 4:
                                    break;

                                case 5:

                                        checkWhile_2 = false;

                                    break;

                                default:

                                    Console.WriteLine("Ingrese un numero valido >:(");

                                    break;
                                } 
                            
                            
                            }

                        break;

                        case 2:

                            Console.WriteLine(" ----- A D M I N _ M A S C O T A S ------");
                            Console.WriteLine("|[1] -     Mostrar todas las mascotas    |");
                            Console.WriteLine("|[2] -      Registrar mascota nueva      |");
                            Console.WriteLine("|[3] -     Buscar mascota por nombre     |");
                            Console.WriteLine("|[4] -    Buscar mascota por especie     |");
                            Console.WriteLine("|[5] -     Regresar al menu anterior     |");
                            Console.WriteLine(" ----------------------------------------");

                            switch (respuesta_ADMINCentro)
                            {

                                case 1:
                                    break;

                                case 2:
                                    break;

                                case 3: 
                                    break;

                                case 4:
                                    break;

                                case 5:

                                    checkWhile_2 = false;

                                    break;
                
                                default:
                                    break;
                            }

                            break;

                        case 3:

                            checkWhile = false;

                            break;

                        default:

                            Console.WriteLine("Ingrese un numero valido >:(");

                            break;
                  
                    }

                }
                

            }

            void AdmintracionDeAdopcion(bool checkWhile = true)
            {
                while (checkWhile) 
                {
                
                Console.WriteLine(" --- A D M I N _ A D O P C I O N E S ----");
                Console.WriteLine("|[1] - Mascotas disponibles por adoptar  |");
                Console.WriteLine("|[2] -          Adoptar mascota          |");
                Console.WriteLine("|[3] -    Regresar a la menú anterior    |");
                Console.WriteLine(" ----------------------------------------");

                int respuesta = int.Parse(Console.ReadLine());

                switch (respuesta)
                {

                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:

                            checkWhile = false;

                        break;

                    default:

                        Console.WriteLine("Ingrese un numero valido >:(");

                        break;
                    }
                
                
                }
                

            }


        }        

    }

}
