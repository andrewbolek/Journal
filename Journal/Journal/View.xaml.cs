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

    /// </summary>
    public partial class View : Window
    {
        public View()
        {
            InitializeComponent();

            bool temp = false;
            SqlConnection con = new SqlConnection
                                       (@"server=THE-PROFESSOR\ANDREW;" +
                                      "Integrated security=sspi;" +
                                      "database= Journal;" +
                                      "MultipleActiveResultSets=true;" +
                                      "connection timeout=10;");


            HelpUser HU = new HelpUser()
            {

            };

            con.Open();

            SqlCommand cmd = new SqlCommand("select Title from Journal where UserID=  @UserId order by title asc", con);
            cmd.Parameters.Add("@UserId", System.Data.SqlDbType.Int);
            cmd.Parameters["@UserId"].Value = UserContext.UserId;

            SqlDataReader dr = cmd.ExecuteReader();
            var ordinal = dr.GetOrdinal("Title");
            while (dr.Read())
            {
                try
                {


                    titles.Text += dr.GetString(ordinal) + Environment.NewLine;

                }
                catch
                {
                    MessageBox.Show("Error");
                }

                temp = true;
            }
            if (temp == false)
                MessageBox.Show("not found");
            con.Close();
        }









        private void Titles(object sender, TextChangedEventArgs e)//displays titles textbox
        {

        }



        private void GoClick(object sender, RoutedEventArgs e)//command to make entries give specific entry
        {
            entry.Clear();
            date.Clear(); //this refreshes your box yo


            using (SqlConnection con = new SqlConnection(@"server=THE-PROFESSOR\ANDREW;" +
                                                 "Integrated security=sspi;" +
                                                 "database= Journal;" +
                                                 "MultipleActiveResultSets=true;" +
                                                 "connection timeout=10;"))
            {


                con.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT Date,Entry FROM [Journal].[dbo].[Journal] WHERE UserId=@UserID and  Title =@Title", con);

                cmd.Parameters.AddWithValue("@UserId", System.Data.SqlDbType.Int);
                cmd.Parameters.AddWithValue("@Title", System.Data.SqlDbType.VarChar);

                cmd.Parameters["@UserId"].Value = UserContext.UserId;
                cmd.Parameters["@Title"].Value = titleName.Text;

                SqlDataReader dr = cmd.ExecuteReader();



                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        entry.Text += dr["Entry"].ToString() + Environment.NewLine;
                        date.Text += dr["Date"].ToString() + Environment.NewLine;
                    }

                }
            }
        }
  

        private void TitleName(object sender, TextCompositionEventArgs e)// where users type title
        {

        }

        private void Entry(object sender, TextChangedEventArgs e)//entry output
        {

        }
        private void Back(object sender, RoutedEventArgs e) // back to menu
        {
            this.Close();
        }

        private void Date(object sender, TextChangedEventArgs e) //entry date
        {

        }
    }
}