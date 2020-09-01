using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MainprojectofTeamphenomenon
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-COH8Q90;Initial Catalog=realmenu;Persist Security Info=True;User ID=sa;Password=APO gaming");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into tblrating([Good],[Amazing!!],[Needs To Improve],[It's Okay])values('Rated','...','...','...')", con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thanks for rating");
            con.Close();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-COH8Q90;Initial Catalog=realmenu;Persist Security Info=True;User ID=sa;Password=APO gaming");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into tblrating([Needs To Improve],[It's Okay],[Good],[Amazing!!])values('Rated','...','...','...')", con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.ExecuteNonQuery();
            MessageBox.Show("We will try better at next time ");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-COH8Q90;Initial Catalog=realmenu;Persist Security Info=True;User ID=sa;Password=APO gaming");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into tblrating([It's Okay],[Needs To Improve],[Good],[Amazing!!])values('Rated','...','...','...')", con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thanks for rating ");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-COH8Q90;Initial Catalog=realmenu;Persist Security Info=True;User ID=sa;Password=APO gaming");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into tblrating([Amazing!!],[It's Okay],[Needs To Improve],[Good])values('Rated','...','...','...')", con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Yes, you are amazing !!");
            con.Close();
        }
    }
    }


