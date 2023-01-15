using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibrary
{
    public partial class MainWind : Form
    {
        public MainWind()
        {
            InitializeComponent();
            
        }

        private void MainWind_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adaugareImprumutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imprumuturiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void cartiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms.Count > 1)
            {
                MessageBoxIcon messageBoxIcon = MessageBoxIcon.Error;
                MessageBox.Show("Inchideti cealalta fereastra deschisa!", "Eroare", 0, messageBoxIcon);
            }
            else
            {
                AdministrareCarti administrareCarti = new AdministrareCarti();
                administrareCarti.MdiParent = this; //declararea faptului ca acest window este parinte pentru MDI
                administrareCarti.Show();
                administrareCarti.SetDesktopLocation(20,20);
            }
        }

       
        private void administrareImprumuturiToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            AdministrareImprumuturi administrareImprumuturi = new AdministrareImprumuturi();
            administrareImprumuturi.MdiParent = this;
            administrareImprumuturi.Show();
            administrareImprumuturi.SetDesktopLocation(20,20);
            
        }

      
    }
}
