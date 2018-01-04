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
    public partial class MainForm : MetroForm
    {
        static string server = "192.168.1.1";
        static string database = "gym";
        static string uid = "others";
        static string password = "23102310";
        static string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);

        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ShowWindow(Form win)
        {
            try
            {
                win.MdiParent = this;
                win.Show();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ShowWindow(new NewMember());
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ShowWindow(new MembersFee());
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            ShowWindow(new WorkoutProgram());
        }
    }
}
