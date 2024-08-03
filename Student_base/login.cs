using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_base
{
    public partial class login : Form
    {
        [Obsolete]
        string sqlcon = System.Configuration.ConfigurationSettings.AppSettings["sqlcon"];
        SqlCommand cmd;
        public login()
        {
            InitializeComponent();
        }

        private void cls_txt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lgn_txt_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(sqlcon);
            
            try 
            {
                conn.Open();
                cmd = new SqlCommand("select * from st_login where username ='"+name_txt.Text.ToString()+"' and [password]='"+pass_txt.Text.ToString()+"' ",conn);
                cmd.CommandType = CommandType.Text;
                var dr = cmd.ExecuteReader();
                if (dr != null) 
                {
                    if (dr.Read())
                    {
                        Main_menu mm = new Main_menu();
                        this.Close();
                        mm.Show();
                    }
                    else 
                    {
                        msg_lbl.Show();
                        msg_lbl.ForeColor = Color.White;
                        msg_lbl.Text = "User id or password is incorrect";
                    }
                }else 
                {
                    MessageBox.Show("Check connection");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            msg_lbl.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked) 
            {
                pass_txt.UseSystemPasswordChar = false;
            }else
            {
                pass_txt.UseSystemPasswordChar = true;
            }
        }
    }
}
