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
    public partial class AdministrareCarti : Form
    {
       private readonly BookLibEntities1 bookLibEntities1;
        
        public AdministrareCarti()
        {
            InitializeComponent();
            bookLibEntities1 = new BookLibEntities1();
            
        }

        private void TabelCarti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdministrareCarti_Load(object sender, EventArgs e)
        {
            //var carti = bookLibEntities1.TipuriCartis.ToList();
            var carti = bookLibEntities1.TipuriCartis.Select(coloana => new { ID = coloana.id, Nume = coloana.nume
                ,Gen=coloana.gen,ISBN=coloana.isbn ,Autor=coloana.autor}).ToList();//creare obiect prin func lamda in care preluam coloanele
            TabelCarti.DataSource = carti;//adaugare sursa  
            TabelCarti.Columns[0].Visible=false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          AdminAdaugareCarte adminAdaugareCarte= new AdminAdaugareCarte();
            adminAdaugareCarte.MdiParent = this.MdiParent;
            adminAdaugareCarte.Show();
          

        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            var id = (int)TabelCarti.SelectedRows[0].Cells["ID"].Value;//castat in int pentru a fi folosit in functia pentru default
            // MessageBox.Show(Convert.ToString(id));
            var carte = bookLibEntities1.TipuriCartis.FirstOrDefault(val => val.id == id) ;//pentru a vedea daca primeste o carte, sau null
            var adminAdaugareCarte = new AdminAdaugareCarte(carte);// se foloseste functia supraincarcata
            adminAdaugareCarte.MdiParent = this.MdiParent;
            adminAdaugareCarte.Show();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            var id = (int)TabelCarti.SelectedRows[0].Cells["ID"].Value; //obtinere id
            var carte = bookLibEntities1.TipuriCartis.FirstOrDefault(val => val.id == id); //selectare obiect
            bookLibEntities1.TipuriCartis.Remove(carte);//stergere  
            bookLibEntities1.SaveChanges();//salvare
            TabelCarti.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            RefreshPagina();
        }

        private void RefreshPagina()
        {
            var carti = bookLibEntities1.TipuriCartis.Select(coloana => new {
                ID = coloana.id,
                Nume = coloana.nume
                ,
                Gen = coloana.gen,
                ISBN = coloana.isbn,
                Autor = coloana.autor
            }).ToList();//creare obiect prin func lamda in care preluam coloanele
            TabelCarti.DataSource = carti;//adaugare sursa  
            TabelCarti.Columns[0].Visible = false;
        }
    }
}
