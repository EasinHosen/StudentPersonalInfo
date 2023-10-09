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
        private int max = GlobalStaticClass.StudentList.Count;
        public StudentDetailsViewForm()
        {
            InitializeComponent();

            GlobalStaticClass.counter = 0;


            lblID.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Id.ToString();
            lblName.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Name;
            lblPhone.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Phone.ToString();
            lblEmail.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Email;
            lblFName.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].FatherName;
            lblMName.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].MotherName;
            lblAddress.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Address;
            pbProfile.ImageLocation = GlobalStaticClass.StudentList[GlobalStaticClass.counter].ImageLocation;
            lblCount.Text = (GlobalStaticClass.counter+1).ToString()+" Out of "+ max.ToString()+" Students";
            btnPrev.Enabled = false;
            if (max == 1) { 
                btnNext.Enabled = false;
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (GlobalStaticClass.counter == max - 1)
            {
                btnNext.Enabled = false;
            }
            else
            {
                GlobalStaticClass.counter++;
                updateForm();
                btnNext.Enabled = true;
                btnPrev.Enabled = true;

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
                btnPrev.Enabled = true;
                btnNext.Enabled = true;

            }
        }

        private void updateForm()
        {
            lblID.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Id.ToString();
            lblName.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Name;
            lblPhone.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Phone.ToString();
            lblEmail.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Email;
            lblFName.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].FatherName;
            lblMName.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].MotherName;
            lblAddress.Text = GlobalStaticClass.StudentList[GlobalStaticClass.counter].Address;
            pbProfile.ImageLocation = GlobalStaticClass.StudentList[GlobalStaticClass.counter].ImageLocation;
            lblCount.Text = (GlobalStaticClass.counter + 1).ToString() + " Out of " + max.ToString() + " Students";

            if (GlobalStaticClass.counter + 1 == max) {
                btnNext.Enabled = false;    
            }
            if (GlobalStaticClass.counter == 0) { 
                btnPrev.Enabled = false;
            }
        }
    }
}
