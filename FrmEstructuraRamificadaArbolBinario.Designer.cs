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
            this.GboBotones = new System.Windows.Forms.GroupBox();
            this.BtnListar = new System.Windows.Forms.Button();
            this.RdbPostOrder = new System.Windows.Forms.RadioButton();
            this.RdbDescendiente = new System.Windows.Forms.RadioButton();
            this.RdbAscendiente = new System.Windows.Forms.RadioButton();
            this.RdbPreOrder = new System.Windows.Forms.RadioButton();
            this.GboListaGrilla = new System.Windows.Forms.GroupBox();
            this.LstArbolBinario = new System.Windows.Forms.ListBox();
            this.DgvArbolBinario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GboElementoEliminado = new System.Windows.Forms.GroupBox();
            this.CboCodigo = new System.Windows.Forms.ComboBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LblCodigoEliminar = new System.Windows.Forms.Label();
            this.GboNuevoElemento = new System.Windows.Forms.GroupBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtTramite = new System.Windows.Forms.TextBox();
            this.LblTramite = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.BtnEquilibrar = new System.Windows.Forms.Button();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.TrvArbolBinario = new System.Windows.Forms.TreeView();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.GboBotones.SuspendLayout();
            this.GboListaGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArbolBinario)).BeginInit();
            this.GboElementoEliminado.SuspendLayout();
            this.GboNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // GboBotones
            // 
            this.GboBotones.Controls.Add(this.BtnListar);
            this.GboBotones.Controls.Add(this.RdbPostOrder);
            this.GboBotones.Controls.Add(this.RdbDescendiente);
            this.GboBotones.Controls.Add(this.RdbAscendiente);
            this.GboBotones.Controls.Add(this.RdbPreOrder);
            this.GboBotones.Location = new System.Drawing.Point(464, 11);
            this.GboBotones.Margin = new System.Windows.Forms.Padding(2);
            this.GboBotones.Name = "GboBotones";
            this.GboBotones.Padding = new System.Windows.Forms.Padding(2);
            this.GboBotones.Size = new System.Drawing.Size(161, 197);
            this.GboBotones.TabIndex = 29;
            this.GboBotones.TabStop = false;
            this.GboBotones.Text = "Elija como se listarán los elementos";
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(43, 149);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 34);
            this.BtnListar.TabIndex = 19;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // RdbPostOrder
            // 
            this.RdbPostOrder.AutoSize = true;
            this.RdbPostOrder.Location = new System.Drawing.Point(35, 125);
            this.RdbPostOrder.Margin = new System.Windows.Forms.Padding(2);
            this.RdbPostOrder.Name = "RdbPostOrder";
            this.RdbPostOrder.Size = new System.Drawing.Size(75, 17);
            this.RdbPostOrder.TabIndex = 18;
            this.RdbPostOrder.TabStop = true;
            this.RdbPostOrder.Text = "Post Order";
            this.RdbPostOrder.UseVisualStyleBackColor = true;
            // 
            // RdbDescendiente
            // 
            this.RdbDescendiente.AutoSize = true;
            this.RdbDescendiente.Location = new System.Drawing.Point(35, 61);
            this.RdbDescendiente.Margin = new System.Windows.Forms.Padding(2);
            this.RdbDescendiente.Name = "RdbDescendiente";
            this.RdbDescendiente.Size = new System.Drawing.Size(91, 17);
            this.RdbDescendiente.TabIndex = 16;
            this.RdbDescendiente.TabStop = true;
            this.RdbDescendiente.Text = "Descendiente";
            this.RdbDescendiente.UseVisualStyleBackColor = true;
            // 
            // RdbAscendiente
            // 
            this.RdbAscendiente.AutoSize = true;
            this.RdbAscendiente.Location = new System.Drawing.Point(35, 29);
            this.RdbAscendiente.Margin = new System.Windows.Forms.Padding(2);
            this.RdbAscendiente.Name = "RdbAscendiente";
            this.RdbAscendiente.Size = new System.Drawing.Size(84, 17);
            this.RdbAscendiente.TabIndex = 15;
            this.RdbAscendiente.TabStop = true;
            this.RdbAscendiente.Text = "Ascendiente";
            this.RdbAscendiente.UseVisualStyleBackColor = true;
            // 
            // RdbPreOrder
            // 
            this.RdbPreOrder.AutoSize = true;
            this.RdbPreOrder.Location = new System.Drawing.Point(35, 93);
            this.RdbPreOrder.Margin = new System.Windows.Forms.Padding(2);
            this.RdbPreOrder.Name = "RdbPreOrder";
            this.RdbPreOrder.Size = new System.Drawing.Size(70, 17);
            this.RdbPreOrder.TabIndex = 17;
            this.RdbPreOrder.TabStop = true;
            this.RdbPreOrder.Text = "Pre Order";
            this.RdbPreOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RdbPreOrder.UseVisualStyleBackColor = true;
            // 
            // GboListaGrilla
            // 
            this.GboListaGrilla.Controls.Add(this.LstArbolBinario);
            this.GboListaGrilla.Controls.Add(this.DgvArbolBinario);
            this.GboListaGrilla.Location = new System.Drawing.Point(12, 224);
            this.GboListaGrilla.Margin = new System.Windows.Forms.Padding(2);
            this.GboListaGrilla.Name = "GboListaGrilla";
            this.GboListaGrilla.Padding = new System.Windows.Forms.Padding(2);
            this.GboListaGrilla.Size = new System.Drawing.Size(787, 227);
            this.GboListaGrilla.TabIndex = 28;
            this.GboListaGrilla.TabStop = false;
            this.GboListaGrilla.Text = "Listado en una lista y una grilla";
            // 
            // LstArbolBinario
            // 
            this.LstArbolBinario.FormattingEnabled = true;
            this.LstArbolBinario.Location = new System.Drawing.Point(4, 17);
            this.LstArbolBinario.Margin = new System.Windows.Forms.Padding(2);
            this.LstArbolBinario.Name = "LstArbolBinario";
            this.LstArbolBinario.Size = new System.Drawing.Size(163, 199);
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
            this.DgvArbolBinario.Size = new System.Drawing.Size(602, 200);
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
            // GboElementoEliminado
            // 
            this.GboElementoEliminado.Controls.Add(this.CboCodigo);
            this.GboElementoEliminado.Controls.Add(this.BtnEliminar);
            this.GboElementoEliminado.Controls.Add(this.LblCodigoEliminar);
            this.GboElementoEliminado.Location = new System.Drawing.Point(629, 93);
            this.GboElementoEliminado.Margin = new System.Windows.Forms.Padding(2);
            this.GboElementoEliminado.Name = "GboElementoEliminado";
            this.GboElementoEliminado.Padding = new System.Windows.Forms.Padding(2);
            this.GboElementoEliminado.Size = new System.Drawing.Size(170, 115);
            this.GboElementoEliminado.TabIndex = 27;
            this.GboElementoEliminado.TabStop = false;
            this.GboElementoEliminado.Text = "Elemento Eliminado";
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
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
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
            // GboNuevoElemento
            // 
            this.GboNuevoElemento.Controls.Add(this.BtnAgregar);
            this.GboNuevoElemento.Controls.Add(this.TxtNombre);
            this.GboNuevoElemento.Controls.Add(this.TxtCodigo);
            this.GboNuevoElemento.Controls.Add(this.TxtTramite);
            this.GboNuevoElemento.Controls.Add(this.LblTramite);
            this.GboNuevoElemento.Controls.Add(this.LblNombre);
            this.GboNuevoElemento.Controls.Add(this.LblCodigo);
            this.GboNuevoElemento.Location = new System.Drawing.Point(261, 11);
            this.GboNuevoElemento.Margin = new System.Windows.Forms.Padding(2);
            this.GboNuevoElemento.Name = "GboNuevoElemento";
            this.GboNuevoElemento.Padding = new System.Windows.Forms.Padding(2);
            this.GboNuevoElemento.Size = new System.Drawing.Size(186, 197);
            this.GboNuevoElemento.TabIndex = 26;
            this.GboNuevoElemento.TabStop = false;
            this.GboNuevoElemento.Text = "Nuevo Elemento";
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
            // BtnEquilibrar
            // 
            this.BtnEquilibrar.Location = new System.Drawing.Point(630, 17);
            this.BtnEquilibrar.Name = "BtnEquilibrar";
            this.BtnEquilibrar.Size = new System.Drawing.Size(165, 62);
            this.BtnEquilibrar.TabIndex = 30;
            this.BtnEquilibrar.Text = "Equilibrar arbol";
            this.BtnEquilibrar.UseVisualStyleBackColor = true;
            this.BtnEquilibrar.Click += new System.EventHandler(this.BtnEquilibrar_Click);
            // 
            // BtnExportar
            // 
            this.BtnExportar.Location = new System.Drawing.Point(674, 456);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(121, 38);
            this.BtnExportar.TabIndex = 31;
            this.BtnExportar.Text = "Exportar";
            this.BtnExportar.UseVisualStyleBackColor = true;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // TrvArbolBinario
            // 
            this.TrvArbolBinario.Location = new System.Drawing.Point(12, 11);
            this.TrvArbolBinario.Name = "TrvArbolBinario";
            this.TrvArbolBinario.Size = new System.Drawing.Size(244, 197);
            this.TrvArbolBinario.TabIndex = 32;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(374, 462);
            this.TxtBuscar.Multiline = true;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(110, 26);
            this.TxtBuscar.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Verificar codigo";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(490, 462);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(110, 26);
            this.BtnBuscar.TabIndex = 35;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FrmEstructuraRamificadaArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 501);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.TrvArbolBinario);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.BtnEquilibrar);
            this.Controls.Add(this.GboBotones);
            this.Controls.Add(this.GboListaGrilla);
            this.Controls.Add(this.GboElementoEliminado);
            this.Controls.Add(this.GboNuevoElemento);
            this.Name = "FrmEstructuraRamificadaArbolBinario";
            this.Text = " Estructura ramificada - Arbol Binario";
            this.Load += new System.EventHandler(this.FrmEstructuraRamificadaArbolBinario_Load);
            this.GboBotones.ResumeLayout(false);
            this.GboBotones.PerformLayout();
            this.GboListaGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArbolBinario)).EndInit();
            this.GboElementoEliminado.ResumeLayout(false);
            this.GboElementoEliminado.PerformLayout();
            this.GboNuevoElemento.ResumeLayout(false);
            this.GboNuevoElemento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GboBotones;
        private System.Windows.Forms.RadioButton RdbPostOrder;
        private System.Windows.Forms.RadioButton RdbDescendiente;
        private System.Windows.Forms.RadioButton RdbAscendiente;
        private System.Windows.Forms.RadioButton RdbPreOrder;
        private System.Windows.Forms.GroupBox GboListaGrilla;
        private System.Windows.Forms.ListBox LstArbolBinario;
        private System.Windows.Forms.DataGridView DgvArbolBinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox GboElementoEliminado;
        private System.Windows.Forms.ComboBox CboCodigo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label LblCodigoEliminar;
        private System.Windows.Forms.GroupBox GboNuevoElemento;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtTramite;
        private System.Windows.Forms.Label LblTramite;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Button BtnEquilibrar;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.TreeView TrvArbolBinario;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
    }
}