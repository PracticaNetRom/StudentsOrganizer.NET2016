namespace Practica.StudentsOrganizer.View
{
    partial class AddStudentEventOccurence
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
            this.buttonSaveStdEvenOccu = new System.Windows.Forms.Button();
            this.intIDStudent = new System.Windows.Forms.MaskedTextBox();
            this.intIdEvent = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(70, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Student Event Occurence";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Event";
            // 
            // buttonSaveStdEvenOccu
            // 
            this.buttonSaveStdEvenOccu.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonSaveStdEvenOccu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveStdEvenOccu.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonSaveStdEvenOccu.Location = new System.Drawing.Point(143, 189);
            this.buttonSaveStdEvenOccu.Name = "buttonSaveStdEvenOccu";
            this.buttonSaveStdEvenOccu.Size = new System.Drawing.Size(90, 50);
            this.buttonSaveStdEvenOccu.TabIndex = 5;
            this.buttonSaveStdEvenOccu.Text = "SAVE";
            this.buttonSaveStdEvenOccu.UseVisualStyleBackColor = false;
            this.buttonSaveStdEvenOccu.Click += new System.EventHandler(this.buttonSaveStdEvenOccu_Click);
            // 
            // intIDStudent
            // 
            this.intIDStudent.Location = new System.Drawing.Point(143, 86);
            this.intIDStudent.Mask = "00000";
            this.intIDStudent.Name = "intIDStudent";
            this.intIDStudent.Size = new System.Drawing.Size(33, 20);
            this.intIDStudent.TabIndex = 6;
            this.intIDStudent.ValidatingType = typeof(int);
            // 
            // intIdEvent
            // 
            this.intIdEvent.Location = new System.Drawing.Point(143, 125);
            this.intIdEvent.Mask = "00000";
            this.intIdEvent.Name = "intIdEvent";
            this.intIdEvent.Size = new System.Drawing.Size(33, 20);
            this.intIdEvent.TabIndex = 7;
            this.intIdEvent.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.intIdEvent_MaskInputRejected);
            // 
            // AddStudentEventOccurence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(349, 280);
            this.Controls.Add(this.intIdEvent);
            this.Controls.Add(this.intIDStudent);
            this.Controls.Add(this.buttonSaveStdEvenOccu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStudentEventOccurence";
            this.Text = "AddStudentEventOccurence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveStdEvenOccu;
        private System.Windows.Forms.MaskedTextBox intIDStudent;
        private System.Windows.Forms.MaskedTextBox intIdEvent;
    }
}