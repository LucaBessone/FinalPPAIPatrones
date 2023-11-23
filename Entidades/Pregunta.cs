using PPAI_DSI_EntregaFinalPatrones.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace PPAI_CU44_G1_3K6.Entidades
{
    public class Pregunta
    {
        public int id { get; set; }
        public string pregunta { get; set; }
        public List<RespuestaPosible> respuesta { get; set; }

        public Pregunta getDescripcionYRespuestaPosible(int id)
        {
            List<Pregunta> pregs = new List<Pregunta>();
            var db = new AppDbContext();
            var preg = db.Pregunta.Where(x => x.id == id).FirstOrDefault();
            return preg;
        }
    }
}
