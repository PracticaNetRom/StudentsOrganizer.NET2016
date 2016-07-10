namespace Practica.StudentsOrganizer
{
    partial class TestEO
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddEvID = new DevExpress.XtraEditors.TextEdit();
            this.Del_EO_Button = new DevExpress.XtraEditors.SimpleButton();
            this.Edit_EO_Button = new DevExpress.XtraEditors.SimpleButton();
            this.Add_EO_Button = new DevExpress.XtraEditors.SimpleButton();
            this.Show_EO_Button = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dateAddStart = new DevExpress.XtraEditors.DateEdit();
            this.dateAddFinish = new DevExpress.XtraEditors.DateEdit();
            this.SaveEO_Button = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddEvID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddFinish.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddFinish.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(144, 119);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "Start";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(144, 79);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "Event  ID";
            // 
            // txtAddEvID
            // 
            this.txtAddEvID.Location = new System.Drawing.Point(238, 76);
            this.txtAddEvID.Name = "txtAddEvID";
            this.txtAddEvID.Size = new System.Drawing.Size(100, 20);
            this.txtAddEvID.TabIndex = 27;
            // 
            // Del_EO_Button
            // 
            this.Del_EO_Button.Location = new System.Drawing.Point(5, 205);
            this.Del_EO_Button.Name = "Del_EO_Button";
            this.Del_EO_Button.Size = new System.Drawing.Size(103, 23);
            this.Del_EO_Button.TabIndex = 26;
            this.Del_EO_Button.Text = "Delete EO";
            this.Del_EO_Button.Click += new System.EventHandler(this.Del_EO_Button_Click);
            // 
            // Edit_EO_Button
            // 
            this.Edit_EO_Button.Location = new System.Drawing.Point(5, 119);
            this.Edit_EO_Button.Name = "Edit_EO_Button";
            this.Edit_EO_Button.Size = new System.Drawing.Size(103, 23);
            this.Edit_EO_Button.TabIndex = 25;
            this.Edit_EO_Button.Text = "Edit EO";
            this.Edit_EO_Button.Click += new System.EventHandler(this.Edit_EO_Button_Click);
            // 
            // Add_EO_Button
            // 
            this.Add_EO_Button.Location = new System.Drawing.Point(5, 79);
            this.Add_EO_Button.Name = "Add_EO_Button";
            this.Add_EO_Button.Size = new System.Drawing.Size(103, 23);
            this.Add_EO_Button.TabIndex = 24;
            this.Add_EO_Button.Text = "Add EO";
            this.Add_EO_Button.Click += new System.EventHandler(this.Add_SEO_Button_Click);
            // 
            // Show_EO_Button
            // 
            this.Show_EO_Button.Location = new System.Drawing.Point(5, 37);
            this.Show_EO_Button.Name = "Show_EO_Button";
            this.Show_EO_Button.Size = new System.Drawing.Size(103, 23);
            this.Show_EO_Button.TabIndex = 23;
            this.Show_EO_Button.Text = "Show EO";
            this.Show_EO_Button.Click += new System.EventHandler(this.Show_EO_Button_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(356, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(353, 287);
            this.gridControl1.TabIndex = 22;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(144, 152);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 37;
            this.labelControl4.Text = "Finish";
            // 
            // dateAddStart
            // 
            this.dateAddStart.EditValue = null;
            this.dateAddStart.Location = new System.Drawing.Point(238, 112);
            this.dateAddStart.Name = "dateAddStart";
            this.dateAddStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateAddStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateAddStart.Size = new System.Drawing.Size(100, 20);
            this.dateAddStart.TabIndex = 38;
            // 
            // dateAddFinish
            // 
            this.dateAddFinish.EditValue = null;
            this.dateAddFinish.Location = new System.Drawing.Point(238, 145);
            this.dateAddFinish.Name = "dateAddFinish";
            this.dateAddFinish.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateAddFinish.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateAddFinish.Size = new System.Drawing.Size(100, 20);
            this.dateAddFinish.TabIndex = 40;
            // 
            // SaveEO_Button
            // 
            this.SaveEO_Button.Location = new System.Drawing.Point(5, 162);
            this.SaveEO_Button.Name = "SaveEO_Button";
            this.SaveEO_Button.Size = new System.Drawing.Size(100, 23);
            this.SaveEO_Button.TabIndex = 42;
            this.SaveEO_Button.Text = "Save Changes";
            this.SaveEO_Button.Click += new System.EventHandler(this.SaveEO_Button_Click);
            // 
            // TestEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 319);
            this.Controls.Add(this.SaveEO_Button);
            this.Controls.Add(this.dateAddFinish);
            this.Controls.Add(this.dateAddStart);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtAddEvID);
            this.Controls.Add(this.Del_EO_Button);
            this.Controls.Add(this.Edit_EO_Button);
            this.Controls.Add(this.Add_EO_Button);
            this.Controls.Add(this.Show_EO_Button);
            this.Controls.Add(this.gridControl1);
            this.Name = "TestEO";
            this.Text = "TestEO";
            this.Load += new System.EventHandler(this.TestEO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAddEvID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddFinish.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddFinish.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtAddEvID;
        private DevExpress.XtraEditors.SimpleButton Del_EO_Button;
        private DevExpress.XtraEditors.SimpleButton Edit_EO_Button;
        private DevExpress.XtraEditors.SimpleButton Add_EO_Button;
        private DevExpress.XtraEditors.SimpleButton Show_EO_Button;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dateAddStart;
        private DevExpress.XtraEditors.DateEdit dateAddFinish;
        private DevExpress.XtraEditors.SimpleButton SaveEO_Button;
    }
}