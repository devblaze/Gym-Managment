﻿namespace GymManagment
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.metroTile2 = new MetroFramework.Controls.MetroTile();
      this.metroTile3 = new MetroFramework.Controls.MetroTile();
      this.metroTile4 = new MetroFramework.Controls.MetroTile();
      this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
      this.metroTile1 = new MetroFramework.Controls.MetroTile();
      this.metroPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // metroTile2
      // 
      this.metroTile2.ActiveControl = null;
      this.metroTile2.Cursor = System.Windows.Forms.Cursors.Hand;
      this.metroTile2.Location = new System.Drawing.Point(248, 4);
      this.metroTile2.Margin = new System.Windows.Forms.Padding(4);
      this.metroTile2.Name = "metroTile2";
      this.metroTile2.Size = new System.Drawing.Size(236, 123);
      this.metroTile2.TabIndex = 1;
      this.metroTile2.Text = "Subscriptions/Customers";
      this.metroTile2.UseSelectable = true;
      this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
      // 
      // metroTile3
      // 
      this.metroTile3.ActiveControl = null;
      this.metroTile3.Cursor = System.Windows.Forms.Cursors.Hand;
      this.metroTile3.Location = new System.Drawing.Point(736, 4);
      this.metroTile3.Margin = new System.Windows.Forms.Padding(4);
      this.metroTile3.Name = "metroTile3";
      this.metroTile3.Size = new System.Drawing.Size(236, 123);
      this.metroTile3.TabIndex = 2;
      this.metroTile3.Text = "Trainers";
      this.metroTile3.UseSelectable = true;
      this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click_1);
      // 
      // metroTile4
      // 
      this.metroTile4.ActiveControl = null;
      this.metroTile4.Cursor = System.Windows.Forms.Cursors.Hand;
      this.metroTile4.Location = new System.Drawing.Point(492, 4);
      this.metroTile4.Margin = new System.Windows.Forms.Padding(4);
      this.metroTile4.Name = "metroTile4";
      this.metroTile4.Size = new System.Drawing.Size(236, 123);
      this.metroTile4.TabIndex = 3;
      this.metroTile4.Text = "Equipment";
      this.metroTile4.UseSelectable = true;
      this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
      // 
      // metroPanel1
      // 
      this.metroPanel1.BackColor = System.Drawing.Color.DimGray;
      this.metroPanel1.Controls.Add(this.metroTile1);
      this.metroPanel1.Controls.Add(this.metroTile4);
      this.metroPanel1.Controls.Add(this.metroTile2);
      this.metroPanel1.Controls.Add(this.metroTile3);
      this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.metroPanel1.ForeColor = System.Drawing.SystemColors.ControlDark;
      this.metroPanel1.HorizontalScrollbarBarColor = true;
      this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
      this.metroPanel1.HorizontalScrollbarSize = 12;
      this.metroPanel1.Location = new System.Drawing.Point(27, 74);
      this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
      this.metroPanel1.Name = "metroPanel1";
      this.metroPanel1.Size = new System.Drawing.Size(986, 134);
      this.metroPanel1.TabIndex = 5;
      this.metroPanel1.VerticalScrollbarBarColor = true;
      this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
      this.metroPanel1.VerticalScrollbarSize = 13;
      // 
      // metroTile1
      // 
      this.metroTile1.ActiveControl = null;
      this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.metroTile1.Location = new System.Drawing.Point(4, 4);
      this.metroTile1.Margin = new System.Windows.Forms.Padding(4);
      this.metroTile1.Name = "metroTile1";
      this.metroTile1.PaintTileCount = false;
      this.metroTile1.Size = new System.Drawing.Size(236, 123);
      this.metroTile1.TabIndex = 0;
      this.metroTile1.Text = "New Customer";
      this.metroTile1.TileImage = global::GymManagment.Properties.Resources.add_user;
      this.metroTile1.UseSelectable = true;
      this.metroTile1.UseTileImage = true;
      this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1040, 789);
      this.Controls.Add(this.metroPanel1);
      this.IsMdiContainer = true;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
      this.Text = "Gym Managment System";
      this.TransparencyKey = System.Drawing.Color.Empty;
      this.metroPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}