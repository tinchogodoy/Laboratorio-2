namespace PrimerProgramaWindowsForm
{
    partial class FrmPantalla2
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
            this.chkEnviaPublicidad = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grbNacionalidad = new System.Windows.Forms.GroupBox();
            this.rdoExtranjero = new System.Windows.Forms.RadioButton();
            this.rdoArgentino = new System.Windows.Forms.RadioButton();
            this.lstPosicion = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.grbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rdoViudo = new System.Windows.Forms.RadioButton();
            this.rdoDivorciado = new System.Windows.Forms.RadioButton();
            this.rdoCasado = new System.Windows.Forms.RadioButton();
            this.rdoSoltero = new System.Windows.Forms.RadioButton();
            this.grbNacionalidad.SuspendLayout();
            this.grbEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkEnviaPublicidad
            // 
            this.chkEnviaPublicidad.AutoSize = true;
            this.chkEnviaPublicidad.Checked = true;
            this.chkEnviaPublicidad.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkEnviaPublicidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkEnviaPublicidad.Location = new System.Drawing.Point(42, 22);
            this.chkEnviaPublicidad.Name = "chkEnviaPublicidad";
            this.chkEnviaPublicidad.Size = new System.Drawing.Size(105, 17);
            this.chkEnviaPublicidad.TabIndex = 0;
            this.chkEnviaPublicidad.Text = "Envia Publicidad";
            this.chkEnviaPublicidad.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(78, 180);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // grbNacionalidad
            // 
            this.grbNacionalidad.Controls.Add(this.rdoExtranjero);
            this.grbNacionalidad.Controls.Add(this.rdoArgentino);
            this.grbNacionalidad.Location = new System.Drawing.Point(52, 55);
            this.grbNacionalidad.Name = "grbNacionalidad";
            this.grbNacionalidad.Size = new System.Drawing.Size(200, 111);
            this.grbNacionalidad.TabIndex = 2;
            this.grbNacionalidad.TabStop = false;
            this.grbNacionalidad.Text = "Estudiante";
            // 
            // rdoExtranjero
            // 
            this.rdoExtranjero.AutoSize = true;
            this.rdoExtranjero.Location = new System.Drawing.Point(10, 70);
            this.rdoExtranjero.Name = "rdoExtranjero";
            this.rdoExtranjero.Size = new System.Drawing.Size(72, 17);
            this.rdoExtranjero.TabIndex = 1;
            this.rdoExtranjero.TabStop = true;
            this.rdoExtranjero.Text = "Extranjero";
            this.rdoExtranjero.UseVisualStyleBackColor = true;
            // 
            // rdoArgentino
            // 
            this.rdoArgentino.AutoSize = true;
            this.rdoArgentino.Location = new System.Drawing.Point(10, 32);
            this.rdoArgentino.Name = "rdoArgentino";
            this.rdoArgentino.Size = new System.Drawing.Size(70, 17);
            this.rdoArgentino.TabIndex = 0;
            this.rdoArgentino.TabStop = true;
            this.rdoArgentino.Text = "Argentino";
            this.rdoArgentino.UseVisualStyleBackColor = true;
            // 
            // lstPosicion
            // 
            this.lstPosicion.FormattingEnabled = true;
            this.lstPosicion.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero",
            "Cuarto",
            "Quinto",
            "Sesto",
            "Septimo"});
            this.lstPosicion.Location = new System.Drawing.Point(474, 71);
            this.lstPosicion.Name = "lstPosicion";
            this.lstPosicion.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPosicion.Size = new System.Drawing.Size(120, 95);
            this.lstPosicion.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(237, 185);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(295, 185);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Items.AddRange(new object[] {
            "Argentina",
            "Bolivia",
            "Brasil",
            "Chile",
            "Ecuador",
            "Paraguay",
            "Peru",
            "Uruguay",
            "Venezuela"});
            this.cmbPais.Location = new System.Drawing.Point(258, 22);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(121, 21);
            this.cmbPais.TabIndex = 8;
            // 
            // grbEstadoCivil
            // 
            this.grbEstadoCivil.Controls.Add(this.rdoViudo);
            this.grbEstadoCivil.Controls.Add(this.rdoDivorciado);
            this.grbEstadoCivil.Controls.Add(this.rdoCasado);
            this.grbEstadoCivil.Controls.Add(this.rdoSoltero);
            this.grbEstadoCivil.Location = new System.Drawing.Point(258, 61);
            this.grbEstadoCivil.Name = "grbEstadoCivil";
            this.grbEstadoCivil.Size = new System.Drawing.Size(200, 100);
            this.grbEstadoCivil.TabIndex = 11;
            this.grbEstadoCivil.TabStop = false;
            this.grbEstadoCivil.Text = "Estado Civil";
            // 
            // rdoViudo
            // 
            this.rdoViudo.AutoSize = true;
            this.rdoViudo.Location = new System.Drawing.Point(95, 64);
            this.rdoViudo.Name = "rdoViudo";
            this.rdoViudo.Size = new System.Drawing.Size(52, 17);
            this.rdoViudo.TabIndex = 14;
            this.rdoViudo.TabStop = true;
            this.rdoViudo.Text = "Viudo";
            this.rdoViudo.UseVisualStyleBackColor = true;
            // 
            // rdoDivorciado
            // 
            this.rdoDivorciado.AutoSize = true;
            this.rdoDivorciado.Location = new System.Drawing.Point(95, 26);
            this.rdoDivorciado.Name = "rdoDivorciado";
            this.rdoDivorciado.Size = new System.Drawing.Size(76, 17);
            this.rdoDivorciado.TabIndex = 13;
            this.rdoDivorciado.TabStop = true;
            this.rdoDivorciado.Text = "Divorciado";
            this.rdoDivorciado.UseVisualStyleBackColor = true;
            // 
            // rdoCasado
            // 
            this.rdoCasado.AutoSize = true;
            this.rdoCasado.Location = new System.Drawing.Point(6, 64);
            this.rdoCasado.Name = "rdoCasado";
            this.rdoCasado.Size = new System.Drawing.Size(61, 17);
            this.rdoCasado.TabIndex = 12;
            this.rdoCasado.TabStop = true;
            this.rdoCasado.Text = "Casado";
            this.rdoCasado.UseVisualStyleBackColor = true;
            // 
            // rdoSoltero
            // 
            this.rdoSoltero.AutoSize = true;
            this.rdoSoltero.Location = new System.Drawing.Point(9, 26);
            this.rdoSoltero.Name = "rdoSoltero";
            this.rdoSoltero.Size = new System.Drawing.Size(58, 17);
            this.rdoSoltero.TabIndex = 11;
            this.rdoSoltero.TabStop = true;
            this.rdoSoltero.Text = "Soltero";
            this.rdoSoltero.UseVisualStyleBackColor = true;
            // 
            // FrmPantalla2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 400);
            this.Controls.Add(this.grbEstadoCivil);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstPosicion);
            this.Controls.Add(this.grbNacionalidad);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.chkEnviaPublicidad);
            this.Name = "FrmPantalla2";
            this.Text = "Controles";
            this.Load += new System.EventHandler(this.FrmPantalla2_Load);
            this.grbNacionalidad.ResumeLayout(false);
            this.grbNacionalidad.PerformLayout();
            this.grbEstadoCivil.ResumeLayout(false);
            this.grbEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEnviaPublicidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox grbNacionalidad;
        private System.Windows.Forms.RadioButton rdoExtranjero;
        private System.Windows.Forms.RadioButton rdoArgentino;
        private System.Windows.Forms.ListBox lstPosicion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.GroupBox grbEstadoCivil;
        private System.Windows.Forms.RadioButton rdoViudo;
        private System.Windows.Forms.RadioButton rdoDivorciado;
        private System.Windows.Forms.RadioButton rdoCasado;
        private System.Windows.Forms.RadioButton rdoSoltero;
    }
}