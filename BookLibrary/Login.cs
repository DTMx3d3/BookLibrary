using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookLibrary
{
    public partial class Login : Form
    {
        BookLibEntities1 entities1;
        int errorcount;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            entities1= new BookLibEntities1();
            errorcount = 0;
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string pass;
            string username;
            try
            {
                pass = txtPass.Text;
                username= txtUser.Text;
                bool founduser = false;
                bool foundpassword = false;
                //Login login= new Login();
                if(string.IsNullOrEmpty(pass)||string.IsNullOrEmpty(username) )
                {
                    MessageBox.Show("Parametrii fara valoare!");
                }
                else
                {
                    int count = 0;
                    var uname1 = entities1.UseriLogins.Select(coloana => new { username=coloana.username, coloana.password, ID = coloana.id }).ToList();//selectare date din db
                    foreach (var x in uname1) //obtinere numar total id-uri
                    {
                        //count++;
                        if (x.username == username)
                        {
                            founduser= true;
                            if (founduser)
                            {
                                if (pass == x.password)
                                {
                                    MessageBox.Show("Login succsessfull!");
                                    MainWind main=new MainWind();
                                    main.Show();//caz reusit se arata fereastra principala
                                    Hide();
                                    
                                   
                                }
                                else
                                {
                                    errorcount++;
                                    MessageBox.Show($"Parola incorecta!, incercari ramase {3-errorcount}");
                                    
                                    if(errorcount==3)
                                    {
                                        MessageBox.Show("Prea multe incercari gresite!");
                                        Close();
                                    }
                                    break;
                                }
                            }
                        }
                        else if(founduser==false)
                        {
                            errorcount++;
                            MessageBox.Show($"Username incorect! Incercari ramase:{3 - errorcount}");
                           
                            if (errorcount==3)
                            {
                                MessageBox.Show("Prea multe incercari gresite!");
                                Close();

                            }
                            break;
                        }
                        
                    }
                    
                 
                     //MessageBox.Show(Convert.ToString());
                   
                    
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show($"{ exc}");
                //throw;
            }
            
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
