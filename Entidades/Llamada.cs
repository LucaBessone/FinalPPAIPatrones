using PPAI_CU44_G1_3K6.ViewModel;
using System;
using System.Collections.Generic;

namespace PPAI_CU44_G1_3K6.Entidades
{
    public class Llamada
    {
        public int id { get; set; }
        public int descripcionOperador { get; set; }
        public int detalleAccionRequerida { get; set; }
        public int duracion { get; set; }
        public Encuesta encuestaEnviada { get; set; }
        public int observacionAuditor { get; set; }
        public Cliente cliente { get; set; }
        public List<CambioDeEstado> cambioDeEstado { get; set; }
        public List<RespuestaDeCliente> respuestaDeCliente { get; set; }

        public bool tieneEncRespondidas(DateTime fechaInicio, DateTime fechaFin)
        {
            foreach (var cambioDeEstado in this.cambioDeEstado)
            {
                if(esDePeriodo(cambioDeEstado, fechaInicio, fechaFin))
                {
                    return true;
                }
            }
            return false;
        }

        public bool esDePeriodo(CambioDeEstado cambioDeEstado, DateTime fechaInicio, DateTime fechaFin)
        {
            if (cambioDeEstado.esEstadoInicial())
            {
                var fechaHoraInicioEstado = cambioDeEstado.getFechaHoraInicio();
                if (DateTime.Compare(fechaHoraInicioEstado, fechaInicio) > 0 && DateTime.Compare(fechaHoraInicioEstado, fechaFin) < 0)
                {
                    return true;
                }
            }
            return false;
        }

        public (string,string,string) getDatosLlamada()
        {
            string nombreCompleto = getNombreClienteDeLaLlamada(this.cliente);
            string estadoActual = "";
            foreach(var cambioEstado in this.cambioDeEstado)
            {
                string estado = cambioEstado.esUltimoEstado();
                if (!(estado.Equals(string.Empty)))
                {
                    estadoActual = estado;
                    break;
                }
            }
            string duracion = getDuracion();
            return (nombreCompleto, estadoActual, duracion);
        }

        private string getDuracion()
        {
            var tiempo = this.duracion; //TimeSpan.FromMinutes(this.duracion);
            return tiempo + " minutos";//.ToString();
            //return tiempo.ToString("hh:mm:ss");
        }

        private string getNombreClienteDeLaLlamada(Cliente clienteLlamada)
        {
            return clienteLlamada.getNombre();
        }
        
        public (List<string>, List<string>) obtenerRespuestas(List<Pregunta> lista)
        {
            var preguntaCliente = new List<string>();
            var respuestasCliente = new List<string>();

            foreach (var preg in lista)
            {
                foreach (var respuesta in preg.respuesta)
                {
                    foreach(var respuestaCliente in this.respuestaDeCliente)
                    {
                        if (respuesta.id == respuestaCliente.respuestaPosible.id)
                        {
                            preguntaCliente.Add(preg.pregunta);
                            respuestasCliente.Add(respuesta.getDescripcionRespuesta());
                        }
                    }
                }
            }
            return (preguntaCliente,respuestasCliente);
        }
    }
}
