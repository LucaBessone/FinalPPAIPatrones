using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPPAIPatrones.Iterator
{
    public interface IIterador<T>
    {
        void primero();
        void siguiente();
        Object actual();
        bool haTerminado();
        bool cumpleFiltro(List<T> filtros);
        

    }
}
