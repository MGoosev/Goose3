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

namespace GymTuto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=31.31.198.169;Initial Catalog=u1707856_gymdb;Persist Security Info=True;User ID=u1707856_mgoosev;Password=Tyxplm42");

        private void button2_Click(object sender, EventArgs e)
        {
            UidTb.Text = "";
            PassTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;

            username = UidTb.Text;
            password = PassTb.Text;
            try
            {
                Con.Open();
                string query = "select * from LoginTbl where LUsername = '" + UidTb.Text + "' and LPassword = '" + PassTb.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                    DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = UidTb.Text;
                    password = PassTb.Text;

                    MainForm mainform = new MainForm();
                    mainform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Указан неверный логин или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UidTb.Text = "";
                    PassTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void UidTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PassTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PShowBtn_Click(object sender, EventArgs e)
        {
            if (PassTb.PasswordChar == '•')
            {
                PHideBtn.BringToFront();
                PassTb.PasswordChar = '\0';
            }
        }

        private void PHideBtn_Click(object sender, EventArgs e)
        {
            if (PassTb.PasswordChar == '\0')
            {
                PShowBtn.BringToFront();
                PassTb.PasswordChar = '•';
            }
        }
    }
}
