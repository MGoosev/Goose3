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
    public partial class ViewMembers : Form
    {
        public ViewMembers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=31.31.198.169;Initial Catalog=u1707856_gymdb;Persist Security Info=True;User ID=u1707856_mgoosev;Password=Tyxplm42");
        private void populate()
        {
            Con.Open();
            string query = "select * from ActMemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();
            this.MemberSDGV.Columns[0].Visible = false;
            this.MemberSDGV.Columns[1].Width = 100;
            this.MemberSDGV.Columns[1].HeaderText = "ФИО клиента";
            this.MemberSDGV.Columns[2].Width = 60;
            this.MemberSDGV.Columns[2].HeaderText = "Номер телефона";
            this.MemberSDGV.Columns[3].Width = 100;
            this.MemberSDGV.Columns[3].HeaderText = "Персональный тренер";
            this.MemberSDGV.Columns[4].Width = 100;
            this.MemberSDGV.Columns[4].HeaderText = "Тип тренировки";
            this.MemberSDGV.Columns[5].Width = 60;
            this.MemberSDGV.Columns[5].HeaderText = "Кол-во тренировок";
        }
        private void ViewMembers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "u1707856_gymdbDataSet1.BookTbl". При необходимости она может быть перемещена или удалена.
            this.bookTblTableAdapter.Fill(this.u1707856_gymdbDataSet1.BookTbl);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "u1707856_gymdbDataSet.PriceTbl". При необходимости она может быть перемещена или удалена.
            this.priceTblTableAdapter.Fill(this.u1707856_gymdbDataSet.PriceTbl);
            Con.Open();
            string query = "delete from ActMemTbl where AAge<=0";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            populate();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MainForm log = new MainForm();
            log.Show();
            this.Hide();
        }
        private void filterByName()
        {
            Con.Open();
            BindingSource bs = new BindingSource();
            bs.DataSource = MemberSDGV.DataSource;
            bs.Filter = "AName like '%" + SearchMember.Text + "%'";
            MemberSDGV.DataSource = bs.DataSource;
            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filterByName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
            SearchMember.Text = "";
        }

        private void MemberSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(MemberSDGV.SelectedRows[0].Cells[0].Value.ToString());
            NameTb.Text = MemberSDGV.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = MemberSDGV.SelectedRows[0].Cells[2].Value.ToString();
            GenderCb.Text = MemberSDGV.SelectedRows[0].Cells[3].Value.ToString();
            TypeCb.Text = MemberSDGV.SelectedRows[0].Cells[4].Value.ToString();
            AgeTb.Text = MemberSDGV.SelectedRows[0].Cells[5].Value.ToString();
            
        }

        private void SearchMember_OnValueChanged(object sender, EventArgs e)
        {

        }
        int key = 0;
        private void DecreaseBtn_Click(object sender, EventArgs e)
        {
            {
                Con.Open();
                string query = "update ActMemTbl set AAge -= 1 where AId=" + key + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
            }
            {
                
                string query = "delete from ActMemTbl where AAge<=0";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                populate();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (key == 0 || NameTb.Text == "" || PhoneTb.Text == "" || GenderCb.Text == "" || AgeTb.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                
                try
                {
                    Con.Open();
                    string query = "update ActMemTbl set AName=N'" + NameTb.Text + "', APhone='" + PhoneTb.Text + "',AGen=N'" + GenderCb.Text + "',AType=N'" + TypeCb.Text + "', AAge='" + AgeTb.Text + "' where AId=" + key + ";";
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Выберите абонемент для удаления");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from ActMemTbl where AId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Абонемент успешно удален");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}


