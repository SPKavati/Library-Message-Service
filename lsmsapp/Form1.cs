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
namespace lsmsapp
{
    public partial class Form1 : Form
    {
        public static String txtbxid;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Initial Catalog=smsdb;Integrated Security=True;Pooling=False");
            try
            {
                cn.Open();
                String sql = "select Uid,Upwd from register where Uid='" + txtuser.Text + "'and Upwd='" + txtpsw.Text + "' ";
                txtbxid = txtuser.Text;
                //MessageBox.Show(txtbxid);
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                int count = 0;
                while (sdr.Read())
                {
                    count += 1;
                }
                if (count == 1)
                {
                    new Form3().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect id or password......please enter valid id and password!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            } 
        }

        private void txtpsw_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
