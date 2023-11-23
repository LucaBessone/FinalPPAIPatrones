using PPAI_CU44_G1_3K6.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPPAIPatrones.Iterator
{
    internal class IteradorCambioEstado : IIterador<DateTime>
    {

        public IteradorCambioEstado(List<CambioDeEstado> elements)
        {
            this.cambios = elements;
        }

        List<CambioDeEstado> cambios { get; set; }
        int puntero { get; set; }


        public object actual()
        {
             return cambios[puntero];
        }

        public bool cumpleFiltro(List<DateTime> fechas)
        {
            if (cambios[puntero].esEstadoInicial())
            {
                var fechaHoraInicioEstado = cambios[puntero].getFechaHoraInicio();
                if (DateTime.Compare(fechaHoraInicioEstado, fechas[0]) > 0 && DateTime.Compare(fechaHoraInicioEstado, fechas[1]) < 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool haTerminado()
        {
            if (cambios.Count > puntero)
            {
                return false;
            }
            return true;
        }

        public void primero()
        {
            puntero=0;
        }

        public void siguiente()
        {
            puntero++;
        }
    }
}
