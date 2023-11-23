using PPAI_DSI_EntregaFinalPatrones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PPAI_CU44_G1_3K6.Entidades
{
    public class Encuesta
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaFinVigencia { get; set; }
        public List<Pregunta> preguntas { get; set; }

        
        List<Encuesta> encuestas = new List<Encuesta> { };

        public Encuesta esEncuestaDeCliente(int idEncuesta)
        {
            var db = new AppDbContext();
            var enc = db.Encuesta.Where(x=>x.id == idEncuesta).FirstOrDefault();
            return enc;
        }
        public string getDescipcion()
        {
            return this.descripcion;
        }
        public List<Pregunta> obtenerDescripcionPregunta()
        {
            List<Pregunta> pregs = new List<Pregunta>();
            Pregunta preg = new Pregunta();
            foreach (Pregunta pregunta in this.preguntas)
            {
                pregs.Add(preg.getDescripcionYRespuestaPosible(pregunta.id));
            }

            return pregs;
        }

    }
}
