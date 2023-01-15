using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibrary
{
    public partial class AdministrareImprumuturi : Form
    {
        BookLibEntities1 bookLibEntities1;
        public AdministrareImprumuturi()
        {
            InitializeComponent();
           bookLibEntities1= new BookLibEntities1();
        }

        private void TabelImprumuturi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdministrareImprumuturi_Load(object sender, EventArgs e)
        {
            var imprumut = bookLibEntities1.CustomerServices.Select(coloana => new {
                ID = coloana.id,
                Nume = coloana.Name
                ,
                DataStart = coloana.DataStart,
                DataEnd = coloana.DataEnd,
                Pret = coloana.Pret,
                Titlu= coloana.Titlu
                
            }).ToList();//creare obiect prin func lamda in care preluam coloanele
            TabelImprumuturi.DataSource = imprumut;//adaugare sursa  
            TabelImprumuturi.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           AdaugareImprumut adaugareImprumut= new AdaugareImprumut();
            adaugareImprumut.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTabel();
        }

        private void RefreshTabel()
        {
            var imprumut = bookLibEntities1.CustomerServices.Select(coloana => new {
                ID = coloana.id,
                Nume = coloana.Name
                ,
                DataStart = coloana.DataStart,
                DataEnd = coloana.DataEnd,
                Pret= coloana.Pret,
                Titlu = coloana.Titlu
            }).ToList();//creare obiect prin func lamda in care preluam coloanele
            TabelImprumuturi.DataSource = imprumut;//adaugare sursa  
            TabelImprumuturi.Columns[0].Visible = false;
            
        }

        private DataGridView GetTabelImprumuturi()
        {
            return TabelImprumuturi;
        }

        private void btnIntarzieri_Click(object sender, EventArgs e)//functie aflare numele celor care au intarziat
        {
            RefreshTabel();
      
           
            DateTime verifData = DateTime.Now; //se afla data actuala
            string NumeInvalidData = "Nume persoane cu intarziere: ";//string pentru mesaj final
            string sDate = verifData.ToShortDateString();
            int contorinvalid = 0;//contor afisare
            var id = TabelImprumuturi.Rows.Count;//se afla numar total de inscrieri in tabel
            
            
           // DateTime ValVerificare = Convert.ToDateTime(TabelImprumuturi.Rows[0].Cells["DataEnd"].Value);
           // MessageBox.Show("Aceste Date sunt comparate");
           // MessageBox.Show(Convert.ToString(ValVerificare));
           // MessageBox.Show(Convert.ToString(verifData));
            for (int i = 0; i < id; i++)
            {
               
                if (Convert.ToDateTime(TabelImprumuturi.Rows[i].Cells["DataEnd"].Value) < verifData){//se compara fiecare datafinala cu data verificare
                    NumeInvalidData += Convert.ToString(TabelImprumuturi.Rows[i].Cells["Nume"].Value)+"\r\n";//concatenare mesaj final
                   // MessageBox.Show(Convert.ToString(TabelImprumuturi.Rows[i].Cells["DataEnd"].Value));
                    contorinvalid++;
                }
            }
            if (contorinvalid==0)
            {
                MessageBoxIcon messageBoxIcon = MessageBoxIcon.Information;
                MessageBox.Show("Nu au fost gasite persoane cu intarziere!");
            }
            else
            {
                MessageBoxIcon messageBoxIcon= MessageBoxIcon.Error;
                MessageBox.Show($"{NumeInvalidData}", "Persoane gasite", 0, messageBoxIcon);
            }
          
           
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            //Modificare imprumut
            var id = (int)TabelImprumuturi.SelectedRows[0].Cells["id"].Value;//castat in int pentru a fi folosit in functia pentru default
         
            var imprumut = bookLibEntities1.CustomerServices.FirstOrDefault(val => val.id == id);//pentru a vedea daca primeste o carte, sau null
            var imprumutAdaugareModificare = new ImprumutAdaugareModificare(imprumut);// se foloseste functia supraincarcata
            imprumutAdaugareModificare.MdiParent = this.MdiParent;
            imprumutAdaugareModificare.Show();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            var id = (int)TabelImprumuturi.SelectedRows[0].Cells["ID"].Value; //obtinere id
            var imprumut = bookLibEntities1.CustomerServices.FirstOrDefault(val => val.id == id); //selectare obiect
            bookLibEntities1.CustomerServices.Remove(imprumut);//stergere  
            bookLibEntities1.SaveChanges();//salvare
            RefreshTabel();
        }
    }
}
