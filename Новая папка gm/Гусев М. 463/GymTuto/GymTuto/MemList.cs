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
    public partial class MemList : Form
    {
        public MemList()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=31.31.198.169;Initial Catalog=u1707856_gymdb;Persist Security Info=True;User ID=u1707856_mgoosev;Password=Tyxplm42");
        private void populate()
        {
            Con.Open();
            string query = "select * from MemberTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();
            this.MemberSDGV.Columns[0].Visible = false;
            this.MemberSDGV.Columns[1].Width = 80;
            this.MemberSDGV.Columns[1].HeaderText = "ФИО клиента";
            this.MemberSDGV.Columns[2].Width = 40;
            this.MemberSDGV.Columns[2].HeaderText = "Номер телефона";
            this.MemberSDGV.Columns[3].Width = 70;
            this.MemberSDGV.Columns[3].HeaderText = "Персональный тренер";
            this.MemberSDGV.Columns[4].Width = 40;
            this.MemberSDGV.Columns[4].HeaderText = "Тип тренировки";
            this.MemberSDGV.Columns[5].Width = 20;
            this.MemberSDGV.Columns[5].HeaderText = "Кол-во";
            this.MemberSDGV.Columns[6].Width = 20;
            this.MemberSDGV.Columns[6].HeaderText = "Цена";
            this.MemberSDGV.Columns[7].Width = 110;
            this.MemberSDGV.Columns[7].HeaderText = "Дата оплаты";
        }
        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "u1707856_gymdbDataSet.BookTbl". При необходимости она может быть перемещена или удалена.
            this.bookTblTableAdapter2.Fill(this.u1707856_gymdbDataSet.BookTbl);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "u1707856_gymdbDataSet.PriceTbl". При необходимости она может быть перемещена или удалена.
            this.priceTblTableAdapter2.Fill(this.u1707856_gymdbDataSet.PriceTbl);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "u1707856_gymdbDataSet.MemberTbl". При необходимости она может быть перемещена или удалена.
            this.memberTblTableAdapter1.Fill(this.u1707856_gymdbDataSet.MemberTbl);

            populate();
        }
        int key=0;
        private void filterByName()
        {
            Con.Open();
            BindingSource bs = new BindingSource();
            bs.DataSource = MemberSDGV.DataSource;
            bs.Filter = "MName like '%" + SearchClient.Text + "%'";
            MemberSDGV.DataSource = bs.DataSource;
            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            PhoneTb.Text = "";
            AmountTb.Text = "";
            GenderCb.Text = "";
            AgeTb.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(key == 0)
            {
                MessageBox.Show("Выберите клиента для удаления");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from MemberTbl where MId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Клиент успешно удален");
                    Con.Close();
                    populate();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0 || NameTb.Text == "" || PhoneTb.Text == "" || AmountTb.Text == "" || GenderCb.Text == "" || AgeTb.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update MemberTbl set MName=N'" + NameTb.Text + "', MPhone='" + PhoneTb.Text + "',MGen=N'" + GenderCb.Text + "',MAge='" + AgeTb.Text + "',MType=N'"+ TypeCb.Text +"', MAmount='" + AmountTb.Text + "' where MId="+key+";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Клиент успешно изменен");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TimingCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AmountTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void AgeTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Periode_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GenderCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgeTb_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AgeTb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SumBtn_Click(object sender, EventArgs e)
        {
            SumLbl.Text = "0";
            for (int i = 0; i < MemberSDGV.Rows.Count; i++)
            {
                SumLbl.Text = Convert.ToString(double.Parse(SumLbl.Text) + double.Parse(MemberSDGV.Rows[i].Cells[6].Value.ToString()));
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            filterByName();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
            SearchClient.Text = "";
        }

        private void MemberSDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(MemberSDGV.SelectedRows[0].Cells[0].Value.ToString());
            NameTb.Text = MemberSDGV.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = MemberSDGV.SelectedRows[0].Cells[2].Value.ToString();
            GenderCb.Text = MemberSDGV.SelectedRows[0].Cells[3].Value.ToString();
            TypeCb.Text = MemberSDGV.SelectedRows[0].Cells[4].Value.ToString();
            AgeTb.Text = MemberSDGV.SelectedRows[0].Cells[5].Value.ToString();
            AmountTb.Text = MemberSDGV.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
