using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibrary
{
    public partial class AdaugareImprumut : Form
    {
        private readonly BookLibEntities1 bookLibEntities;//entitate pentru baza de date
        public AdaugareImprumut()
        {
            InitializeComponent();
            bookLibEntities= new BookLibEntities1(); //initializare entitate
        }

        private void button1_MouseCaptureChanged(object sender, EventArgs e)
        {
            MessageBoxIcon icon = MessageBoxIcon.Information;
            try
            {
                string nume = CustName.Text;

                double pret = Convert.ToDouble(Pret.Text);
                DateTime DataStart = Convert.ToDateTime(StartDate.Text);
                DateTime DataEnd = Convert.ToDateTime(EndDate.Text);
                
                string carte = Nume_Carte.Text;
               
                var valid = true;
                string erori=""; //pentru afisarea mai multor erori intr-una singura
                int contoreroare = 0;


                if (string.IsNullOrWhiteSpace(nume) || string.IsNullOrWhiteSpace(carte))
                {
                    valid = false;
                    contoreroare++;
                 erori += contoreroare+". Date incorecte!\n";
                }
                if (DataStart > DataEnd)
                {
                    valid = false;
                    contoreroare++;
                    erori += contoreroare + ". Data de imprumut nu poate fi dupa data de returnare!";

                }
                if (DataStart == DataEnd)
                {
                    valid = false;
                    contoreroare++;
                    erori += contoreroare + ". Data de imprumut este aceeasi cu cea de returnare!";

                }



                //-----------------------Actiune caz valid------------------------
                if (valid)
                {
                    var customer_serv = new CustomerService();//initializare customer
                    //Preluare valori in obiect
                    customer_serv.Name = nume;
                    customer_serv.DataStart= DataStart;
                    customer_serv.DataEnd= DataEnd;
                    customer_serv.Pret = Convert.ToDecimal(pret);
                    customer_serv.id = (int)Nume_Carte.SelectedValue;
                    customer_serv.Titlu = Nume_Carte.Text;
                   // customer_serv.TipCarte = Nume_Carte.SelectedValue;
                    //adaugarea obiectului in table +save 
                    bookLibEntities.CustomerServices.Add(customer_serv);
                    bookLibEntities.SaveChanges();

                    MessageBox.Show($"Nume:{nume}\n\r" +
                      $"data imprumut:{DataStart}\n\r" +
                      $"data returnare:{DataEnd}\n\r"
                      , "hello", 0, icon);
                }
                //------------------------End Actiune------------------------------
                


                else
                {
                    icon= MessageBoxIcon.Error;
                    MessageBox.Show(erori, "Error", 0, icon);
                    contoreroare = 0;
                }

              
            }
            catch (Exception exceptie)
            {
                
                MessageBox.Show($"Exceptie: {exceptie.Message}");
                
               // throw;
            }
            
            
        }
       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)//actiuni cand porneste form-ul
        {
            // var carti = bookLibEntities.TipuriCartis.ToList();//se obtine lista din tabela cu carti pentru a fi adaugata in dropdown
            var carti = bookLibEntities.TipuriCartis.Select(
                coloana => new { ID = coloana.id, Nume = coloana.nume + " - " +coloana.autor}
                ).ToList();
            Nume_Carte.DisplayMember = "nume";
            Nume_Carte.ValueMember= "id";
            Nume_Carte.DataSource= carti;
            



        }

        private void Nume_Carte_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
