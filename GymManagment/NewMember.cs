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
    public partial class NewMember : MetroForm
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

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
    }
}
