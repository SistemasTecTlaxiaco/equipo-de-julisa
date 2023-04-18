namespace InterfasGrafica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cmbCuidad = new System.Windows.Forms.ComboBox();
            this.lblCuidad = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.chkFiebre = new System.Windows.Forms.CheckBox();
            this.lblSintomas = new System.Windows.Forms.Label();
            this.chkDolordecabeza = new System.Windows.Forms.CheckBox();
            this.chkPresion = new System.Windows.Forms.CheckBox();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.gbxGenero = new System.Windows.Forms.GroupBox();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.gbxIngreso = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbtUrgencia = new System.Windows.Forms.RadioButton();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbxGenero.SuspendLayout();
            this.gbxIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(69, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "&Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(81, 98);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "&Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(119, 95);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(114, 20);
            this.txtEdad.TabIndex = 5;
            // 
            // cmbCuidad
            // 
            this.cmbCuidad.FormattingEnabled = true;
            this.cmbCuidad.Items.AddRange(new object[] {
            "Tlaxiaco",
            "Mexico",
            "Oaxaca",
            "Puebla",
            "Queretaro"});
            this.cmbCuidad.Location = new System.Drawing.Point(119, 126);
            this.cmbCuidad.Name = "cmbCuidad";
            this.cmbCuidad.Size = new System.Drawing.Size(121, 21);
            this.cmbCuidad.TabIndex = 6;
            // 
            // lblCuidad
            // 
            this.lblCuidad.AutoSize = true;
            this.lblCuidad.Location = new System.Drawing.Point(73, 129);
            this.lblCuidad.Name = "lblCuidad";
            this.lblCuidad.Size = new System.Drawing.Size(40, 13);
            this.lblCuidad.TabIndex = 7;
            this.lblCuidad.Text = "&Cuidad";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(69, 170);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(0, 13);
            this.lblGenero.TabIndex = 8;
            // 
            // chkFiebre
            // 
            this.chkFiebre.AutoSize = true;
            this.chkFiebre.Location = new System.Drawing.Point(119, 229);
            this.chkFiebre.Name = "chkFiebre";
            this.chkFiebre.Size = new System.Drawing.Size(55, 17);
            this.chkFiebre.TabIndex = 11;
            this.chkFiebre.Text = "Fiebre";
            this.chkFiebre.UseVisualStyleBackColor = true;
            // 
            // lblSintomas
            // 
            this.lblSintomas.AutoSize = true;
            this.lblSintomas.Location = new System.Drawing.Point(63, 229);
            this.lblSintomas.Name = "lblSintomas";
            this.lblSintomas.Size = new System.Drawing.Size(50, 13);
            this.lblSintomas.TabIndex = 12;
            this.lblSintomas.Text = "&Sintomas";
            // 
            // chkDolordecabeza
            // 
            this.chkDolordecabeza.AutoSize = true;
            this.chkDolordecabeza.Location = new System.Drawing.Point(119, 252);
            this.chkDolordecabeza.Name = "chkDolordecabeza";
            this.chkDolordecabeza.Size = new System.Drawing.Size(105, 17);
            this.chkDolordecabeza.TabIndex = 13;
            this.chkDolordecabeza.Text = "Dolor de Cabeza";
            this.chkDolordecabeza.UseVisualStyleBackColor = true;
            // 
            // chkPresion
            // 
            this.chkPresion.AutoSize = true;
            this.chkPresion.Location = new System.Drawing.Point(119, 275);
            this.chkPresion.Name = "chkPresion";
            this.chkPresion.Size = new System.Drawing.Size(61, 17);
            this.chkPresion.TabIndex = 14;
            this.chkPresion.Text = "Presion";
            this.chkPresion.UseVisualStyleBackColor = true;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(226, 170);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(0, 13);
            this.lblIngreso.TabIndex = 15;
            // 
            // gbxGenero
            // 
            this.gbxGenero.Controls.Add(this.rbtFemenino);
            this.gbxGenero.Controls.Add(this.rbtMasculino);
            this.gbxGenero.Location = new System.Drawing.Point(72, 150);
            this.gbxGenero.Name = "gbxGenero";
            this.gbxGenero.Size = new System.Drawing.Size(155, 76);
            this.gbxGenero.TabIndex = 18;
            this.gbxGenero.TabStop = false;
            this.gbxGenero.Text = "&Genero";
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(36, 43);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtFemenino.TabIndex = 12;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(36, 20);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 11;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // gbxIngreso
            // 
            this.gbxIngreso.Controls.Add(this.radioButton1);
            this.gbxIngreso.Controls.Add(this.rbtUrgencia);
            this.gbxIngreso.Location = new System.Drawing.Point(266, 150);
            this.gbxIngreso.Name = "gbxIngreso";
            this.gbxIngreso.Size = new System.Drawing.Size(133, 76);
            this.gbxIngreso.TabIndex = 19;
            this.gbxIngreso.TabStop = false;
            this.gbxIngreso.Text = "Tipo de ingreso";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(105, 17);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Consulta Externa";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbtUrgencia
            // 
            this.rbtUrgencia.AutoSize = true;
            this.rbtUrgencia.Location = new System.Drawing.Point(6, 20);
            this.rbtUrgencia.Name = "rbtUrgencia";
            this.rbtUrgencia.Size = new System.Drawing.Size(73, 17);
            this.rbtUrgencia.TabIndex = 18;
            this.rbtUrgencia.TabStop = true;
            this.rbtUrgencia.Text = "Urgencias";
            this.rbtUrgencia.UseVisualStyleBackColor = true;
            // 
            // pbxImagen
            // 
            this.pbxImagen.Image = global::InterfasGrafica.Properties.Resources.images;
            this.pbxImagen.Location = new System.Drawing.Point(365, 12);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(216, 135);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 20;
            this.pbxImagen.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::InterfasGrafica.Properties.Resources.can;
            this.btnCancelar.Location = new System.Drawing.Point(390, 343);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 59);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::InterfasGrafica.Properties.Resources.aceptar;
            this.btnAceptar.Location = new System.Drawing.Point(143, 343);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 52);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.lblAceptar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.AutoSize = true;
            this.txtApellido.Location = new System.Drawing.Point(69, 65);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(44, 13);
            this.txtApellido.TabIndex = 24;
            this.txtApellido.Text = "Apellido";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(593, 430);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.gbxIngreso);
            this.Controls.Add(this.gbxGenero);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.chkPresion);
            this.Controls.Add(this.chkDolordecabeza);
            this.Controls.Add(this.lblSintomas);
            this.Controls.Add(this.chkFiebre);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblCuidad);
            this.Controls.Add(this.cmbCuidad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.Text = "Registros de paciente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxGenero.ResumeLayout(false);
            this.gbxGenero.PerformLayout();
            this.gbxIngreso.ResumeLayout(false);
            this.gbxIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cmbCuidad;
        private System.Windows.Forms.Label lblCuidad;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.CheckBox chkFiebre;
        private System.Windows.Forms.Label lblSintomas;
        private System.Windows.Forms.CheckBox chkDolordecabeza;
        private System.Windows.Forms.CheckBox chkPresion;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.GroupBox gbxGenero;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.GroupBox gbxIngreso;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbtUrgencia;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label txtApellido;
        private System.Windows.Forms.TextBox textBox1;
    }
}

