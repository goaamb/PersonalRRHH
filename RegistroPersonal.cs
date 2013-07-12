using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Panchita
{
    public partial class RegistroPersonal : FormBase
    {
        DBClass db;
        public RegistroPersonal()
        {
            InitializeComponent();
            db = new DBClass();
            db.openDB();
        }

        private void btnNuevoDedo_Click(object sender, EventArgs e)
        {
            formMain f=new formMain();
            f.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            db.insertarPersonal(txtCI.Text, txtPaterno.Text, txtMaterno.Text, txtNombre.Text);
        }

        private void RegistroPersonal_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.closeDB();
        }

    }
}
