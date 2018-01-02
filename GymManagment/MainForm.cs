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
    public partial class MainForm : MetroForm
    {
        public string server = "192.168.1.1";
        public string database = "gym";
        public string uid = "others";
        public string password = "23102310";
        //string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ShowWindow(Form test)
        {
            test.MdiParent = this;
            test.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ShowWindow(new NewMember());
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ShowWindow(new MembersFee());
        }
    }
}
