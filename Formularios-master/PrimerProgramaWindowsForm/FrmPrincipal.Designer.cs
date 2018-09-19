namespace PrimerProgramaWindowsForm
{
    partial class frmPrincipal
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnShowDialog = new System.Windows.Forms.Button();
            this.btnMDI = new System.Windows.Forms.Button();
            this.btnOwner = new System.Windows.Forms.Button();
            this.btnOrden = new System.Windows.Forms.Button();
            this.grbTipoOrden = new System.Windows.Forms.GroupBox();
            this.rdoArrangeIcons = new System.Windows.Forms.RadioButton();
            this.rdoTileVertical = new System.Windows.Forms.RadioButton();
            this.rdoTileHorizontal = new System.Windows.Forms.RadioButton();
            this.rdoCascade = new System.Windows.Forms.RadioButton();
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.grbTipoOrden.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(354, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrar.Location = new System.Drawing.Point(354, 71);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(148, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar con Show";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowDialog.Location = new System.Drawing.Point(354, 100);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(148, 23);
            this.btnShowDialog.TabIndex = 3;
            this.btnShowDialog.Text = "Mostrar con ShowDialog";
            this.btnShowDialog.UseVisualStyleBackColor = true;
            this.btnShowDialog.Click += new System.EventHandler(this.btnShowDialog_Click);
            // 
            // btnMDI
            // 
            this.btnMDI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMDI.Location = new System.Drawing.Point(354, 129);
            this.btnMDI.Name = "btnMDI";
            this.btnMDI.Size = new System.Drawing.Size(148, 23);
            this.btnMDI.TabIndex = 4;
            this.btnMDI.Text = "Mostrar MDI";
            this.btnMDI.UseVisualStyleBackColor = true;
            this.btnMDI.Click += new System.EventHandler(this.btnMDI_Click);
            // 
            // btnOwner
            // 
            this.btnOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOwner.Location = new System.Drawing.Point(354, 158);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(148, 23);
            this.btnOwner.TabIndex = 5;
            this.btnOwner.Text = "Mostrar con Owner";
            this.btnOwner.UseVisualStyleBackColor = true;
            this.btnOwner.Click += new System.EventHandler(this.btnOwner_Click);
            // 
            // btnOrden
            // 
            this.btnOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrden.Location = new System.Drawing.Point(354, 187);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(148, 23);
            this.btnOrden.TabIndex = 6;
            this.btnOrden.Text = "Ordena MDI";
            this.btnOrden.UseVisualStyleBackColor = true;
            this.btnOrden.Click += new System.EventHandler(this.btnOrden_Click);
            // 
            // grbTipoOrden
            // 
            this.grbTipoOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTipoOrden.Controls.Add(this.rdoArrangeIcons);
            this.grbTipoOrden.Controls.Add(this.rdoTileVertical);
            this.grbTipoOrden.Controls.Add(this.rdoTileHorizontal);
            this.grbTipoOrden.Controls.Add(this.rdoCascade);
            this.grbTipoOrden.Location = new System.Drawing.Point(353, 216);
            this.grbTipoOrden.Name = "grbTipoOrden";
            this.grbTipoOrden.Size = new System.Drawing.Size(147, 120);
            this.grbTipoOrden.TabIndex = 8;
            this.grbTipoOrden.TabStop = false;
            this.grbTipoOrden.Text = "Tipo Orden";
            // 
            // rdoArrangeIcons
            // 
            this.rdoArrangeIcons.AutoSize = true;
            this.rdoArrangeIcons.Location = new System.Drawing.Point(20, 97);
            this.rdoArrangeIcons.Name = "rdoArrangeIcons";
            this.rdoArrangeIcons.Size = new System.Drawing.Size(88, 17);
            this.rdoArrangeIcons.TabIndex = 3;
            this.rdoArrangeIcons.TabStop = true;
            this.rdoArrangeIcons.Text = "ArrangeIcons";
            this.rdoArrangeIcons.UseVisualStyleBackColor = true;
            // 
            // rdoTileVertical
            // 
            this.rdoTileVertical.AutoSize = true;
            this.rdoTileVertical.Location = new System.Drawing.Point(20, 73);
            this.rdoTileVertical.Name = "rdoTileVertical";
            this.rdoTileVertical.Size = new System.Drawing.Size(77, 17);
            this.rdoTileVertical.TabIndex = 2;
            this.rdoTileVertical.TabStop = true;
            this.rdoTileVertical.Text = "TileVertical";
            this.rdoTileVertical.UseVisualStyleBackColor = true;
            // 
            // rdoTileHorizontal
            // 
            this.rdoTileHorizontal.AutoSize = true;
            this.rdoTileHorizontal.Location = new System.Drawing.Point(20, 50);
            this.rdoTileHorizontal.Name = "rdoTileHorizontal";
            this.rdoTileHorizontal.Size = new System.Drawing.Size(89, 17);
            this.rdoTileHorizontal.TabIndex = 1;
            this.rdoTileHorizontal.TabStop = true;
            this.rdoTileHorizontal.Text = "TileHorizontal";
            this.rdoTileHorizontal.UseVisualStyleBackColor = true;
            // 
            // rdoCascade
            // 
            this.rdoCascade.AutoSize = true;
            this.rdoCascade.Location = new System.Drawing.Point(20, 27);
            this.rdoCascade.Name = "rdoCascade";
            this.rdoCascade.Size = new System.Drawing.Size(67, 17);
            this.rdoCascade.TabIndex = 0;
            this.rdoCascade.TabStop = true;
            this.rdoCascade.Text = "Cascade";
            this.rdoCascade.UseVisualStyleBackColor = true;
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMessageBox.Location = new System.Drawing.Point(354, 41);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(148, 23);
            this.btnMessageBox.TabIndex = 10;
            this.btnMessageBox.Text = "Mostrar con MessageBox";
            this.btnMessageBox.UseVisualStyleBackColor = true;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 348);
            this.Controls.Add(this.btnMessageBox);
            this.Controls.Add(this.grbTipoOrden);
            this.Controls.Add(this.btnOrden);
            this.Controls.Add(this.btnOwner);
            this.Controls.Add(this.btnMDI);
            this.Controls.Add(this.btnShowDialog);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnSalir);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.grbTipoOrden.ResumeLayout(false);
            this.grbTipoOrden.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnShowDialog;
        private System.Windows.Forms.Button btnMDI;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.Button btnOrden;
        private System.Windows.Forms.GroupBox grbTipoOrden;
        private System.Windows.Forms.RadioButton rdoArrangeIcons;
        private System.Windows.Forms.RadioButton rdoTileVertical;
        private System.Windows.Forms.RadioButton rdoTileHorizontal;
        private System.Windows.Forms.RadioButton rdoCascade;
        private System.Windows.Forms.Button btnMessageBox;
    }
}

