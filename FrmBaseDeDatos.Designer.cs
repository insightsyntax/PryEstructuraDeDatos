
namespace PryEstructuraDeDatos
{
    partial class FrmBaseDeDatos
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
            this.DgvBaseDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnJuntar = new System.Windows.Forms.Button();
            this.BtnProyMulti = new System.Windows.Forms.Button();
            this.BtnProySimple = new System.Windows.Forms.Button();
            this.BtnSeleccionSimple = new System.Windows.Forms.Button();
            this.BtnSeleccionMultiatributo = new System.Windows.Forms.Button();
            this.BtnSeleccionConvolucion = new System.Windows.Forms.Button();
            this.BtnUnion = new System.Windows.Forms.Button();
            this.BtnInterseccion = new System.Windows.Forms.Button();
            this.BtnDiferencia = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBaseDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvBaseDatos
            // 
            this.DgvBaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBaseDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.DgvBaseDatos.Location = new System.Drawing.Point(0, 0);
            this.DgvBaseDatos.Name = "DgvBaseDatos";
            this.DgvBaseDatos.Size = new System.Drawing.Size(898, 203);
            this.DgvBaseDatos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnJuntar);
            this.groupBox1.Controls.Add(this.BtnProyMulti);
            this.groupBox1.Controls.Add(this.BtnProySimple);
            this.groupBox1.Location = new System.Drawing.Point(12, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones de proyeccion - SELECT";
            // 
            // BtnJuntar
            // 
            this.BtnJuntar.Location = new System.Drawing.Point(16, 100);
            this.BtnJuntar.Name = "BtnJuntar";
            this.BtnJuntar.Size = new System.Drawing.Size(252, 23);
            this.BtnJuntar.TabIndex = 0;
            this.BtnJuntar.Text = "Juntar";
            this.BtnJuntar.UseVisualStyleBackColor = true;
            this.BtnJuntar.Click += new System.EventHandler(this.BtnJuntar_Click);
            // 
            // BtnProyMulti
            // 
            this.BtnProyMulti.Location = new System.Drawing.Point(16, 60);
            this.BtnProyMulti.Name = "BtnProyMulti";
            this.BtnProyMulti.Size = new System.Drawing.Size(252, 23);
            this.BtnProyMulti.TabIndex = 0;
            this.BtnProyMulti.Text = "Proyeccion multiatributo";
            this.BtnProyMulti.UseVisualStyleBackColor = true;
            this.BtnProyMulti.Click += new System.EventHandler(this.BtnProyMulti_Click);
            // 
            // BtnProySimple
            // 
            this.BtnProySimple.Location = new System.Drawing.Point(16, 19);
            this.BtnProySimple.Name = "BtnProySimple";
            this.BtnProySimple.Size = new System.Drawing.Size(252, 23);
            this.BtnProySimple.TabIndex = 0;
            this.BtnProySimple.Text = "Proyeccion simple";
            this.BtnProySimple.UseVisualStyleBackColor = true;
            this.BtnProySimple.Click += new System.EventHandler(this.BtnProySimple_Click);
            // 
            // BtnSeleccionSimple
            // 
            this.BtnSeleccionSimple.Location = new System.Drawing.Point(16, 19);
            this.BtnSeleccionSimple.Name = "BtnSeleccionSimple";
            this.BtnSeleccionSimple.Size = new System.Drawing.Size(252, 23);
            this.BtnSeleccionSimple.TabIndex = 0;
            this.BtnSeleccionSimple.Text = "Seleccion simple";
            this.BtnSeleccionSimple.UseVisualStyleBackColor = true;
            this.BtnSeleccionSimple.Click += new System.EventHandler(this.BtnSeleccionSimple_Click);
            // 
            // BtnSeleccionMultiatributo
            // 
            this.BtnSeleccionMultiatributo.Location = new System.Drawing.Point(16, 60);
            this.BtnSeleccionMultiatributo.Name = "BtnSeleccionMultiatributo";
            this.BtnSeleccionMultiatributo.Size = new System.Drawing.Size(252, 23);
            this.BtnSeleccionMultiatributo.TabIndex = 0;
            this.BtnSeleccionMultiatributo.Text = "Seleccion multiatributo";
            this.BtnSeleccionMultiatributo.UseVisualStyleBackColor = true;
            this.BtnSeleccionMultiatributo.Click += new System.EventHandler(this.BtnSeleccionMultiatributo_Click);
            // 
            // BtnSeleccionConvolucion
            // 
            this.BtnSeleccionConvolucion.Location = new System.Drawing.Point(16, 100);
            this.BtnSeleccionConvolucion.Name = "BtnSeleccionConvolucion";
            this.BtnSeleccionConvolucion.Size = new System.Drawing.Size(252, 23);
            this.BtnSeleccionConvolucion.TabIndex = 0;
            this.BtnSeleccionConvolucion.Text = "Seleccion por convolucion";
            this.BtnSeleccionConvolucion.UseVisualStyleBackColor = true;
            this.BtnSeleccionConvolucion.Click += new System.EventHandler(this.BtnSeleccionConvolucion_Click);
            // 
            // BtnUnion
            // 
            this.BtnUnion.Location = new System.Drawing.Point(16, 19);
            this.BtnUnion.Name = "BtnUnion";
            this.BtnUnion.Size = new System.Drawing.Size(252, 23);
            this.BtnUnion.TabIndex = 0;
            this.BtnUnion.Text = "Union";
            this.BtnUnion.UseVisualStyleBackColor = true;
            this.BtnUnion.Click += new System.EventHandler(this.BtnUnion_Click);
            // 
            // BtnInterseccion
            // 
            this.BtnInterseccion.Location = new System.Drawing.Point(16, 60);
            this.BtnInterseccion.Name = "BtnInterseccion";
            this.BtnInterseccion.Size = new System.Drawing.Size(252, 23);
            this.BtnInterseccion.TabIndex = 0;
            this.BtnInterseccion.Text = "Interseccion";
            this.BtnInterseccion.UseVisualStyleBackColor = true;
            this.BtnInterseccion.Click += new System.EventHandler(this.BtnInterseccion_Click);
            // 
            // BtnDiferencia
            // 
            this.BtnDiferencia.Location = new System.Drawing.Point(16, 100);
            this.BtnDiferencia.Name = "BtnDiferencia";
            this.BtnDiferencia.Size = new System.Drawing.Size(252, 23);
            this.BtnDiferencia.TabIndex = 0;
            this.BtnDiferencia.Text = "Diferencia";
            this.BtnDiferencia.UseVisualStyleBackColor = true;
            this.BtnDiferencia.Click += new System.EventHandler(this.BtnDiferencia_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSeleccionSimple);
            this.groupBox2.Controls.Add(this.BtnSeleccionMultiatributo);
            this.groupBox2.Controls.Add(this.BtnSeleccionConvolucion);
            this.groupBox2.Location = new System.Drawing.Point(312, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 143);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones de seleccion - WHERE";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnUnion);
            this.groupBox3.Controls.Add(this.BtnInterseccion);
            this.groupBox3.Controls.Add(this.BtnDiferencia);
            this.groupBox3.Location = new System.Drawing.Point(609, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 142);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones Algebraicas";
            // 
            // FrmBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 362);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvBaseDatos);
            this.Name = "FrmBaseDeDatos";
            this.Text = "Base de datos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvBaseDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBaseDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnJuntar;
        private System.Windows.Forms.Button BtnProyMulti;
        private System.Windows.Forms.Button BtnProySimple;
        private System.Windows.Forms.Button BtnSeleccionSimple;
        private System.Windows.Forms.Button BtnSeleccionMultiatributo;
        private System.Windows.Forms.Button BtnSeleccionConvolucion;
        private System.Windows.Forms.Button BtnUnion;
        private System.Windows.Forms.Button BtnInterseccion;
        private System.Windows.Forms.Button BtnDiferencia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}