using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymTuto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            AddMember addmember = new AddMember();
            addmember.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            MemList Update = new MemList();
            Update.Show();
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            PriceList pay = new PriceList();
            pay.Show();
            this.Hide();
        }

       

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
            ViewMembers viewmember = new ViewMembers();
            viewmember.Show();
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            AddTrainer addbook = new AddTrainer();
            addbook.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddClientBtn_Click(object sender, EventArgs e)
        {
            AddClient addclient = new AddClient();
            addclient.Show();
            this.Hide();
        }
    }
}
