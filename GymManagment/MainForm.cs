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
            //bool check = false;
            if (test.WindowState == FormWindowState.Normal)
            {
                test.MdiParent = this;
                test.Show();
            }
            else
            {
                //test.MdiParent = this;
                //test.Show();
            }

            /*foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(MainForm))
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.Activate();
                    check = true;
                    return;
                }
            }
            if (check == false)
            {
                test.MdiParent = this;
                test.Show();
            }
            test.TopLevel = false;
            metroPanel2.Controls.Add(test);
            test.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            test.Dock = DockStyle.Fill;
            test.Show();*/
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
