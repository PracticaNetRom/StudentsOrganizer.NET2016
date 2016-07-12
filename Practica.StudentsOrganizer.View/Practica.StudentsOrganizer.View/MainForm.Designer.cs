namespace Practica.StudentsOrganizer.View
{
    partial class MainForm
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
            this.btnNewStudent = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditStudent = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteStudent = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlStudent = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnEvents = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewStudent.Location = new System.Drawing.Point(214, 52);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(171, 48);
            this.btnNewStudent.TabIndex = 0;
            this.btnNewStudent.Text = "NewStudent";
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditStudent.Location = new System.Drawing.Point(391, 52);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(171, 48);
            this.btnEditStudent.TabIndex = 1;
            this.btnEditStudent.Text = "EditStudent";
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteStudent.Location = new System.Drawing.Point(568, 52);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(171, 48);
            this.btnDeleteStudent.TabIndex = 2;
            this.btnDeleteStudent.Text = "DeleteStudent";
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // gridControlStudent
            // 
            this.gridControlStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlStudent.Location = new System.Drawing.Point(37, 106);
            this.gridControlStudent.MainView = this.gridView1;
            this.gridControlStudent.Name = "gridControlStudent";
            this.gridControlStudent.Size = new System.Drawing.Size(910, 294);
            this.gridControlStudent.TabIndex = 3;
            this.gridControlStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlStudent;
            this.gridView1.Name = "gridView1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(37, 52);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(171, 48);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(745, 52);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(171, 48);
            this.btnEvents.TabIndex = 5;
            this.btnEvents.Text = "Events";
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 437);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gridControlStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.btnNewStudent);
            this.Name = "MainForm";
            this.Text = "AllStudents";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNewStudent;
        private DevExpress.XtraEditors.SimpleButton btnEditStudent;
        private DevExpress.XtraEditors.SimpleButton btnDeleteStudent;
        private DevExpress.XtraGrid.GridControl gridControlStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnEvents;
    }
}