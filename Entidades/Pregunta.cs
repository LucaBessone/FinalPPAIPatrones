using Microsoft.EntityFrameworkCore;
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
            var db = new AppDbContext();
            var preg = db.Pregunta.Include(p => p.respuesta).Where(x => x.id == id).FirstOrDefault();
            preg = (from p in db.Pregunta
                       where p.id == id
                       select new Pregunta
                       {
                           id = p.id,
                           pregunta = p.pregunta,
                           respuesta = p.respuesta.Select(rp => new RespuestaPosible
                           {
                               id = rp.id,
                               descripcion = rp.descripcion
                           }).ToList()
                       }).First();
            return preg;
        }
    }
}
