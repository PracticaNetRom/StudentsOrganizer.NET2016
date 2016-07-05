namespace Practica.StudentsOrganizer.View
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
            this.Save = new System.Windows.Forms.Button();
            this.textTask = new System.Windows.Forms.TextBox();
            this.textDepartament = new System.Windows.Forms.TextBox();
            this.textNameEvent = new System.Windows.Forms.TextBox();
            this.textEvent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(184, 245);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(101, 35);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // textTask
            // 
            this.textTask.Location = new System.Drawing.Point(144, 103);
            this.textTask.Name = "textTask";
            this.textTask.Size = new System.Drawing.Size(141, 20);
            this.textTask.TabIndex = 1;
            // 
            // textDepartament
            // 
            this.textDepartament.Location = new System.Drawing.Point(144, 77);
            this.textDepartament.Name = "textDepartament";
            this.textDepartament.Size = new System.Drawing.Size(141, 20);
            this.textDepartament.TabIndex = 2;
            this.textDepartament.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textNameEvent
            // 
            this.textNameEvent.Location = new System.Drawing.Point(144, 51);
            this.textNameEvent.Name = "textNameEvent";
            this.textNameEvent.Size = new System.Drawing.Size(141, 20);
            this.textNameEvent.TabIndex = 3;
            // 
            // textEvent
            // 
            this.textEvent.Location = new System.Drawing.Point(144, 25);
            this.textEvent.Name = "textEvent";
            this.textEvent.Size = new System.Drawing.Size(141, 20);
            this.textEvent.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IdEvent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "EventName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Departament";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Task";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 292);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEvent);
            this.Controls.Add(this.textNameEvent);
            this.Controls.Add(this.textDepartament);
            this.Controls.Add(this.textTask);
            this.Controls.Add(this.Save);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox textTask;
        private System.Windows.Forms.TextBox textDepartament;
        private System.Windows.Forms.TextBox textNameEvent;
        private System.Windows.Forms.TextBox textEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}