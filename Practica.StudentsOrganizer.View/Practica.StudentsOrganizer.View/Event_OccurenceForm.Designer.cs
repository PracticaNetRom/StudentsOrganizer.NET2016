namespace Practica.StudentsOrganizer.View
{
    partial class Event_OccurenceForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddEvent_Occurence = new System.Windows.Forms.Button();
            this.txtId_Event = new System.Windows.Forms.TextBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "All * fields are mandatory!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "*Id_Event:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "*Start date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "*End date:";
            // 
            // btnAddEvent_Occurence
            // 
            this.btnAddEvent_Occurence.Location = new System.Drawing.Point(103, 225);
            this.btnAddEvent_Occurence.Name = "btnAddEvent_Occurence";
            this.btnAddEvent_Occurence.Size = new System.Drawing.Size(75, 23);
            this.btnAddEvent_Occurence.TabIndex = 7;
            this.btnAddEvent_Occurence.Text = "Add";
            this.btnAddEvent_Occurence.UseVisualStyleBackColor = true;
            // 
            // txtId_Event
            // 
            this.txtId_Event.Location = new System.Drawing.Point(103, 49);
            this.txtId_Event.Name = "txtId_Event";
            this.txtId_Event.Size = new System.Drawing.Size(100, 20);
            this.txtId_Event.TabIndex = 11;
            // 
            // StartDate
            // 
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate.Location = new System.Drawing.Point(103, 96);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(100, 20);
            this.StartDate.TabIndex = 12;
            // 
            // EndDate
            // 
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDate.Location = new System.Drawing.Point(103, 148);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(100, 20);
            this.EndDate.TabIndex = 13;
            // 
            // Event_OccurenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.txtId_Event);
            this.Controls.Add(this.btnAddEvent_Occurence);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Event_OccurenceForm";
            this.Text = "Event_OccurenceForm";
            this.Load += new System.EventHandler(this.Event_OccurenceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddEvent_Occurence;
        private System.Windows.Forms.TextBox txtId_Event;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
    }
}