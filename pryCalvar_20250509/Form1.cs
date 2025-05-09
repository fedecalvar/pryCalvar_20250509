using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCalvar_20250509
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cboClubes.Items.Clear();
            cboClubes.Items.Add("BOCA");
            cboClubes.Items.Add("riBer");
            cboClubes.Items.Add("Instituto");
        }

        private void cboClubes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClubes.SelectedIndex == 0)
            {
                pbFotosClub.Load();
            }
            else if (cboClubes.SelectedIndex == 1)
            {

            }
            else if (cboClubes.SelectedIndex == 2)
            {

            }
        }
    }
}
