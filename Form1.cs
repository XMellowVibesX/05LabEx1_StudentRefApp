using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // THE MESSAGE BOXES

        // FIRST ONE WITH COMPLETE INFORMATION
        private void msgboxStudentInfo(string firstName, string midName, string lastName, string gender, string bDay, string bMonth, string bYear, string appliedProgram)
        {
            MessageBox.Show(
                "Student name: " + firstName + " " + midName + " " + lastName +
                "\nGender: " + gender +
                "\nDate of birth: " + bDay + "/" + bMonth + "/" + bYear +
                "\nProgram: " + appliedProgram);
        }
        // SECOND ONE, FULL NAME AND PROGRAM
        private void msgboxStudentInfo(string firstName, string midName, string lastName, string appliedProgram)
        {
            MessageBox.Show(
                "Student name: " + firstName + " " + midName + " " + lastName +
                "\nProgram: " + appliedProgram);
        }
        // THIRD ONE, INCOMPLETE NAME AND PROGRAM
        private void msgboxStudentInfo(string firstName, string lastName, string appliedProgram)
        {
            MessageBox.Show(
                "Student name: " + firstName + " " + lastName +
                "\nProgram: " + appliedProgram);
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (rBtnMale.Checked) {
                gender = "Male"; }
            if (rBtnFemale.Checked) {
                gender = "Female"; }

            msgboxStudentInfo(tbFirstName.Text, tbMidName.Text, tbLastName.Text, gender, dropDay.Text, dropMonth.Text, dropYear.Text, dropCourse.Text);
            msgboxStudentInfo(tbFirstName.Text, tbMidName.Text, tbLastName.Text, dropCourse.Text);
            msgboxStudentInfo(tbFirstName.Text, tbLastName.Text, dropCourse.Text);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picBox.Image = new Bitmap(open.FileName);
            }
        }
    }
}
