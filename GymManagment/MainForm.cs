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

namespace GymManagment
{
    public partial class MainForm : MetroForm
    {
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
