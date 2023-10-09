using StudentPersonalInfo.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPersonalInfo
{
    public partial class StudentDetailsViewForm : Form
    {
        public StudentDetailsViewForm()
        {
            InitializeComponent();

            lblID.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Id.ToString();
            lblName.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Name;
            lblPhone.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Phone.ToString();
            lblEmail.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Email;
            lblFName.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].FatherName;
            lblMName.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].MotherName;
            lblAddress.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Address;
            pbProfile.ImageLocation = GlobalStaticClass.StudentList[GlobalStaticClass.counter].ImageLocation;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (GlobalStaticClass.counter == GlobalStaticClass.StudentList.Count)
            {
                btnNext.Enabled = false;
            }
            else
            {
                GlobalStaticClass.counter++;
                updateForm();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (GlobalStaticClass.counter == 0)
            {
                btnPrev.Enabled = false;
            }
            else
            {
                GlobalStaticClass.counter--;
                updateForm();

            }
        }

        private void updateForm() {
            lblID.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Id.ToString();
            lblName.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Name;
            lblPhone.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Phone.ToString();
            lblEmail.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Email;
            lblFName.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].FatherName;
            lblMName.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].MotherName;
            lblAddress.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Address;
            pbProfile.ImageLocation = GlobalStaticClass.StudentList[GlobalStaticClass.counter].ImageLocation;
        }
    }
}
