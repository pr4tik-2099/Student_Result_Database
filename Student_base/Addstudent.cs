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
    public partial class Addstudent : Form
    {
        string sqlconn = System.Configuration.ConfigurationSettings.AppSettings["sqlcon"];
        public Addstudent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            info_lbl.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(sqlconn);
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            try
            {

                  string sqlquery = "insert into marks(Name,Roll_no,marks)values('" + name_txt.Text.ToString() + "','" + rno_txt.Text.ToString() + "','" + marks_txt.Text.ToString() + "')";
                  cmd = new SqlCommand(sqlquery, conn);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    info_lbl.Show();
                    info_lbl.ForeColor = Color.LightGreen;
                    info_lbl.Text = "Data inserted successfully";

                }
                else if(result == 0)
                {
                    info_lbl.Show();
                     info_lbl.ForeColor = Color.Red;
                    info_lbl.Text = "Error";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { conn.Close(); 
              cmd.Dispose();
            }
        }
    }
}
