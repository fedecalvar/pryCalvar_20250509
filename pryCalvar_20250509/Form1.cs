using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCalvar_20250509
{
    public partial class frmClubs : Form
    {
        public frmClubs()
        {
            InitializeComponent();

            cboClubes.Items.Clear();
            cboClubes.Items.Add("BOCA");
            cboClubes.Items.Add("riBer");
            cboClubes.Items.Add("Instituto");

            numFrio.Minimum = 1;
            numFrio.Maximum = 10;

            numGrandeza.Minimum = 1;
            numGrandeza.Maximum = 10;
        }

        private void cboClubes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClubes.SelectedIndex == 0)
            {
                pbFotosClub.Image = Properties.Resources.boca;
            }
            else if (cboClubes.SelectedIndex == 1)
            {
                pbFotosClub.Image = Properties.Resources.riber;
            }
            else if (cboClubes.SelectedIndex == 2)
            {
                pbFotosClub.Image = Properties.Resources.instituto;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (cboClubes.SelectedIndex == 0)
            {
                using (StreamWriter writer = new StreamWriter(ruta, append: true))
                {
                    writer.WriteLine("Club 1. Grandeza: " + numGrandeza + ". Frio ");
                }
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
