namespace Panchita
{
    partial class formMessage
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
            this.components = new System.ComponentModel.Container();
            this.texto = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.Location = new System.Drawing.Point(20, 20);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(367, 74);
            this.texto.TabIndex = 0;
            this.texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.texto.Click += new System.EventHandler(this.texto_Click);
            // 
            // tiempo
            // 
            this.tiempo.Interval = 5000;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // formMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 114);
            this.Controls.Add(this.texto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMessage";
            this.Opacity = 0.9D;
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "formMessage";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.formMessage_Shown);
            this.Click += new System.EventHandler(this.texto_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.Timer tiempo;
    }
}