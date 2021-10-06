namespace EjercicioUDP
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aBRIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cERRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Normal = new System.Windows.Forms.NotifyIcon(this.components);
            this.Alerta = new System.Windows.Forms.NotifyIcon(this.components);
            this.Advertencia = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblTipo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLeido = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBRIRToolStripMenuItem,
            this.cERRARToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            // 
            // aBRIRToolStripMenuItem
            // 
            this.aBRIRToolStripMenuItem.Name = "aBRIRToolStripMenuItem";
            this.aBRIRToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.aBRIRToolStripMenuItem.Text = "ABRIR";
            this.aBRIRToolStripMenuItem.Click += new System.EventHandler(this.aBRIRToolStripMenuItem_Click);
            // 
            // cERRARToolStripMenuItem
            // 
            this.cERRARToolStripMenuItem.Name = "cERRARToolStripMenuItem";
            this.cERRARToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.cERRARToolStripMenuItem.Text = "CERRAR";
            this.cERRARToolStripMenuItem.Click += new System.EventHandler(this.cERRARToolStripMenuItem_Click);
            // 
            // Normal
            // 
            this.Normal.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Normal.BalloonTipText = "¡Nuevo mensaje!";
            this.Normal.Icon = ((System.Drawing.Icon)(resources.GetObject("Normal.Icon")));
            this.Normal.Text = "Normal";
            // 
            // Alerta
            // 
            this.Alerta.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.Alerta.BalloonTipText = "¡ALERTA!";
            this.Alerta.Icon = ((System.Drawing.Icon)(resources.GetObject("Alerta.Icon")));
            this.Alerta.Text = "¡ALERTA!";
            // 
            // Advertencia
            // 
            this.Advertencia.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.Advertencia.BalloonTipText = "¡ADVERTENCIA!";
            this.Advertencia.Icon = ((System.Drawing.Icon)(resources.GetObject("Advertencia.Icon")));
            this.Advertencia.Text = "¡ADVERTENCIA!";
            // 
            // lblTipo
            // 
            this.lblTipo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(12, 29);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(254, 36);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 128);
            this.label2.TabIndex = 2;
            // 
            // btnLeido
            // 
            this.btnLeido.Location = new System.Drawing.Point(191, 208);
            this.btnLeido.Name = "btnLeido";
            this.btnLeido.Size = new System.Drawing.Size(75, 23);
            this.btnLeido.TabIndex = 3;
            this.btnLeido.Text = "Leido";
            this.btnLeido.UseVisualStyleBackColor = true;
            this.btnLeido.Click += new System.EventHandler(this.btnLeido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 337);
            this.Controls.Add(this.btnLeido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTipo);
            this.Name = "Form1";
            this.Text = "Cliente UDP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBRIRToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon Normal;
        private System.Windows.Forms.NotifyIcon Alerta;
        private System.Windows.Forms.NotifyIcon Advertencia;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem cERRARToolStripMenuItem;
        private System.Windows.Forms.Button btnLeido;
    }
}

