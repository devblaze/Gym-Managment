using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GymManagment
{
    public partial class Subs : MetroForm
    {
        public DataTable ds;
        MySqlConnection cn;
        MySqlDataAdapter da1;

        public Subs()
        {
            InitializeComponent();
        }

        private void Subs_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds;
        }

        private void Subs_FormClosing(object sender, FormClosingEventArgs e)
        {
            ds.Clear();
        }

        private void Subs_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            cn = new MySqlConnection(MainForm.connectionString);
            cn.Open();

        }
    }
}
