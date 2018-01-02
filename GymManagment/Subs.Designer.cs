namespace GymManagment
{
    partial class Subs
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.costTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.startDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.endDate = new MetroFramework.Controls.MetroDateTime();
            this.monthTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(863, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(859, 546);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(146, 38);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "New Sub";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // costTB
            // 
            // 
            // 
            // 
            this.costTB.CustomButton.Image = null;
            this.costTB.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.costTB.CustomButton.Name = "";
            this.costTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.costTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.costTB.CustomButton.TabIndex = 1;
            this.costTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.costTB.CustomButton.UseSelectable = true;
            this.costTB.CustomButton.Visible = false;
            this.costTB.Lines = new string[0];
            this.costTB.Location = new System.Drawing.Point(123, 376);
            this.costTB.MaxLength = 32767;
            this.costTB.Name = "costTB";
            this.costTB.PasswordChar = '\0';
            this.costTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.costTB.SelectedText = "";
            this.costTB.SelectionLength = 0;
            this.costTB.SelectionStart = 0;
            this.costTB.ShortcutsEnabled = true;
            this.costTB.Size = new System.Drawing.Size(198, 23);
            this.costTB.TabIndex = 2;
            this.costTB.UseSelectable = true;
            this.costTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.costTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 379);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Cost";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 414);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Start Date";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(123, 414);
            this.startDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 30);
            this.startDate.TabIndex = 6;
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 492);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 20);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "End Date";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(121, 482);
            this.endDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 30);
            this.endDate.TabIndex = 8;
            // 
            // monthTB
            // 
            // 
            // 
            // 
            this.monthTB.CustomButton.Image = null;
            this.monthTB.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.monthTB.CustomButton.Name = "";
            this.monthTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.monthTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.monthTB.CustomButton.TabIndex = 1;
            this.monthTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.monthTB.CustomButton.UseSelectable = true;
            this.monthTB.CustomButton.Visible = false;
            this.monthTB.Lines = new string[0];
            this.monthTB.Location = new System.Drawing.Point(123, 453);
            this.monthTB.MaxLength = 32767;
            this.monthTB.Name = "monthTB";
            this.monthTB.PasswordChar = '\0';
            this.monthTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.monthTB.SelectedText = "";
            this.monthTB.SelectionLength = 0;
            this.monthTB.SelectionStart = 0;
            this.monthTB.ShortcutsEnabled = true;
            this.monthTB.Size = new System.Drawing.Size(198, 23);
            this.monthTB.TabIndex = 9;
            this.monthTB.UseSelectable = true;
            this.monthTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.monthTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.monthTB.Validated += new System.EventHandler(this.monthTB_Validated);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 456);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 20);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Months";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Subs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 607);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.monthTB);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.costTB);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Subs";
            this.Text = "Subs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Subs_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Subs_FormClosed);
            this.Load += new System.EventHandler(this.Subs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox costTB;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime startDate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime endDate;
        private MetroFramework.Controls.MetroTextBox monthTB;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}