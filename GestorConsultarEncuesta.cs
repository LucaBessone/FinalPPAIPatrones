using PPAI_CU44_G1_3K6.Entidades;
using PPAI_DSI_EntregaFinalPatrones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPPAIPatrones
{
    internal static class GestorConsultarEncuesta
    {
        public static PantallaConsultarEncuesta pantalla { get; set; }
        public static List<Llamada> llamadasPeriodo { get; set; }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            pantalla = new PantallaConsultarEncuesta();
            Application.Run(pantalla);
        }

        public static void tomarOpcionCE()
        {
            pantalla.solicitarPeriodo();
        }

        public static void tomarPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {

            List<Llamada> lista = buscarLlamadasConEncRespondidas(fechaInicio, fechaFin);
            llamadasPeriodo = lista;
            pantalla.mostrarLlamadasDelPeriodo(lista);
        }

        public static List<Llamada> buscarLlamadasConEncRespondidas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Llamada> llamadas;
            using (var db = new AppDbContext())
            {
                llamadas = (from l in db.Llamada 
                            select new Llamada
                            {
                                id = l.id,
                                descripcionOperador = l.descripcionOperador,
                                detalleAccionRequerida = l.detalleAccionRequerida,
                                duracion = l.duracion,
                                encuestaEnviada = l.encuestaEnviada,
                                observacionAuditor = l.observacionAuditor,
                                cliente = l.cliente,
                                cambioDeEstado = l.cambioDeEstado.Select(ce => new CambioDeEstado
                                                                {
                                                                    id = ce.id,
                                                                    fechaHoraInicio = ce.fechaHoraInicio,
                                                                    fechaHoraFin = ce.fechaHoraFin,
                                                                    estado = ce.estado
                                                                }).ToList(),
                                respuestaDeCliente = l.respuestaDeCliente,
                            }).ToList();
            }

            List<Llamada> llamadasPeriodo = new List<Llamada>();
            foreach (var llamada in llamadas)
            {
                if ((llamada.tieneEncRespondidas(fechaInicio, fechaFin)))
                {
                    llamadasPeriodo.Add(llamada);
                }
            }
            return llamadasPeriodo;
        }

        public static /*Llamada*/void tomarSeleccionLlamada(int seleccionadoLlamada)
        {
            //Llamada seleccion = llamadasPeriodo.Where(x => x.cliente.numeroCelular == seleccionadoLlamada).FirstOrDefault();
            //return obtenerDatosLlamada(seleccion);
        }

        public static /*Llamada*/void obtenerDatosLlamada(Llamada seleccion)
        {
            //var (nombreCompleto, estadoActual, duracion) = seleccion.getDatosLlamada();

            //Encuesta enc = new Encuesta();
            //var encuesta = enc.esEncuestaDeCliente(seleccion.encuestaEnviada.id);
            //var descripcion = encuesta.getDescipcion();

            //var preguntasRespuestas = encuesta.obtenerDescripcionPregunta();
            //List<string> respuestasCliente = new List<string>();
            //respuestasCliente = seleccion.obtenerRespuestas(preguntasRespuestas);
            //var contador = 0;
            //List<PreguntaRespuesta> preguntaRespuesta = new List<PreguntaRespuesta>();
            //foreach (string descripcion in descripcionPreguntas)
            //{
            //    PreguntaRespuesta pregRes = new PreguntaRespuesta
            //    {
            //        pregunta = descripcion,
            //        respuesta = respuestasCliente.ElementAt(contador)
            //    };
            //    preguntaRespuesta.Add(pregRes);
            //    contador++;
            //}
            //llamadaSeleccionada.preguntaRespuestas = preguntaRespuesta;
            //return llamadaSeleccionada;
        }
    }
}
