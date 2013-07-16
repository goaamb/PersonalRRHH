using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Panchita
{
    public partial class RegistroPersonal : FormBase
    {
        DBClass db;
        uint id = 0;
        public RegistroPersonal()
        {
            InitializeComponent();
            db = DBClass.getDB();
            db.openDB();
        }

        private void btnNuevoDedo_Click(object sender, EventArgs e)
        {
            formMain f=formMain.getInstance();
            f.showEnroll(id, enHuellaLeida);
        }

        private void enHuellaLeida(uint id) { 
            formMain.getInstance().prepareEnroll = false;
            loadPersonalGrid(this.id);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Personal p = db.getPersonal(txtCI.Text);
            if (p != null)
            {
                id = p.id;
                txtCI.Text = p.ci;
                txtPaterno.Text = p.paterno;
                txtMaterno.Text = p.materno;
                txtNombre.Text = p.nombre;
                btnRegistrar.Enabled = false;
                btnNuevoDedo.Enabled = true;
                btnEliminaDedo.Enabled = true;
                loadPersonalGrid(id);
            }
            else if ((id=(uint)db.insertarPersonal(txtCI.Text, txtPaterno.Text, txtMaterno.Text, txtNombre.Text))>0)
            {
                btnRegistrar.Enabled = false;
                btnNuevoDedo.Enabled = true;
                btnEliminaDedo.Enabled = true;
                loadPersonalGrid(id);
            }
        }

        private void RegistroPersonal_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.FormBase_FormClosed(sender, e);
        }

        private void loadPersonalGrid(uint id) {
            DataTable da= db.getPersonalHuellaRS(id);
            bsPersonal.DataSource = da;
            dgPersonal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgPersonal.ReadOnly = true;
            dgPersonal.DataSource = bsPersonal;
        }

        private void btnEliminaDedo_Click(object sender, EventArgs e)
        {
            DataTable da = (DataTable)dgPersonal.DataSource;
            if (dgPersonal.SelectedRows.Count > 0) { }
        }

    }
}
