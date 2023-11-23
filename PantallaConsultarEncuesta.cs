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
            ddlLlamadas.DataSource = llamadasPeriodo.Select(llamada => llamada.cliente.numeroCelular).ToList();
        }

        private void ddlLlamadas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTomarSeleccionLlamada_Click(object sender, EventArgs e)
        {
            //devuelve el numero
            GestorConsultarEncuesta.tomarSeleccionLlamada(long.Parse(ddlLlamadas.SelectedValue.ToString()));
        }

        public void mostrarDatosDeLlamada(string nombreCompleto, string estadoActual, string duracion, string descripcionEncuesta, List<string> preguntas, List<string> respuestas)
        {
            gb3.Visible = true;
            txtNombreCliente.Text = nombreCompleto;
            txtEstadoEncuesta.Text = estadoActual;
            txtDescripcionEncuesta.Text = descripcionEncuesta;
            txtDuracion.Text = duracion;

            DataTable dataTable = new DataTable();

            // Agrega las columnas al DataTable
            dataTable.Columns.Add("Preguntas", typeof(string));
            dataTable.Columns.Add("Respuestas", typeof(string));

            // Combina las listas y agrega filas al DataTable
            for (int i = 0; i < Math.Min(preguntas.Count, respuestas.Count); i++)
            {
                dataTable.Rows.Add(preguntas[i], respuestas[i]);
            }

            // Asigna el DataTable al origen de datos del DataGridView
            GrillaPR.DataSource = dataTable;

            // Configura las columnas para llenar el ancho del control
            foreach (DataGridViewColumn column in GrillaPR.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void mostrarOpcionDeImpresion()
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
