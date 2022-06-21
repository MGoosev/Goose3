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
namespace GymTuto
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=31.31.198.169;Initial Catalog=u1707856_gymdb;Persist Security Info=True;User ID=u1707856_mgoosev;Password=Tyxplm42");
        private void AddMember_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "u1707856_gymdbDataSet.ClientTbl". При необходимости она может быть перемещена или удалена.
            this.clientTblTableAdapter.Fill(this.u1707856_gymdbDataSet.ClientTbl);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "u1707856_gymdbDataSet.PriceTbl". При необходимости она может быть перемещена или удалена.
            this.priceTblTableAdapter2.Fill(this.u1707856_gymdbDataSet.PriceTbl);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "u1707856_gymdbDataSet.BookTbl". При необходимости она может быть перемещена или удалена.
            this.bookTblTableAdapter2.Fill(this.u1707856_gymdbDataSet.BookTbl);
            NameTb.Text = "";
            PhoneTb.Text = "";
            AgeTb.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PhoneTb.Text == "" || GenderCb.Text == "" || AgeTb.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                string payperiode = Periode.Value.Date.ToShortDateString();
                try
                {
                    {
                        Con.Open();
                        string query = "insert into MemberTbl values(N'" + NameTb.Text + "','" + PhoneTb.Text + "',N'" + GenderCb.Text + "','" + TypeCb.Text + "','" + AgeTb.Text + "','" + AmountTb.Text + "','" + payperiode + "')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                    }
                    {
                        string query = "insert into ActMemTbl values(N'" + NameTb.Text + "','" + PhoneTb.Text + "',N'" + GenderCb.Text + "','" + TypeCb.Text + "','" + AgeTb.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        
                    }
                    {
                        string query = "insert into ClientTbl values(N'" + NameTb.Text + "','" + PhoneTb.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Абонемент успешно добавлен");
                        Con.Close();
                        NameTb.Text = "";
                        PhoneTb.Text = "";
                        GenderCb.Text = "";
                        AgeTb.Text = "";
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            PhoneTb.Text = "";
            GenderCb.Text = "";
            AgeTb.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void TimingCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AmountTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void PhoneTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void AgeTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void GenderCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NameTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Periode_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AmountTb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AmountTb_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void AgeTb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
