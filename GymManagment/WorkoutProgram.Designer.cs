namespace GymManagment
{
    partial class WorkoutProgram
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
            this.btPrint = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(23, 248);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(283, 58);
            this.btPrint.TabIndex = 1;
            this.btPrint.Text = "Print";
            this.btPrint.UseSelectable = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // WorkoutProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 329);
            this.Controls.Add(this.btPrint);
            this.Name = "WorkoutProgram";
            this.Text = "Print Workout Program";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btPrint;
    }
}