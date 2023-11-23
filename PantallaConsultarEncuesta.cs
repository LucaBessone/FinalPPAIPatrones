using PPAI_CU44_G1_3K6.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPPAIPatrones
{
    public partial class PantallaConsultarEncuesta : Form
    {
        public PantallaConsultarEncuesta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestorConsultarEncuesta.tomarOpcionCE();
        }

        public void solicitarPeriodo()
        {
            gb1.Visible = true;
        }

        private void btnTomarPeriodo_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = monthCalendar1.SelectionRange.Start;
            DateTime fechaFin = monthCalendar1.SelectionRange.End;
            GestorConsultarEncuesta.tomarPeriodo(fechaInicio, fechaFin);
        }

        public void mostrarLlamadasDelPeriodo(List<Llamada> llamadasPeriodo)
        {
            gb2.Visible = true;
            ddlLlamadas.DataSource = llamadasPeriodo.Select(llamada => llamada.cliente.numeroCelular).ToList(); ;
        }

        private void ddlLlamadas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
