namespace Practica.StudentsOrganizer.View
{
    partial class StudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.BirthDate = new DevExpress.XtraEditors.DateEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtFaculty = new DevExpress.XtraEditors.TextEdit();
            this.Gender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtFacultyStartYear = new DevExpress.XtraEditors.TextEdit();
            this.txtRemarks = new DevExpress.XtraEditors.TextEdit();
            this.btnAddStudent = new DevExpress.XtraEditors.SimpleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControlEvent = new DevExpress.XtraGrid.GridControl();
            this.gridViewEvent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAddEvent = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteEvent = new DevExpress.XtraEditors.SimpleButton();
            this.btnDone = new DevExpress.XtraEditors.SimpleButton();
            this.btnShow = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaculty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacultyStartYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "*First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "*Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "*Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "*Birth date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "*Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "*Phone number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "*Faculty:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "*Faculty start year:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Remarks:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "All * fields are mandatory!";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(141, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 23;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(141, 75);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 24;
            // 
            // BirthDate
            // 
            this.BirthDate.EditValue = null;
            this.BirthDate.Location = new System.Drawing.Point(141, 150);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BirthDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BirthDate.Properties.MaxValue = new System.DateTime(((long)(0)));
            this.BirthDate.Size = new System.Drawing.Size(100, 20);
            this.BirthDate.TabIndex = 25;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(141, 186);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 27;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(141, 221);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 28;
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(141, 259);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(100, 20);
            this.txtFaculty.TabIndex = 29;
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(141, 112);
            this.Gender.Name = "Gender";
            this.Gender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Gender.Properties.DropDownRows = 2;
            this.Gender.Properties.Items.AddRange(new object[] {
            "F",
            "M"});
            this.Gender.Size = new System.Drawing.Size(100, 20);
            this.Gender.TabIndex = 30;
            // 
            // txtFacultyStartYear
            // 
            this.txtFacultyStartYear.Location = new System.Drawing.Point(141, 296);
            this.txtFacultyStartYear.Name = "txtFacultyStartYear";
            this.txtFacultyStartYear.Properties.Mask.EditMask = "\\d\\d\\d\\d";
            this.txtFacultyStartYear.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtFacultyStartYear.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtFacultyStartYear.Size = new System.Drawing.Size(100, 20);
            this.txtFacultyStartYear.TabIndex = 31;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(141, 333);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(100, 20);
            this.txtRemarks.TabIndex = 32;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(166, 383);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 33;
            this.btnAddStudent.Text = "Save";
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "*Event:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(261, 450);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "*Occurence:";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(141, 447);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 33, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Departament/Technology", "Departament/Technology", 132, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit1.Properties.DisplayMember = "Name";
            this.lookUpEdit1.Properties.ValueMember = "Id";
            this.lookUpEdit1.Size = new System.Drawing.Size(100, 20);
            this.lookUpEdit1.TabIndex = 38;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(356, 447);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Size = new System.Drawing.Size(100, 20);
            this.lookUpEdit2.TabIndex = 39;
            // 
            // gridControlEvent
            // 
            this.gridControlEvent.Location = new System.Drawing.Point(17, 498);
            this.gridControlEvent.MainView = this.gridViewEvent;
            this.gridControlEvent.Name = "gridControlEvent";
            this.gridControlEvent.Size = new System.Drawing.Size(400, 200);
            this.gridControlEvent.TabIndex = 40;
            this.gridControlEvent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEvent});
            // 
            // gridViewEvent
            // 
            this.gridViewEvent.GridControl = this.gridControlEvent;
            this.gridViewEvent.Name = "gridViewEvent";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(543, 444);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(75, 23);
            this.btnAddEvent.TabIndex = 41;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Location = new System.Drawing.Point(543, 546);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEvent.TabIndex = 42;
            this.btnDeleteEvent.Text = "Delete Event";
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(166, 723);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 43;
            this.btnDone.Text = "Done";
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(543, 621);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 44;
            this.btnShow.Text = "Show Events";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 758);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.gridControlEvent);
            this.Controls.Add(this.lookUpEdit2);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtFacultyStartYear);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaculty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFacultyStartYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.DateEdit BirthDate;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.TextEdit txtFaculty;
        private DevExpress.XtraEditors.ComboBoxEdit Gender;
        private DevExpress.XtraEditors.TextEdit txtFacultyStartYear;
        private DevExpress.XtraEditors.TextEdit txtRemarks;
        private DevExpress.XtraEditors.SimpleButton btnAddStudent;
        public DevExpress.XtraEditors.TextEdit txtFirstName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraGrid.GridControl gridControlEvent;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEvent;
        private DevExpress.XtraEditors.SimpleButton btnAddEvent;
        private DevExpress.XtraEditors.SimpleButton btnDeleteEvent;
        private DevExpress.XtraEditors.SimpleButton btnDone;
        private DevExpress.XtraEditors.SimpleButton btnShow;
    }
}