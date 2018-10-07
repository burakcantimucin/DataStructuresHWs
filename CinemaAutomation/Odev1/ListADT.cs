using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    public abstract class ListADT
    {
        public Node Head;
        public int Size = 0;
        public abstract void InsertFirst(int value);
        public abstract void InsertPos(int position, Seyirci seyirci);
        public abstract void DeletePos(int position);
        public abstract String GetElement(int position);
    }
}
