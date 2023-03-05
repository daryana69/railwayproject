using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LogInDBs
{
    /// <summary>
    /// Interaction logic for SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Window
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-N8FGE93; Initial Catalog=Trains; Integrated Security=True");

            try 
            { 

                
                //opening the connection to the db 

                sqlCon.Open();  

                //Build our actual query 

                string query = "INSERT INTO SignUp(FirstName, LastName, username, pswrd, email, telephone)values ('" + this.txtFirstName.Text + "','" + this.txtLastName.Text + "','" + this.txtUsername.Text + "','" + this.PasswordBox.Password + "','" + this.txtEmail.Text + "','" + this.txtTelephone.Text + "') ";

                //Establish a sql command

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully saved");

                LogIn_ lg = new LogIn_();
                lg.Show();
                this.Close();

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }

            finally

            {

                sqlCon.Close();

            }
        }
    }
}
