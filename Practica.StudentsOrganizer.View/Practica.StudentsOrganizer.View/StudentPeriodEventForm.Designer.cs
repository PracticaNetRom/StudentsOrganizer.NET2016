namespace Practica.StudentsOrganizer.View
{
    partial class StudentPeriodEventForm
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
            this.textIdStud = new System.Windows.Forms.TextBox();
            this.textIdOcc = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IdStudent";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IdStudentOccurence";
            // 
            // textIdStud
            // 
            this.textIdStud.Location = new System.Drawing.Point(139, 29);
            this.textIdStud.Name = "textIdStud";
            this.textIdStud.Size = new System.Drawing.Size(225, 20);
            this.textIdStud.TabIndex = 3;
            // 
            // textIdOcc
            // 
            this.textIdOcc.Location = new System.Drawing.Point(139, 55);
            this.textIdOcc.Name = "textIdOcc";
            this.textIdOcc.Size = new System.Drawing.Size(225, 20);
            this.textIdOcc.TabIndex = 4;
            this.textIdOcc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(267, 262);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(97, 54);
            this.Save.TabIndex = 5;
            this.Save.Text = "SAVE";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // StudentPeriodEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 328);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.textIdOcc);
            this.Controls.Add(this.textIdStud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentPeriodEventForm";
            this.Text = "StudentPeriodEventForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIdStud;
        private System.Windows.Forms.TextBox textIdOcc;
        private System.Windows.Forms.Button Save;
    }
}