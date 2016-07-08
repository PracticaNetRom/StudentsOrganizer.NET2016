namespace Practica.StudentsOrganizer.View
{
    partial class AddEvenimentForm
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
            this.txtTask = new System.Windows.Forms.TextBox();
            this.buttonSaveEvent = new System.Windows.Forms.Button();
            this.comboBoxDepart = new System.Windows.Forms.ComboBox();
            this.txtEventName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(190, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Task";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 141);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(192, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Department or Technology";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(172, 105);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(232, 20);
            this.txtTask.TabIndex = 11;
            // 
            // buttonSaveEvent
            // 
            this.buttonSaveEvent.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonSaveEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveEvent.Location = new System.Drawing.Point(193, 262);
            this.buttonSaveEvent.Name = "buttonSaveEvent";
            this.buttonSaveEvent.Size = new System.Drawing.Size(100, 40);
            this.buttonSaveEvent.TabIndex = 12;
            this.buttonSaveEvent.Text = "SAVE";
            this.buttonSaveEvent.UseVisualStyleBackColor = false;
            // 
            // comboBoxDepart
            // 
            this.comboBoxDepart.FormattingEnabled = true;
            this.comboBoxDepart.Items.AddRange(new object[] {
            "C",
            "C++",
            "C#",
            "Java",
            "iOS",
            "Android"});
            this.comboBoxDepart.Location = new System.Drawing.Point(260, 136);
            this.comboBoxDepart.Name = "comboBoxDepart";
            this.comboBoxDepart.Size = new System.Drawing.Size(44, 21);
            this.comboBoxDepart.TabIndex = 13;
            this.comboBoxDepart.Text = "C#";
            // 
            // txtEventName
            // 
            this.txtEventName.FormattingEnabled = true;
            this.txtEventName.Items.AddRange(new object[] {
            "Intership",
            "Practica",
            "Academie",
            "CodeGolf"});
            this.txtEventName.Location = new System.Drawing.Point(172, 70);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(232, 21);
            this.txtEventName.TabIndex = 14;
            this.txtEventName.Text = "Practica";
            // 
            // AddEvenimentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(484, 341);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.comboBoxDepart);
            this.Controls.Add(this.buttonSaveEvent);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEvenimentForm";
            this.Text = "AddEvenimentForm";
            this.Load += new System.EventHandler(this.AddEvenimentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button buttonSaveEvent;
        private System.Windows.Forms.ComboBox comboBoxDepart;
        private System.Windows.Forms.ComboBox txtEventName;
    }
}