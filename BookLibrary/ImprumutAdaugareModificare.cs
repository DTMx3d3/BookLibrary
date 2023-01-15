using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BookLibrary
{
    public partial class ImprumutAdaugareModificare : Form
    {
        private readonly BookLibEntities1 bookLibEntities1;
        bool Editor; //Variabila determinare mod editor

  
        public ImprumutAdaugareModificare(CustomerService customerService)
        {
            InitializeComponent();
            Titlu.Text = "Modificare Imprumut";
            bookLibEntities1 = new BookLibEntities1();
            Umplere(customerService);
            Editor = true;
        }

        private void Umplere(CustomerService customer)
        {
            IDlbl.Text = Convert.ToString(customer.id);
            txtNume.Text = customer.Name;
            dataStart.Value = (DateTime)customer.DataStart;
            dataEnd.Value = (DateTime)customer.DataEnd;
            txtPret.Text = Convert.ToString(customer.Pret);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(IDlbl.Text);//obtinere id
            var imprumut = bookLibEntities1.CustomerServices.FirstOrDefault(x => x.id == id);//selectare obiect
            if (string.IsNullOrEmpty(txtNume.Text) == true || string.IsNullOrEmpty(Convert.ToString(dataStart.Value)) == true|| string.IsNullOrEmpty(Convert.ToString(dataEnd.Value)) == true|| string.IsNullOrEmpty(Convert.ToString(txtPret.Text)) == true)
               
            {
                MessageBoxIcon messageBoxIcon = MessageBoxIcon.Error;
                MessageBox.Show("Parametrii nespecificati!", "Eroare!", 0, messageBoxIcon);
            }
            else
            {
                imprumut.Name = txtNume.Text;
                imprumut.DataStart = dataStart.Value;
                imprumut.DataEnd = dataEnd.Value;
                imprumut.Pret = Convert.ToDecimal(txtPret.Text);
                bookLibEntities1.SaveChanges();
                MessageBoxIcon messageBoxIcon = MessageBoxIcon.Information;
                MessageBox.Show("Editare reusita!", "Success!", 0, messageBoxIcon);
                Close();
            }

        }

        private void ImprumutAdaugareModificare_Load(object sender, EventArgs e)
        {

        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
