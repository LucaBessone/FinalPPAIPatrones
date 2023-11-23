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
            //var db = new AppDbContext();
            //var enc = db.Encuesta.Where(x=>x.id == idEncuesta).FirstOrDefault();
            Encuesta enc;
            using (var db = new AppDbContext())
            {
                enc = (from e in db.Encuesta
                            where e.id == idEncuesta
                            select new Encuesta
                            {
                                id = e.id,
                                descripcion = e.descripcion,
                                fechaFinVigencia = e.fechaFinVigencia,
                                preguntas = e.preguntas.Select(ce => new Pregunta
                                {
                                    id = ce.id,
                                    pregunta = ce.pregunta,
                                    respuesta = ce.respuesta,
                                }).ToList(),
                            }).FirstOrDefault();
            }
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
