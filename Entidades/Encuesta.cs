using System;
using System.Collections.Generic;

namespace PPAI_CU44_G1_3K6.Entidades
{
    public class Encuesta
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaFinVigencia { get; set; }
        public List<Pregunta> preguntas { get; set; }

        
        List<Encuesta> encuestas = new List<Encuesta> { };

        public (Encuesta, List<Pregunta>, List<List<RespuestaPosible>>) esEncuestaDeCliente(int idEncuesta)
        {
            Encuesta encuestaLlamada = new Encuesta();
            List<Pregunta> preguntas = new List<Pregunta>();
            List<List<RespuestaPosible>> respuestas = new List<List<RespuestaPosible>>();
            foreach(var encuesta in encuestas)
            {
                if(encuesta.id == idEncuesta)
                {
                    encuestaLlamada = encuesta;
                    foreach(var pregunta in encuesta.preguntas)
                    {
                        preguntas.Add(pregunta);
                        respuestas.Add(pregunta.listarRespuestasPosibles());
                    };
                }
            }
            return (encuestaLlamada, preguntas, respuestas);
        }
        public string getDescipcion()
        {
            return this.descripcion;
        }
        public List<string> obtenerDescripcionPregunta(List<Pregunta> preguntas)
        {
            List<string> descripcionPreguntas = new List<string>();
            foreach(var pregunta in preguntas)
            {
                descripcionPreguntas.Add(pregunta.getDescripcion());
            }
            return descripcionPreguntas;
        }

    }
}
