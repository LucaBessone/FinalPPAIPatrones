using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPPAIPatrones.Iterator
{
    public interface IAgregado<T1,T2>
    {
        IIterador<T2> crearIterador(List<T1> elements);
    }
}
