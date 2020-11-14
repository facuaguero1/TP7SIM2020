namespace TP7SIM
{
    partial class Frm_EcDif
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.btn_Graficar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_h = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Euler = new System.Windows.Forms.DataGridView();
            this.t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Euler)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(482, 341);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(97, 36);
            this.btn_Cancelar.TabIndex = 15;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Result);
            this.groupBox2.Controls.Add(this.btn_Graficar);
            this.groupBox2.Controls.Add(this.btn_Calcular);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(220, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 85);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info Simulación";
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(262, 21);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(37, 13);
            this.lbl_Result.TabIndex = 8;
            this.lbl_Result.Text = "_____";
            // 
            // btn_Graficar
            // 
            this.btn_Graficar.Enabled = false;
            this.btn_Graficar.Location = new System.Drawing.Point(206, 43);
            this.btn_Graficar.Name = "btn_Graficar";
            this.btn_Graficar.Size = new System.Drawing.Size(106, 27);
            this.btn_Graficar.TabIndex = 6;
            this.btn_Graficar.Text = "Graficar";
            this.btn_Graficar.UseVisualStyleBackColor = true;
            this.btn_Graficar.Click += new System.EventHandler(this.btn_Graficar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(48, 43);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(111, 28);
            this.btn_Calcular.TabIndex = 5;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiempo de secado de un auto: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_h);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 86);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Entrada";
            // 
            // txt_h
            // 
            this.txt_h.Location = new System.Drawing.Point(81, 43);
            this.txt_h.Name = "txt_h";
            this.txt_h.Size = new System.Drawing.Size(97, 20);
            this.txt_h.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor de h";
            // 
            // dgv_Euler
            // 
            this.dgv_Euler.AllowUserToAddRows = false;
            this.dgv_Euler.AllowUserToDeleteRows = false;
            this.dgv_Euler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Euler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Euler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t,
            this.H,
            this.H1});
            this.dgv_Euler.Location = new System.Drawing.Point(12, 108);
            this.dgv_Euler.Name = "dgv_Euler";
            this.dgv_Euler.ReadOnly = true;
            this.dgv_Euler.Size = new System.Drawing.Size(571, 228);
            this.dgv_Euler.TabIndex = 12;
            // 
            // t
            // 
            this.t.FillWeight = 43.64764F;
            this.t.HeaderText = "t";
            this.t.Name = "t";
            this.t.ReadOnly = true;
            // 
            // H
            // 
            this.H.FillWeight = 64.16203F;
            this.H.HeaderText = "H(t)";
            this.H.Name = "H";
            this.H.ReadOnly = true;
            // 
            // H1
            // 
            this.H1.FillWeight = 64.16203F;
            this.H1.HeaderText = "H\'(t)";
            this.H1.Name = "H1";
            this.H1.ReadOnly = true;
            // 
            // Frm_EcDif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 383);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Euler);
            this.MaximumSize = new System.Drawing.Size(608, 421);
            this.MinimumSize = new System.Drawing.Size(608, 421);
            this.Name = "Frm_EcDif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procedimiento de la ecuación diferencial";
            this.Load += new System.EventHandler(this.Frm_EcuacionDiferencial_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Euler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Button btn_Graficar;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_h;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Euler;
        private System.Windows.Forms.DataGridViewTextBoxColumn t;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Windows.Forms.DataGridViewTextBoxColumn H1;
    }
}