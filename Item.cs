using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
   public class Item
    {
        private string nombre;
        public string Nombre { get; set; }

        public Item(string _nombre)
        {
            Nombre = _nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }


    }
}
