using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
  public abstract  class Collection
    {
        public abstract Iterator CreateIterator();
        public abstract void  Agregar(Item item);
        public abstract Item Index(int i);

        public abstract int Count ();

        public abstract int Posicion();
    }
}
