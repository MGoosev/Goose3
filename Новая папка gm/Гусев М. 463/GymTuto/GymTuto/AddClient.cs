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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=31.31.198.169;Initial Catalog=u1707856_gymdb;Persist Security Info=True;User ID=u1707856_mgoosev;Password=Tyxplm42");

        private void populate()
        {
            Con.Open();
            string query = "select * from ClientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            ClientSDGV.DataSource = ds.Tables[0];
            this.ClientSDGV.Columns[0].Visible = false;
            this.ClientSDGV.Columns[1].Width = 270;
            this.ClientSDGV.Columns[1].HeaderText = "ФИО клиента";
            this.ClientSDGV.Columns[2].HeaderText = "Телефон";
            Con.Close();
        }


        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from ClientTbl where CName='" + NameTb.Text + "' and CPhone='" + PhoneTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0].ToString() == "1")
                {
                    MessageBox.Show("Клиент уже существует");
                }
                try
                {
                    Con.Open();
                    string query = "insert into ClientTbl values(N'" + NameTb.Text + "','" + PhoneTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Клиент успешно добавлен");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            populate();
        }
        int key = 0;
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
                    string query = "delete from ClientTbl where CId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Клиент успешно удален");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ClientSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(ClientSDGV.SelectedRows[0].Cells[0].Value.ToString());
            NameTb.Text = ClientSDGV.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = ClientSDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            if (key == 0 || NameTb.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {

                try
                {
                    Con.Open();
                    string query = "update ClientTbl set CName=N'" + NameTb.Text + "',CPhone='" + PhoneTb.Text + "' where CId = " + key + ";";
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
    }
}
