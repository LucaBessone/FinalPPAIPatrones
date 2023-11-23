namespace FinalPPAIPatrones
{
    partial class PantallaConsultarEncuesta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConsultarEncuesta = new System.Windows.Forms.Button();
            this.lblFechas = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnTomarPeriodo = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.btnTomarSeleccionLlamada = new System.Windows.Forms.Button();
            this.ddlLlamadas = new System.Windows.Forms.ComboBox();
            this.lblLlamadasPeriodo = new System.Windows.Forms.Label();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.txtDescripcionEncuesta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstadoEncuesta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatosLlamada = new System.Windows.Forms.Label();
            this.GrillaPR = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.gb3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarEncuesta
            // 
            this.btnConsultarEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEncuesta.Location = new System.Drawing.Point(41, 12);
            this.btnConsultarEncuesta.Name = "btnConsultarEncuesta";
            this.btnConsultarEncuesta.Size = new System.Drawing.Size(153, 44);
            this.btnConsultarEncuesta.TabIndex = 0;
            this.btnConsultarEncuesta.Text = "Consultar Encuesta";
            this.btnConsultarEncuesta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarEncuesta.UseVisualStyleBackColor = true;
            this.btnConsultarEncuesta.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFechas
            // 
            this.lblFechas.AutoSize = true;
            this.lblFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechas.Location = new System.Drawing.Point(29, 16);
            this.lblFechas.Name = "lblFechas";
            this.lblFechas.Size = new System.Drawing.Size(344, 24);
            this.lblFechas.TabIndex = 1;
            this.lblFechas.Text = "Ingrese el periodo de las encuestas";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(33, 53);
            this.monthCalendar1.MaxSelectionCount = 1000;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // btnTomarPeriodo
            // 
            this.btnTomarPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomarPeriodo.Location = new System.Drawing.Point(254, 97);
            this.btnTomarPeriodo.Name = "btnTomarPeriodo";
            this.btnTomarPeriodo.Size = new System.Drawing.Size(153, 44);
            this.btnTomarPeriodo.TabIndex = 8;
            this.btnTomarPeriodo.Text = "Tomar Periodo";
            this.btnTomarPeriodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTomarPeriodo.UseVisualStyleBackColor = true;
            this.btnTomarPeriodo.Click += new System.EventHandler(this.btnTomarPeriodo_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btnTomarPeriodo);
            this.gb1.Controls.Add(this.monthCalendar1);
            this.gb1.Controls.Add(this.lblFechas);
            this.gb1.Location = new System.Drawing.Point(12, 62);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(455, 227);
            this.gb1.TabIndex = 9;
            this.gb1.TabStop = false;
            this.gb1.Visible = false;
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.btnTomarSeleccionLlamada);
            this.gb2.Controls.Add(this.ddlLlamadas);
            this.gb2.Controls.Add(this.lblLlamadasPeriodo);
            this.gb2.Location = new System.Drawing.Point(502, 62);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(286, 227);
            this.gb2.TabIndex = 10;
            this.gb2.TabStop = false;
            this.gb2.Visible = false;
            // 
            // btnTomarSeleccionLlamada
            // 
            this.btnTomarSeleccionLlamada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomarSeleccionLlamada.Location = new System.Drawing.Point(66, 126);
            this.btnTomarSeleccionLlamada.Name = "btnTomarSeleccionLlamada";
            this.btnTomarSeleccionLlamada.Size = new System.Drawing.Size(153, 44);
            this.btnTomarSeleccionLlamada.TabIndex = 9;
            this.btnTomarSeleccionLlamada.Text = "Elegir llamada";
            this.btnTomarSeleccionLlamada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTomarSeleccionLlamada.UseVisualStyleBackColor = true;
            this.btnTomarSeleccionLlamada.Click += new System.EventHandler(this.btnTomarSeleccionLlamada_Click);
            // 
            // ddlLlamadas
            // 
            this.ddlLlamadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlLlamadas.FormattingEnabled = true;
            this.ddlLlamadas.Location = new System.Drawing.Point(43, 67);
            this.ddlLlamadas.Name = "ddlLlamadas";
            this.ddlLlamadas.Size = new System.Drawing.Size(208, 28);
            this.ddlLlamadas.TabIndex = 3;
            this.ddlLlamadas.Text = "Llamadas";
            this.ddlLlamadas.SelectedIndexChanged += new System.EventHandler(this.ddlLlamadas_SelectedIndexChanged);
            // 
            // lblLlamadasPeriodo
            // 
            this.lblLlamadasPeriodo.AutoSize = true;
            this.lblLlamadasPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlamadasPeriodo.Location = new System.Drawing.Point(39, 16);
            this.lblLlamadasPeriodo.Name = "lblLlamadasPeriodo";
            this.lblLlamadasPeriodo.Size = new System.Drawing.Size(212, 24);
            this.lblLlamadasPeriodo.TabIndex = 2;
            this.lblLlamadasPeriodo.Text = "Llamadas del Periodo";
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.btnImprimir);
            this.gb3.Controls.Add(this.txtDescripcionEncuesta);
            this.gb3.Controls.Add(this.label4);
            this.gb3.Controls.Add(this.txtDuracion);
            this.gb3.Controls.Add(this.label3);
            this.gb3.Controls.Add(this.txtEstadoEncuesta);
            this.gb3.Controls.Add(this.label2);
            this.gb3.Controls.Add(this.txtNombreCliente);
            this.gb3.Controls.Add(this.label1);
            this.gb3.Controls.Add(this.lblDatosLlamada);
            this.gb3.Controls.Add(this.GrillaPR);
            this.gb3.Location = new System.Drawing.Point(15, 297);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(772, 399);
            this.gb3.TabIndex = 11;
            this.gb3.TabStop = false;
            this.gb3.Visible = false;
            // 
            // txtDescripcionEncuesta
            // 
            this.txtDescripcionEncuesta.Enabled = false;
            this.txtDescripcionEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionEncuesta.Location = new System.Drawing.Point(30, 325);
            this.txtDescripcionEncuesta.Name = "txtDescripcionEncuesta";
            this.txtDescripcionEncuesta.Size = new System.Drawing.Size(279, 23);
            this.txtDescripcionEncuesta.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Descripcion Encuesta";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Enabled = false;
            this.txtDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracion.Location = new System.Drawing.Point(30, 255);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(279, 23);
            this.txtDuracion.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Duracion Llamada";
            // 
            // txtEstadoEncuesta
            // 
            this.txtEstadoEncuesta.Enabled = false;
            this.txtEstadoEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoEncuesta.Location = new System.Drawing.Point(30, 184);
            this.txtEstadoEncuesta.Name = "txtEstadoEncuesta";
            this.txtEstadoEncuesta.Size = new System.Drawing.Size(279, 23);
            this.txtEstadoEncuesta.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Estado Encuesta";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(30, 118);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(279, 23);
            this.txtNombreCliente.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre cliente";
            // 
            // lblDatosLlamada
            // 
            this.lblDatosLlamada.AutoSize = true;
            this.lblDatosLlamada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosLlamada.Location = new System.Drawing.Point(21, 33);
            this.lblDatosLlamada.Name = "lblDatosLlamada";
            this.lblDatosLlamada.Size = new System.Drawing.Size(322, 24);
            this.lblDatosLlamada.TabIndex = 2;
            this.lblDatosLlamada.Text = "Datos de la llamada seleccionada";
            // 
            // GrillaPR
            // 
            this.GrillaPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaPR.Location = new System.Drawing.Point(339, 86);
            this.GrillaPR.Name = "GrillaPR";
            this.GrillaPR.Size = new System.Drawing.Size(427, 192);
            this.GrillaPR.TabIndex = 0;
            this.GrillaPR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(464, 304);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(153, 44);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // PantallaConsultarEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 733);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.btnConsultarEncuesta);
            this.Name = "PantallaConsultarEncuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Encuesta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gb3.ResumeLayout(false);
            this.gb3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarEncuesta;
        private System.Windows.Forms.Label lblFechas;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnTomarPeriodo;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.ComboBox ddlLlamadas;
        private System.Windows.Forms.Label lblLlamadasPeriodo;
        private System.Windows.Forms.Button btnTomarSeleccionLlamada;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.Label lblDatosLlamada;
        private System.Windows.Forms.DataGridView GrillaPR;
        private System.Windows.Forms.TextBox txtDescripcionEncuesta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstadoEncuesta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimir;
    }
}

