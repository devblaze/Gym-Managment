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
using System.Data.SqlClient;

namespace GymManagment
{
    public partial class NewMember : MetroForm
    {
   

        public NewMember()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;";
            SqlConnection cn;
            SqlCommand da1;
            SqlDataReader r1;
            cn = new SqlConnection(cs);
            da1 = new SqlCommand("insert into [dbo].[Customers] ([Id], [name], [surname]) values('1','yo','hi')", cn);           
            try
            {
                cn.Open();
                r1 = da1.ExecuteReader();
                MessageBox.Show("saved");
                while (r1.Read()) { }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cn.Close();
        }

        private void cbPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPackage.Text == "Custom")
            {
                lbFrom.Visible = true;
                lbTo.Visible = true;
                mcFrom.Visible = true;
                mcTo.Visible = true;
            }
            else
            {
                lbFrom.Visible = false;
                lbTo.Visible = false;
                mcFrom.Visible = false;
                mcTo.Visible = false;
            }
        }

        private void NewMember_Load(object sender, EventArgs e)
        {
           
        }
    }
}
