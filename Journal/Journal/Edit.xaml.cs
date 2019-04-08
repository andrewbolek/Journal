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
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            UserContext HU = new UserContext();
            if (String.IsNullOrEmpty(username.Text))
            {
                MessageBox.Show("Invalid username Input", "Error", MessageBoxButton.OK);
                return;
            }
            if (String.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Invalid password Input", "Error", MessageBoxButton.OK);
                return;
            }
            if (String.IsNullOrEmpty(first.Text))
            {
                MessageBox.Show("Invalid First Name Input", "Error", MessageBoxButton.OK);
                return;
            }
            if (String.IsNullOrEmpty(last.Text))
            {
                MessageBox.Show("Invalid Last Name Input", "Error", MessageBoxButton.OK);
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
                MessageBox.Show("Error Connecting to server");
            }

            //try
            //{
                SqlCommand cmd = new SqlCommand("UPDATE[dbo].[User] SET[username] = @username, [Password] = @password, [First Name] = @first, [Last Name] = @last WHERE userid = @userid", con);

                cmd.Parameters.AddWithValue("@userid", System.Data.SqlDbType.Int);
                cmd.Parameters.AddWithValue("@first", System.Data.SqlDbType.VarChar);
                cmd.Parameters.AddWithValue("@last", System.Data.SqlDbType.VarChar);
                cmd.Parameters.AddWithValue("@username", System.Data.SqlDbType.VarChar);
                cmd.Parameters.AddWithValue("@password", System.Data.SqlDbType.VarChar);


                cmd.Parameters["@userid"].Value = UserContext.UserId;
                cmd.Parameters["@first"].Value = first.Text;
                cmd.Parameters["@last"].Value = last.Text;
                cmd.Parameters["@username"].Value = username.Text;
                cmd.Parameters["@password"].Value = password.Text;



                cmd.ExecuteNonQuery();
                MessageBoxResult result = MessageBox.Show("Account Updated! ",
                                                "User update",
                                                MessageBoxButton.OK);

        }
            //catch
            //{
            //    MessageBox.Show("That didnt work..", ":(", MessageBoxButton.OK);
            //}
    }
}
    

