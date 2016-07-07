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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttInsertStd = new DevExpress.XtraEditors.SimpleButton();
            this.buttonUpdateStd = new DevExpress.XtraEditors.SimpleButton();
            this.buttDeleteStd = new DevExpress.XtraEditors.SimpleButton();
            this.grdCtrlStudents = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttInsertStd
            // 
            this.buttInsertStd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttInsertStd.Appearance.Options.UseFont = true;
            this.buttInsertStd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.buttInsertStd.Image = ((System.Drawing.Image)(resources.GetObject("buttInsertStd.Image")));
            this.buttInsertStd.Location = new System.Drawing.Point(31, 73);
            this.buttInsertStd.Name = "buttInsertStd";
            this.buttInsertStd.Size = new System.Drawing.Size(141, 47);
            this.buttInsertStd.TabIndex = 0;
            this.buttInsertStd.Text = "Insert Student";
            this.buttInsertStd.Click += new System.EventHandler(this.buttInsertStd_Click);
            // 
            // buttonUpdateStd
            // 
            this.buttonUpdateStd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonUpdateStd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateStd.Appearance.Options.UseFont = true;
            this.buttonUpdateStd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.buttonUpdateStd.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateStd.Image")));
            this.buttonUpdateStd.Location = new System.Drawing.Point(221, 73);
            this.buttonUpdateStd.Name = "buttonUpdateStd";
            this.buttonUpdateStd.Size = new System.Drawing.Size(136, 47);
            this.buttonUpdateStd.TabIndex = 1;
            this.buttonUpdateStd.Text = "Update Student";
            this.buttonUpdateStd.Click += new System.EventHandler(this.buttonUpdateStd_Click);
            // 
            // buttDeleteStd
            // 
            this.buttDeleteStd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttDeleteStd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttDeleteStd.Appearance.Options.UseFont = true;
            this.buttDeleteStd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.buttDeleteStd.Image = ((System.Drawing.Image)(resources.GetObject("buttDeleteStd.Image")));
            this.buttDeleteStd.Location = new System.Drawing.Point(416, 73);
            this.buttDeleteStd.Name = "buttDeleteStd";
            this.buttDeleteStd.Size = new System.Drawing.Size(136, 47);
            this.buttDeleteStd.TabIndex = 2;
            this.buttDeleteStd.Text = "Delete Student";
            this.buttDeleteStd.Click += new System.EventHandler(this.buttDeleteStd_Click);
            // 
            // grdCtrlStudents
            // 
            this.grdCtrlStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCtrlStudents.Location = new System.Drawing.Point(12, 138);
            this.grdCtrlStudents.MainView = this.gridView1;
            this.grdCtrlStudents.Name = "grdCtrlStudents";
            this.grdCtrlStudents.Size = new System.Drawing.Size(568, 236);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(193, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Details of Students";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(592, 386);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton buttInsertStd;
        private DevExpress.XtraEditors.SimpleButton buttonUpdateStd;
        private DevExpress.XtraEditors.SimpleButton buttDeleteStd;
        private DevExpress.XtraGrid.GridControl grdCtrlStudents;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
    }
}