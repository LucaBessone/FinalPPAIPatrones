namespace PPAI_CU44_G1_3K6.Entidades
{
    public class RespuestaPosible
    {
        public int id { get;set;}
        public string descripcion { get; set; }


        public string getDescripcionRespuesta()
        {
            return this.descripcion;
        }
    }

}
