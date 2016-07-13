namespace Practica.StudentsOrganizer
{
    partial class EOForm
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtStdId = new DevExpress.XtraEditors.TextEdit();
            this.txtEOid = new DevExpress.XtraEditors.TextEdit();
            this.Add_SEO_Button = new DevExpress.XtraEditors.SimpleButton();
            this.Del_SEO_Button = new DevExpress.XtraEditors.SimpleButton();
            this.Edit_SEO_Button = new DevExpress.XtraEditors.SimpleButton();
            this.SaveChSEO = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddEvID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddFinish.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddFinish.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStdId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEOid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(138, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "Start Date";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(138, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "Event  ID";
            // 
            // txtAddEvID
            // 
            this.txtAddEvID.Location = new System.Drawing.Point(232, 54);
            this.txtAddEvID.Name = "txtAddEvID";
            this.txtAddEvID.Size = new System.Drawing.Size(100, 20);
            this.txtAddEvID.TabIndex = 27;
            // 
            // Del_EO_Button
            // 
            this.Del_EO_Button.Location = new System.Drawing.Point(5, 124);
            this.Del_EO_Button.Name = "Del_EO_Button";
            this.Del_EO_Button.Size = new System.Drawing.Size(103, 23);
            this.Del_EO_Button.TabIndex = 26;
            this.Del_EO_Button.Text = "Delete EO";
            this.Del_EO_Button.Click += new System.EventHandler(this.Del_EO_Button_Click);
            // 
            // Edit_EO_Button
            // 
            this.Edit_EO_Button.Location = new System.Drawing.Point(5, 66);
            this.Edit_EO_Button.Name = "Edit_EO_Button";
            this.Edit_EO_Button.Size = new System.Drawing.Size(103, 23);
            this.Edit_EO_Button.TabIndex = 25;
            this.Edit_EO_Button.Text = "Edit EO";
            this.Edit_EO_Button.Click += new System.EventHandler(this.Edit_EO_Button_Click);
            // 
            // Add_EO_Button
            // 
            this.Add_EO_Button.Location = new System.Drawing.Point(5, 38);
            this.Add_EO_Button.Name = "Add_EO_Button";
            this.Add_EO_Button.Size = new System.Drawing.Size(103, 23);
            this.Add_EO_Button.TabIndex = 24;
            this.Add_EO_Button.Text = "Add EO";
            this.Add_EO_Button.Click += new System.EventHandler(this.Add_SEO_Button_Click);
            // 
            // Show_EO_Button
            // 
            this.Show_EO_Button.Location = new System.Drawing.Point(543, 159);
            this.Show_EO_Button.Name = "Show_EO_Button";
            this.Show_EO_Button.Size = new System.Drawing.Size(103, 23);
            this.Show_EO_Button.TabIndex = 23;
            this.Show_EO_Button.Text = "Refresh";
            this.Show_EO_Button.Click += new System.EventHandler(this.Show_EO_Button_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(356, 38);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(457, 109);
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
            this.labelControl4.Location = new System.Drawing.Point(138, 118);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 37;
            this.labelControl4.Text = "Finish Date";
            // 
            // dateAddStart
            // 
            this.dateAddStart.EditValue = null;
            this.dateAddStart.Location = new System.Drawing.Point(232, 82);
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
            this.dateAddFinish.Location = new System.Drawing.Point(232, 111);
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
            this.SaveEO_Button.Location = new System.Drawing.Point(5, 95);
            this.SaveEO_Button.Name = "SaveEO_Button";
            this.SaveEO_Button.Size = new System.Drawing.Size(103, 23);
            this.SaveEO_Button.TabIndex = 42;
            this.SaveEO_Button.Text = "Save Changes";
            this.SaveEO_Button.Click += new System.EventHandler(this.SaveEO_Button_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(121, 254);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 13);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "StudentsID";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(121, 226);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(96, 13);
            this.labelControl5.TabIndex = 46;
            this.labelControl5.Text = "Event Occurence ID";
            // 
            // txtStdId
            // 
            this.txtStdId.Location = new System.Drawing.Point(232, 247);
            this.txtStdId.Name = "txtStdId";
            this.txtStdId.Size = new System.Drawing.Size(100, 20);
            this.txtStdId.TabIndex = 45;
            // 
            // txtEOid
            // 
            this.txtEOid.Location = new System.Drawing.Point(232, 219);
            this.txtEOid.Name = "txtEOid";
            this.txtEOid.Size = new System.Drawing.Size(100, 20);
            this.txtEOid.TabIndex = 44;
            // 
            // Add_SEO_Button
            // 
            this.Add_SEO_Button.Location = new System.Drawing.Point(5, 188);
            this.Add_SEO_Button.Name = "Add_SEO_Button";
            this.Add_SEO_Button.Size = new System.Drawing.Size(103, 23);
            this.Add_SEO_Button.TabIndex = 43;
            this.Add_SEO_Button.Text = "Add SEO";
            this.Add_SEO_Button.Click += new System.EventHandler(this.Add_SEO_Button_Click_1);
            // 
            // Del_SEO_Button
            // 
            this.Del_SEO_Button.Location = new System.Drawing.Point(5, 275);
            this.Del_SEO_Button.Name = "Del_SEO_Button";
            this.Del_SEO_Button.Size = new System.Drawing.Size(103, 23);
            this.Del_SEO_Button.TabIndex = 49;
            this.Del_SEO_Button.Text = "Delete SEO";
            this.Del_SEO_Button.Click += new System.EventHandler(this.Del_SEO_Button_Click);
            // 
            // Edit_SEO_Button
            // 
            this.Edit_SEO_Button.Location = new System.Drawing.Point(5, 217);
            this.Edit_SEO_Button.Name = "Edit_SEO_Button";
            this.Edit_SEO_Button.Size = new System.Drawing.Size(103, 23);
            this.Edit_SEO_Button.TabIndex = 48;
            this.Edit_SEO_Button.Text = "Edit SEO";
            this.Edit_SEO_Button.Click += new System.EventHandler(this.Edit_SEO_Button_Click);
            // 
            // SaveChSEO
            // 
            this.SaveChSEO.Location = new System.Drawing.Point(5, 246);
            this.SaveChSEO.Name = "SaveChSEO";
            this.SaveChSEO.Size = new System.Drawing.Size(103, 23);
            this.SaveChSEO.TabIndex = 50;
            this.SaveChSEO.Text = "Save Changes";
            this.SaveChSEO.Click += new System.EventHandler(this.SaveChSEO_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(132, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(85, 13);
            this.labelControl6.TabIndex = 51;
            this.labelControl6.Text = "Event  Occurence";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(121, 162);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(123, 13);
            this.labelControl7.TabIndex = 52;
            this.labelControl7.Text = "Student Event Occurence";
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Location = new System.Drawing.Point(356, 188);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(457, 110);
            this.gridControl2.TabIndex = 53;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // EOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 319);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.SaveChSEO);
            this.Controls.Add(this.Del_SEO_Button);
            this.Controls.Add(this.Edit_SEO_Button);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtStdId);
            this.Controls.Add(this.txtEOid);
            this.Controls.Add(this.Add_SEO_Button);
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
            this.Name = "EOForm";
            this.Text = "EOForm";
            this.Load += new System.EventHandler(this.EOForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAddEvID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddFinish.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAddFinish.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStdId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEOid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtStdId;
        private DevExpress.XtraEditors.TextEdit txtEOid;
        private DevExpress.XtraEditors.SimpleButton Add_SEO_Button;
        private DevExpress.XtraEditors.SimpleButton Del_SEO_Button;
        private DevExpress.XtraEditors.SimpleButton Edit_SEO_Button;
        private DevExpress.XtraEditors.SimpleButton SaveChSEO;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}