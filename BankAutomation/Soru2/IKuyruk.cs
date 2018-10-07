using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    public interface IKuyruk
    {
        void Insert(Musteri m);
        object Remove();
        object Peek();
        Boolean IsEmpty();
    }
}
