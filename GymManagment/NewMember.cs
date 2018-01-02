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
    public partial class NewMember : MetroForm
    {
   

        public NewMember()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            double heiDouble = double.Parse(tbHeight.Text);
            double weiDouble = double.Parse(tbWeight.Text);
            string query = "INSERT INTO customers(name,surname,contact,gender,workout,height,weight,health_problems,notes) VALUES ('" + tbName.Text + "','" + tbSurname.Text + "','" + tbContact.Text + "','" + cbGender.Text + "','" + cbWorkout.Text + "','" + heiDouble + "','" + weiDouble + "','" + tbHealth.Text + "','" + tbNotes.Text + "')";
            MainForm.connection.Open();
            MySqlCommand command = new MySqlCommand(query, MainForm.connection);
            if (command.ExecuteNonQuery()==1)
            {
                MetroMessageBox.Show(this, "Success", "Data saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Data not saved!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            MainForm.connection.Close();
        }
    }
}
