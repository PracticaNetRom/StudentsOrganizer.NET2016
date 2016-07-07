namespace Practica.StudentsOrganizer
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Show_Students_Button = new DevExpress.XtraEditors.SimpleButton();
            this.Add_Stud_Button = new DevExpress.XtraEditors.SimpleButton();
            this.Edit_Stud_Button = new DevExpress.XtraEditors.SimpleButton();
            this.Del_Stud_Button = new DevExpress.XtraEditors.SimpleButton();
            this.EventsButton = new DevExpress.XtraEditors.SimpleButton();
            this.EOButton = new DevExpress.XtraEditors.SimpleButton();
            this.SEOButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Students Table";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(168, 46);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(633, 311);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Show_Students_Button
            // 
            this.Show_Students_Button.Image = global::Practica.StudentsOrganizer.Properties.Resources.show_table;
            this.Show_Students_Button.Location = new System.Drawing.Point(13, 46);
            this.Show_Students_Button.Name = "Show_Students_Button";
            this.Show_Students_Button.Size = new System.Drawing.Size(118, 39);
            this.Show_Students_Button.TabIndex = 7;
            this.Show_Students_Button.Text = "Show Students";
            this.Show_Students_Button.Click += new System.EventHandler(this.Show_Students_Button_Click);
            // 
            // Add_Stud_Button
            // 
            this.Add_Stud_Button.Image = global::Practica.StudentsOrganizer.Properties.Resources.add_to_table;
            this.Add_Stud_Button.Location = new System.Drawing.Point(13, 91);
            this.Add_Stud_Button.Name = "Add_Stud_Button";
            this.Add_Stud_Button.Size = new System.Drawing.Size(118, 40);
            this.Add_Stud_Button.TabIndex = 8;
            this.Add_Stud_Button.Text = "Add Student";
            this.Add_Stud_Button.Click += new System.EventHandler(this.Add_Stud_Button_Click);
            // 
            // Edit_Stud_Button
            // 
            this.Edit_Stud_Button.Image = global::Practica.StudentsOrganizer.Properties.Resources.edit_table;
            this.Edit_Stud_Button.Location = new System.Drawing.Point(13, 137);
            this.Edit_Stud_Button.Name = "Edit_Stud_Button";
            this.Edit_Stud_Button.Size = new System.Drawing.Size(118, 37);
            this.Edit_Stud_Button.TabIndex = 9;
            this.Edit_Stud_Button.Text = "Edit Student";
            this.Edit_Stud_Button.Click += new System.EventHandler(this.Edit_Stud_Button_Click);
            // 
            // Del_Stud_Button
            // 
            this.Del_Stud_Button.Image = global::Practica.StudentsOrganizer.Properties.Resources.delete_from_table;
            this.Del_Stud_Button.Location = new System.Drawing.Point(13, 180);
            this.Del_Stud_Button.Name = "Del_Stud_Button";
            this.Del_Stud_Button.Size = new System.Drawing.Size(118, 38);
            this.Del_Stud_Button.TabIndex = 10;
            this.Del_Stud_Button.Text = "Delete Student";
            this.Del_Stud_Button.Click += new System.EventHandler(this.Del_Stud_Button_Click);
            // 
            // EventsButton
            // 
            this.EventsButton.Location = new System.Drawing.Point(13, 234);
            this.EventsButton.Name = "EventsButton";
            this.EventsButton.Size = new System.Drawing.Size(118, 23);
            this.EventsButton.TabIndex = 11;
            this.EventsButton.Text = "Events";
            this.EventsButton.Click += new System.EventHandler(this.EventsButton_Click);
            // 
            // EOButton
            // 
            this.EOButton.Location = new System.Drawing.Point(13, 272);
            this.EOButton.Name = "EOButton";
            this.EOButton.Size = new System.Drawing.Size(118, 23);
            this.EOButton.TabIndex = 12;
            this.EOButton.Text = "Event Occurence";
            this.EOButton.Click += new System.EventHandler(this.EOButton_Click);
            // 
            // SEOButton
            // 
            this.SEOButton.Location = new System.Drawing.Point(13, 316);
            this.SEOButton.Name = "SEOButton";
            this.SEOButton.Size = new System.Drawing.Size(118, 23);
            this.SEOButton.TabIndex = 13;
            this.SEOButton.Text = "SEO";
            this.SEOButton.Click += new System.EventHandler(this.SEOButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 369);
            this.Controls.Add(this.SEOButton);
            this.Controls.Add(this.EOButton);
            this.Controls.Add(this.EventsButton);
            this.Controls.Add(this.Del_Stud_Button);
            this.Controls.Add(this.Edit_Stud_Button);
            this.Controls.Add(this.Add_Stud_Button);
            this.Controls.Add(this.Show_Students_Button);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.ShowStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Show_Students_Button;
        private DevExpress.XtraEditors.SimpleButton Add_Stud_Button;
        private DevExpress.XtraEditors.SimpleButton Edit_Stud_Button;
        private DevExpress.XtraEditors.SimpleButton Del_Stud_Button;
        private DevExpress.XtraEditors.SimpleButton EventsButton;
        private DevExpress.XtraEditors.SimpleButton EOButton;
        private DevExpress.XtraEditors.SimpleButton SEOButton;
    }
}