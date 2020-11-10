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
            this.EstadoEmpl2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoCocina2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxFinPrep2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimoFinAtencion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoEmpl3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoCocina3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxFinPrep3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimoFinAtencion3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaPendientesEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PendientesEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mochila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxFinEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxCierreTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProximoInicioTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.EstadoEmpl2,
            this.TiempoCocina2,
            this.ProxFinPrep2,
            this.UltimoFinAtencion2,
            this.Column6,
            this.EstadoEmpl3,
            this.TiempoCocina3,
            this.ProxFinPrep3,
            this.UltimoFinAtencion3,
            this.Column7,
            this.ColaPendientesEntrega,
            this.PendientesEntrega,
            this.Column8,
            this.EstadoDelivery,
            this.Mochila,
            this.TiempoEntrega,
            this.ProxFinEntrega,
            this.Column9,
            this.EstadoTurno,
            this.ProxCierreTurno,
            this.ProximoInicioTurno,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column15,
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25,
            this.Column31,
            this.Column26,
            this.Column27,
            this.Column28,
            this.Column29,
            this.Column30,
            this.Column34,
            this.Column35,
            this.Column32,
            this.Column33,
            this.Column36,
            this.Column38});
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
            this.EstadoQA.HeaderText = "Estado";
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
            // EstadoEmpl2
            // 
            this.EstadoEmpl2.HeaderText = "Estado";
            this.EstadoEmpl2.MinimumWidth = 6;
            this.EstadoEmpl2.Name = "EstadoEmpl2";
            this.EstadoEmpl2.ReadOnly = true;
            this.EstadoEmpl2.Width = 125;
            // 
            // TiempoCocina2
            // 
            this.TiempoCocina2.HeaderText = "Tiempo de Cocina";
            this.TiempoCocina2.MinimumWidth = 6;
            this.TiempoCocina2.Name = "TiempoCocina2";
            this.TiempoCocina2.ReadOnly = true;
            this.TiempoCocina2.Width = 125;
            // 
            // ProxFinPrep2
            // 
            this.ProxFinPrep2.HeaderText = "Prox. Fin Preparación";
            this.ProxFinPrep2.MinimumWidth = 6;
            this.ProxFinPrep2.Name = "ProxFinPrep2";
            this.ProxFinPrep2.ReadOnly = true;
            this.ProxFinPrep2.Width = 125;
            // 
            // UltimoFinAtencion2
            // 
            this.UltimoFinAtencion2.HeaderText = "Ultimo Fin Atencion";
            this.UltimoFinAtencion2.MinimumWidth = 6;
            this.UltimoFinAtencion2.Name = "UltimoFinAtencion2";
            this.UltimoFinAtencion2.ReadOnly = true;
            this.UltimoFinAtencion2.Width = 125;
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
            // EstadoEmpl3
            // 
            this.EstadoEmpl3.HeaderText = "Estado";
            this.EstadoEmpl3.MinimumWidth = 6;
            this.EstadoEmpl3.Name = "EstadoEmpl3";
            this.EstadoEmpl3.ReadOnly = true;
            this.EstadoEmpl3.Width = 125;
            // 
            // TiempoCocina3
            // 
            this.TiempoCocina3.HeaderText = "Tiempo de Cocina";
            this.TiempoCocina3.MinimumWidth = 6;
            this.TiempoCocina3.Name = "TiempoCocina3";
            this.TiempoCocina3.ReadOnly = true;
            this.TiempoCocina3.Width = 125;
            // 
            // ProxFinPrep3
            // 
            this.ProxFinPrep3.HeaderText = "Prox. Fin Preparación";
            this.ProxFinPrep3.MinimumWidth = 6;
            this.ProxFinPrep3.Name = "ProxFinPrep3";
            this.ProxFinPrep3.ReadOnly = true;
            this.ProxFinPrep3.Width = 125;
            // 
            // UltimoFinAtencion3
            // 
            this.UltimoFinAtencion3.HeaderText = "Ultimo Fin Atencion";
            this.UltimoFinAtencion3.MinimumWidth = 6;
            this.UltimoFinAtencion3.Name = "UltimoFinAtencion3";
            this.UltimoFinAtencion3.ReadOnly = true;
            this.UltimoFinAtencion3.Width = 125;
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
            // ColaPendientesEntrega
            // 
            this.ColaPendientesEntrega.HeaderText = "Cola Pedidos Pendiente Entrega";
            this.ColaPendientesEntrega.MinimumWidth = 6;
            this.ColaPendientesEntrega.Name = "ColaPendientesEntrega";
            this.ColaPendientesEntrega.ReadOnly = true;
            this.ColaPendientesEntrega.Width = 125;
            // 
            // PendientesEntrega
            // 
            this.PendientesEntrega.HeaderText = "Pendientes de Entrega";
            this.PendientesEntrega.MinimumWidth = 6;
            this.PendientesEntrega.Name = "PendientesEntrega";
            this.PendientesEntrega.ReadOnly = true;
            this.PendientesEntrega.Width = 125;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 20F;
            this.Column8.HeaderText = "";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 20;
            // 
            // EstadoDelivery
            // 
            this.EstadoDelivery.HeaderText = "Estado";
            this.EstadoDelivery.MinimumWidth = 6;
            this.EstadoDelivery.Name = "EstadoDelivery";
            this.EstadoDelivery.ReadOnly = true;
            this.EstadoDelivery.Width = 125;
            // 
            // Mochila
            // 
            this.Mochila.HeaderText = "Mochila";
            this.Mochila.MinimumWidth = 6;
            this.Mochila.Name = "Mochila";
            this.Mochila.ReadOnly = true;
            this.Mochila.Width = 125;
            // 
            // TiempoEntrega
            // 
            this.TiempoEntrega.HeaderText = "Tiempo de Entrega";
            this.TiempoEntrega.MinimumWidth = 6;
            this.TiempoEntrega.Name = "TiempoEntrega";
            this.TiempoEntrega.ReadOnly = true;
            this.TiempoEntrega.Width = 125;
            // 
            // ProxFinEntrega
            // 
            this.ProxFinEntrega.HeaderText = "Prox. Fin Entrega";
            this.ProxFinEntrega.MinimumWidth = 6;
            this.ProxFinEntrega.Name = "ProxFinEntrega";
            this.ProxFinEntrega.ReadOnly = true;
            this.ProxFinEntrega.Width = 125;
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
            // EstadoTurno
            // 
            this.EstadoTurno.HeaderText = "Estado";
            this.EstadoTurno.MinimumWidth = 6;
            this.EstadoTurno.Name = "EstadoTurno";
            this.EstadoTurno.ReadOnly = true;
            this.EstadoTurno.Width = 125;
            // 
            // ProxCierreTurno
            // 
            this.ProxCierreTurno.HeaderText = "Prox. Cierre Turno";
            this.ProxCierreTurno.MinimumWidth = 6;
            this.ProxCierreTurno.Name = "ProxCierreTurno";
            this.ProxCierreTurno.Width = 125;
            // 
            // ProximoInicioTurno
            // 
            this.ProximoInicioTurno.HeaderText = "ProximoInicioTurno";
            this.ProximoInicioTurno.MinimumWidth = 6;
            this.ProximoInicioTurno.Name = "ProximoInicioTurno";
            this.ProximoInicioTurno.ReadOnly = true;
            this.ProximoInicioTurno.Width = 125;
            // 
            // Column10
            // 
            this.Column10.FillWeight = 20F;
            this.Column10.HeaderText = "";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 20;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "TiempoEntrePedidos";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "CantidadPedidoXHora";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Cantidad Tipo Pedido";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 125;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Tiempo Prep Sandwich";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.Width = 125;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Tiempo Coccion Pizza";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            this.Column16.Width = 125;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Cantidad Empanadas Demand";
            this.Column17.MinimumWidth = 6;
            this.Column17.Name = "Column17";
            this.Column17.Width = 125;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Tiempo Coccion Empanadas";
            this.Column18.MinimumWidth = 6;
            this.Column18.Name = "Column18";
            this.Column18.Width = 125;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Ingreso Hamburguesa/Lomito";
            this.Column19.MinimumWidth = 6;
            this.Column19.Name = "Column19";
            this.Column19.Width = 125;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Orden Uso Empleados";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.Width = 125;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Tiempo Entrega Pedidos";
            this.Column20.MinimumWidth = 6;
            this.Column20.Name = "Column20";
            this.Column20.Width = 125;
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
            // Column22
            // 
            this.Column22.HeaderText = "Tiempo Libre Cocineros";
            this.Column22.MinimumWidth = 6;
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            this.Column22.Width = 125;
            // 
            // Column23
            // 
            this.Column23.HeaderText = "Tiempo Promedio Libre Cocineros";
            this.Column23.MinimumWidth = 6;
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            this.Column23.Width = 125;
            // 
            // Column24
            // 
            this.Column24.HeaderText = "Tiempo Libre Delivery";
            this.Column24.MinimumWidth = 6;
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            this.Column24.Width = 125;
            // 
            // Column25
            // 
            this.Column25.HeaderText = "Tiempo Promedio Libre Delivery";
            this.Column25.MinimumWidth = 6;
            this.Column25.Name = "Column25";
            this.Column25.ReadOnly = true;
            this.Column25.Width = 125;
            // 
            // Column31
            // 
            this.Column31.HeaderText = "Ventas Perdidas";
            this.Column31.MinimumWidth = 6;
            this.Column31.Name = "Column31";
            this.Column31.ReadOnly = true;
            this.Column31.Width = 125;
            // 
            // Column26
            // 
            this.Column26.HeaderText = "Ingreso Perdido";
            this.Column26.MinimumWidth = 6;
            this.Column26.Name = "Column26";
            this.Column26.ReadOnly = true;
            this.Column26.Width = 125;
            // 
            // Column27
            // 
            this.Column27.HeaderText = "Ingreso Promedio Perdido";
            this.Column27.MinimumWidth = 6;
            this.Column27.Name = "Column27";
            this.Column27.ReadOnly = true;
            this.Column27.Width = 125;
            // 
            // Column28
            // 
            this.Column28.HeaderText = "Ventas Gratis";
            this.Column28.MinimumWidth = 6;
            this.Column28.Name = "Column28";
            this.Column28.ReadOnly = true;
            this.Column28.Width = 125;
            // 
            // Column29
            // 
            this.Column29.HeaderText = "Ingresos";
            this.Column29.MinimumWidth = 6;
            this.Column29.Name = "Column29";
            this.Column29.ReadOnly = true;
            this.Column29.Width = 125;
            // 
            // Column30
            // 
            this.Column30.HeaderText = "Ingreso Promedio Diario";
            this.Column30.MinimumWidth = 6;
            this.Column30.Name = "Column30";
            this.Column30.ReadOnly = true;
            this.Column30.Width = 125;
            // 
            // Column34
            // 
            this.Column34.HeaderText = "Tiempo Espera Preparacion";
            this.Column34.MinimumWidth = 6;
            this.Column34.Name = "Column34";
            this.Column34.ReadOnly = true;
            this.Column34.Width = 125;
            // 
            // Column35
            // 
            this.Column35.HeaderText = "Tiempo Promedio Espera Preparacion";
            this.Column35.MinimumWidth = 6;
            this.Column35.Name = "Column35";
            this.Column35.ReadOnly = true;
            this.Column35.Width = 125;
            // 
            // Column32
            // 
            this.Column32.HeaderText = "Tiempo Espera Pedido";
            this.Column32.MinimumWidth = 6;
            this.Column32.Name = "Column32";
            this.Column32.ReadOnly = true;
            this.Column32.Width = 125;
            // 
            // Column33
            // 
            this.Column33.HeaderText = "Tiempo Promedio Espera Pedido";
            this.Column33.MinimumWidth = 6;
            this.Column33.Name = "Column33";
            this.Column33.ReadOnly = true;
            this.Column33.Width = 125;
            // 
            // Column36
            // 
            this.Column36.HeaderText = "Prob $250 o menos";
            this.Column36.MinimumWidth = 6;
            this.Column36.Name = "Column36";
            this.Column36.ReadOnly = true;
            this.Column36.Width = 125;
            // 
            // Column38
            // 
            this.Column38.HeaderText = "Cantidad Maxima Pedidos post 25 min";
            this.Column38.MinimumWidth = 6;
            this.Column38.Name = "Column38";
            this.Column38.Width = 125;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoEmpl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoCocina2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxFinPrep2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimoFinAtencion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoEmpl3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoCocina3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxFinPrep3;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimoFinAtencion3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaPendientesEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn PendientesEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mochila;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxFinEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxCierreTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProximoInicioTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column31;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column26;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column29;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column30;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column34;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column35;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column32;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column33;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column36;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column38;
    }
}

