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
    public partial class PriceList : Form
    {
        public PriceList()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=31.31.198.169;Initial Catalog=u1707856_gymdb;Persist Security Info=True;User ID=u1707856_mgoosev;Password=Tyxplm42");
        
        private void populate()
        {
            Con.Open();
            string query = "select * from PriceTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PListSDGV.DataSource = ds.Tables[0];
            Con.Close();
            this.PListSDGV.Columns[0].Visible = false;
            this.PListSDGV.Columns[1].HeaderText = "Количество тренировок";
            this.PListSDGV.Columns[2].HeaderText = "Тип тренировки";
            this.PListSDGV.Columns[3].HeaderText = "Цена";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TimeTb.Text = "";
            TypeCb.Text = "";
            PriceTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "u1707856_gymdbDataSet.PriceTbl". При необходимости она может быть перемещена или удалена.
            this.priceTblTableAdapter1.Fill(this.u1707856_gymdbDataSet.PriceTbl);
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TimeTb.Text == "" || TypeCb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from PriceTbl where PTime='" + TimeTb.Text + "' and PType=N'" + TypeCb.Text + "' and PPrice='" + PriceTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Услуга уже существует");
                }
                else
                {
                    string query = "insert into PriceTbl values('" + TimeTb.Text + "',N'" + TypeCb.Text + "','" + PriceTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Услуга успешно добавлена");
                    TimeTb.Text = "";
                    TypeCb.Text = "";
                    PriceTb.Text = "";
                }
                Con.Close();
                populate();
            }
        }

        int key = 0;
        private void PListSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(PListSDGV.SelectedRows[0].Cells[0].Value.ToString());
            TimeTb.Text = PListSDGV.SelectedRows[0].Cells[1].Value.ToString();
            TypeCb.Text = PListSDGV.SelectedRows[0].Cells[2].Value.ToString();
            PriceTb.Text = PListSDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            if (key == 0 || TimeTb.Text == "" || TypeCb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update PriceTbl set PTime=N'" + TimeTb.Text + "', PType=N'" + TypeCb.SelectedItem.ToString() + "', PPrice='" + PriceTb.Text + "' where PId = " + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Прайс-лист успешно изменен");
                    Con.Close();
                    populate();
                    TimeTb.Text = "";
                    TypeCb.Text = "";
                    PriceTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void TimeCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Выберите услугу для удаления");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from PriceTbl where PId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Услуга успешно удалена");
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
