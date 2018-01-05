﻿using MetroFramework;
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
    public partial class Equipment : MetroForm
    {
        MySqlDataAdapter adapter;
        DataSet ds;

        public Equipment()
        {
            InitializeComponent();
        }

        private void Equipment_Load(object sender, EventArgs e)
        {
            if (MainForm.connection.State == ConnectionState.Closed)
            {
                MainForm.connection.Open();
            }
            else
            {
                MetroMessageBox.Show(this, "Connection Error", "Could not establish connection with the database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            MainForm.connection = new MySqlConnection();
            adapter = new MySqlDataAdapter("SELECT * FROM equipment", MainForm.connection);
            ds = new DataSet();
            adapter.Fill(ds, "Equipment");
            metroGrid1.DataSource = ds.Tables[0];
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
