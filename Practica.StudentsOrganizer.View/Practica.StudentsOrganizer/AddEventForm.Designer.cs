namespace Practica.StudentsOrganizer
{
    partial class AddEventForm
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
            this.txtTask = new System.Windows.Forms.Label();
            this.txtTech = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.Label();
            this.Show_Ev_Button = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SaveEv_Button = new DevExpress.XtraEditors.SimpleButton();
            this.txtEvName = new DevExpress.XtraEditors.TextEdit();
            this.Edit_Ev_Button = new DevExpress.XtraEditors.SimpleButton();
            this.Add_Ev_Button = new DevExpress.XtraEditors.SimpleButton();
            this.txtTechnology = new DevExpress.XtraEditors.TextEdit();
            this.txtTsk = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTechnology.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTsk.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTask
            // 
            this.txtTask.AutoSize = true;
            this.txtTask.Location = new System.Drawing.Point(177, 117);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(31, 13);
            this.txtTask.TabIndex = 25;
            this.txtTask.Text = "Task";
            // 
            // txtTech
            // 
            this.txtTech.AutoSize = true;
            this.txtTech.Location = new System.Drawing.Point(177, 94);
            this.txtTech.Name = "txtTech";
            this.txtTech.Size = new System.Drawing.Size(63, 13);
            this.txtTech.TabIndex = 24;
            this.txtTech.Text = "Technology";
            // 
            // txtEventName
            // 
            this.txtEventName.AutoSize = true;
            this.txtEventName.Location = new System.Drawing.Point(177, 73);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(66, 13);
            this.txtEventName.TabIndex = 23;
            this.txtEventName.Text = "Event Name";
            // 
            // Show_Ev_Button
            // 
            this.Show_Ev_Button.Location = new System.Drawing.Point(22, 24);
            this.Show_Ev_Button.Name = "Show_Ev_Button";
            this.Show_Ev_Button.Size = new System.Drawing.Size(103, 23);
            this.Show_Ev_Button.TabIndex = 34;
            this.Show_Ev_Button.Text = "Show Event";
            this.Show_Ev_Button.Click += new System.EventHandler(this.Show_Ev_Button_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(435, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(334, 232);
            this.gridControl1.TabIndex = 33;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // SaveEv_Button
            // 
            this.SaveEv_Button.Location = new System.Drawing.Point(22, 173);
            this.SaveEv_Button.Name = "SaveEv_Button";
            this.SaveEv_Button.Size = new System.Drawing.Size(103, 23);
            this.SaveEv_Button.TabIndex = 51;
            this.SaveEv_Button.Text = "Save Changes";
            this.SaveEv_Button.Click += new System.EventHandler(this.SaveEv_Button_Click);
            // 
            // txtEvName
            // 
            this.txtEvName.Location = new System.Drawing.Point(300, 74);
            this.txtEvName.Name = "txtEvName";
            this.txtEvName.Size = new System.Drawing.Size(100, 20);
            this.txtEvName.TabIndex = 45;
            // 
            // Edit_Ev_Button
            // 
            this.Edit_Ev_Button.Location = new System.Drawing.Point(22, 124);
            this.Edit_Ev_Button.Name = "Edit_Ev_Button";
            this.Edit_Ev_Button.Size = new System.Drawing.Size(103, 23);
            this.Edit_Ev_Button.TabIndex = 44;
            this.Edit_Ev_Button.Text = "Edit Event";
            this.Edit_Ev_Button.Click += new System.EventHandler(this.Edit_Ev_Button_Click);
            // 
            // Add_Ev_Button
            // 
            this.Add_Ev_Button.Location = new System.Drawing.Point(22, 73);
            this.Add_Ev_Button.Name = "Add_Ev_Button";
            this.Add_Ev_Button.Size = new System.Drawing.Size(103, 23);
            this.Add_Ev_Button.TabIndex = 43;
            this.Add_Ev_Button.Text = "Add Event";
            this.Add_Ev_Button.Click += new System.EventHandler(this.Add_Ev_Button_Click);
            // 
            // txtTechnology
            // 
            this.txtTechnology.Location = new System.Drawing.Point(300, 100);
            this.txtTechnology.Name = "txtTechnology";
            this.txtTechnology.Size = new System.Drawing.Size(100, 20);
            this.txtTechnology.TabIndex = 52;
            // 
            // txtTsk
            // 
            this.txtTsk.Location = new System.Drawing.Point(300, 126);
            this.txtTsk.Name = "txtTsk";
            this.txtTsk.Size = new System.Drawing.Size(100, 20);
            this.txtTsk.TabIndex = 53;
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 282);
            this.Controls.Add(this.txtTsk);
            this.Controls.Add(this.txtTechnology);
            this.Controls.Add(this.SaveEv_Button);
            this.Controls.Add(this.txtEvName);
            this.Controls.Add(this.Edit_Ev_Button);
            this.Controls.Add(this.Add_Ev_Button);
            this.Controls.Add(this.Show_Ev_Button);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.txtTech);
            this.Controls.Add(this.txtEventName);
            this.Name = "AddEventForm";
            this.Text = "Events Form";
            this.Load += new System.EventHandler(this.AddEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTechnology.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTsk.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtTask;
        private System.Windows.Forms.Label txtTech;
        private System.Windows.Forms.Label txtEventName;
        private DevExpress.XtraEditors.SimpleButton Show_Ev_Button;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton SaveEv_Button;
        private DevExpress.XtraEditors.TextEdit txtEvName;
        private DevExpress.XtraEditors.SimpleButton Edit_Ev_Button;
        private DevExpress.XtraEditors.SimpleButton Add_Ev_Button;
        private DevExpress.XtraEditors.TextEdit txtTechnology;
        private DevExpress.XtraEditors.TextEdit txtTsk;
    }
}