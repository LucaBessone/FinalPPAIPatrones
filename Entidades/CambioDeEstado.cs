using Microsoft.EntityFrameworkCore;
using PPAI_DSI_EntregaFinalPatrones.Entidades;
using System;
using System.Linq;

namespace PPAI_CU44_G1_3K6.Entidades
{
    public class CambioDeEstado
    {
        public int id { get; set; }
        public DateTime fechaHoraInicio { get; set; }
        public DateTime? fechaHoraFin { get; set; }
        public Estado estado { get; set; }

        public bool esEstadoInicial()
        {
            return this.estado.esIniciado();
        }
        public DateTime getFechaHoraInicio()
        {
            return this.fechaHoraInicio;
        }

        public string esUltimoEstado()
        {
            if(this.fechaHoraFin == null)
            {
                return this.estado.getNombre();
            }
            return string.Empty;
        }
    }
}
