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
    public partial class AdminAdaugareCarte : Form
    {
        private bool Editor;//pentru a stii ce fel de querry va fi folosit
        private readonly BookLibEntities1 bookLibEntities1;
        public AdminAdaugareCarte()
        {
            InitializeComponent();
            Titlu.Text = "Adaugare Carte";
            Editor= false;
            bookLibEntities1= new BookLibEntities1();
        }
        public AdminAdaugareCarte(TipuriCarti carti)//supraincarcare pentru initializare in modul edit a form-ului
        {
            InitializeComponent();
            Titlu.Text = "Editare Carte";
            bookLibEntities1 = new BookLibEntities1();
            Umplere(carti);
            Editor= true;
        }

        private void Umplere(TipuriCarti carti)
        {
            txtid.Text = Convert.ToString(carti.id);
            txtNume.Text = carti.nume;
            txtGen.Text = carti.gen;
            txtAutor.Text = carti.autor;
            txtISBN.Text = carti.isbn;
        }

        private void AdminAdaugareCarte_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Editor)//verificam ce querry folosim
            {
                var id=int.Parse(txtid.Text);//obtinere id
                var carte = bookLibEntities1.TipuriCartis.FirstOrDefault(x => x.id == id);//selectare obiect
                if (string.IsNullOrEmpty(txtNume.Text) == true || string.IsNullOrEmpty(txtGen.Text) == true || string.IsNullOrEmpty(txtAutor.Text) == true || string.IsNullOrEmpty(txtISBN.Text) == true)
                {
                    MessageBoxIcon messageBoxIcon = MessageBoxIcon.Error;
                    MessageBox.Show("Parametrii nespecificati!", "Eroare!", 0, messageBoxIcon);
                }
                else
                {
                    carte.nume = txtNume.Text;
                    carte.gen = txtGen.Text;
                    carte.autor = txtAutor.Text;
                    carte.isbn = txtISBN.Text;
                    bookLibEntities1.SaveChanges();
                    MessageBoxIcon messageBoxIcon = MessageBoxIcon.Information;
                    MessageBox.Show("Editare reusita!", "Success!", 0, messageBoxIcon);
                    Close();
                }
            }
            else//pentru adaugare
            {
                var cartenoua= new TipuriCarti {
               nume=txtNume.Text,
               gen=txtGen.Text,
               autor=txtAutor.Text,
               isbn=txtISBN.Text,
                };
                if (string.IsNullOrEmpty(txtNume.Text) == true || string.IsNullOrEmpty(txtGen.Text) == true || string.IsNullOrEmpty(txtAutor.Text) == true || string.IsNullOrEmpty(txtISBN.Text) == true)
                {
                    MessageBoxIcon messageBoxIcon = MessageBoxIcon.Error;
                    MessageBox.Show("Parametrii nespecificati!", "Eroare!", 0, messageBoxIcon);
                }
                else
                {
                    bookLibEntities1.TipuriCartis.Add(cartenoua);
                    bookLibEntities1.SaveChanges();
                    MessageBoxIcon messageBoxIcon = MessageBoxIcon.Information;
                    MessageBox.Show("Adaugare reusita!", "Success!", 0, messageBoxIcon);
                    Close();
                }
            }
        }

        private void Titlu_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtid_Click(object sender, EventArgs e)
        {

        }
    }
}
