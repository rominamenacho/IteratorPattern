using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
   public abstract class Iterator
    {
        public abstract void First();
        public abstract void Next();
        public abstract Item Current();
        public abstract bool IsDone();
    }
}
