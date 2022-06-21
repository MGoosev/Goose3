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
    public partial class AddTrainer : Form
    {
        public AddTrainer()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=31.31.198.169;Initial Catalog=u1707856_gymdb;Persist Security Info=True;User ID=u1707856_mgoosev;Password=Tyxplm42");
        private void populate()
        {
            Con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            TrainerSDGV.DataSource = ds.Tables[0];
            this.TrainerSDGV.Columns[0].Visible = false;
            this.TrainerSDGV.Columns[1].Width = 280;
            this.TrainerSDGV.Columns[1].HeaderText = "Тренер";
            this.TrainerSDGV.Columns[2].HeaderText = "Телефон";
            Con.Close();
        }
        private void AddTrainer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "u1707856_gymdbDataSet.BookTbl". При необходимости она может быть перемещена или удалена.
            this.bookTblTableAdapter1.Fill(this.u1707856_gymdbDataSet.BookTbl);
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TitleTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BookTbl values(N'" + TitleTb.Text + "', '" + PhoneTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Тренер успешно добавлен");
                    Con.Close();
                    populate();
                    TitleTb.Text = "";
                    PhoneTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int key = 0;
        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            if (key == 0 || TitleTb.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {

                try
                {
                    Con.Open();
                    string query = "update BookTbl set BTitle=N'" + TitleTb.Text + "',BPhone='" + PhoneTb.Text + "' where BId = " + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Тренер успешно изменен");
                    Con.Close();
                    populate();
                    TitleTb.Text = "";
                    PhoneTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void TrainerSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(TrainerSDGV.SelectedRows[0].Cells[0].Value.ToString());
            TitleTb.Text = TrainerSDGV.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = TrainerSDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Выберите тренера для удаления");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from BookTbl where BId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Тренер успешно удален");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }
    }
}
