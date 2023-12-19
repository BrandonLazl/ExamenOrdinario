using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinario
{

    public enum temperamento
    {
      
    }
    class Gato
    {
        public int id { get; set; }
        public string nombre { get; }
        public int edad { get; }
        public string especie { get; }

        public void HacerRuido()
        {
            Console.WriteLine("miau miau");
        }
        public void CambiarDeDueño()
        {

        }
        public void ResponderAcaricia()
        {
          
        }
    }
}
