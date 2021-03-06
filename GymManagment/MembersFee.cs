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
using System.Data.OleDb;
using System.Data.SqlClient;


namespace GymManagment
{
    public partial class MembersFee : MetroForm
    {   
        MySqlCommandBuilder builder;
        MySqlDataAdapter da1;
        MySqlDataAdapter da2;
        DataSet ds;
        MySqlCommand command;
        static int customerID;

        public MembersFee()
        {
            if (MainForm.connection.State == ConnectionState.Open)
            {
                InitializeComponent();
            }
            else
            {
                MainForm.connection.Open();
                InitializeComponent();
            }
            /*try
            {
                MainForm.connection.Open();               
            }
            catch(Exception ex)
            {
                this.Close();
            }*/
        }
        private void MembersFee_Load(object sender, EventArgs e)
        {
            da1 = new MySqlDataAdapter("select * from customers", MainForm.connection);
            ds = new DataSet();
            da1.Fill(ds, "Customers");
            dataGridView1.DataSource = ds.Tables["Customers"];
            var link = new DataGridViewLinkColumn();
            link.DataPropertyName = "Subs";
            link.Name = "Subs";
            link.DisplayIndex = 6;
            link.DefaultCellStyle.NullValue = "Subs";
            link.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            link.Width = 60;
            link.ActiveLinkColor = Color.White;
            link.LinkBehavior = LinkBehavior.HoverUnderline;
            link.LinkColor = Color.Crimson;
            link.VisitedLinkColor = Color.YellowGreen;

            dataGridView1.Columns.Add(link);
        }      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dataGridView1.Rows[e.RowIndex].Cells["Subs"].ColumnIndex)
                {                  
                    String q = "select * from subscriptions";
                    q += " where customer_id='";
                    q += Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value) + "'";
                    da2 = new MySqlDataAdapter(q, MainForm.connection);
                    da2.Fill(ds, "Subscriptions");
                    Subs sub = new Subs();
                    customerID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);                  
                    sub.ShowDialog();
                }
            }catch(Exception ex)
            {
                MetroMessageBox.Show(this, "Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void checkdate()
        {
            DateTime tmp2 = new DateTime();
            tmp2 = DateTime.Now;         
            String q = "SELECT * FROM gym.subscriptions WHERE LOCATE('"+ tmp2.ToString("d/M/yyyy") + "',end_date)";
            da2 = new MySqlDataAdapter(q, MainForm.connection);
            da2.Fill(ds, "End_Subscriptions");                  
            DataTable data = new DataTable();
            data = ds.Tables["End_Subscriptions"];                            
            for (int j = 0; j < data.Rows.Count; j++)
            {           
                for (int i = 0; i < dataGridView1.Rows.Count; i++)                    
                    try
                    {
                        if (int.Parse(dataGridView1.Rows[i].Cells["id"].Value.ToString()) == int.Parse(data.Rows[j]["customer_id"].ToString()))
                        {                        
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                    }catch(Exception ex)
                    {
                     //   MetroMessageBox.Show(this, "Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            }

        public static int CustomerId()
        {
            return customerID;
        }

        private void MembersFee_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.connection.Close();
        }     

        private void check_Click(object sender, EventArgs e)
        {
            checkdate();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                builder = new MySqlCommandBuilder(da1);
                da1.Update(ds, "Customers");
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Cant Delete a customer when he has subs", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string nameSearch = tbSearch.Text;
            string query = "SELECT * FROM customers WHERE CONCAT(`name`,`surname`) LIKE '" + nameSearch + "%'";
            try
            {
                da1 = new MySqlDataAdapter(query, MainForm.connection);
                ds.Clear();
                da1.Fill(ds, "Customers");
                dataGridView1.DataSource = ds.Tables["Customers"];
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

