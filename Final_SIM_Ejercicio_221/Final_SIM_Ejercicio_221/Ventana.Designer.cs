namespace Final_SIM_Ejercicio_221
{
    partial class Ventana
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
            this.label38 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHS = new System.Windows.Forms.Label();
            this.txtUltHoras = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtHorasSim = new System.Windows.Forms.TextBox();
            this.lblHsSim = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnSimular = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTpoLlegColectivos = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTpoLLeg = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(12, 9);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(139, 25);
            this.label38.TabIndex = 18;
            this.label38.Text = "Parametros:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHS);
            this.groupBox1.Controls.Add(this.txtUltHoras);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.txtHorasSim);
            this.groupBox1.Controls.Add(this.lblHsSim);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 78);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // lblHS
            // 
            this.lblHS.AutoSize = true;
            this.lblHS.Location = new System.Drawing.Point(147, 47);
            this.lblHS.Name = "lblHS";
            this.lblHS.Size = new System.Drawing.Size(20, 13);
            this.lblHS.TabIndex = 5;
            this.lblHS.Text = "Hs";
            // 
            // txtUltHoras
            // 
            this.txtUltHoras.Location = new System.Drawing.Point(90, 44);
            this.txtUltHoras.Name = "txtUltHoras";
            this.txtUltHoras.Size = new System.Drawing.Size(51, 20);
            this.txtUltHoras.TabIndex = 4;
            this.txtUltHoras.Text = "3";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(4, 47);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(80, 13);
            this.label30.TabIndex = 3;
            this.label30.Text = "Mostrar últimas:";
            // 
            // txtHorasSim
            // 
            this.txtHorasSim.Location = new System.Drawing.Point(102, 16);
            this.txtHorasSim.Name = "txtHorasSim";
            this.txtHorasSim.Size = new System.Drawing.Size(68, 20);
            this.txtHorasSim.TabIndex = 2;
            this.txtHorasSim.Text = "8";
            // 
            // lblHsSim
            // 
            this.lblHsSim.AutoSize = true;
            this.lblHsSim.Location = new System.Drawing.Point(4, 19);
            this.lblHsSim.Name = "lblHsSim";
            this.lblHsSim.Size = new System.Drawing.Size(92, 13);
            this.lblHsSim.TabIndex = 1;
            this.lblHsSim.Text = "Horas Simulación:";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 129);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 10;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(960, 380);
            this.dgvDatos.TabIndex = 20;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(881, 81);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(91, 42);
            this.btnSimular.TabIndex = 22;
            this.btnSimular.Text = "SIMULAR";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTpoLlegColectivos);
            this.groupBox2.Location = new System.Drawing.Point(196, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 60);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Llegada Coletivos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "min.";
            // 
            // txtTpoLlegColectivos
            // 
            this.txtTpoLlegColectivos.Location = new System.Drawing.Point(19, 19);
            this.txtTpoLlegColectivos.Name = "txtTpoLlegColectivos";
            this.txtTpoLlegColectivos.Size = new System.Drawing.Size(42, 20);
            this.txtTpoLlegColectivos.TabIndex = 1;
            this.txtTpoLlegColectivos.Text = "6";
            this.txtTpoLlegColectivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtTpoLLeg);
            this.groupBox3.Location = new System.Drawing.Point(328, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(116, 60);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Llegada Pasajeros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "seg.";
            // 
            // txtTpoLLeg
            // 
            this.txtTpoLLeg.Location = new System.Drawing.Point(19, 19);
            this.txtTpoLLeg.Name = "txtTpoLLeg";
            this.txtTpoLLeg.Size = new System.Drawing.Size(42, 20);
            this.txtTpoLLeg.TabIndex = 1;
            this.txtTpoLLeg.Text = "30";
            this.txtTpoLLeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(984, 521);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label38);
            this.Name = "Ventana";
            this.Text = "Parada Colectivo Córdoba. Argentina";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHS;
        private System.Windows.Forms.TextBox txtUltHoras;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtHorasSim;
        private System.Windows.Forms.Label lblHsSim;
        public System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTpoLlegColectivos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTpoLLeg;
    }
}

