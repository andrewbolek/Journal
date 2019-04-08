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


namespace Journal
{
    ///  Register page
    /// 
    /// 
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }
        

        private void Username(object sender, TextChangedEventArgs e)//Username/box1
        {
            
        }
        private void Password(object sender, TextChangedEventArgs e)//Password/box2
        {

        }
        private void Firstname(object sender, TextChangedEventArgs e)//FirstName/box3
        {

        }
        private void Lastname(object sender, TextChangedEventArgs e)//LastName/box4
        {

        }



        private void Button_Click(object sender, RoutedEventArgs e) //register
        {
            string box1 = Username1.Text;
            string box2 = Password1.Text;
            string box3 = Firstname1.Text;
            string box4 = Lastname1.Text;





            SqlConnection myConnection = new SqlConnection
                                      (@"server=THE-PROFESSOR\ANDREW;" +
                                      "Integrated security=sspi;" +
                                      "database= Journal;" +
                                      "MultipleActiveResultSets=true;" +
                                      "connection timeout=10;");
            
            try
            {
                myConnection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

          
            SqlCommand myCommand = new SqlCommand("INSERT INTO [User] (username,Password,[First Name], [Last Name])"+ 
                                    $" Values ('{box1}', '{box2}', '{box3}', '{box4}')", myConnection);
            myCommand.ExecuteNonQuery();

           
           

            MessageBoxResult result = MessageBox.Show($"You are registered {box3}!",
                                            "Confirmation",
                                            MessageBoxButton.OK);
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //back
        {
            
            this.Close();
        }

        
        
    }
}
