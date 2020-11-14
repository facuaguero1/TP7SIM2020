namespace TP7SIM
{
    partial class Frm_ConfiguracionParametros
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMediaLlegadas = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxClientes = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtL_A = new System.Windows.Forms.MaskedTextBox();
            this.txtL_B = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAA_A = new System.Windows.Forms.MaskedTextBox();
            this.txtAA_B = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPA = new System.Windows.Forms.MaskedTextBox();
            this.txtQA = new System.Windows.Forms.MaskedTextBox();
            this.txtHEcDif = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnProcEcDif = new System.Windows.Forms.Button();
            this.btnValoresPorDefecto = new System.Windows.Forms.Button();
            this.btn_ConfirmarParametros = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMediaLlegadas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaxClientes);
            this.groupBox1.Location = new System.Drawing.Point(28, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Media de llegadas (minutos)";
            // 
            // txtMediaLlegadas
            // 
            this.txtMediaLlegadas.Location = new System.Drawing.Point(150, 60);
            this.txtMediaLlegadas.Mask = "##,##";
            this.txtMediaLlegadas.Name = "txtMediaLlegadas";
            this.txtMediaLlegadas.Size = new System.Drawing.Size(66, 20);
            this.txtMediaLlegadas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cant. max. clientes";
            // 
            // txtMaxClientes
            // 
            this.txtMaxClientes.Location = new System.Drawing.Point(150, 19);
            this.txtMaxClientes.Name = "txtMaxClientes";
            this.txtMaxClientes.Size = new System.Drawing.Size(66, 20);
            this.txtMaxClientes.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPA);
            this.groupBox2.Controls.Add(this.txtQA);
            this.groupBox2.Location = new System.Drawing.Point(283, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiempos de tareas ( en minutos)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Poner alfombras";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtL_A);
            this.groupBox4.Controls.Add(this.txtL_B);
            this.groupBox4.Location = new System.Drawing.Point(237, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(140, 100);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lavado (D.Uniforme)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "A";
            // 
            // txtL_A
            // 
            this.txtL_A.Location = new System.Drawing.Point(65, 21);
            this.txtL_A.Mask = "##,##";
            this.txtL_A.Name = "txtL_A";
            this.txtL_A.Size = new System.Drawing.Size(58, 20);
            this.txtL_A.TabIndex = 3;
            // 
            // txtL_B
            // 
            this.txtL_B.Location = new System.Drawing.Point(65, 63);
            this.txtL_B.Mask = "##,##";
            this.txtL_B.Name = "txtL_B";
            this.txtL_B.Size = new System.Drawing.Size(58, 20);
            this.txtL_B.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtAA_A);
            this.groupBox3.Controls.Add(this.txtAA_B);
            this.groupBox3.Location = new System.Drawing.Point(28, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aspirado (D.Uniforme)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "A";
            // 
            // txtAA_A
            // 
            this.txtAA_A.Location = new System.Drawing.Point(65, 21);
            this.txtAA_A.Mask = "##,##";
            this.txtAA_A.Name = "txtAA_A";
            this.txtAA_A.Size = new System.Drawing.Size(58, 20);
            this.txtAA_A.TabIndex = 3;
            // 
            // txtAA_B
            // 
            this.txtAA_B.Location = new System.Drawing.Point(65, 63);
            this.txtAA_B.Mask = "##,##";
            this.txtAA_B.Name = "txtAA_B";
            this.txtAA_B.Size = new System.Drawing.Size(58, 20);
            this.txtAA_B.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quitar alfombras";
            // 
            // txtPA
            // 
            this.txtPA.Location = new System.Drawing.Point(319, 29);
            this.txtPA.Mask = "##,##";
            this.txtPA.Name = "txtPA";
            this.txtPA.Size = new System.Drawing.Size(58, 20);
            this.txtPA.TabIndex = 1;
            // 
            // txtQA
            // 
            this.txtQA.Location = new System.Drawing.Point(114, 32);
            this.txtQA.Mask = "##,##";
            this.txtQA.Name = "txtQA";
            this.txtQA.Size = new System.Drawing.Size(54, 20);
            this.txtQA.TabIndex = 0;
            // 
            // txtHEcDif
            // 
            this.txtHEcDif.Location = new System.Drawing.Point(36, 44);
            this.txtHEcDif.Mask = "#,##";
            this.txtHEcDif.Name = "txtHEcDif";
            this.txtHEcDif.Size = new System.Drawing.Size(66, 20);
            this.txtHEcDif.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "h";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnProcEcDif);
            this.groupBox5.Controls.Add(this.txtHEcDif);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(28, 129);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(240, 100);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ecuación diferencial de secado";
            // 
            // btnProcEcDif
            // 
            this.btnProcEcDif.Location = new System.Drawing.Point(121, 33);
            this.btnProcEcDif.Name = "btnProcEcDif";
            this.btnProcEcDif.Size = new System.Drawing.Size(113, 37);
            this.btnProcEcDif.TabIndex = 8;
            this.btnProcEcDif.Text = "Procedimiento de la ecuación diferencial";
            this.btnProcEcDif.UseVisualStyleBackColor = true;
            this.btnProcEcDif.Click += new System.EventHandler(this.btnProcEcDif_Click);
            // 
            // btnValoresPorDefecto
            // 
            this.btnValoresPorDefecto.Location = new System.Drawing.Point(260, 237);
            this.btnValoresPorDefecto.Name = "btnValoresPorDefecto";
            this.btnValoresPorDefecto.Size = new System.Drawing.Size(174, 23);
            this.btnValoresPorDefecto.TabIndex = 5;
            this.btnValoresPorDefecto.Text = "Valores por defecto";
            this.btnValoresPorDefecto.UseVisualStyleBackColor = true;
            this.btnValoresPorDefecto.Click += new System.EventHandler(this.btnValoresPorDefecto_Click);
            // 
            // btn_ConfirmarParametros
            // 
            this.btn_ConfirmarParametros.Location = new System.Drawing.Point(270, 266);
            this.btn_ConfirmarParametros.Name = "btn_ConfirmarParametros";
            this.btn_ConfirmarParametros.Size = new System.Drawing.Size(150, 52);
            this.btn_ConfirmarParametros.TabIndex = 6;
            this.btn_ConfirmarParametros.Text = "Confirmar";
            this.btn_ConfirmarParametros.UseVisualStyleBackColor = true;
            this.btn_ConfirmarParametros.Click += new System.EventHandler(this.btn_ConfirmarParametros_Click);
            // 
            // Frm_ConfiguracionParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 324);
            this.Controls.Add(this.btn_ConfirmarParametros);
            this.Controls.Add(this.btnValoresPorDefecto);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_ConfiguracionParametros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración de parámetros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtMaxClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtMediaLlegadas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtAA_A;
        private System.Windows.Forms.MaskedTextBox txtAA_B;
        private System.Windows.Forms.MaskedTextBox txtPA;
        private System.Windows.Forms.MaskedTextBox txtQA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtL_A;
        private System.Windows.Forms.MaskedTextBox txtL_B;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtHEcDif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnValoresPorDefecto;
        private System.Windows.Forms.Button btn_ConfirmarParametros;
        private System.Windows.Forms.Button btnProcEcDif;
    }
}