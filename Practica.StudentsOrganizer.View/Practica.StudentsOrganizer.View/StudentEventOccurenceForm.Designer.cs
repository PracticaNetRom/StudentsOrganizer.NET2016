namespace Practica.StudentsOrganizer.View
{
    partial class StudentEventOccurenceForm
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
            this.btnShowEO = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddEO = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditEO = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteEO = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelEventId = new DevExpress.XtraEditors.LabelControl();
            this.Start = new DevExpress.XtraEditors.LabelControl();
            this.Finish = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.gridControlEO = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowEO
            // 
            this.btnShowEO.Location = new System.Drawing.Point(44, 105);
            this.btnShowEO.Name = "btnShowEO";
            this.btnShowEO.Size = new System.Drawing.Size(75, 23);
            this.btnShowEO.TabIndex = 0;
            this.btnShowEO.Text = "ShowEO";
            // 
            // btnAddEO
            // 
            this.btnAddEO.Location = new System.Drawing.Point(44, 155);
            this.btnAddEO.Name = "btnAddEO";
            this.btnAddEO.Size = new System.Drawing.Size(75, 23);
            this.btnAddEO.TabIndex = 1;
            this.btnAddEO.Text = "AddEO";
            // 
            // btnEditEO
            // 
            this.btnEditEO.Location = new System.Drawing.Point(44, 203);
            this.btnEditEO.Name = "btnEditEO";
            this.btnEditEO.Size = new System.Drawing.Size(75, 23);
            this.btnEditEO.TabIndex = 2;
            this.btnEditEO.Text = "EditEO";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(44, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            // 
            // btnDeleteEO
            // 
            this.btnDeleteEO.Location = new System.Drawing.Point(44, 304);
            this.btnDeleteEO.Name = "btnDeleteEO";
            this.btnDeleteEO.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEO.TabIndex = 4;
            this.btnDeleteEO.Text = "Delete";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(275, 158);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 5;
            // 
            // labelEventId
            // 
            this.labelEventId.Location = new System.Drawing.Point(190, 165);
            this.labelEventId.Name = "labelEventId";
            this.labelEventId.Size = new System.Drawing.Size(42, 13);
            this.labelEventId.TabIndex = 6;
            this.labelEventId.Text = "Event ID";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(190, 213);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(24, 13);
            this.Start.TabIndex = 7;
            this.Start.Text = "Start";
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(190, 264);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(27, 13);
            this.Finish.TabIndex = 8;
            this.Finish.Text = "Finish";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(275, 206);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 9;
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(275, 257);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(100, 20);
            this.dateEdit2.TabIndex = 10;
            // 
            // gridControlEO
            // 
            this.gridControlEO.Location = new System.Drawing.Point(381, 105);
            this.gridControlEO.MainView = this.gridView1;
            this.gridControlEO.Name = "gridControlEO";
            this.gridControlEO.Size = new System.Drawing.Size(477, 222);
            this.gridControlEO.TabIndex = 11;
            this.gridControlEO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlEO;
            this.gridView1.Name = "gridView1";
            // 
            // StudentEventOccurenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 436);
            this.Controls.Add(this.gridControlEO);
            this.Controls.Add(this.dateEdit2);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.labelEventId);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.btnDeleteEO);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEditEO);
            this.Controls.Add(this.btnAddEO);
            this.Controls.Add(this.btnShowEO);
            this.Name = "StudentEventOccurenceForm";
            this.Text = "StudentEventOccurenceForm";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnShowEO;
        private DevExpress.XtraEditors.SimpleButton btnAddEO;
        private DevExpress.XtraEditors.SimpleButton btnEditEO;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDeleteEO;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelEventId;
        private DevExpress.XtraEditors.LabelControl Start;
        private DevExpress.XtraEditors.LabelControl Finish;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraGrid.GridControl gridControlEO;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}