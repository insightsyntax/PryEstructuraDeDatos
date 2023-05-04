﻿namespace PryEstructuraDeDatos
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
            this.RbtnOrder = new System.Windows.Forms.RadioButton();
            this.RbtnDescendente = new System.Windows.Forms.RadioButton();
            this.RbtnAscendente = new System.Windows.Forms.RadioButton();
            this.RbtnPreOrder = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.GboBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GboListaGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArbolBinario)).BeginInit();
            this.GboElementoEliminado.SuspendLayout();
            this.GboNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // GboBotones
            // 
            this.GboBotones.Controls.Add(this.BtnListar);
            this.GboBotones.Controls.Add(this.RbtnOrder);
            this.GboBotones.Controls.Add(this.RbtnDescendente);
            this.GboBotones.Controls.Add(this.RbtnAscendente);
            this.GboBotones.Controls.Add(this.RbtnPreOrder);
            this.GboBotones.Location = new System.Drawing.Point(464, 11);
            this.GboBotones.Margin = new System.Windows.Forms.Padding(2);
            this.GboBotones.Name = "GboBotones";
            this.GboBotones.Padding = new System.Windows.Forms.Padding(2);
            this.GboBotones.Size = new System.Drawing.Size(128, 197);
            this.GboBotones.TabIndex = 29;
            this.GboBotones.TabStop = false;
            this.GboBotones.Text = "Elija como se listarán los elementos";
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
            this.pictureBox1.Image = global::PryEstructuraDeDatos.Properties.Resources._192px_Binary_tree__oriented_digraph_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // GboListaGrilla
            // 
            this.GboListaGrilla.Controls.Add(this.LstArbolBinario);
            this.GboListaGrilla.Controls.Add(this.DgvArbolBinario);
            this.GboListaGrilla.Location = new System.Drawing.Point(12, 214);
            this.GboListaGrilla.Margin = new System.Windows.Forms.Padding(2);
            this.GboListaGrilla.Name = "GboListaGrilla";
            this.GboListaGrilla.Padding = new System.Windows.Forms.Padding(2);
            this.GboListaGrilla.Size = new System.Drawing.Size(754, 263);
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
            this.DgvArbolBinario.Size = new System.Drawing.Size(569, 238);
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
            this.GboElementoEliminado.Location = new System.Drawing.Point(596, 93);
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
            this.BtnEquilibrar.Location = new System.Drawing.Point(597, 11);
            this.BtnEquilibrar.Name = "BtnEquilibrar";
            this.BtnEquilibrar.Size = new System.Drawing.Size(81, 62);
            this.BtnEquilibrar.TabIndex = 30;
            this.BtnEquilibrar.Text = "Equilibrar arbol";
            this.BtnEquilibrar.UseVisualStyleBackColor = true;
            this.BtnEquilibrar.Click += new System.EventHandler(this.BtnEquilibrar_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(16, 482);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 31;
            // 
            // FrmEstructuraRamificadaArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 693);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.BtnEquilibrar);
            this.Controls.Add(this.GboBotones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GboListaGrilla);
            this.Controls.Add(this.GboElementoEliminado);
            this.Controls.Add(this.GboNuevoElemento);
            this.Name = "FrmEstructuraRamificadaArbolBinario";
            this.Text = "Estructura Ramificadas - Arbol Binario";
            this.GboBotones.ResumeLayout(false);
            this.GboBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GboListaGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArbolBinario)).EndInit();
            this.GboElementoEliminado.ResumeLayout(false);
            this.GboElementoEliminado.PerformLayout();
            this.GboNuevoElemento.ResumeLayout(false);
            this.GboNuevoElemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GboBotones;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.RadioButton RbtnOrder;
        private System.Windows.Forms.RadioButton RbtnDescendente;
        private System.Windows.Forms.RadioButton RbtnAscendente;
        private System.Windows.Forms.RadioButton RbtnPreOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.TreeView treeView1;
    }
}