namespace Practica.StudentsOrganizer
{
    partial class OperationTablesForm
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
            this.Tables_Students_Button = new System.Windows.Forms.Button();
            this.Tables_Events_Button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tables_Students_Button
            // 
            this.Tables_Students_Button.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tables_Students_Button.Location = new System.Drawing.Point(20, 38);
            this.Tables_Students_Button.Name = "Tables_Students_Button";
            this.Tables_Students_Button.Size = new System.Drawing.Size(75, 23);
            this.Tables_Students_Button.TabIndex = 0;
            this.Tables_Students_Button.Text = "Students";
            this.Tables_Students_Button.UseVisualStyleBackColor = false;
            this.Tables_Students_Button.Click += new System.EventHandler(this.Tables_Students_Button_Click);
            // 
            // Tables_Events_Button
            // 
            this.Tables_Events_Button.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tables_Events_Button.Location = new System.Drawing.Point(20, 79);
            this.Tables_Events_Button.Name = "Tables_Events_Button";
            this.Tables_Events_Button.Size = new System.Drawing.Size(75, 23);
            this.Tables_Events_Button.TabIndex = 1;
            this.Tables_Events_Button.Text = "Events";
            this.Tables_Events_Button.UseVisualStyleBackColor = false;
            this.Tables_Events_Button.Click += new System.EventHandler(this.Tables_Events_Button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3.Location = new System.Drawing.Point(20, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Event Occurence";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.Tables_Students_Button);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.Tables_Events_Button);
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 240);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tables";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.Location = new System.Drawing.Point(20, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Student Event Occurence";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // OperationTablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 311);
            this.Controls.Add(this.groupBox1);
            this.Name = "OperationTablesForm";
            this.Text = "OperationTablesForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Tables_Students_Button;
        private System.Windows.Forms.Button Tables_Events_Button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
    }
}