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
using static DevExpress.Data.Helpers.SyncHelper.ZombieContextsDetector;
using System.Xml.Linq;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraEditors;

namespace MainForm
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        //Sir Soi Gwapo

        //set the list for students
        List<Student> ListOfStudents = new List<Student>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateStudentButton_Click(object sender, EventArgs e)
        {

            string StudentID = StudentIDTe.Text.Trim();
            string FirstName = FirstNameTe.Text.Trim();
            string MiddleName = MiddleNameTe.Text.Trim();
            string LastName = LastNameTe.Text.Trim();
            string NameExtension = NameExtensionTe.Text.Trim();
            string YearLevel = YearLevelCbe.Text.Trim();
            string Gender = GenderCbe.Text.Trim();
            DateTime DateOfBirth = Convert.ToDateTime(DateOfBirthDe.EditValue);

            //ensures all necessary fields are filled in
            if (string.IsNullOrEmpty(FirstName)
                || string.IsNullOrEmpty(MiddleName)
                || string.IsNullOrEmpty(LastName)
                || string.IsNullOrEmpty(YearLevel)
                || DateOfBirth == null)
            {
                MessageBox.Show("Please fill in all necessary data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Create a new Student
            Student student = new Student();
            student.StudentID = StudentID;
            student.FirstName = FirstName;
            student.MiddleName = MiddleName;
            student.LastName = LastName;
            student.NameExtension = NameExtension;
            student.YearLevel = YearLevel;
            student.Gender = Gender;
            student.DateOfBirth = DateOfBirth;

            //loops through the list to find whether studentID already exist
            if (ListOfStudents.Any(s => s.StudentID == StudentID))
            {
                MessageBox.Show("A student with this ID already exists!\nMaybe try updating if that is what you are doing", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Add all inputted details to the list
            ListOfStudents.Add(student);
            
            //Refreshes the table and updates the table
            gridControl1.DataSource = null;
            gridControl1.DataSource = ListOfStudents;

            //resets all textedits and such
            FirstNameTe.Text = "";
            MiddleNameTe.Text = "";
            LastNameTe.Text = "";
            NameExtensionTe.Text = "";
            YearLevelCbe.Text = "";
            GenderCbe.Text = "";
            DateOfBirthDe.Text = "";
        }

        private static string GenerateID()
        {
            //Generates random strings for student ID
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
            //resets the Text Edit in order to replace a new generated ID
            StudentIDTe.Text = "";
            StudentIDTe.Text = GenerateID();
        }

        private void EditButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // finds the student data from the list and retrieves all details into the textedits and all
            var gridView = gridView1;
            var selectedRowHandle = gridView.FocusedRowHandle;

            if (selectedRowHandle >= 0)
            {
                var student = gridView.GetRow(selectedRowHandle) as Student;

                if (student != null)
                {
                    FirstNameTe.Text = student.FirstName;
                    MiddleNameTe.Text = student.MiddleName;
                    LastNameTe.Text = student.LastName;
                    NameExtensionTe.Text = student.NameExtension;
                    YearLevelCbe.Text = student.YearLevel;
                    GenderCbe.Text = student.Gender;
                    DateOfBirthDe.Text = student.DateOfBirth.ToString("yyyy-MM-dd");
                }
            }
        }

        private void DeleteButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //code that finds the student of the selectedrow and deletes that data
            var gridView = gridView1;
            var student = gridView.GetFocusedRow() as Student;
            if (student != null)
            {
                ListOfStudents.Remove(student);
                gridControl1.RefreshDataSource();
            }
        }

        private void UpdateStudentButon_Click(object sender, EventArgs e)
        {
            //delcares the studentID and finds that ID in the list whether it exist
            string StudentID = StudentIDTe.Text.Trim();
            var student = ListOfStudents.FirstOrDefault(s => s.StudentID == StudentID);

            if (string.IsNullOrEmpty(StudentID))
            {
                MessageBox.Show("No Student ID chosen to be updates", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //If ID exists in the list, updates that student data
            if (student != null)
            {
                string FirstName = FirstNameTe.Text.Trim();
                string MiddleName = MiddleNameTe.Text.Trim();
                string LastName = LastNameTe.Text.Trim();
                string NameExtension = NameExtensionTe.Text.Trim();
                string YearLevel = YearLevelCbe.Text.Trim();
                string Gender = GenderCbe.Text.Trim();
                DateTime DateOfBirth = Convert.ToDateTime(DateOfBirthDe.EditValue);


                //same as adding details
                if (string.IsNullOrEmpty(FirstName)
                    || string.IsNullOrEmpty(MiddleName)
                    || string.IsNullOrEmpty(LastName)
                    || string.IsNullOrEmpty(YearLevel))
                {
                    MessageBox.Show("Please fill in all necessary data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                student.FirstName = FirstName;
                student.MiddleName = MiddleName;
                student.LastName = LastName;
                student.NameExtension = NameExtension;
                student.YearLevel = YearLevel;
                student.Gender = Gender;
                student.DateOfBirth = DateOfBirth;

                gridControl1.RefreshDataSource();
            } 
            else
            {
                MessageBox.Show("Student does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
