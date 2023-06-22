namespace PryEstructuraDeDatos
{
    partial class FrmBaseDatosLista
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
            this.BtnListar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CboInstrucciones = new System.Windows.Forms.ComboBox();
            this.DgvListar = new System.Windows.Forms.DataGridView();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListar)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(713, 32);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 21);
            this.BtnListar.TabIndex = 0;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operacion:";
            // 
            // CboInstrucciones
            // 
            this.CboInstrucciones.FormattingEnabled = true;
            this.CboInstrucciones.Location = new System.Drawing.Point(77, 32);
            this.CboInstrucciones.Name = "CboInstrucciones";
            this.CboInstrucciones.Size = new System.Drawing.Size(630, 21);
            this.CboInstrucciones.TabIndex = 2;
            this.CboInstrucciones.SelectedIndexChanged += new System.EventHandler(this.CboInstrucciones_SelectedIndexChanged);
            // 
            // DgvListar
            // 
            this.DgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListar.Location = new System.Drawing.Point(15, 213);
            this.DgvListar.Name = "DgvListar";
            this.DgvListar.Size = new System.Drawing.Size(773, 225);
            this.DgvListar.TabIndex = 3;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Enabled = false;
            this.TxtDescripcion.Location = new System.Drawing.Point(15, 59);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(773, 148);
            this.TxtDescripcion.TabIndex = 4;
            // 
            // FrmRepasoBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.DgvListar);
            this.Controls.Add(this.CboInstrucciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnListar);
            this.Name = "FrmRepasoBaseDatos";
            this.Text = "Repaso Base Datos";
            this.Load += new System.EventHandler(this.FrmRepasoBaseDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboInstrucciones;
        private System.Windows.Forms.DataGridView DgvListar;
        private System.Windows.Forms.TextBox TxtDescripcion;
    }
}