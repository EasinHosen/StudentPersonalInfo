using StudentPersonalInfo.Global;
using StudentPersonalInfo.Models;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace StudentPersonalInfo
{
    public partial class Form1 : Form
    {
        private string imageLocation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "jpg files(*.jpg)|*.jpg| png files(*.png)|*.png| all files(*.*)|*.*";

                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = fileDialog.FileName;

                    pbSelectedImage.ImageLocation = imageLocation;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddMore_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student();

                student.Id = Int32.Parse(txtID.Text);
                student.Name = txtName.Text;
                student.Phone = txtPhone.Text;
                student.Email = txtEamil.Text;
                student.FatherName = txtFName.Text;
                student.MotherName = txtMName.Text;
                student.ImageLocation = imageLocation;
                student.Address = txtAddress.Text;

                GlobalStaticClass.StudentList.Add(student);

                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        textBox.Text = string.Empty;
                    }
                }
                imageLocation = "";
                pbSelectedImage.ImageLocation = "C:\\Users\\easin\\OneDrive\\Documents\\C#\\StudentPersonalInfo\\StudentPersonalInfo\\Resources\\person-placeholder.jpg";
                Debug.Print(GlobalStaticClass.StudentList.Count.ToString());
                int i = 0;

                foreach (Student s in GlobalStaticClass.StudentList)
                {
                    Debug.Print(GlobalStaticClass.StudentList[i].ToString());
                    i++;
                }
            }
            catch (Exception ex) { }

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not a digit or a control key, mark the event as handled
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not a digit or a control key, mark the event as handled
                e.Handled = true;
            }
        }

        private void txtEamil_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string emailPattern = @"^[\w\.-]+@[\w\.-]+\.\w+$"; // Regular expression pattern for a basic email validation

            if (!Regex.IsMatch(txtEamil.Text, emailPattern))
            {
                MessageBox.Show("Invalid email address. Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; // Cancel the event to keep focus on the TextBox
            }
        }
    }
}