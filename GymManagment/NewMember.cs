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
using MySql.Data.MySqlClient;

namespace GymManagment
{
    public partial class NewMember : MetroForm
    {
   

        public NewMember()
        {
            InitializeComponent();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO customers(name,surname,contact,gender,workout,height,weight,health_problems,notes) VALUES ('" + tbName+ "','" + tbSurname + "','" + tbContact + "','" + cbGender.Text + "','" + cbWorkout.Text + "','" + tbHeight + "','" + tbWeight + "','" + tbHealth + "','" + tbNotes + "')";
            MySqlCommand command = new MySqlCommand(query, MainForm.connection);
        }
    }
}
