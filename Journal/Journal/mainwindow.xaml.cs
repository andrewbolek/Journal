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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Journal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    
    
    
        public void Username(object sender, TextChangedEventArgs e)
        {
            //string box1 = Username1.Text;
        }

        public void Password(object sender, TextChangedEventArgs e)
        {
            //string box2 = Password1.Text;
        }

       
        


        private void Button_Click(object sender, RoutedEventArgs e) //register
        {
            Register Rwin = new Register();
            Rwin.Show();
            
        }

       

        private void LoginClick(object sender, RoutedEventArgs e)//login
        {
            Login login = new Login();
            login.Show();
            this.Close();

        }

        private void ExitClick(object sender, RoutedEventArgs e) //exit 
        {
            this.Close();
        }
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Shapes;
//using System.Data.SqlClient;

//namespace Journal
//{
//    /// <summary>

//    /// </summary>
//    public partial class View : Window
//    {
//        public View()
//        {
//            InitializeComponent();
//        }


//        private void EntriesClick(object sender, RoutedEventArgs e)
//        {
//            bool temp = false;
//            SqlConnection con = new SqlConnection
//                                       (@"server=THE-PROFESSOR\ANDREW;" +
//                                      "Integrated security=sspi;" +
//                                      "database= Journal;" +
//                                      "MultipleActiveResultSets=true;" +
//                                      "connection timeout=10;");



//            con.Open();
//            SqlCommand cmd = new SqlCommand("select * from Journal where date='" + date.Text.Trim() + "'", con);
//            SqlDataReader dr = cmd.ExecuteReader();
//            while (dr.Read())
//            {
//                try
//                {

//                    entry.Text = dr.GetString(4);
//                    Title.Text = dr.GetString(2);
//                }
//                catch
//                {
//                    MessageBox.Show("");
//                }

//                temp = true;
//            }
//            if (temp == false)
//                MessageBox.Show("not found");
//            con.Close();
//        }

//        private void Date(object sender, TextChangedEventArgs e)
//        {

//        }



//        private void Title1(object sender, TextChangedEventArgs e)
//        {

//        }
//    }
//}