using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class ConcreteCollection : Collection
    {
        private int _posicion;
        private List<Item> items   = new List<Item>();
        private Item _item;
        public ConcreteCollection()
        {
          
        }

        public override void Agregar(Item item)
        {
            items.Add(item);
        }

        public override int Count()
        {
           return items.Count();
        }

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public override Item Index(int i)
        {
            _item = items[i];
            _posicion = i;
            return _item;
        }

        public override int Posicion()
        {
            return _posicion;
        }
    }
}
