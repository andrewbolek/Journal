using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;
using Journal.Help;


namespace Journal
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Username(object sender, TextChangedEventArgs e)
        {

        }
        private void Password(object sender, TextChangedEventArgs e)
        {

        }


        
        public void LoginClick(object sender, RoutedEventArgs e)
        {
            string userr = Username1.Text;
            HelpUser help = new HelpUser()
            {
                Username = Username1.Text,
                Password = Password1.Text,
               UserID = UserContext.UserId
            };

           
            
            SqlConnection myConnection = new SqlConnection
                                                  (@"server=THE-PROFESSOR\ANDREW;" +
                                                  "Integrated security=sspi;" +
                                                  "database= Journal;" +
                                                  "MultipleActiveResultSets=true;" +
                                                  "connection timeout=10;");
            {
                try
                {
                    myConnection.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT userID FROM [Journal].[dbo].[User] WHERE Username=@uname and password=@pass", myConnection);
                    cmd.Parameters.AddWithValue("@uname", Username1.Text);
                    cmd.Parameters.AddWithValue("@pass", Password1.Text);
                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        UserContext.UserId = result;

                        MessageBox.Show($"Welcome {userr}! ");

                        Menu menu = new Menu();
                        menu.Show();



                        this.Close();
                    }
                    else
                        MessageBox.Show("Incorrect login");
                }                 
                catch (Exception ex)
                {
                    MessageBox.Show("Incorrect login");
                }
            }
        }




            

        



        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        
    }
}
