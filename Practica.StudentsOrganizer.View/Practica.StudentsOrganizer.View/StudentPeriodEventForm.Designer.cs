namespace Practica.StudentsOrganizer.View
{
    partial class StudentPeriodEventForm
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
            this.addIdStudent = new DevExpress.XtraEditors.TextEdit();
            this.editIdStudent = new DevExpress.XtraEditors.TextEdit();
            this.addIdStudentOc = new DevExpress.XtraEditors.TextEdit();
            this.editIdStudentOc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnAddSPE = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditSPE = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteSPE = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.addIdStudent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editIdStudent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addIdStudentOc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editIdStudentOc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // addIdStudent
            // 
            this.addIdStudent.Location = new System.Drawing.Point(147, 189);
            this.addIdStudent.Name = "addIdStudent";
            this.addIdStudent.Size = new System.Drawing.Size(100, 20);
            this.addIdStudent.TabIndex = 0;
            // 
            // editIdStudent
            // 
            this.editIdStudent.Location = new System.Drawing.Point(253, 189);
            this.editIdStudent.Name = "editIdStudent";
            this.editIdStudent.Size = new System.Drawing.Size(100, 20);
            this.editIdStudent.TabIndex = 1;
            // 
            // addIdStudentOc
            // 
            this.addIdStudentOc.Location = new System.Drawing.Point(147, 148);
            this.addIdStudentOc.Name = "addIdStudentOc";
            this.addIdStudentOc.Size = new System.Drawing.Size(100, 20);
            this.addIdStudentOc.TabIndex = 2;
            // 
            // editIdStudentOc
            // 
            this.editIdStudentOc.Location = new System.Drawing.Point(253, 148);
            this.editIdStudentOc.Name = "editIdStudentOc";
            this.editIdStudentOc.Size = new System.Drawing.Size(100, 20);
            this.editIdStudentOc.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(42, 155);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "IdStudentOccurence";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(42, 196);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "IdStudent";
            // 
            // btnAddSPE
            // 
            this.btnAddSPE.Location = new System.Drawing.Point(147, 28);
            this.btnAddSPE.Name = "btnAddSPE";
            this.btnAddSPE.Size = new System.Drawing.Size(100, 23);
            this.btnAddSPE.TabIndex = 6;
            this.btnAddSPE.Text = "Add";
            this.btnAddSPE.Click += new System.EventHandler(this.btnAddSPE_Click);
            // 
            // btnEditSPE
            // 
            this.btnEditSPE.Location = new System.Drawing.Point(253, 28);
            this.btnEditSPE.Name = "btnEditSPE";
            this.btnEditSPE.Size = new System.Drawing.Size(100, 23);
            this.btnEditSPE.TabIndex = 7;
            this.btnEditSPE.Text = "Edit";
            this.btnEditSPE.Click += new System.EventHandler(this.btnEditSPE_Click);
            // 
            // btnDeleteSPE
            // 
            this.btnDeleteSPE.Location = new System.Drawing.Point(407, 293);
            this.btnDeleteSPE.Name = "btnDeleteSPE";
            this.btnDeleteSPE.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSPE.TabIndex = 8;
            this.btnDeleteSPE.Text = "Delete";
            this.btnDeleteSPE.Click += new System.EventHandler(this.btnDeleteSPE_Click);
            // 
            // StudentPeriodEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 328);
            this.Controls.Add(this.btnDeleteSPE);
            this.Controls.Add(this.btnEditSPE);
            this.Controls.Add(this.btnAddSPE);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.editIdStudentOc);
            this.Controls.Add(this.addIdStudentOc);
            this.Controls.Add(this.editIdStudent);
            this.Controls.Add(this.addIdStudent);
            this.Name = "StudentPeriodEventForm";
            this.Text = "StudentPeriodEventForm";
            this.Load += new System.EventHandler(this.StudentPeriodEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addIdStudent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editIdStudent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addIdStudentOc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editIdStudentOc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit addIdStudent;
        private DevExpress.XtraEditors.TextEdit editIdStudent;
        private DevExpress.XtraEditors.TextEdit addIdStudentOc;
        private DevExpress.XtraEditors.TextEdit editIdStudentOc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnAddSPE;
        private DevExpress.XtraEditors.SimpleButton btnEditSPE;
        private DevExpress.XtraEditors.SimpleButton btnDeleteSPE;
    }
}