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
    /// Interaction logic for New.xaml
    /// </summary>
    public partial class New : Window
    {
        public New()
        {
            InitializeComponent();
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SubmitClick(object sender, RoutedEventArgs e)
        {


            UserContext HU = new UserContext();
            if(String.IsNullOrEmpty(title.Text))
            {
                MessageBox.Show("Invalid Title Input","Error", MessageBoxButton.OK);
                return;
            }
            if (String.IsNullOrEmpty (date.Text))
            {
                MessageBox.Show("Invalid Date Input", "Error", MessageBoxButton.OK);
                return;
            }
            if (String.IsNullOrEmpty (entry.Text))
            {
                MessageBox.Show("Invalid Entry Input", "Error", MessageBoxButton.OK);
                return;
            }


            SqlConnection con = new SqlConnection
                                      (@"server=THE-PROFESSOR\ANDREW;" +
                                      "Integrated security=sspi;" +
                                      "database= Journal;" +
                                      "MultipleActiveResultSets=true;" +
                                      "connection timeout=10;");

            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }

            
                SqlCommand cmd = new SqlCommand(@"Insert into Journal.dbo.Journal (userid,Title,Date,Entry) Values (@userid, @Title, @Date, @Entry)", con);

                cmd.Parameters.AddWithValue("@UserId", System.Data.SqlDbType.Int);
                cmd.Parameters["@UserId"].Value = UserContext.UserId;
                cmd.Parameters.AddWithValue("@Title", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@Title"].Value = title.Text;
                cmd.Parameters.AddWithValue("@Date", System.Data.SqlDbType.Date);
                cmd.Parameters["@Date"].Value = date.Text;
                cmd.Parameters.AddWithValue("@Entry", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@Entry"].Value = entry.Text;


                cmd.ExecuteNonQuery();
                MessageBoxResult result = MessageBox.Show("Submitted ",
                                                "Journal Log",
                                                MessageBoxButton.OK);
            
           

        }

        private void Title(object sender, TextChangedEventArgs e)
        {

        }

        private void Date(object sender, TextChangedEventArgs e)
        {

        }

        private void Entry(object sender, TextChangedEventArgs e)
        {

        }
    }
}
