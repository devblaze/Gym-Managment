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
using System.Data.OleDb;
using System.Data.SqlClient;


namespace GymManagment
{
    public partial class MembersFee : MetroForm
    {   
        MySqlConnection cn;
        MySqlDataAdapter da1;
        DataSet ds;

        public MembersFee()
        {
            InitializeComponent();
        }

        private void MembersFee_Load(object sender, EventArgs e)
        {
            cn = new MySqlConnection(MainForm.connectionString);
            cn.Open();
            da1 = new MySqlDataAdapter("select * from customers", cn);

            ds = new DataSet();
            da1.Fill(ds, "Customers");
            dataGridView1.DataSource = ds.Tables["Customers"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
