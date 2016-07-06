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
            this.buttInsertStd = new DevExpress.XtraEditors.SimpleButton();
            this.buttonUpdateStd = new DevExpress.XtraEditors.SimpleButton();
            this.buttDeleteStd = new DevExpress.XtraEditors.SimpleButton();
            this.grdCtrlStudents = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttInsertStd
            // 
            this.buttInsertStd.Location = new System.Drawing.Point(12, 12);
            this.buttInsertStd.Name = "buttInsertStd";
            this.buttInsertStd.Size = new System.Drawing.Size(89, 47);
            this.buttInsertStd.TabIndex = 0;
            this.buttInsertStd.Text = "Insert Student";
            this.buttInsertStd.Click += new System.EventHandler(this.buttInsertStd_Click);
            // 
            // buttonUpdateStd
            // 
            this.buttonUpdateStd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonUpdateStd.Location = new System.Drawing.Point(351, 12);
            this.buttonUpdateStd.Name = "buttonUpdateStd";
            this.buttonUpdateStd.Size = new System.Drawing.Size(89, 47);
            this.buttonUpdateStd.TabIndex = 1;
            this.buttonUpdateStd.Text = "Update Student";
            this.buttonUpdateStd.Click += new System.EventHandler(this.buttonUpdateStd_Click);
            // 
            // buttDeleteStd
            // 
            this.buttDeleteStd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttDeleteStd.Location = new System.Drawing.Point(667, 12);
            this.buttDeleteStd.Name = "buttDeleteStd";
            this.buttDeleteStd.Size = new System.Drawing.Size(89, 47);
            this.buttDeleteStd.TabIndex = 2;
            this.buttDeleteStd.Text = "Delete Student";
            // 
            // grdCtrlStudents
            // 
            this.grdCtrlStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCtrlStudents.Location = new System.Drawing.Point(23, 79);
            this.grdCtrlStudents.MainView = this.gridView1;
            this.grdCtrlStudents.Name = "grdCtrlStudents";
            this.grdCtrlStudents.Size = new System.Drawing.Size(721, 304);
            this.grdCtrlStudents.TabIndex = 3;
            this.grdCtrlStudents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdCtrlStudents.Click += new System.EventHandler(this.grdCtrlStudents_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdCtrlStudents;
            this.gridView1.Name = "gridView1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 407);
            this.Controls.Add(this.grdCtrlStudents);
            this.Controls.Add(this.buttDeleteStd);
            this.Controls.Add(this.buttonUpdateStd);
            this.Controls.Add(this.buttInsertStd);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton buttInsertStd;
        private DevExpress.XtraEditors.SimpleButton buttonUpdateStd;
        private DevExpress.XtraEditors.SimpleButton buttDeleteStd;
        private DevExpress.XtraGrid.GridControl grdCtrlStudents;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}