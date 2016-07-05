namespace Practica.StudentsOrganizer
{
    partial class ShowStudentsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Del_Stud_Button = new System.Windows.Forms.Button();
            this.Edit_Stud_Button = new System.Windows.Forms.Button();
            this.Add_Stud_Button = new System.Windows.Forms.Button();
            this.ShowStudentsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(223, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // Del_Stud_Button
            // 
            this.Del_Stud_Button.Image = global::Practica.StudentsOrganizer.Properties.Resources.delete_from_table;
            this.Del_Stud_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Del_Stud_Button.Location = new System.Drawing.Point(34, 216);
            this.Del_Stud_Button.Name = "Del_Stud_Button";
            this.Del_Stud_Button.Size = new System.Drawing.Size(150, 38);
            this.Del_Stud_Button.TabIndex = 4;
            this.Del_Stud_Button.Text = "Delete Student";
            this.Del_Stud_Button.UseVisualStyleBackColor = true;
            // 
            // Edit_Stud_Button
            // 
            this.Edit_Stud_Button.Image = global::Practica.StudentsOrganizer.Properties.Resources.edit_table;
            this.Edit_Stud_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit_Stud_Button.Location = new System.Drawing.Point(34, 162);
            this.Edit_Stud_Button.Name = "Edit_Stud_Button";
            this.Edit_Stud_Button.Size = new System.Drawing.Size(150, 37);
            this.Edit_Stud_Button.TabIndex = 3;
            this.Edit_Stud_Button.Text = "Edit Student";
            this.Edit_Stud_Button.UseVisualStyleBackColor = true;
            // 
            // Add_Stud_Button
            // 
            this.Add_Stud_Button.Image = global::Practica.StudentsOrganizer.Properties.Resources.add_to_table;
            this.Add_Stud_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_Stud_Button.Location = new System.Drawing.Point(34, 103);
            this.Add_Stud_Button.Name = "Add_Stud_Button";
            this.Add_Stud_Button.Size = new System.Drawing.Size(150, 39);
            this.Add_Stud_Button.TabIndex = 2;
            this.Add_Stud_Button.Text = "Add new student";
            this.Add_Stud_Button.UseVisualStyleBackColor = true;
            this.Add_Stud_Button.Click += new System.EventHandler(this.Add_Stud_Button_Click);
            // 
            // ShowStudentsButton
            // 
            this.ShowStudentsButton.Image = global::Practica.StudentsOrganizer.Properties.Resources.show_table;
            this.ShowStudentsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowStudentsButton.Location = new System.Drawing.Point(34, 52);
            this.ShowStudentsButton.Name = "ShowStudentsButton";
            this.ShowStudentsButton.Size = new System.Drawing.Size(150, 35);
            this.ShowStudentsButton.TabIndex = 1;
            this.ShowStudentsButton.Text = "Show Students";
            this.ShowStudentsButton.UseVisualStyleBackColor = true;
            this.ShowStudentsButton.Click += new System.EventHandler(this.ShowStudentsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Students Table";
            // 
            // ShowStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Del_Stud_Button);
            this.Controls.Add(this.Edit_Stud_Button);
            this.Controls.Add(this.Add_Stud_Button);
            this.Controls.Add(this.ShowStudentsButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowStudentsForm";
            this.Text = "ShowStudentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowStudentsButton;
        private System.Windows.Forms.Button Add_Stud_Button;
        private System.Windows.Forms.Button Edit_Stud_Button;
        private System.Windows.Forms.Button Del_Stud_Button;
        private System.Windows.Forms.Label label1;
    }
}