namespace Practica.StudentsOrganizer
{
    partial class ShowEventsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Del_Event_Button = new System.Windows.Forms.Button();
            this.Edit_Event_Button = new System.Windows.Forms.Button();
            this.Add_Event_Button = new System.Windows.Forms.Button();
            this.ShowEventsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Events Table";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(219, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 225);
            this.dataGridView1.TabIndex = 6;
            // 
            // Del_Event_Button
            // 
            this.Del_Event_Button.Image = global::Practica.StudentsOrganizer.Properties.Resources.delete_from_table;
            this.Del_Event_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Del_Event_Button.Location = new System.Drawing.Point(30, 209);
            this.Del_Event_Button.Name = "Del_Event_Button";
            this.Del_Event_Button.Size = new System.Drawing.Size(150, 38);
            this.Del_Event_Button.TabIndex = 10;
            this.Del_Event_Button.Text = "Delete Event";
            this.Del_Event_Button.UseVisualStyleBackColor = true;
            // 
            // Edit_Event_Button
            // 
            this.Edit_Event_Button.Image = global::Practica.StudentsOrganizer.Properties.Resources.edit_table;
            this.Edit_Event_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit_Event_Button.Location = new System.Drawing.Point(30, 155);
            this.Edit_Event_Button.Name = "Edit_Event_Button";
            this.Edit_Event_Button.Size = new System.Drawing.Size(150, 37);
            this.Edit_Event_Button.TabIndex = 9;
            this.Edit_Event_Button.Text = "Edit Event";
            this.Edit_Event_Button.UseVisualStyleBackColor = true;
            // 
            // Add_Event_Button
            // 
            this.Add_Event_Button.Image = global::Practica.StudentsOrganizer.Properties.Resources.add_to_table;
            this.Add_Event_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_Event_Button.Location = new System.Drawing.Point(30, 96);
            this.Add_Event_Button.Name = "Add_Event_Button";
            this.Add_Event_Button.Size = new System.Drawing.Size(150, 39);
            this.Add_Event_Button.TabIndex = 8;
            this.Add_Event_Button.Text = "Add new event";
            this.Add_Event_Button.UseVisualStyleBackColor = true;
            this.Add_Event_Button.Click += new System.EventHandler(this.Add_Event_Button_Click);
            // 
            // ShowEventsButton
            // 
            this.ShowEventsButton.Image = global::Practica.StudentsOrganizer.Properties.Resources.show_table;
            this.ShowEventsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowEventsButton.Location = new System.Drawing.Point(30, 45);
            this.ShowEventsButton.Name = "ShowEventsButton";
            this.ShowEventsButton.Size = new System.Drawing.Size(150, 35);
            this.ShowEventsButton.TabIndex = 7;
            this.ShowEventsButton.Text = "Show Events";
            this.ShowEventsButton.UseVisualStyleBackColor = true;
            this.ShowEventsButton.Click += new System.EventHandler(this.ShowEventsButton_Click);
            // 
            // ShowEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Del_Event_Button);
            this.Controls.Add(this.Edit_Event_Button);
            this.Controls.Add(this.Add_Event_Button);
            this.Controls.Add(this.ShowEventsButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowEventsForm";
            this.Text = "ShowEventsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Del_Event_Button;
        private System.Windows.Forms.Button Edit_Event_Button;
        private System.Windows.Forms.Button Add_Event_Button;
        private System.Windows.Forms.Button ShowEventsButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}