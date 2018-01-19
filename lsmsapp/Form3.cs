using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmsClient;
using System.Data.SqlClient;
using System.Net;
using Twilio;
namespace lsmsapp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            fillcombo();
        }
        void fillcombo()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=libdb;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            String query = "select Book_Name,Book_ID,Book_Author from Libbooks;";
            String query1 = "select distinct Book_deptID from Libbooks;";
            String query2 = "select distinct Book_semID from Libbooks;";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader dr;
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbname.Items.Add(dr["Book_Name"]);

                    cbid.Items.Add(dr["Book_ID"]);
                    
                    cbauthor.Items.Add(dr["Book_Author"]);

                 }
                dr.Close();

                SqlCommand cmd2 = new SqlCommand(query1, con);
                dr = cmd2.ExecuteReader();
                while(dr.Read())
                {
                    cbdptid.Items.Add(dr["Book_deptID"]);
                }
                dr.Close();

                SqlCommand cmd3 = new SqlCommand(query2, con);
                dr = cmd3.ExecuteReader();
                while (dr.Read())
                {
                   cbsem.Items.Add(dr["Book_semID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void cbname_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=libdb;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            String query = "select * from Libbooks where Book_Name='"+cbname.Text+"';";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String sid = dr.GetInt32(0).ToString();
                    cbid.Text = sid;
                    String sdptid = dr.GetInt32(4).ToString();
                    cbdptid.Text = sdptid;
                    String sauthor = dr.GetString(2);
                    cbauthor.Text = sauthor;
                    String ssemid = dr.GetString(5);
                    cbsem.Text = ssemid;
                }

             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void cbid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public String str4;
        public Int64 j;
        public void sendbtn_Click(object sender, EventArgs e)
        {
            SendSms sms = new SendSms();
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=libdb;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Initial Catalog=smsdb;Integrated Security=True;Pooling=False");
            try
            {
                 con.Open();
              // MessageBox.Show(cbid.Text);
                String str = "select Book_Status from Libbooks where Book_ID='"+cbid.Text+"';";
                SqlCommand cmd1 = new SqlCommand(str, con);
               cmd1.ExecuteNonQuery();
                SqlDataReader dr = cmd1.ExecuteReader();
              // MessageBox.Show(str);
              
                while(dr.Read())
                {
                    str4 = Convert.ToString(dr.GetString(0));
                }

                dr.Close();
                   cn.Open();
                  // MessageBox.Show(Form1.txtbxid);
                    String str1 = "select Umob from register where Uid='" + Form1.txtbxid + "'; ";
                    SqlCommand cmd2 = new SqlCommand(str1,cn);
                    cmd2.ExecuteNonQuery();
                     dr=cmd2.ExecuteReader();
                    //String str5;
                    
                     while (dr.Read())
                     {
                         //str5 = dr.GetInt64(0).ToString();
                       j= Convert.ToInt64(dr.GetValue(0));
                     }
                    /* if (j == 8897813908)
                         MessageBox.Show("Nunber exist");
                    // MessageBox.Show();*/
                String ava = "AVAILABLE ";
                String str3;
                if (String.Compare(str4,ava)==0)
                {
                    str3 = "the book is available........you can issue it in our library";
                }
                else
                {
                    str3 = "sorry!!!, the book is already issued,try after sometime";
                }
               // MessageBox.Show(str3);
                  
         //using way2sms
            String status = sms.send("7382546990","W2759G",str3,"j");
            if (status == "1")
                MessageBox.Show("your request received successfully, you will receive message in short span of time");
            else if (status == "2")
                MessageBox.Show("no internet connection");
            else
                MessageBox.Show("invalid login id/pswd");

         //using site2sms
            String status1 = sms.send("7382546990", "swathi25",str3,"j");
            if (status == "1")
                MessageBox.Show("your request received successfully, you will receive message in short span of time");
            else if (status1 == "2")
                MessageBox.Show("no internet connection");
            else
                MessageBox.Show("invalid login id/pswd");

          //using twilio
            string AccountSid = "AC527f70f5b094ea04bd0fe0f55a16d2c2";
            string AuthToken = "189694c4c63f23517e0c5f7ffc9676a2";
           
                var twilio = new TwilioRestClient(AccountSid, AuthToken);
                var message = twilio.SendMessage("+1 201-762-5137","j",str3);
                MessageBox.Show(message.Sid);

          //using clickatell
                WebClient client = new WebClient();
                String baseurl = "http://api.clickatell.com/http/sendmsg?api_id=3514102&user=suryapradeep&password=swathi25&to='"+j+"'&text='" + str3 + "'";
                client.OpenRead(baseurl);
                MessageBox.Show("your request received successfully, you will receive message in short span of time");
            
          //using bulk sms
             WebClient clnt=new WebClient();
             String url = "http://bulksms.vsms.net:5567/eapi/submission/send_sms/2/2.0?username=suryapradeep&password=swathi25&message='" + str3 + "'&msisdn='"+j+"'";
             clnt.OpenRead(url);  
              // MessageBox.Show("successfully sent");
              String i= "http://bulksms.vsms.net:5567/eapi/status_reports/get_report/2/2.0?username=suryapradeep&password=swathi25&batch_id=623745";
                if (i=="0"|i=="10")
                {
                    MessageBox.Show("your request received successfully, you will receive message in short span of time");
                }
                else 
                {
                    MessageBox.Show("No internet connection is available");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
             {
                con.Close();
                cn.Close();
             }
        }

        private void cbdptid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbauthor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbsem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public string Umob { get; set; }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
