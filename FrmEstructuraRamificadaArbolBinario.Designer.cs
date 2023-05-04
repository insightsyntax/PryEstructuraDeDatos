namespace PryEstructuraDeDatos
{
    partial class FrmEstructuraRamificadaArbolBinario
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
            this.GrpBotones = new System.Windows.Forms.GroupBox();
            this.BtnListar = new System.Windows.Forms.Button();
            this.RbtnOrder = new System.Windows.Forms.RadioButton();
            this.RbtnDescendente = new System.Windows.Forms.RadioButton();
            this.RbtnAscendente = new System.Windows.Forms.RadioButton();
            this.RbtnPreOrder = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GrpListaGrilla = new System.Windows.Forms.GroupBox();
            this.LstArbolBinario = new System.Windows.Forms.ListBox();
            this.DgvArbolBinario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpElementoEliminado = new System.Windows.Forms.GroupBox();
            this.CboCodigo = new System.Windows.Forms.ComboBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LblCodigoEliminar = new System.Windows.Forms.Label();
            this.GrpNuevoElemento = new System.Windows.Forms.GroupBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtTramite = new System.Windows.Forms.TextBox();
            this.LblTramite = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.GrpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GrpListaGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArbolBinario)).BeginInit();
            this.GrpElementoEliminado.SuspendLayout();
            this.GrpNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBotones
            // 
            this.GrpBotones.Controls.Add(this.BtnListar);
            this.GrpBotones.Controls.Add(this.RbtnOrder);
            this.GrpBotones.Controls.Add(this.RbtnDescendente);
            this.GrpBotones.Controls.Add(this.RbtnAscendente);
            this.GrpBotones.Controls.Add(this.RbtnPreOrder);
            this.GrpBotones.Location = new System.Drawing.Point(464, 11);
            this.GrpBotones.Margin = new System.Windows.Forms.Padding(2);
            this.GrpBotones.Name = "GrpBotones";
            this.GrpBotones.Padding = new System.Windows.Forms.Padding(2);
            this.GrpBotones.Size = new System.Drawing.Size(128, 197);
            this.GrpBotones.TabIndex = 29;
            this.GrpBotones.TabStop = false;
            this.GrpBotones.Text = "Elija como se listarán los elementos";
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(13, 158);
            this.BtnListar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(98, 35);
            this.BtnListar.TabIndex = 23;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // RbtnOrder
            // 
            this.RbtnOrder.AutoSize = true;
            this.RbtnOrder.Location = new System.Drawing.Point(13, 129);
            this.RbtnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.RbtnOrder.Name = "RbtnOrder";
            this.RbtnOrder.Size = new System.Drawing.Size(75, 17);
            this.RbtnOrder.TabIndex = 18;
            this.RbtnOrder.TabStop = true;
            this.RbtnOrder.Text = "Post Order";
            this.RbtnOrder.UseVisualStyleBackColor = true;
            // 
            // RbtnDescendente
            // 
            this.RbtnDescendente.AutoSize = true;
            this.RbtnDescendente.Location = new System.Drawing.Point(13, 63);
            this.RbtnDescendente.Margin = new System.Windows.Forms.Padding(2);
            this.RbtnDescendente.Name = "RbtnDescendente";
            this.RbtnDescendente.Size = new System.Drawing.Size(89, 17);
            this.RbtnDescendente.TabIndex = 16;
            this.RbtnDescendente.TabStop = true;
            this.RbtnDescendente.Text = "Descendente";
            this.RbtnDescendente.UseVisualStyleBackColor = true;
            // 
            // RbtnAscendente
            // 
            this.RbtnAscendente.AutoSize = true;
            this.RbtnAscendente.Location = new System.Drawing.Point(13, 30);
            this.RbtnAscendente.Margin = new System.Windows.Forms.Padding(2);
            this.RbtnAscendente.Name = "RbtnAscendente";
            this.RbtnAscendente.Size = new System.Drawing.Size(82, 17);
            this.RbtnAscendente.TabIndex = 15;
            this.RbtnAscendente.TabStop = true;
            this.RbtnAscendente.Text = "Ascendente";
            this.RbtnAscendente.UseVisualStyleBackColor = true;
            // 
            // RbtnPreOrder
            // 
            this.RbtnPreOrder.AutoSize = true;
            this.RbtnPreOrder.Location = new System.Drawing.Point(13, 96);
            this.RbtnPreOrder.Margin = new System.Windows.Forms.Padding(2);
            this.RbtnPreOrder.Name = "RbtnPreOrder";
            this.RbtnPreOrder.Size = new System.Drawing.Size(70, 17);
            this.RbtnPreOrder.TabIndex = 17;
            this.RbtnPreOrder.TabStop = true;
            this.RbtnPreOrder.Text = "Pre Order";
            this.RbtnPreOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RbtnPreOrder.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // GrpListaGrilla
            // 
            this.GrpListaGrilla.Controls.Add(this.LstArbolBinario);
            this.GrpListaGrilla.Controls.Add(this.DgvArbolBinario);
            this.GrpListaGrilla.Location = new System.Drawing.Point(12, 214);
            this.GrpListaGrilla.Margin = new System.Windows.Forms.Padding(2);
            this.GrpListaGrilla.Name = "GrpListaGrilla";
            this.GrpListaGrilla.Padding = new System.Windows.Forms.Padding(2);
            this.GrpListaGrilla.Size = new System.Drawing.Size(754, 263);
            this.GrpListaGrilla.TabIndex = 28;
            this.GrpListaGrilla.TabStop = false;
            this.GrpListaGrilla.Text = "Listado en una lista y una grilla";
            // 
            // LstArbolBinario
            // 
            this.LstArbolBinario.FormattingEnabled = true;
            this.LstArbolBinario.Location = new System.Drawing.Point(4, 17);
            this.LstArbolBinario.Margin = new System.Windows.Forms.Padding(2);
            this.LstArbolBinario.Name = "LstArbolBinario";
            this.LstArbolBinario.Size = new System.Drawing.Size(163, 238);
            this.LstArbolBinario.TabIndex = 0;
            // 
            // DgvArbolBinario
            // 
            this.DgvArbolBinario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvArbolBinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArbolBinario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvArbolBinario.Location = new System.Drawing.Point(181, 17);
            this.DgvArbolBinario.Margin = new System.Windows.Forms.Padding(2);
            this.DgvArbolBinario.Name = "DgvArbolBinario";
            this.DgvArbolBinario.RowHeadersWidth = 51;
            this.DgvArbolBinario.RowTemplate.Height = 24;
            this.DgvArbolBinario.Size = new System.Drawing.Size(569, 242);
            this.DgvArbolBinario.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trámite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // GrpElementoEliminado
            // 
            this.GrpElementoEliminado.Controls.Add(this.CboCodigo);
            this.GrpElementoEliminado.Controls.Add(this.BtnEliminar);
            this.GrpElementoEliminado.Controls.Add(this.LblCodigoEliminar);
            this.GrpElementoEliminado.Location = new System.Drawing.Point(596, 93);
            this.GrpElementoEliminado.Margin = new System.Windows.Forms.Padding(2);
            this.GrpElementoEliminado.Name = "GrpElementoEliminado";
            this.GrpElementoEliminado.Padding = new System.Windows.Forms.Padding(2);
            this.GrpElementoEliminado.Size = new System.Drawing.Size(170, 115);
            this.GrpElementoEliminado.TabIndex = 27;
            this.GrpElementoEliminado.TabStop = false;
            this.GrpElementoEliminado.Text = "Elemento Eliminado";
            // 
            // CboCodigo
            // 
            this.CboCodigo.FormattingEnabled = true;
            this.CboCodigo.Location = new System.Drawing.Point(56, 32);
            this.CboCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.CboCodigo.Name = "CboCodigo";
            this.CboCodigo.Size = new System.Drawing.Size(92, 21);
            this.CboCodigo.TabIndex = 3;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(56, 67);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(92, 29);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // LblCodigoEliminar
            // 
            this.LblCodigoEliminar.AutoSize = true;
            this.LblCodigoEliminar.Location = new System.Drawing.Point(11, 36);
            this.LblCodigoEliminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCodigoEliminar.Name = "LblCodigoEliminar";
            this.LblCodigoEliminar.Size = new System.Drawing.Size(43, 13);
            this.LblCodigoEliminar.TabIndex = 2;
            this.LblCodigoEliminar.Text = "Código:";
            // 
            // GrpNuevoElemento
            // 
            this.GrpNuevoElemento.Controls.Add(this.BtnAgregar);
            this.GrpNuevoElemento.Controls.Add(this.TxtNombre);
            this.GrpNuevoElemento.Controls.Add(this.TxtCodigo);
            this.GrpNuevoElemento.Controls.Add(this.TxtTramite);
            this.GrpNuevoElemento.Controls.Add(this.LblTramite);
            this.GrpNuevoElemento.Controls.Add(this.LblNombre);
            this.GrpNuevoElemento.Controls.Add(this.LblCodigo);
            this.GrpNuevoElemento.Location = new System.Drawing.Point(261, 11);
            this.GrpNuevoElemento.Margin = new System.Windows.Forms.Padding(2);
            this.GrpNuevoElemento.Name = "GrpNuevoElemento";
            this.GrpNuevoElemento.Padding = new System.Windows.Forms.Padding(2);
            this.GrpNuevoElemento.Size = new System.Drawing.Size(186, 197);
            this.GrpNuevoElemento.TabIndex = 26;
            this.GrpNuevoElemento.TabStop = false;
            this.GrpNuevoElemento.Text = "Nuevo Elemento";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(44, 148);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(99, 35);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(92, 74);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.MaxLength = 12;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(76, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(113, 32);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCodigo.MaxLength = 8;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(54, 20);
            this.TxtCodigo.TabIndex = 3;
            this.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTramite
            // 
            this.TxtTramite.Location = new System.Drawing.Point(92, 116);
            this.TxtTramite.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTramite.Name = "TxtTramite";
            this.TxtTramite.Size = new System.Drawing.Size(76, 20);
            this.TxtTramite.TabIndex = 4;
            // 
            // LblTramite
            // 
            this.LblTramite.AutoSize = true;
            this.LblTramite.Location = new System.Drawing.Point(24, 119);
            this.LblTramite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTramite.Name = "LblTramite";
            this.LblTramite.Size = new System.Drawing.Size(45, 13);
            this.LblTramite.TabIndex = 4;
            this.LblTramite.Text = "Trámite:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(24, 76);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 13);
            this.LblNombre.TabIndex = 3;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(24, 34);
            this.LblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(43, 13);
            this.LblCodigo.TabIndex = 2;
            this.LblCodigo.Text = "Código:";
            // 
            // FrmEstructuraRamificadaArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 482);
            this.Controls.Add(this.GrpBotones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GrpListaGrilla);
            this.Controls.Add(this.GrpElementoEliminado);
            this.Controls.Add(this.GrpNuevoElemento);
            this.Name = "FrmEstructuraRamificadaArbolBinario";
            this.Text = "Estructura Ramificadas - Arbol Binario";
            this.GrpBotones.ResumeLayout(false);
            this.GrpBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GrpListaGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArbolBinario)).EndInit();
            this.GrpElementoEliminado.ResumeLayout(false);
            this.GrpElementoEliminado.PerformLayout();
            this.GrpNuevoElemento.ResumeLayout(false);
            this.GrpNuevoElemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBotones;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.RadioButton RbtnOrder;
        private System.Windows.Forms.RadioButton RbtnDescendente;
        private System.Windows.Forms.RadioButton RbtnAscendente;
        private System.Windows.Forms.RadioButton RbtnPreOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GrpListaGrilla;
        private System.Windows.Forms.ListBox LstArbolBinario;
        private System.Windows.Forms.DataGridView DgvArbolBinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox GrpElementoEliminado;
        private System.Windows.Forms.ComboBox CboCodigo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label LblCodigoEliminar;
        private System.Windows.Forms.GroupBox GrpNuevoElemento;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtTramite;
        private System.Windows.Forms.Label LblTramite;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCodigo;
    }
}