﻿
namespace PryEstructuraDeDatos
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDelProgramadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosBotonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemasToolStripMenuItem,
            this.linealesToolStripMenuItem,
            this.noLinealesToolStripMenuItem,
            this.baseDeDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemasToolStripMenuItem
            // 
            this.sistemasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDelProgramadorToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            this.sistemasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sistemasToolStripMenuItem.Text = "Sistemas";
            // 
            // datosDelProgramadorToolStripMenuItem
            // 
            this.datosDelProgramadorToolStripMenuItem.Name = "datosDelProgramadorToolStripMenuItem";
            this.datosDelProgramadorToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.datosDelProgramadorToolStripMenuItem.Text = "Datos del programador...";
            this.datosDelProgramadorToolStripMenuItem.Click += new System.EventHandler(this.datosDelProgramadorToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // linealesToolStripMenuItem
            // 
            this.linealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaToolStripMenuItem,
            this.pilaToolStripMenuItem,
            this.listaToolStripMenuItem});
            this.linealesToolStripMenuItem.Name = "linealesToolStripMenuItem";
            this.linealesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.linealesToolStripMenuItem.Text = "Lineales";
            // 
            // colaToolStripMenuItem
            // 
            this.colaToolStripMenuItem.Name = "colaToolStripMenuItem";
            this.colaToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.colaToolStripMenuItem.Text = "Cola...";
            this.colaToolStripMenuItem.Click += new System.EventHandler(this.colaToolStripMenuItem_Click);
            // 
            // pilaToolStripMenuItem
            // 
            this.pilaToolStripMenuItem.Name = "pilaToolStripMenuItem";
            this.pilaToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.pilaToolStripMenuItem.Text = "Pila...";
            this.pilaToolStripMenuItem.Click += new System.EventHandler(this.pilaToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleToolStripMenuItem,
            this.dobleToolStripMenuItem});
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.listaToolStripMenuItem.Text = "Lista...";
            // 
            // simpleToolStripMenuItem
            // 
            this.simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
            this.simpleToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.simpleToolStripMenuItem.Text = "Simple...";
            this.simpleToolStripMenuItem.Click += new System.EventHandler(this.simpleToolStripMenuItem_Click);
            // 
            // dobleToolStripMenuItem
            // 
            this.dobleToolStripMenuItem.Name = "dobleToolStripMenuItem";
            this.dobleToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.dobleToolStripMenuItem.Text = "Doble...";
            this.dobleToolStripMenuItem.Click += new System.EventHandler(this.dobleToolStripMenuItem_Click);
            // 
            // noLinealesToolStripMenuItem
            // 
            this.noLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolToolStripMenuItem,
            this.grafoToolStripMenuItem});
            this.noLinealesToolStripMenuItem.Name = "noLinealesToolStripMenuItem";
            this.noLinealesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.noLinealesToolStripMenuItem.Text = "No Lineales";
            // 
            // arbolToolStripMenuItem
            // 
            this.arbolToolStripMenuItem.Name = "arbolToolStripMenuItem";
            this.arbolToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.arbolToolStripMenuItem.Text = "Arbol...";
            this.arbolToolStripMenuItem.Click += new System.EventHandler(this.arbolToolStripMenuItem_Click);
            // 
            // grafoToolStripMenuItem
            // 
            this.grafoToolStripMenuItem.Name = "grafoToolStripMenuItem";
            this.grafoToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.grafoToolStripMenuItem.Text = "Grafo...";
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDeDatosBotonesToolStripMenuItem,
            this.consultaBaseDeDatosToolStripMenuItem,
            this.baseDeDatosListaToolStripMenuItem});
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.baseDeDatosToolStripMenuItem.Text = "Base de datos";
            this.baseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.baseDeDatosToolStripMenuItem_Click);
            // 
            // baseDeDatosBotonesToolStripMenuItem
            // 
            this.baseDeDatosBotonesToolStripMenuItem.Name = "baseDeDatosBotonesToolStripMenuItem";
            this.baseDeDatosBotonesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.baseDeDatosBotonesToolStripMenuItem.Text = "Base de datos botones";
            this.baseDeDatosBotonesToolStripMenuItem.Click += new System.EventHandler(this.baseDeDatosBotonesToolStripMenuItem_Click);
            // 
            // consultaBaseDeDatosToolStripMenuItem
            // 
            this.consultaBaseDeDatosToolStripMenuItem.Name = "consultaBaseDeDatosToolStripMenuItem";
            this.consultaBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.consultaBaseDeDatosToolStripMenuItem.Text = "Consulta base de datos";
            this.consultaBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.consultaBaseDeDatosToolStripMenuItem_Click);
            // 
            // baseDeDatosListaToolStripMenuItem
            // 
            this.baseDeDatosListaToolStripMenuItem.Name = "baseDeDatosListaToolStripMenuItem";
            this.baseDeDatosListaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.baseDeDatosListaToolStripMenuItem.Text = "Base de datos en lista";
            this.baseDeDatosListaToolStripMenuItem.Click += new System.EventHandler(this.baseDeDatosListaToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de Datos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDelProgramadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosBotonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosListaToolStripMenuItem;
    }
}

