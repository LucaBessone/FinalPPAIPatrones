﻿namespace PPAI_CU44_G1_3K6.Entidades
{
    public class Estado
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public bool esIniciado()
        {
            return this.nombre.Equals("Inicial");
        }

        public string getNombre()
        {
            return this.nombre;
        }
    }
}
