namespace Practica.StudentsOrganizer.View
{
    partial class Std_Event_OccurenceForm
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
            this.txtId_Student = new System.Windows.Forms.Label();
            this.txtId_Event = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAddStd_Event_Occurence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "All * fields are mandatory!";
            // 
            // txtId_Student
            // 
            this.txtId_Student.AutoSize = true;
            this.txtId_Student.Location = new System.Drawing.Point(16, 60);
            this.txtId_Student.Name = "txtId_Student";
            this.txtId_Student.Size = new System.Drawing.Size(66, 13);
            this.txtId_Student.TabIndex = 1;
            this.txtId_Student.Text = "*Id_Student:";
            // 
            // txtId_Event
            // 
            this.txtId_Event.AutoSize = true;
            this.txtId_Event.Location = new System.Drawing.Point(16, 110);
            this.txtId_Event.Name = "txtId_Event";
            this.txtId_Event.Size = new System.Drawing.Size(57, 13);
            this.txtId_Event.TabIndex = 2;
            this.txtId_Event.Text = "*Id_Event:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // btnAddStd_Event_Occurence
            // 
            this.btnAddStd_Event_Occurence.Location = new System.Drawing.Point(102, 185);
            this.btnAddStd_Event_Occurence.Name = "btnAddStd_Event_Occurence";
            this.btnAddStd_Event_Occurence.Size = new System.Drawing.Size(75, 23);
            this.btnAddStd_Event_Occurence.TabIndex = 5;
            this.btnAddStd_Event_Occurence.Text = "Add";
            this.btnAddStd_Event_Occurence.UseVisualStyleBackColor = true;
            // 
            // Std_Event_OccurenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnAddStd_Event_Occurence);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtId_Event);
            this.Controls.Add(this.txtId_Student);
            this.Controls.Add(this.label1);
            this.Name = "Std_Event_OccurenceForm";
            this.Text = "Std_Event_OccurenceForm";
            this.Load += new System.EventHandler(this.Std_Event_OccurenceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtId_Student;
        private System.Windows.Forms.Label txtId_Event;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAddStd_Event_Occurence;
    }
}