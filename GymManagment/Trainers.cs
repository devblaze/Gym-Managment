using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagment
{
  public partial class Trainers : MetroForm
  {
    private MySqlDataAdapter da;
    private DataSet ds;

    public Trainers()
    {
      InitializeComponent();
    }

    private void Trainers_Load(object sender, EventArgs e)
    {
      if (MainForm.connection.State == ConnectionState.Closed)
      {
        MainForm.connection.Open();
      }

      da = new MySqlDataAdapter("select * from trainers", MainForm.connection);
      ds = new DataSet();
      da.Fill(ds, "Trainers");
      dataGridView.DataSource = ds.Tables["Trainers"];
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      DialogResult dialogResult = MessageBox.Show("Are you sure you want to save changes?", "Saving...", MessageBoxButtons.YesNo);
      if (dialogResult == DialogResult.Yes)
      {
        update();
      }
      else if (dialogResult == DialogResult.No)
      {
        DataTable dt = dataGridView.DataSource as DataTable;
        dt.RejectChanges();
      }
    }

    private void update()
    {
      try
      {
        var builder = new MySqlCommandBuilder(da);
        da.Update(ds, "Trainers");
        MessageBox.Show("Saved successfully", "Success");
      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception: " + ex.Message, "Fail");
      }
    }

    private void Trainers_FormClosing(object sender, FormClosingEventArgs e)
    {
      MainForm.connection.Close();
    }
  }
}
