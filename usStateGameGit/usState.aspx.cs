using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace usStateGameGit
{
    public partial class usState : System.Web.UI.Page
    {
        private int count = 0;
        private int total;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                GetData(); // Load a new game when the Page load for the first time
                total = 0;
            }
            else
            {
                total = (int)ViewState["count"];
            }
        }


        /// <summary>
        /// This function gest the Name of the state from Database
        /// </summary>
        private void GetData()
        {
            string str = ConfigurationManager.ConnectionStrings["game"].ConnectionString; // connection string
            SqlConnection con = new SqlConnection(str);
            string Query = "Select States from State_Capitals"; // Query the database
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "st");  // fill the virtual database


            Random num = new Random();
            DataRow[] dr = new DataRow[5];

            Label[] Lbl = new Label[5];
            int[] index = new int[5];

            List<string> mylist = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                index[i] = num.Next(0, 50);
                dr[i] = ds.Tables["st"].Rows[index[i]];
                Lbl[i] = new Label();
                Lbl[i].Text = dr[i]["States"].ToString();
                mylist.Add(Lbl[i].Text);
            }

            ViewState["da"] = mylist;

            // After clicking the answer button the state name stay close the answer texboxes.
            this.LblQuestion1.Controls.Add(Lbl[0]);
            this.LblQuestion2.Controls.Add(Lbl[1]);
            this.LblQuestion3.Controls.Add(Lbl[2]);
            this.LblQuestion4.Controls.Add(Lbl[3]);
            this.LblQuestion5.Controls.Add(Lbl[4]);

        }

        // This function turn all the answer texboxs to read only mode
        private void DisableTextBox()
        {
            TextBoxQuestion1.ReadOnly = true;
            TextBoxQuestion2.ReadOnly = true;
            TextBoxQuestion3.ReadOnly = true;
            TextBoxQuestion4.ReadOnly = true;
            TextBoxQuestion5.ReadOnly = true;
        }


        private void ableTextBox()
        {
            TextBoxQuestion1.ReadOnly = false;
            TextBoxQuestion2.ReadOnly = false;
            TextBoxQuestion3.ReadOnly = false;
            TextBoxQuestion4.ReadOnly = false;
            TextBoxQuestion5.ReadOnly = false;
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            CheckAnswer();
            LblCountGoodAnswer.Text = "Your current score : " + count.ToString(); // Your score
            total += count;
            LblOverAllTotal.Text = "Your score  :" + total.ToString(); // Your total score
        }


        private void CheckAnswer()
        {
            List<string> llbl = new List<string>();
            llbl = (List<string>)ViewState["da"];

            String str = ConfigurationManager.ConnectionStrings["game"].ConnectionString;

            // The following check Question # 1
            using (SqlConnection con = new SqlConnection(str))
            {
                string Query = "Select Capital from State_Capitals where states ='" + llbl[0] + "'";
                SqlCommand cmd = new SqlCommand(Query, con);
                con.Open();


                using (SqlDataReader rdr = cmd.ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        string dt = rdr["Capital"].ToString().ToUpper();
                        string text = TextBoxQuestion1.Text.ToUpper().Trim();


                        if (string.Equals(dt, text))
                        {
                            Lblanswer1.ForeColor = System.Drawing.Color.Blue;
                            Lblanswer1.Text = "Good";
                            count++;
                        }
                        else
                        {
                            Lblanswer1.ForeColor = System.Drawing.Color.Red;
                            Lblanswer1.Text = "False";
                        }

                    }


                } // End checking question  # 1


                // begins Checking question #2
                Query = "Select Capital from State_Capitals where states ='" + llbl[1] + "'";
                cmd = new SqlCommand(Query, con);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        string dt = rdr["Capital"].ToString().ToUpper();
                        string text = TextBoxQuestion2.Text.ToUpper().Trim();
                        if (string.Equals(dt, text))
                        {
                            Lblanswer2.ForeColor = System.Drawing.Color.Blue;
                            Lblanswer2.Text = "Good";
                            count++;
                        }
                        else
                        {
                            Lblanswer2.ForeColor = System.Drawing.Color.Red;
                            Lblanswer2.Text = "False";
                        }

                    }


                }// Closing checking Question No2

                // Begin cheking question #3 
                Query = "Select Capital from State_Capitals where states ='" + llbl[2] + "'";
                cmd = new SqlCommand(Query, con);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        string dt = rdr["Capital"].ToString().ToUpper();
                        string text = TextBoxQuestion3.Text.ToUpper().Trim();
                        if (string.Equals(dt, text))
                        {
                            Lblanswer3.ForeColor = System.Drawing.Color.Blue;
                            Lblanswer3.Text = "Good";
                            count++;
                        }
                        else
                        {
                            Lblanswer3.ForeColor = System.Drawing.Color.Red;
                            Lblanswer3.Text = "False";
                        }

                    }


                }// Closing Question No3

                // Begingin checking Question No 4
                Query = "Select Capital from State_Capitals where states ='" + llbl[3] + "'";
                cmd = new SqlCommand(Query, con);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        string dt = rdr["Capital"].ToString().ToUpper();
                        string text = TextBoxQuestion4.Text.ToUpper().Trim();
                        if (string.Equals(dt, text))
                        {
                            Lblanswer4.ForeColor = System.Drawing.Color.Blue;
                            Lblanswer4.Text = "Good";
                            count++;
                        }
                        else
                        {
                            Lblanswer4.ForeColor = System.Drawing.Color.Red;
                            Lblanswer4.Text = "False";
                        }

                    }


                }// Closing Question No4

                // Begin cheking quesion No5
                Query = "Select Capital from State_Capitals where states ='" + llbl[4] + "'";
                cmd = new SqlCommand(Query, con);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        string dt = rdr["Capital"].ToString().ToUpper();
                        string text = TextBoxQuestion5.Text.ToUpper().Trim();
                        if (string.Equals(dt, text))
                        {
                            Lblanswer5.ForeColor = System.Drawing.Color.Blue;
                            Lblanswer5.Text = "Good";
                            count++;
                        }
                        else
                        {
                            Lblanswer5.ForeColor = System.Drawing.Color.Red;
                            Lblanswer5.Text = "False";
                        }

                    }


                }// Closing Question No5



            } // closing connection

            // Restore the name of all the states 
            LblQuestion1.Text = llbl[0].ToString();
            LblQuestion2.Text = llbl[1].ToString();
            LblQuestion3.Text = llbl[2].ToString();
            LblQuestion4.Text = llbl[3].ToString();
            LblQuestion5.Text = llbl[4].ToString();

            // Disable all the texboxes, turn them to read only mode
            DisableTextBox();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GetData();
            // Remove text in the tex box
            TextBoxQuestion1.Text = String.Empty;
            TextBoxQuestion2.Text = String.Empty;
            TextBoxQuestion3.Text = String.Empty;
            TextBoxQuestion4.Text = String.Empty;
            TextBoxQuestion5.Text = String.Empty;

            // clear all the label data

            Lblanswer1.Text = String.Empty;
            Lblanswer2.Text = String.Empty;
            Lblanswer3.Text = String.Empty;
            Lblanswer4.Text = String.Empty;
            Lblanswer5.Text = String.Empty;

            // Clear the score result
            LblCountGoodAnswer.Text = string.Empty;

            // Turn the texboxes back to write mode
            ableTextBox();
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {

            ViewState["count"] = total;
        }

    }
}