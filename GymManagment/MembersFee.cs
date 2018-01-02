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
        SqlConnection cn;
        SqlDataAdapter da1;
        DataSet ds;

        public MembersFee()
        {
            InitializeComponent();
        }

        private void MembersFee_Load(object sender, EventArgs e)
        {

            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\192.168.1.1(gym).mdf;Integrated Security=True;";
            cn = new SqlConnection(cs);
            da1 = new SqlDataAdapter("select * from customers", cn);

            ds = new DataSet();
            da1.Fill(ds, "Customers");
            dataGridView1.DataSource = ds.Tables["Customers"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
