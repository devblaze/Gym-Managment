using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagment
{
    public partial class WorkoutProgram : MetroForm
    {
        private int t = 0;
        public WorkoutProgram()
        {
            InitializeComponent();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1170);
                pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
                pd.Print();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "An error occurred while printing!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            if (t < 2)
            {
                
            }
        }
    }
}
