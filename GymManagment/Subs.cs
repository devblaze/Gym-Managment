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
    public partial class Subs : MetroForm
    {
        MySqlCommandBuilder builder;
        MySqlDataAdapter da2;
        private DataSet ds2;
        MySqlCommand com;

        public Subs()
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

        private void Subs_Load(object sender, EventArgs e)
        {
            ds2 = new DataSet();
            rerfeshGrid();
        }

        private void executeQuery(string query)
        {
            try
            {
                com = new MySqlCommand(query, MainForm.connection);
                if (com.ExecuteNonQuery() == 1)
                {
                    MetroMessageBox.Show(this, "Success", "Query executed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Error", "Query not executed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rerfeshGrid()
        {
            try
            {
                String q2 = "select * from subscriptions";
                q2 += " where customer_id='";
                q2 += MembersFee.CustomerId().ToString() + "'";
                da2 = new MySqlDataAdapter(q2, MainForm.connection);
                ds2.Clear();
                da2.Fill(ds2, "Subscriptions");
                dataGridView1.DataSource = ds2.Tables["Subscriptions"];
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      
        private void monthTB_Validated_1(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(monthTB.Text) <= 0)
                {
                    errorProvider1.SetError(monthTB, "Cant make a subscription with no months");
                }
                else
                {
                    errorProvider1.Clear();
                    DateTime date = new DateTime();
                    date = startDate.Value;
                    endDate.Value = date.AddMonths(int.Parse(monthTB.Text));
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(monthTB, "Cant make a subscription with no months");
            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            int tmp = MembersFee.CustomerId();
            string q = "INSERT INTO subscriptions(customer_id,start_date,end_date,package,cost,paid) VALUES(" + tmp + ",'" + startDate.Value.ToString() + "','" + endDate.Value.ToString() + "','" + monthTB.Text + "','" + double.Parse(costTB.Text) + "','" + payTB.Text + "')";
            executeQuery(q);
            rerfeshGrid();
        }

        private void freeze_Click_1(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            String q2 = "select * from subscriptions";
            q2 += " where id='";
            q2 += subID.Text.ToString().ToString() + "'";
            da2 = new MySqlDataAdapter(q2, MainForm.connection);
            ds2.Clear();
            da2.Fill(ds2, "Subscriptions");
            dataGridView1.DataSource = ds2.Tables["Subscriptions"];
            date = DateTime.Parse(dataGridView1.Rows[0].Cells["end_date"].Value.ToString());
            endDate.Value = date.AddMonths(int.Parse(monthsFTB.Text));
            string q = "UPDATE subscriptions SET end_date='" + endDate.Value.ToString() + "' WHERE id='" + subID.Text.ToString() + "'";
            executeQuery(q);
            rerfeshGrid();
        }

        private void update_Click_1(object sender, EventArgs e)
        {
            builder = new MySqlCommandBuilder(da2);
            da2.Update(ds2, "Subscriptions");

        }
    }
}
