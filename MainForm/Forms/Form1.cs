using MainForm.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace MainForm
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {

        //set the list for students
        List<Student> ListOfStudents = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            // Create a new Student
            Student student = new Student();
            student.StudentID = StudentIDTe.Text.Trim();
            student.FirstName = FirstNameTe.Text.Trim();
            student.MiddleName = MiddleNameTe.Text.Trim();
            student.LastName = LastNameTe.Text.Trim();
            student.NameExtension = NameExtensionTe.Text.Trim();
            student.YearLevel = YearLevelCbe.Text.Trim();
            student.Gender = GenderCbe.Text.Trim();
            student.DateOfBirth = Convert.ToDateTime(DateOfBirthDe.EditValue);

            //Add all inputted details to the list
            ListOfStudents.Add(student);
            
            //Refreshes the table and updates the table
            gridControl1.DataSource = null;
            gridControl1.DataSource = ListOfStudents;
        }

        private static string GenerateID()
        {

            Random rand = new Random();
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string id = string.Empty;

            for (int i = 0; i < 8; i++)
            {
                id += letters[rand.Next(letters.Length)];
            }
            return id;
        }
        private void GenerateStudentIDButton_Click(object sender, EventArgs e)
        {
            StudentIDTe.Text = "";
            StudentIDTe.Text = GenerateID();
        }

        private void EditButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
        }
    }
}
