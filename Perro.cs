using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinario
{
    class Perro: IAcariciable
    {
          public int id { get; set; }
        public string nombre { get; }
        public int edad { get; }
        public string especie { get; }

        public void HacerRuido()
        {
            Console.WriteLine("guau guau");
        }
        public void CambiarDeDueño()
        {

        }
        public void ResponderAcaricia()
        {
            Console.WriteLine($"{nombre} se pone feliz y mueve la cola :)");
        }
    }
}
