using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinario
{
    class Capibara
    {
        public int id { get; set; }
        public string nombre { get; }
        public int edad { get; }
        public string especie { get; }

        public void HacerRuido()
        {
            Console.WriteLine("cui cui");
        }
        public void CambiarDeDueño()
        {

        }
    }
}
