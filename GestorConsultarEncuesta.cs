using PPAI_CU44_G1_3K6.Entidades;
using PPAI_DSI_EntregaFinalPatrones.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
                                respuestaDeCliente = l.respuestaDeCliente.Select(rc => new RespuestaDeCliente
                                                                {
                                                                    id = rc.id,
                                                                    fechaEncuesta = rc.fechaEncuesta,
                                                                    respuestaPosible = rc.respuestaPosible,
                                                                }).ToList(),
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

        public static void tomarSeleccionLlamada(long seleccionadoLlamada)
        {
            Llamada seleccion = llamadasPeriodo.Where(x => x.cliente.numeroCelular == seleccionadoLlamada).FirstOrDefault();
            /*return*/ obtenerDatosLlamada(seleccion);
        }

        public static void obtenerDatosLlamada(Llamada seleccion)
        {
            var (nombreCompleto, estadoActual, duracion) = seleccion.getDatosLlamada();

            Encuesta enc = new Encuesta();
            var encuesta = enc.esEncuestaDeCliente(seleccion.encuestaEnviada.id);
            var descripcion = encuesta.getDescipcion();

            var preguntasRespuestas = encuesta.obtenerDescripcionPregunta();
            var (preguntasCliente, respuestasCliente) = seleccion.obtenerRespuestas(preguntasRespuestas);

            pantalla.mostrarDatosDeLlamada(nombreCompleto,estadoActual,duracion.ToString(),descripcion,preguntasCliente,respuestasCliente);
            pantalla.mostrarOpcionDeImpresion();
        }
        public static void tomarOpcionDeImpresion(string nombreCompleto, string estadoActual, string duracion, string descripcionEncuesta, List<string> preguntas, List<string> respuestas)
        {
            generarCSV(nombreCompleto, estadoActual, duracion, descripcionEncuesta, preguntas, respuestas);
        }
        public static void generarCSV(string nombreCompleto, string estadoActual, string duracion, string descripcionEncuesta, List<string> preguntas, List<string> respuestas)
        {
            string csv = nombreCompleto.ToString() + "," + estadoActual.ToString() + "," + duracion.ToString();
            var contador = 0;
            foreach (var pregunta in preguntas)
            {
                string pregRes = "\n►" + pregunta + "," + respuestas[contador] + "◄";
                csv = string.Concat(csv, pregRes);
                contador++;
            }
            guardarCSV(csv);
        }
        public static void guardarCSV(string csv)
        {
            string ruta = @"H:\\PPAI-DSI-EntregaFinalPatrones\\llamada.csv";
            using (FileStream fileStream = File.Create(ruta))
            {
                string contiene = csv;
                byte[] data = Encoding.UTF8.GetBytes(contiene);
                fileStream.Write(data, 0, data.Length);
            }
        }
    }
}
