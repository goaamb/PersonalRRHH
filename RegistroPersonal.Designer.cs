namespace Panchita
{
    partial class RegistroPersonal
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCI = new System.Windows.Forms.Label();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNuevoDedo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Personal";
            // 
            // lblCI
            // 
            this.lblCI.AutoSize = true;
            this.lblCI.Location = new System.Drawing.Point(56, 70);
            this.lblCI.Name = "lblCI";
            this.lblCI.Size = new System.Drawing.Size(134, 13);
            this.lblCI.TabIndex = 1;
            this.lblCI.Text = "Documento de Identidad *:";
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(196, 67);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(190, 20);
            this.txtCI.TabIndex = 2;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(196, 93);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(190, 20);
            this.txtPaterno.TabIndex = 4;
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Location = new System.Drawing.Point(56, 96);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(94, 13);
            this.lblPaterno.TabIndex = 3;
            this.lblPaterno.Text = "Apellido Paterno *:";
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(196, 119);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(190, 20);
            this.txtMaterno.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido Materno :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(196, 145);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre Completo *:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(196, 182);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(327, 190);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnNuevoDedo
            // 
            this.btnNuevoDedo.Enabled = false;
            this.btnNuevoDedo.Location = new System.Drawing.Point(185, 426);
            this.btnNuevoDedo.Name = "btnNuevoDedo";
            this.btnNuevoDedo.Size = new System.Drawing.Size(99, 23);
            this.btnNuevoDedo.TabIndex = 11;
            this.btnNuevoDedo.Text = "Nuevo Dedo";
            this.btnNuevoDedo.UseVisualStyleBackColor = true;
            this.btnNuevoDedo.Click += new System.EventHandler(this.btnNuevoDedo_Click);
            // 
            // RegistroPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 461);
            this.Controls.Add(this.btnNuevoDedo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.lblPaterno);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.lblCI);
            this.Controls.Add(this.label1);
            this.Name = "RegistroPersonal";
            this.Text = "RegistroPersonal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistroPersonal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCI;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNuevoDedo;
    }
}