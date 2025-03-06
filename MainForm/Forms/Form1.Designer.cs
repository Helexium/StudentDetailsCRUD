namespace MainForm
{
    partial class Form1
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
            this.CreateStudentButton = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EditButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DeleteButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.FirstNameTe = new DevExpress.XtraEditors.TextEdit();
            this.MiddleNameTe = new DevExpress.XtraEditors.TextEdit();
            this.LastNameTe = new DevExpress.XtraEditors.TextEdit();
            this.NameExtensionTe = new DevExpress.XtraEditors.TextEdit();
            this.DateOfBirthDe = new DevExpress.XtraEditors.DateEdit();
            this.YearLevelCbe = new DevExpress.XtraEditors.ComboBoxEdit();
            this.GenderCbe = new DevExpress.XtraEditors.ComboBoxEdit();
            this.StudentIDTe = new DevExpress.XtraEditors.TextEdit();
            this.GenerateStudentIDButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleNameTe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameExtensionTe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfBirthDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfBirthDe.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearLevelCbe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderCbe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentIDTe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateStudentButton
            // 
            this.CreateStudentButton.Location = new System.Drawing.Point(9, 166);
            this.CreateStudentButton.Name = "CreateStudentButton";
            this.CreateStudentButton.Size = new System.Drawing.Size(94, 35);
            this.CreateStudentButton.TabIndex = 0;
            this.CreateStudentButton.Text = "Create Student \r\nDetails";
            this.CreateStudentButton.Click += new System.EventHandler(this.CreateStudentButton_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 219);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.EditButton,
            this.DeleteButton});
            this.gridControl1.Size = new System.Drawing.Size(900, 246);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Student ID";
            this.gridColumn1.FieldName = "StudentID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 90;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "First Name";
            this.gridColumn2.FieldName = "FirstName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 137;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Middle Name";
            this.gridColumn3.FieldName = "MiddleName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 134;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Last Name";
            this.gridColumn4.FieldName = "LastName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 161;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Name Extension";
            this.gridColumn5.FieldName = "NameExtension";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 55;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Year Level";
            this.gridColumn6.FieldName = "YearLevel";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 83;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Gender";
            this.gridColumn7.FieldName = "Gender";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 103;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Date of Birth";
            this.gridColumn8.FieldName = "DateOfBirth";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 105;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Edit";
            this.gridColumn9.ColumnEdit = this.EditButton;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // EditButton
            // 
            this.EditButton.AutoHeight = false;
            this.EditButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EditButton.Name = "EditButton";
            this.EditButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.EditButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.EditButton_ButtonClick);
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Delete";
            this.gridColumn10.ColumnEdit = this.DeleteButton;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoHeight = false;
            this.DeleteButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // FirstNameTe
            // 
            this.FirstNameTe.Location = new System.Drawing.Point(7, 78);
            this.FirstNameTe.Name = "FirstNameTe";
            this.FirstNameTe.Size = new System.Drawing.Size(200, 28);
            this.FirstNameTe.TabIndex = 7;
            // 
            // MiddleNameTe
            // 
            this.MiddleNameTe.Location = new System.Drawing.Point(214, 78);
            this.MiddleNameTe.Name = "MiddleNameTe";
            this.MiddleNameTe.Size = new System.Drawing.Size(200, 28);
            this.MiddleNameTe.TabIndex = 8;
            // 
            // LastNameTe
            // 
            this.LastNameTe.Location = new System.Drawing.Point(420, 78);
            this.LastNameTe.Name = "LastNameTe";
            this.LastNameTe.Size = new System.Drawing.Size(200, 28);
            this.LastNameTe.TabIndex = 9;
            // 
            // NameExtensionTe
            // 
            this.NameExtensionTe.Location = new System.Drawing.Point(626, 78);
            this.NameExtensionTe.Name = "NameExtensionTe";
            this.NameExtensionTe.Size = new System.Drawing.Size(100, 28);
            this.NameExtensionTe.TabIndex = 10;
            // 
            // DateOfBirthDe
            // 
            this.DateOfBirthDe.EditValue = null;
            this.DateOfBirthDe.Location = new System.Drawing.Point(221, 132);
            this.DateOfBirthDe.Name = "DateOfBirthDe";
            this.DateOfBirthDe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateOfBirthDe.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateOfBirthDe.Size = new System.Drawing.Size(100, 28);
            this.DateOfBirthDe.TabIndex = 12;
            // 
            // YearLevelCbe
            // 
            this.YearLevelCbe.Location = new System.Drawing.Point(7, 132);
            this.YearLevelCbe.Name = "YearLevelCbe";
            this.YearLevelCbe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.YearLevelCbe.Properties.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.YearLevelCbe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.YearLevelCbe.Size = new System.Drawing.Size(100, 28);
            this.YearLevelCbe.TabIndex = 13;
            // 
            // GenderCbe
            // 
            this.GenderCbe.Location = new System.Drawing.Point(115, 132);
            this.GenderCbe.Name = "GenderCbe";
            this.GenderCbe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GenderCbe.Properties.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCbe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.GenderCbe.Size = new System.Drawing.Size(100, 28);
            this.GenderCbe.TabIndex = 14;
            // 
            // StudentIDTe
            // 
            this.StudentIDTe.Location = new System.Drawing.Point(7, 25);
            this.StudentIDTe.Name = "StudentIDTe";
            this.StudentIDTe.Size = new System.Drawing.Size(127, 28);
            this.StudentIDTe.TabIndex = 15;
            // 
            // GenerateStudentIDButton
            // 
            this.GenerateStudentIDButton.Location = new System.Drawing.Point(140, 27);
            this.GenerateStudentIDButton.Name = "GenerateStudentIDButton";
            this.GenerateStudentIDButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateStudentIDButton.TabIndex = 16;
            this.GenerateStudentIDButton.Text = "Generate";
            this.GenerateStudentIDButton.Click += new System.EventHandler(this.GenerateStudentIDButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Student ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "FirstName";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(214, 59);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Middle Name";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(420, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 13);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Last Name";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(626, 59);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 13);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Name Extension";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(7, 113);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(50, 13);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Year Level";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(115, 113);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 13);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "Year Level";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(221, 112);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(63, 13);
            this.labelControl8.TabIndex = 25;
            this.labelControl8.Text = "Date Of Birth";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 465);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.GenerateStudentIDButton);
            this.Controls.Add(this.StudentIDTe);
            this.Controls.Add(this.GenderCbe);
            this.Controls.Add(this.YearLevelCbe);
            this.Controls.Add(this.DateOfBirthDe);
            this.Controls.Add(this.NameExtensionTe);
            this.Controls.Add(this.LastNameTe);
            this.Controls.Add(this.MiddleNameTe);
            this.Controls.Add(this.FirstNameTe);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.CreateStudentButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleNameTe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameExtensionTe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfBirthDe.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfBirthDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearLevelCbe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderCbe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentIDTe.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton CreateStudentButton;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit FirstNameTe;
        private DevExpress.XtraEditors.TextEdit MiddleNameTe;
        private DevExpress.XtraEditors.TextEdit LastNameTe;
        private DevExpress.XtraEditors.TextEdit NameExtensionTe;
        private DevExpress.XtraEditors.DateEdit DateOfBirthDe;
        private DevExpress.XtraEditors.ComboBoxEdit YearLevelCbe;
        private DevExpress.XtraEditors.ComboBoxEdit GenderCbe;
        private DevExpress.XtraEditors.TextEdit StudentIDTe;
        private DevExpress.XtraEditors.SimpleButton GenerateStudentIDButton;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit EditButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit DeleteButton;
    }
}

