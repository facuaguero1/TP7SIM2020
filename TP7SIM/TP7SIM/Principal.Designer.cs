namespace TP7SIM
{
    partial class Principal
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnParametros = new System.Windows.Forms.Button();
            this.btnIniciarSimulacion = new System.Windows.Forms.Button();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NroEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEntreLlegadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TamColaQA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaQA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoQA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoAtencionQA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxFinAtencionQA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TamColaLavado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaLavado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoLavado1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoAtencionLavado1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxFinAtencionLavado1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoLavado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoAtencionLavado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxFinAtencionLavado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TamColaSecado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaSecado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoSecado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoAtencionSecado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxFinAtencionSecado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TamColaAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoAtencionAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxFinAtencionAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TamColaPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlfombrasListas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoAtencionPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxFinAtencionPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "INFO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnParametros
            // 
            this.btnParametros.Location = new System.Drawing.Point(132, 386);
            this.btnParametros.Name = "btnParametros";
            this.btnParametros.Size = new System.Drawing.Size(94, 34);
            this.btnParametros.TabIndex = 2;
            this.btnParametros.Text = "Parámetros";
            this.btnParametros.UseVisualStyleBackColor = true;
            this.btnParametros.Click += new System.EventHandler(this.btnParametros_Click);
            // 
            // btnIniciarSimulacion
            // 
            this.btnIniciarSimulacion.Location = new System.Drawing.Point(606, 373);
            this.btnIniciarSimulacion.Name = "btnIniciarSimulacion";
            this.btnIniciarSimulacion.Size = new System.Drawing.Size(169, 47);
            this.btnIniciarSimulacion.TabIndex = 3;
            this.btnIniciarSimulacion.Text = "Iniciar simulación";
            this.btnIniciarSimulacion.UseVisualStyleBackColor = true;
            this.btnIniciarSimulacion.Click += new System.EventHandler(this.btnIniciarSimulacion_Click);
            // 
            // progressbar
            // 
            this.progressbar.Location = new System.Drawing.Point(275, 398);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(282, 16);
            this.progressbar.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroEvento,
            this.Evento,
            this.Reloj,
            this.Column1,
            this.TEntreLlegadas,
            this.ProxLlegada,
            this.Column2,
            this.NroAuto,
            this.Column3,
            this.TamColaQA,
            this.ColaQA,
            this.Column4,
            this.EstadoQA,
            this.TiempoAtencionQA,
            this.ProxFinAtencionQA,
            this.Column5,
            this.TamColaLavado,
            this.ColaLavado,
            this.Column6,
            this.EstadoLavado1,
            this.TiempoAtencionLavado1,
            this.ProxFinAtencionLavado1,
            this.Column7,
            this.EstadoLavado2,
            this.TiempoAtencionLavado2,
            this.ProxFinAtencionLavado2,
            this.Column9,
            this.TamColaSecado,
            this.ColaSecado,
            this.Column10,
            this.EstadoSecado,
            this.TiempoAtencionSecado,
            this.ProxFinAtencionSecado,
            this.Column14,
            this.TamColaAA,
            this.ColaAA,
            this.Column18,
            this.Column19,
            this.TiempoAtencionAA,
            this.ProxFinAtencionAA,
            this.Column21,
            this.TamColaPA,
            this.ColaPA,
            this.AlfombrasListas,
            this.Column25,
            this.Column31,
            this.TiempoAtencionPA,
            this.ProxFinAtencionPA});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(805, 344);
            this.dataGridView1.TabIndex = 5;
            // 
            // NroEvento
            // 
            this.NroEvento.HeaderText = "Nro Evento";
            this.NroEvento.MinimumWidth = 6;
            this.NroEvento.Name = "NroEvento";
            this.NroEvento.ReadOnly = true;
            this.NroEvento.Width = 125;
            // 
            // Evento
            // 
            this.Evento.HeaderText = "Evento";
            this.Evento.MinimumWidth = 6;
            this.Evento.Name = "Evento";
            this.Evento.ReadOnly = true;
            this.Evento.Width = 150;
            // 
            // Reloj
            // 
            this.Reloj.HeaderText = "Reloj";
            this.Reloj.MinimumWidth = 6;
            this.Reloj.Name = "Reloj";
            this.Reloj.ReadOnly = true;
            this.Reloj.Width = 125;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 20F;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 20;
            // 
            // TEntreLlegadas
            // 
            this.TEntreLlegadas.HeaderText = "T. Entre Llegadas";
            this.TEntreLlegadas.MinimumWidth = 6;
            this.TEntreLlegadas.Name = "TEntreLlegadas";
            this.TEntreLlegadas.ReadOnly = true;
            this.TEntreLlegadas.Width = 125;
            // 
            // ProxLlegada
            // 
            this.ProxLlegada.HeaderText = "Próxima Llegada";
            this.ProxLlegada.MinimumWidth = 6;
            this.ProxLlegada.Name = "ProxLlegada";
            this.ProxLlegada.ReadOnly = true;
            this.ProxLlegada.Width = 125;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 20F;
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 20;
            // 
            // NroAuto
            // 
            this.NroAuto.HeaderText = "Nro Auto";
            this.NroAuto.MinimumWidth = 6;
            this.NroAuto.Name = "NroAuto";
            this.NroAuto.ReadOnly = true;
            this.NroAuto.Width = 125;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 20F;
            this.Column3.HeaderText = "";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 20;
            // 
            // TamColaQA
            // 
            this.TamColaQA.HeaderText = "Tamaño Cola QA";
            this.TamColaQA.MinimumWidth = 6;
            this.TamColaQA.Name = "TamColaQA";
            this.TamColaQA.ReadOnly = true;
            this.TamColaQA.Width = 125;
            // 
            // ColaQA
            // 
            this.ColaQA.HeaderText = "Cola Quitar Alfombras";
            this.ColaQA.MinimumWidth = 6;
            this.ColaQA.Name = "ColaQA";
            this.ColaQA.ReadOnly = true;
            this.ColaQA.Width = 125;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 20F;
            this.Column4.HeaderText = "";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 20;
            // 
            // EstadoQA
            // 
            this.EstadoQA.HeaderText = "Estado QA";
            this.EstadoQA.MinimumWidth = 6;
            this.EstadoQA.Name = "EstadoQA";
            this.EstadoQA.ReadOnly = true;
            this.EstadoQA.Width = 125;
            // 
            // TiempoAtencionQA
            // 
            this.TiempoAtencionQA.HeaderText = "Tiempo de Atención";
            this.TiempoAtencionQA.MinimumWidth = 6;
            this.TiempoAtencionQA.Name = "TiempoAtencionQA";
            this.TiempoAtencionQA.ReadOnly = true;
            this.TiempoAtencionQA.Width = 125;
            // 
            // ProxFinAtencionQA
            // 
            this.ProxFinAtencionQA.HeaderText = "Prox. Fin Atención";
            this.ProxFinAtencionQA.MinimumWidth = 6;
            this.ProxFinAtencionQA.Name = "ProxFinAtencionQA";
            this.ProxFinAtencionQA.ReadOnly = true;
            this.ProxFinAtencionQA.Width = 125;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 20F;
            this.Column5.HeaderText = "";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 20;
            // 
            // TamColaLavado
            // 
            this.TamColaLavado.HeaderText = "Tamaño Cola Lavado";
            this.TamColaLavado.MinimumWidth = 6;
            this.TamColaLavado.Name = "TamColaLavado";
            this.TamColaLavado.ReadOnly = true;
            this.TamColaLavado.Width = 125;
            // 
            // ColaLavado
            // 
            this.ColaLavado.HeaderText = "Cola Lavado";
            this.ColaLavado.MinimumWidth = 6;
            this.ColaLavado.Name = "ColaLavado";
            this.ColaLavado.ReadOnly = true;
            this.ColaLavado.Width = 125;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 20F;
            this.Column6.HeaderText = "";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 20;
            // 
            // EstadoLavado1
            // 
            this.EstadoLavado1.HeaderText = "Estado Lavado 1";
            this.EstadoLavado1.MinimumWidth = 6;
            this.EstadoLavado1.Name = "EstadoLavado1";
            this.EstadoLavado1.ReadOnly = true;
            this.EstadoLavado1.Width = 125;
            // 
            // TiempoAtencionLavado1
            // 
            this.TiempoAtencionLavado1.HeaderText = "Tiempo de Atención";
            this.TiempoAtencionLavado1.MinimumWidth = 6;
            this.TiempoAtencionLavado1.Name = "TiempoAtencionLavado1";
            this.TiempoAtencionLavado1.ReadOnly = true;
            this.TiempoAtencionLavado1.Width = 125;
            // 
            // ProxFinAtencionLavado1
            // 
            this.ProxFinAtencionLavado1.HeaderText = "Prox. Fin Atención";
            this.ProxFinAtencionLavado1.MinimumWidth = 6;
            this.ProxFinAtencionLavado1.Name = "ProxFinAtencionLavado1";
            this.ProxFinAtencionLavado1.ReadOnly = true;
            this.ProxFinAtencionLavado1.Width = 125;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 20F;
            this.Column7.HeaderText = "";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 20;
            // 
            // EstadoLavado2
            // 
            this.EstadoLavado2.HeaderText = "Estado Lavado 2";
            this.EstadoLavado2.MinimumWidth = 6;
            this.EstadoLavado2.Name = "EstadoLavado2";
            this.EstadoLavado2.ReadOnly = true;
            this.EstadoLavado2.Width = 125;
            // 
            // TiempoAtencionLavado2
            // 
            this.TiempoAtencionLavado2.HeaderText = "Tiempo de Atención";
            this.TiempoAtencionLavado2.MinimumWidth = 6;
            this.TiempoAtencionLavado2.Name = "TiempoAtencionLavado2";
            this.TiempoAtencionLavado2.ReadOnly = true;
            this.TiempoAtencionLavado2.Width = 125;
            // 
            // ProxFinAtencionLavado2
            // 
            this.ProxFinAtencionLavado2.HeaderText = "Prox. Fin Atención";
            this.ProxFinAtencionLavado2.MinimumWidth = 6;
            this.ProxFinAtencionLavado2.Name = "ProxFinAtencionLavado2";
            this.ProxFinAtencionLavado2.ReadOnly = true;
            this.ProxFinAtencionLavado2.Width = 125;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 20F;
            this.Column9.HeaderText = "";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 20;
            // 
            // TamColaSecado
            // 
            this.TamColaSecado.HeaderText = "Tam. Cola Secado";
            this.TamColaSecado.MinimumWidth = 6;
            this.TamColaSecado.Name = "TamColaSecado";
            this.TamColaSecado.ReadOnly = true;
            this.TamColaSecado.Width = 125;
            // 
            // ColaSecado
            // 
            this.ColaSecado.HeaderText = "Cola Secado";
            this.ColaSecado.MinimumWidth = 6;
            this.ColaSecado.Name = "ColaSecado";
            this.ColaSecado.Width = 125;
            // 
            // Column10
            // 
            this.Column10.FillWeight = 20F;
            this.Column10.HeaderText = "";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 20;
            // 
            // EstadoSecado
            // 
            this.EstadoSecado.HeaderText = "Estado Secado";
            this.EstadoSecado.MinimumWidth = 6;
            this.EstadoSecado.Name = "EstadoSecado";
            this.EstadoSecado.Width = 125;
            // 
            // TiempoAtencionSecado
            // 
            this.TiempoAtencionSecado.HeaderText = "Tiempo de Atención";
            this.TiempoAtencionSecado.MinimumWidth = 6;
            this.TiempoAtencionSecado.Name = "TiempoAtencionSecado";
            this.TiempoAtencionSecado.Width = 125;
            // 
            // ProxFinAtencionSecado
            // 
            this.ProxFinAtencionSecado.HeaderText = "Prox. Fin Atención";
            this.ProxFinAtencionSecado.MinimumWidth = 6;
            this.ProxFinAtencionSecado.Name = "ProxFinAtencionSecado";
            this.ProxFinAtencionSecado.Width = 125;
            // 
            // Column14
            // 
            this.Column14.FillWeight = 20F;
            this.Column14.HeaderText = "";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.Width = 20;
            // 
            // TamColaAA
            // 
            this.TamColaAA.HeaderText = "Tam. Cola AA";
            this.TamColaAA.MinimumWidth = 6;
            this.TamColaAA.Name = "TamColaAA";
            this.TamColaAA.Width = 125;
            // 
            // ColaAA
            // 
            this.ColaAA.HeaderText = "Cola Aspirado Alfombras";
            this.ColaAA.MinimumWidth = 6;
            this.ColaAA.Name = "ColaAA";
            this.ColaAA.Width = 125;
            // 
            // Column18
            // 
            this.Column18.FillWeight = 20F;
            this.Column18.HeaderText = "";
            this.Column18.MinimumWidth = 6;
            this.Column18.Name = "Column18";
            this.Column18.Width = 20;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Estado AA";
            this.Column19.MinimumWidth = 6;
            this.Column19.Name = "Column19";
            this.Column19.Width = 125;
            // 
            // TiempoAtencionAA
            // 
            this.TiempoAtencionAA.HeaderText = "Tiempo de Atención";
            this.TiempoAtencionAA.MinimumWidth = 6;
            this.TiempoAtencionAA.Name = "TiempoAtencionAA";
            this.TiempoAtencionAA.Width = 125;
            // 
            // ProxFinAtencionAA
            // 
            this.ProxFinAtencionAA.HeaderText = "Prox. Fin Atención";
            this.ProxFinAtencionAA.MinimumWidth = 6;
            this.ProxFinAtencionAA.Name = "ProxFinAtencionAA";
            this.ProxFinAtencionAA.Width = 125;
            // 
            // Column21
            // 
            this.Column21.FillWeight = 20F;
            this.Column21.HeaderText = "";
            this.Column21.MinimumWidth = 6;
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            this.Column21.Width = 20;
            // 
            // TamColaPA
            // 
            this.TamColaPA.HeaderText = "Tam. Cola PA";
            this.TamColaPA.MinimumWidth = 6;
            this.TamColaPA.Name = "TamColaPA";
            this.TamColaPA.ReadOnly = true;
            this.TamColaPA.Width = 125;
            // 
            // ColaPA
            // 
            this.ColaPA.HeaderText = "Cola Poner Alfombras";
            this.ColaPA.MinimumWidth = 6;
            this.ColaPA.Name = "ColaPA";
            this.ColaPA.ReadOnly = true;
            this.ColaPA.Width = 125;
            // 
            // AlfombrasListas
            // 
            this.AlfombrasListas.HeaderText = "Alfombras Listas";
            this.AlfombrasListas.MinimumWidth = 6;
            this.AlfombrasListas.Name = "AlfombrasListas";
            this.AlfombrasListas.ReadOnly = true;
            this.AlfombrasListas.Width = 125;
            // 
            // Column25
            // 
            this.Column25.FillWeight = 20F;
            this.Column25.HeaderText = "";
            this.Column25.MinimumWidth = 6;
            this.Column25.Name = "Column25";
            this.Column25.ReadOnly = true;
            this.Column25.Width = 20;
            // 
            // Column31
            // 
            this.Column31.HeaderText = "Estado PA";
            this.Column31.MinimumWidth = 6;
            this.Column31.Name = "Column31";
            this.Column31.ReadOnly = true;
            this.Column31.Width = 125;
            // 
            // TiempoAtencionPA
            // 
            this.TiempoAtencionPA.HeaderText = "Tiempo de Atención";
            this.TiempoAtencionPA.MinimumWidth = 6;
            this.TiempoAtencionPA.Name = "TiempoAtencionPA";
            this.TiempoAtencionPA.ReadOnly = true;
            this.TiempoAtencionPA.Width = 125;
            // 
            // ProxFinAtencionPA
            // 
            this.ProxFinAtencionPA.HeaderText = "Prox. Fin Atención PA";
            this.ProxFinAtencionPA.MinimumWidth = 6;
            this.ProxFinAtencionPA.Name = "ProxFinAtencionPA";
            this.ProxFinAtencionPA.ReadOnly = true;
            this.ProxFinAtencionPA.Width = 125;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 426);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.btnIniciarSimulacion);
            this.Controls.Add(this.btnParametros);
            this.Controls.Add(this.button1);
            this.Name = "Principal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnParametros;
        private System.Windows.Forms.Button btnIniciarSimulacion;
        internal System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEntreLlegadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TamColaQA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaQA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoQA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoAtencionQA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxFinAtencionQA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TamColaLavado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaLavado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoLavado1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoAtencionLavado1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxFinAtencionLavado1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoLavado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoAtencionLavado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxFinAtencionLavado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn TamColaSecado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaSecado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoSecado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoAtencionSecado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxFinAtencionSecado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn TamColaAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoAtencionAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxFinAtencionAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn TamColaPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlfombrasListas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column31;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoAtencionPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxFinAtencionPA;
    }
}

