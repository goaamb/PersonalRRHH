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
        public RegistroPersonal()
        {
            InitializeComponent();
        }

        private void btnNuevoDedo_Click(object sender, EventArgs e)
        {
            formMain f=new formMain();
            f.Show();
        }
    }
}
