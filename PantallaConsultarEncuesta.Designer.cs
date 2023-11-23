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
            this.lblLlamadasPeriodo = new System.Windows.Forms.Label();
            this.ddlLlamadas = new System.Windows.Forms.ComboBox();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
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
            this.gb2.Controls.Add(this.ddlLlamadas);
            this.gb2.Controls.Add(this.lblLlamadasPeriodo);
            this.gb2.Location = new System.Drawing.Point(502, 62);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(286, 227);
            this.gb2.TabIndex = 10;
            this.gb2.TabStop = false;
            this.gb2.Visible = false;
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
            // PantallaConsultarEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.btnConsultarEncuesta);
            this.Name = "PantallaConsultarEncuesta";
            this.Text = "Consultar Encuesta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
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
    }
}

