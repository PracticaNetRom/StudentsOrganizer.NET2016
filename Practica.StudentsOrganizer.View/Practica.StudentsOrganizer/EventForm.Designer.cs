namespace Practica.StudentsOrganizer
{
    partial class EventForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Show_Ev_Button = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SaveEv_Button = new DevExpress.XtraEditors.SimpleButton();
            this.txtEvName = new DevExpress.XtraEditors.TextEdit();
            this.Edit_Ev_Button = new DevExpress.XtraEditors.SimpleButton();
            this.Add_Ev_Button = new DevExpress.XtraEditors.SimpleButton();
            this.txtTask = new DevExpress.XtraEditors.TextEdit();
            this.Del_Ev_Button = new DevExpress.XtraEditors.SimpleButton();
            this.comboTechnology = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTask.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboTechnology.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Technology";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Event Name";
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
            this.txtEvName.Location = new System.Drawing.Point(282, 74);
            this.txtEvName.Name = "txtEvName";
            this.txtEvName.Size = new System.Drawing.Size(118, 20);
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
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(282, 126);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(118, 20);
            this.txtTask.TabIndex = 53;
            // 
            // Del_Ev_Button
            // 
            this.Del_Ev_Button.Location = new System.Drawing.Point(22, 223);
            this.Del_Ev_Button.Name = "Del_Ev_Button";
            this.Del_Ev_Button.Size = new System.Drawing.Size(103, 23);
            this.Del_Ev_Button.TabIndex = 54;
            this.Del_Ev_Button.Text = "Delete";
            this.Del_Ev_Button.Click += new System.EventHandler(this.Del_Ev_Button_Click);
            // 
            // comboTechnology
            // 
            this.comboTechnology.Location = new System.Drawing.Point(282, 100);
            this.comboTechnology.Name = "comboTechnology";
            this.comboTechnology.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboTechnology.Properties.Items.AddRange(new object[] {
            "Java",
            "C#"});
            this.comboTechnology.Size = new System.Drawing.Size(118, 20);
            this.comboTechnology.TabIndex = 55;
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 282);
            this.Controls.Add(this.comboTechnology);
            this.Controls.Add(this.Del_Ev_Button);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.SaveEv_Button);
            this.Controls.Add(this.txtEvName);
            this.Controls.Add(this.Edit_Ev_Button);
            this.Controls.Add(this.Add_Ev_Button);
            this.Controls.Add(this.Show_Ev_Button);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEventForm";
            this.Text = "Events Form";
            this.Load += new System.EventHandler(this.AddEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTask.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboTechnology.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton Show_Ev_Button;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton SaveEv_Button;
        private DevExpress.XtraEditors.TextEdit txtEvName;
        private DevExpress.XtraEditors.SimpleButton Edit_Ev_Button;
        private DevExpress.XtraEditors.SimpleButton Add_Ev_Button;
        private DevExpress.XtraEditors.TextEdit txtTask;
        private DevExpress.XtraEditors.SimpleButton Del_Ev_Button;
        private DevExpress.XtraEditors.ComboBoxEdit comboTechnology;
    }
}