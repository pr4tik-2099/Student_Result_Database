using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_base
{
    public partial class Remove_Student : Form
    {
        string sqlconn = System.Configuration.ConfigurationSettings.AppSettings["sqlcon"];
        public Remove_Student()
        {
            InitializeComponent();
        }

        private void Show_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlconn);
            SqlCommand cmd = new SqlCommand();
            con.Open();

            try
            {
                string sqlquery = "select * from marks where Roll_no='" + rno_txt.Text.ToString() + "'";
                cmd = new SqlCommand(sqlquery, con);
                cmd.CommandType = CommandType.Text;
                var dr = cmd.ExecuteReader();

                if (dr != null)
                {
                    if (dr.Read())
                    {
                        result_gbox.Show();
                        name_txt.Text = dr["Name"].ToString();
                        srno_txt.Text = dr["Roll_no"].ToString();
                        marks_txt.Text = dr["marks"].ToString();

                    }
                    else
                    {
                        result_gbox.Hide();
                        MessageBox.Show("Please Enter your roll no");

                    }

                }
                else
                {
                    MessageBox.Show("Check connection");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
        }

        private void Remove_Student_Load(object sender, EventArgs e)
        {
            name_txt.Enabled = false;
            srno_txt.Enabled = false;
            marks_txt.Enabled = false;
        }

        private void dlt_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlconn);
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Open();
                string sqlquery = "delete from marks where Roll_no = '" + rno_txt.Text.ToString() + "' ";
                cmd = new SqlCommand(sqlquery, con);
                cmd.CommandType = CommandType.Text;
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Success");
                    name_txt.Text = "";
                    srno_txt.Text = "";
                    marks_txt.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close();
            cmd.Dispose();
            }
        }
    }
}
