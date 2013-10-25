using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Panchita
{
    public partial class formMessage : Form
    {
        public static formMessage instancia=null;

        public static void show(string msg){
            GC.Collect();
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new formMessage();
            }
            if (!instancia.IsDisposed)
            {
                instancia.tiempo.Enabled = false;
                instancia.Show();
                instancia.texto.Text = msg;
                instancia.Left = Screen.PrimaryScreen.Bounds.Width - instancia.Width;
                instancia.Top = 0;
                instancia.tiempo.Enabled = true;
            }
        }
        public formMessage()
        {
            InitializeComponent();
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            instancia.Hide();
            tiempo.Enabled = false;
        }

        private void texto_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void formMessage_Shown(object sender, EventArgs e)
        {
            BringToFront();
        }
    }
}