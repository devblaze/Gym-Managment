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
        MySqlDataAdapter da2;
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

            var link = new DataGridViewLinkColumn();
            link.DataPropertyName = "Select";
            link.Name = "Select";
            link.DisplayIndex = 6;
            link.DefaultCellStyle.NullValue = "Select";
            link.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            link.Width = 60;
            link.ActiveLinkColor = Color.White;
            link.LinkBehavior = LinkBehavior.HoverUnderline;
            link.LinkColor = Color.Crimson;
            link.VisitedLinkColor = Color.YellowGreen;

            dataGridView1.Columns.Add(link);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Rows[e.RowIndex].Cells["Select"].ColumnIndex)
            {
                String q = "select * from subscriptions";
                q += " where customer_id='";
                q += Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value) + "'";
                da2 = new MySqlDataAdapter(q, cn);
                da2.Fill(ds, "Subscriptions");
                //MessageBox.Show(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["name"].Value));
                Subs sub = new Subs();
                sub.ds = ds.Tables["Subscriptions"];
                sub.ShowDialog();
            }
        }
    }
}
