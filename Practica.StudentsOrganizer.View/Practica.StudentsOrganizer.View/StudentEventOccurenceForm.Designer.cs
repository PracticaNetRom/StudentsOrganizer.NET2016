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
            this.textId = new System.Windows.Forms.TextBox();
            this.textEventId = new System.Windows.Forms.TextBox();
            this.textDataEnd = new System.Windows.Forms.TextBox();
            this.textDataStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(147, 12);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(186, 20);
            this.textId.TabIndex = 0;
            this.textId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textEventId
            // 
            this.textEventId.Location = new System.Drawing.Point(147, 38);
            this.textEventId.Name = "textEventId";
            this.textEventId.Size = new System.Drawing.Size(186, 20);
            this.textEventId.TabIndex = 1;
            // 
            // textDataEnd
            // 
            this.textDataEnd.Location = new System.Drawing.Point(147, 90);
            this.textDataEnd.Name = "textDataEnd";
            this.textDataEnd.Size = new System.Drawing.Size(186, 20);
            this.textDataEnd.TabIndex = 2;
            // 
            // textDataStart
            // 
            this.textDataStart.Location = new System.Drawing.Point(147, 64);
            this.textDataStart.Name = "textDataStart";
            this.textDataStart.Size = new System.Drawing.Size(186, 20);
            this.textDataStart.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "IdEvent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DataStart";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DataEnd";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(246, 257);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(87, 37);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // StudentEventOccurenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 306);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDataStart);
            this.Controls.Add(this.textDataEnd);
            this.Controls.Add(this.textEventId);
            this.Controls.Add(this.textId);
            this.Name = "StudentEventOccurenceForm";
            this.Text = "StudentEventOccurenceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textEventId;
        private System.Windows.Forms.TextBox textDataEnd;
        private System.Windows.Forms.TextBox textDataStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save;
    }
}