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
            this.label10 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtLast_Name = new System.Windows.Forms.TextBox();
            this.txtFirst_Name = new System.Windows.Forms.TextBox();
            this.txtTask = new System.Windows.Forms.Label();
            this.txtTech = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.Label();
            this.ShowEventsButton = new System.Windows.Forms.Button();
            this.SaveEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(187, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "New Event";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(209, 141);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(200, 20);
            this.txtGender.TabIndex = 28;
            // 
            // txtLast_Name
            // 
            this.txtLast_Name.Location = new System.Drawing.Point(209, 118);
            this.txtLast_Name.Name = "txtLast_Name";
            this.txtLast_Name.Size = new System.Drawing.Size(200, 20);
            this.txtLast_Name.TabIndex = 27;
            // 
            // txtFirst_Name
            // 
            this.txtFirst_Name.Location = new System.Drawing.Point(209, 97);
            this.txtFirst_Name.Name = "txtFirst_Name";
            this.txtFirst_Name.Size = new System.Drawing.Size(200, 20);
            this.txtFirst_Name.TabIndex = 26;
            // 
            // txtTask
            // 
            this.txtTask.AutoSize = true;
            this.txtTask.Location = new System.Drawing.Point(58, 141);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(31, 13);
            this.txtTask.TabIndex = 25;
            this.txtTask.Text = "Task";
            // 
            // txtTech
            // 
            this.txtTech.AutoSize = true;
            this.txtTech.Location = new System.Drawing.Point(58, 118);
            this.txtTech.Name = "txtTech";
            this.txtTech.Size = new System.Drawing.Size(63, 13);
            this.txtTech.TabIndex = 24;
            this.txtTech.Text = "Technology";
            // 
            // txtEventName
            // 
            this.txtEventName.AutoSize = true;
            this.txtEventName.Location = new System.Drawing.Point(58, 97);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(66, 13);
            this.txtEventName.TabIndex = 23;
            this.txtEventName.Text = "Event Name";
            // 
            // ShowEventsButton
            // 
            this.ShowEventsButton.Image = global::Practica.StudentsOrganizer.Properties.Resources.show_table;
            this.ShowEventsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowEventsButton.Location = new System.Drawing.Point(219, 231);
            this.ShowEventsButton.Name = "ShowEventsButton";
            this.ShowEventsButton.Size = new System.Drawing.Size(150, 35);
            this.ShowEventsButton.TabIndex = 32;
            this.ShowEventsButton.Text = "Show Events";
            this.ShowEventsButton.UseVisualStyleBackColor = true;
            // 
            // SaveEvent
            // 
            this.SaveEvent.Image = global::Practica.StudentsOrganizer.Properties.Resources.save;
            this.SaveEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveEvent.Location = new System.Drawing.Point(80, 231);
            this.SaveEvent.Name = "SaveEvent";
            this.SaveEvent.Size = new System.Drawing.Size(75, 35);
            this.SaveEvent.TabIndex = 31;
            this.SaveEvent.Text = "Save";
            this.SaveEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveEvent.UseVisualStyleBackColor = true;
            this.SaveEvent.Click += new System.EventHandler(this.SaveEvent_Click);
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 312);
            this.Controls.Add(this.ShowEventsButton);
            this.Controls.Add(this.SaveEvent);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtLast_Name);
            this.Controls.Add(this.txtFirst_Name);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.txtTech);
            this.Controls.Add(this.txtEventName);
            this.Name = "AddEventForm";
            this.Text = "AddEventForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtLast_Name;
        private System.Windows.Forms.TextBox txtFirst_Name;
        private System.Windows.Forms.Label txtTask;
        private System.Windows.Forms.Label txtTech;
        private System.Windows.Forms.Label txtEventName;
        private System.Windows.Forms.Button ShowEventsButton;
        private System.Windows.Forms.Button SaveEvent;
    }
}