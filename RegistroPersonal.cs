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
            db = DBClass.getDB();
            db.openDB();
        }

        private void btnNuevoDedo_Click(object sender, EventArgs e)
        {
            formMain f=formMain.getInstance();
            f.prepareEnroll=true;
            f.Show();
            f.enroll();
            f.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Personal p = db.getPersonal(txtCI.Text);
            if (p != null)
            {
                txtCI.Text = p.ci;
                txtPaterno.Text = p.paterno;
                txtMaterno.Text = p.materno;
                txtNombre.Text = p.nombre;
                btnRegistrar.Enabled = false;
                btnNuevoDedo.Enabled = true;
            }
            else if (db.insertarPersonal(txtCI.Text, txtPaterno.Text, txtMaterno.Text, txtNombre.Text))
            {
                btnRegistrar.Enabled = false;
                btnNuevoDedo.Enabled = true;
            }
        }

        private void RegistroPersonal_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.FormBase_FormClosed(sender, e);
            db.closeDB();
        }

    }
}
