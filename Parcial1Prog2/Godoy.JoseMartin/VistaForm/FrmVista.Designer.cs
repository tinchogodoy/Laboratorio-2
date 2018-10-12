namespace VistaForm
{
    partial class FrmVista
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
            this.gpbDatosCurso = new System.Windows.Forms.GroupBox();
            this.txtDocumentoProfe = new System.Windows.Forms.MaskedTextBox();
            this.txtApellidoProfe = new System.Windows.Forms.TextBox();
            this.txtNombreProfe = new System.Windows.Forms.TextBox();
            this.nudAnioCurso = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.cmbDivisionCurso = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblDocumentoProfe = new System.Windows.Forms.Label();
            this.lblApellidoProfe = new System.Windows.Forms.Label();
            this.lblNombreProfe = new System.Windows.Forms.Label();
            this.lblDivisionCurso = new System.Windows.Forms.Label();
            this.lblAnioCurso = new System.Windows.Forms.Label();
            this.gpbDatosAlumnos = new System.Windows.Forms.GroupBox();
            this.txtDocumento = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.gpbDatosCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).BeginInit();
            this.gpbDatosAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDatosCurso
            // 
            this.gpbDatosCurso.Controls.Add(this.txtDocumentoProfe);
            this.gpbDatosCurso.Controls.Add(this.txtApellidoProfe);
            this.gpbDatosCurso.Controls.Add(this.txtNombreProfe);
            this.gpbDatosCurso.Controls.Add(this.nudAnioCurso);
            this.gpbDatosCurso.Controls.Add(this.dtpFechaIngreso);
            this.gpbDatosCurso.Controls.Add(this.cmbDivisionCurso);
            this.gpbDatosCurso.Controls.Add(this.btnCrear);
            this.gpbDatosCurso.Controls.Add(this.btnMostrar);
            this.gpbDatosCurso.Controls.Add(this.lblFechaIngreso);
            this.gpbDatosCurso.Controls.Add(this.lblDocumentoProfe);
            this.gpbDatosCurso.Controls.Add(this.lblApellidoProfe);
            this.gpbDatosCurso.Controls.Add(this.lblNombreProfe);
            this.gpbDatosCurso.Controls.Add(this.lblDivisionCurso);
            this.gpbDatosCurso.Controls.Add(this.lblAnioCurso);
            this.gpbDatosCurso.Location = new System.Drawing.Point(12, 0);
            this.gpbDatosCurso.Name = "gpbDatosCurso";
            this.gpbDatosCurso.Size = new System.Drawing.Size(380, 284);
            this.gpbDatosCurso.TabIndex = 0;
            this.gpbDatosCurso.TabStop = false;
            this.gpbDatosCurso.Text = "Datos Curso";
            this.gpbDatosCurso.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtDocumentoProfe
            // 
            this.txtDocumentoProfe.Location = new System.Drawing.Point(99, 152);
            this.txtDocumentoProfe.Mask = "00000000";
            this.txtDocumentoProfe.Name = "txtDocumentoProfe";
            this.txtDocumentoProfe.Size = new System.Drawing.Size(205, 20);
            this.txtDocumentoProfe.TabIndex = 23;
            // 
            // txtApellidoProfe
            // 
            this.txtApellidoProfe.Location = new System.Drawing.Point(99, 123);
            this.txtApellidoProfe.Name = "txtApellidoProfe";
            this.txtApellidoProfe.Size = new System.Drawing.Size(205, 20);
            this.txtApellidoProfe.TabIndex = 21;
            // 
            // txtNombreProfe
            // 
            this.txtNombreProfe.Location = new System.Drawing.Point(99, 92);
            this.txtNombreProfe.Name = "txtNombreProfe";
            this.txtNombreProfe.Size = new System.Drawing.Size(205, 20);
            this.txtNombreProfe.TabIndex = 20;
            this.txtNombreProfe.TextChanged += new System.EventHandler(this.txtNombreProfe_TextChanged);
            this.txtNombreProfe.MouseHover += new System.EventHandler(this.txtNombreProfe_MouseHover);
            // 
            // nudAnioCurso
            // 
            this.nudAnioCurso.Location = new System.Drawing.Point(99, 25);
            this.nudAnioCurso.Name = "nudAnioCurso";
            this.nudAnioCurso.Size = new System.Drawing.Size(105, 20);
            this.nudAnioCurso.TabIndex = 19;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(99, 186);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(205, 20);
            this.dtpFechaIngreso.TabIndex = 15;
            // 
            // cmbDivisionCurso
            // 
            this.cmbDivisionCurso.FormattingEnabled = true;
            this.cmbDivisionCurso.Location = new System.Drawing.Point(99, 58);
            this.cmbDivisionCurso.Name = "cmbDivisionCurso";
            this.cmbDivisionCurso.Size = new System.Drawing.Size(107, 21);
            this.cmbDivisionCurso.TabIndex = 11;
            this.cmbDivisionCurso.SelectedIndexChanged += new System.EventHandler(this.cmbDivisionCurso_SelectedIndexChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(6, 224);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(127, 50);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear Curso";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(247, 224);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(127, 50);
            this.btnMostrar.TabIndex = 10;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(35, 192);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(42, 13);
            this.lblFechaIngreso.TabIndex = 5;
            this.lblFechaIngreso.Text = "Ingreso";
            // 
            // lblDocumentoProfe
            // 
            this.lblDocumentoProfe.AutoSize = true;
            this.lblDocumentoProfe.Location = new System.Drawing.Point(35, 159);
            this.lblDocumentoProfe.Name = "lblDocumentoProfe";
            this.lblDocumentoProfe.Size = new System.Drawing.Size(26, 13);
            this.lblDocumentoProfe.TabIndex = 4;
            this.lblDocumentoProfe.Text = "DNI";
            this.lblDocumentoProfe.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblApellidoProfe
            // 
            this.lblApellidoProfe.AutoSize = true;
            this.lblApellidoProfe.Location = new System.Drawing.Point(35, 126);
            this.lblApellidoProfe.Name = "lblApellidoProfe";
            this.lblApellidoProfe.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoProfe.TabIndex = 3;
            this.lblApellidoProfe.Text = "Apellido";
            // 
            // lblNombreProfe
            // 
            this.lblNombreProfe.AutoSize = true;
            this.lblNombreProfe.Location = new System.Drawing.Point(35, 95);
            this.lblNombreProfe.Name = "lblNombreProfe";
            this.lblNombreProfe.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProfe.TabIndex = 2;
            this.lblNombreProfe.Text = "Nombre";
            // 
            // lblDivisionCurso
            // 
            this.lblDivisionCurso.AutoSize = true;
            this.lblDivisionCurso.Location = new System.Drawing.Point(35, 61);
            this.lblDivisionCurso.Name = "lblDivisionCurso";
            this.lblDivisionCurso.Size = new System.Drawing.Size(44, 13);
            this.lblDivisionCurso.TabIndex = 1;
            this.lblDivisionCurso.Text = "División";
            // 
            // lblAnioCurso
            // 
            this.lblAnioCurso.AutoSize = true;
            this.lblAnioCurso.Location = new System.Drawing.Point(35, 27);
            this.lblAnioCurso.Name = "lblAnioCurso";
            this.lblAnioCurso.Size = new System.Drawing.Size(26, 13);
            this.lblAnioCurso.TabIndex = 0;
            this.lblAnioCurso.Text = "Año";
            this.lblAnioCurso.Click += new System.EventHandler(this.label1_Click);
            // 
            // gpbDatosAlumnos
            // 
            this.gpbDatosAlumnos.Controls.Add(this.txtDocumento);
            this.gpbDatosAlumnos.Controls.Add(this.txtNombre);
            this.gpbDatosAlumnos.Controls.Add(this.txtApellido);
            this.gpbDatosAlumnos.Controls.Add(this.nudAnio);
            this.gpbDatosAlumnos.Controls.Add(this.cmbDivision);
            this.gpbDatosAlumnos.Controls.Add(this.btnAgregar);
            this.gpbDatosAlumnos.Controls.Add(this.lblDivision);
            this.gpbDatosAlumnos.Controls.Add(this.lblAnio);
            this.gpbDatosAlumnos.Controls.Add(this.lblDocumento);
            this.gpbDatosAlumnos.Controls.Add(this.lblApellido);
            this.gpbDatosAlumnos.Controls.Add(this.lblNombre);
            this.gpbDatosAlumnos.Location = new System.Drawing.Point(414, 0);
            this.gpbDatosAlumnos.Name = "gpbDatosAlumnos";
            this.gpbDatosAlumnos.Size = new System.Drawing.Size(381, 284);
            this.gpbDatosAlumnos.TabIndex = 1;
            this.gpbDatosAlumnos.TabStop = false;
            this.gpbDatosAlumnos.Text = "Datos Alumnos";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(111, 92);
            this.txtDocumento.Mask = "00-0000-0";
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(205, 20);
            this.txtDocumento.TabIndex = 24;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(111, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 20);
            this.txtNombre.TabIndex = 22;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(111, 58);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(205, 20);
            this.txtApellido.TabIndex = 23;
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(111, 127);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(105, 20);
            this.nudAnio.TabIndex = 18;
            // 
            // cmbDivision
            // 
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(111, 159);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(107, 21);
            this.cmbDivision.TabIndex = 12;
            this.cmbDivision.SelectedIndexChanged += new System.EventHandler(this.cmbDivision_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(248, 224);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(127, 50);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(43, 162);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(44, 13);
            this.lblDivision.TabIndex = 9;
            this.lblDivision.Text = "División";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(43, 129);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 8;
            this.lblAnio.Text = "Año";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(43, 95);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(39, 13);
            this.lblDocumento.TabIndex = 7;
            this.lblDocumento.Text = "Legajo";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(43, 61);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(43, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(12, 290);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(783, 138);
            this.rtbDatos.TabIndex = 2;
            this.rtbDatos.Text = "";
            // 
            // FrmVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 440);
            this.Controls.Add(this.rtbDatos);
            this.Controls.Add(this.gpbDatosAlumnos);
            this.Controls.Add(this.gpbDatosCurso);
            this.Name = "FrmVista";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbDatosCurso.ResumeLayout(false);
            this.gpbDatosCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).EndInit();
            this.gpbDatosAlumnos.ResumeLayout(false);
            this.gpbDatosAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatosCurso;
        private System.Windows.Forms.GroupBox gpbDatosAlumnos;
        private System.Windows.Forms.Label lblNombreProfe;
        private System.Windows.Forms.Label lblDivisionCurso;
        private System.Windows.Forms.Label lblAnioCurso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblDocumentoProfe;
        private System.Windows.Forms.Label lblApellidoProfe;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellidoProfe;
        private System.Windows.Forms.TextBox txtNombreProfe;
        private System.Windows.Forms.NumericUpDown nudAnioCurso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.ComboBox cmbDivisionCurso;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RichTextBox rtbDatos;
        private System.Windows.Forms.MaskedTextBox txtDocumentoProfe;
        private System.Windows.Forms.MaskedTextBox txtDocumento;
    }
}

