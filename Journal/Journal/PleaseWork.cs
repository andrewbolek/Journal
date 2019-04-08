using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Journal
{
    public class PleaseWork
    {
        public PleaseWork()
        {

            

            //SqlConnection myConnection = new SqlConnection
            //                                      (@"server=THE-PROFESSOR\ANDREW;" +
            //                                      "Integrated security=sspi;" +
            //                                      "database= Journal;" +
            //                                      "MultipleActiveResultSets=true;" +
            //                                      "connection timeout=10;");
            //{
            //    try
            //    {
            //        myConnection.Open();
            //        SqlCommand cmd = new SqlCommand(@"SELECT userID FROM [Journal].[dbo].[User] WHERE Username=@uname and password=@pass", myConnection);
            //        cmd.Parameters.AddWithValue("@uname", Username1.Text);
            //        cmd.Parameters.AddWithValue("@pass", Password1.Text);
            //        int result = (int)cmd.ExecuteScalar();
            //        if (result > 0)
            //        {

            //            MessageBox.Show($"Welcome {box1}! ");

            //            Menu menu = new Menu();
            //            menu.Show();



            //            this.Close();
            //        }
            //        else
            //            MessageBox.Show("Incorrect login");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Unexpected error:" + ex.Message);
            //    }
            //}

        }


    }
}
