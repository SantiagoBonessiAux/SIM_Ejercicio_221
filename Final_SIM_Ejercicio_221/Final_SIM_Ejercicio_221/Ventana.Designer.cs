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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana));
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
            this.txtTpoLLegPasajeros = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTpoSubirPasajero = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTpoEsperaMaximaPasajeros = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCapacidadColectivos = new System.Windows.Forms.TextBox();
            this.chPasajColect = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(12, 3);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 68);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // lblHS
            // 
            this.lblHS.AutoSize = true;
            this.lblHS.Location = new System.Drawing.Point(153, 40);
            this.lblHS.Name = "lblHS";
            this.lblHS.Size = new System.Drawing.Size(20, 13);
            this.lblHS.TabIndex = 5;
            this.lblHS.Text = "Hs";
            // 
            // txtUltHoras
            // 
            this.txtUltHoras.Location = new System.Drawing.Point(96, 37);
            this.txtUltHoras.Name = "txtUltHoras";
            this.txtUltHoras.Size = new System.Drawing.Size(51, 20);
            this.txtUltHoras.TabIndex = 4;
            this.txtUltHoras.Text = "1";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(10, 40);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(80, 13);
            this.label30.TabIndex = 3;
            this.label30.Text = "Mostrar últimas:";
            // 
            // txtHorasSim
            // 
            this.txtHorasSim.Location = new System.Drawing.Point(108, 11);
            this.txtHorasSim.Name = "txtHorasSim";
            this.txtHorasSim.Size = new System.Drawing.Size(68, 20);
            this.txtHorasSim.TabIndex = 2;
            this.txtHorasSim.Text = "1";
            // 
            // lblHsSim
            // 
            this.lblHsSim.AutoSize = true;
            this.lblHsSim.Location = new System.Drawing.Point(10, 14);
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
            this.dgvDatos.Location = new System.Drawing.Point(12, 105);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 10;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(1235, 479);
            this.dgvDatos.TabIndex = 20;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(1036, 31);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(183, 60);
            this.btnSimular.TabIndex = 22;
            this.btnSimular.Text = "SIMULAR";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTpoLlegColectivos);
            this.groupBox2.Location = new System.Drawing.Point(200, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 50);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Promedio Llegada Coletivos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "min.";
            // 
            // txtTpoLlegColectivos
            // 
            this.txtTpoLlegColectivos.Location = new System.Drawing.Point(39, 19);
            this.txtTpoLlegColectivos.Name = "txtTpoLlegColectivos";
            this.txtTpoLlegColectivos.Size = new System.Drawing.Size(42, 20);
            this.txtTpoLlegColectivos.TabIndex = 1;
            this.txtTpoLlegColectivos.Text = "6";
            this.txtTpoLlegColectivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtTpoLLegPasajeros);
            this.groupBox3.Location = new System.Drawing.Point(359, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 50);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Promedio Llegada Pasajeros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "seg.";
            // 
            // txtTpoLLegPasajeros
            // 
            this.txtTpoLLegPasajeros.Location = new System.Drawing.Point(46, 19);
            this.txtTpoLLegPasajeros.Name = "txtTpoLLegPasajeros";
            this.txtTpoLLegPasajeros.Size = new System.Drawing.Size(42, 20);
            this.txtTpoLLegPasajeros.TabIndex = 1;
            this.txtTpoLLegPasajeros.Text = "30";
            this.txtTpoLLegPasajeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtTpoSubirPasajero);
            this.groupBox4.Location = new System.Drawing.Point(848, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(153, 50);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tiempo Ascenso Pasajeros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "seg.";
            // 
            // txtTpoSubirPasajero
            // 
            this.txtTpoSubirPasajero.Location = new System.Drawing.Point(26, 19);
            this.txtTpoSubirPasajero.Name = "txtTpoSubirPasajero";
            this.txtTpoSubirPasajero.Size = new System.Drawing.Size(42, 20);
            this.txtTpoSubirPasajero.TabIndex = 1;
            this.txtTpoSubirPasajero.Text = "5";
            this.txtTpoSubirPasajero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtTpoEsperaMaximaPasajeros);
            this.groupBox5.Location = new System.Drawing.Point(656, 38);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(186, 50);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tiempo espera Máxima Pasajeros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "min.";
            // 
            // txtTpoEsperaMaximaPasajeros
            // 
            this.txtTpoEsperaMaximaPasajeros.Location = new System.Drawing.Point(52, 19);
            this.txtTpoEsperaMaximaPasajeros.Name = "txtTpoEsperaMaximaPasajeros";
            this.txtTpoEsperaMaximaPasajeros.Size = new System.Drawing.Size(42, 20);
            this.txtTpoEsperaMaximaPasajeros.TabIndex = 1;
            this.txtTpoEsperaMaximaPasajeros.Text = "10";
            this.txtTpoEsperaMaximaPasajeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.txtCapacidadColectivos);
            this.groupBox6.Location = new System.Drawing.Point(523, 38);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(127, 50);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Capacidad Coletivos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "pasajeros";
            // 
            // txtCapacidadColectivos
            // 
            this.txtCapacidadColectivos.Location = new System.Drawing.Point(18, 20);
            this.txtCapacidadColectivos.Name = "txtCapacidadColectivos";
            this.txtCapacidadColectivos.Size = new System.Drawing.Size(42, 20);
            this.txtCapacidadColectivos.TabIndex = 1;
            this.txtCapacidadColectivos.Text = "40";
            this.txtCapacidadColectivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chPasajColect
            // 
            this.chPasajColect.AutoSize = true;
            this.chPasajColect.Location = new System.Drawing.Point(1036, 11);
            this.chPasajColect.Name = "chPasajColect";
            this.chPasajColect.Size = new System.Drawing.Size(170, 17);
            this.chPasajColect.TabIndex = 28;
            this.chPasajColect.Text = "Mostrar Pasajeros y Colectivos";
            this.chPasajColect.UseVisualStyleBackColor = true;
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1259, 596);
            this.Controls.Add(this.chPasajColect);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label38);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ventana";
            this.Text = "SIMULACIÓN - Parada Colectivo Córdoba ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
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
        private System.Windows.Forms.TextBox txtTpoLLegPasajeros;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTpoSubirPasajero;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTpoEsperaMaximaPasajeros;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCapacidadColectivos;
        private System.Windows.Forms.CheckBox chPasajColect;
    }
}

