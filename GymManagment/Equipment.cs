using MetroFramework;
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
    public partial class Equipment : MetroForm
    {
        MySqlDataAdapter adapter;
        DataSet ds;
        MySqlCommandBuilder builder;

        public Equipment()
        {
            if (MainForm.connection.State == ConnectionState.Open)
            {
                InitializeComponent();
            }
            else
            {
                MainForm.connection.Open();
                InitializeComponent();
            }
        }

        private void Equipment_Load(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("SELECT * FROM equipment", MainForm.connection);
            ds = new DataSet();
            adapter.Fill(ds, "Equipment");
            metroGrid1.DataSource = ds.Tables[0];
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                builder = new MySqlCommandBuilder(adapter);
                adapter.Update(ds, "Equipment");
                MetroMessageBox.Show(this, "Success", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM equipment WHERE CONCAT(`id`,`name`) LIKE '" + tbSearch.Text + "%'";
            try
            {
                adapter = new MySqlDataAdapter(query, MainForm.connection);
                ds.Clear();
                adapter.Fill(ds, "Equipment");
                metroGrid1.DataSource = ds.Tables["Equipment"];
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
