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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
       // private void form2_load(object sender, EventArgs e)
        //{
           // this.membersTableAdapters.Fill(this.DbmembersDataSet1.members);
        //}
        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Initial Catalog=smsdb;Integrated Security=True;Pooling=False");
            try{
              cn.Open();
              String sql = "INSERT INTO register values('" + uId.Text + "','" + uName.Text + "','" + uDptId.Text + "','" + uAdd.Text + "','" + uMob.Text + "','" + uStatus.Text + "','" + uPassword.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, cn);
                if (uId.Text.Length <= 5 | uId.Text.Length >= 10)
                MessageBox.Show("id length b/w 5&10 ");
                else if (uMob.Text.Length < 10 | uMob.Text.Length > 10)
                    MessageBox.Show("enter valid phone number");
                else if (uName.Text.Length < 7|uPassword.Text.Length<7)
                    MessageBox.Show("username or password length is atleast 6 characters");
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully registerd", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Form1().Show();
                    this.Hide();
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
