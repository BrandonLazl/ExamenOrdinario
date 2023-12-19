using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinario
{
   class Mascota
    {
        public int id { get; set; }
        public string nombre { get;}
        public string temperamento { get; set; }
        public int edad { get;}
        public string especie { get;}

        public void HacerRuido()
        {
            if (especie == "Perro")
            {
                Console.WriteLine("guau guau");
            }
            else if (especie == "Gato")
            {
                Console.WriteLine("miau miau");
            }
            else if (especie== "Capibara")
            {
                Console.WriteLine("cui cui");
            }
        }
        public void CambiarDeDueño()
        {

        }
    }
}
