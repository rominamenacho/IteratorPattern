using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class ConcreteIterator : Iterator
    {
        private Item _item;
        private Collection _aggregate;

        public ConcreteIterator(Collection colection)
        {
            _aggregate = colection;
        }

        public override Item Current()
        {
            return _item;
        }

        public override void First()
        {
          _item= _aggregate.Index(0);
        }

        public override bool IsDone()
        {
            if(_aggregate.Count() == _aggregate.Posicion() + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Next()
        {
            _item = _aggregate.Index(_aggregate.Posicion() + 1);
        }
    }
}
