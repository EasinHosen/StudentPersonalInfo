using StudentPersonalInfo.Global;
using StudentPersonalInfo.Models;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace StudentPersonalInfo
{
    public partial class StudentInfoInputForm : Form
    {
        private string imageLocation = "";
        private string emailPattern = @"^[\w\.-]+@[\w\.-]+\.\w+$";
        public StudentInfoInputForm()
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

                if (!Regex.IsMatch(txtEamil.Text, emailPattern))
                {
                    MessageBox.Show("Invalid email address. Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (imageLocation == "")
                {
                    MessageBox.Show("Please select an Image!", "Invalid Image!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
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
                    pbSelectedImage.ImageLocation = GlobalStaticClass.placeholder;
                    Debug.Print(GlobalStaticClass.StudentList.Count.ToString());
                    int i = 0;

                    foreach (Student s in GlobalStaticClass.StudentList)
                    {
                        Debug.Print(GlobalStaticClass.StudentList[i].ToString());
                        i++;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("One or more field is empty!");
            }

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            if(GlobalStaticClass.StudentList.Count > 0)
            {
                StudentDetailsViewForm viewForm = new StudentDetailsViewForm();
                this.Hide();

                viewForm.FormClosed += (s, args) =>
                {
                    this.Show();
                };

                viewForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No students in the list to display.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        /*private void txtEamil_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string emailPattern = @"^[\w\.-]+@[\w\.-]+\.\w+$"; 

            if (!Regex.IsMatch(txtEamil.Text, emailPattern))
            {
                MessageBox.Show("Invalid email address. Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; 
                isFormValid = false; 
            }
            else
            {
                isFormValid = true; // Set the form validation flag to true when the email is valid
            }
        }*/

        /*private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isFormValid)
            {
                DialogResult result = MessageBox.Show("There are validation errors. Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    isFormValid = true;
                    e.Cancel = false;
                }
            }
        }*/
    }
}