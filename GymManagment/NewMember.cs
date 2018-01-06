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
using System.IO;

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
      //string query = "INSERT INTO customers(name,surname,contact,gender,workout,height,weight,health_problems,notes,photo) VALUES ('" + tbName.Text + "','" + tbSurname.Text + "','" + tbContact.Text + "','" + cbGender.Text + "','" + cbWorkout.Text + "','" + heiDouble + "','" + weiDouble + "','" + tbHealth.Text + "','" + tbNotes.Text + "','" + ImageToByte(pictureBox1.Image) + "')";
      string query = "INSERT INTO customers(name,surname,contact,gender,workout,height,weight,health_problems,notes,photo) VALUES (@name,@surname,@contact,@gender,@workout,@height,@weight,@health_problems,@notes,@photo)";
      MainForm.connection.Open();
      MySqlCommand command = new MySqlCommand(query, MainForm.connection);
      command.Parameters.AddWithValue("@name", tbName.Text);
      command.Parameters.AddWithValue("@surname", tbSurname.Text);
      command.Parameters.AddWithValue("@contact", tbContact.Text);
      command.Parameters.AddWithValue("@gender", cbGender.Text);
      command.Parameters.AddWithValue("@workout", cbWorkout.Text);
      command.Parameters.AddWithValue("@height", heiDouble);
      command.Parameters.AddWithValue("@weight", weiDouble);
      command.Parameters.AddWithValue("@health_problems", tbHealth.Text);
      command.Parameters.AddWithValue("@notes", tbNotes.Text);
      command.Parameters.AddWithValue("@photo", ImageToByte(pictureBox1.Image));
      if (command.ExecuteNonQuery() == 1)
      {
        MetroMessageBox.Show(this, "Success", "Data saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        MetroMessageBox.Show(this, "Error", "Data not saved!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      MainForm.connection.Close();
    }

    private void metroButton1_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog dlg = new OpenFileDialog())
      {
        dlg.Title = "Open Image";
        dlg.Filter = "BMP|*.bmp|JPG|*.jpg;*.jpeg|PNG|*.png|"
          + "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png";

        if (dlg.ShowDialog() == DialogResult.OK)
        {
          // Create a new Bitmap object from the picture file on disk,
          // and assign that to the pictureBox1.Image property
          pictureBox1.Image = new Bitmap(dlg.FileName);
        }
      }
    }

    private byte[] ImageToByte(Image img)
    {
      ImageConverter converter = new ImageConverter();
      return (byte[])converter.ConvertTo(img, typeof(byte[]));
    }
  }
}
