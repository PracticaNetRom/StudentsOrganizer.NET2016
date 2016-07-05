namespace Practica.StudentsOrganizer.View
{
    partial class AddEventOccurenceForm
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
            this.dateTimeStartData = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeEndData = new System.Windows.Forms.DateTimePicker();
            this.buttonSaveEventOcurence = new System.Windows.Forms.Button();
            this.intIdEvent = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(125, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Event Occurence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Event";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start Data";
            // 
            // dateTimeStartData
            // 
            this.dateTimeStartData.Location = new System.Drawing.Point(168, 111);
            this.dateTimeStartData.Name = "dateTimeStartData";
            this.dateTimeStartData.Size = new System.Drawing.Size(200, 20);
            this.dateTimeStartData.TabIndex = 4;
            this.dateTimeStartData.ValueChanged += new System.EventHandler(this.dateTimeStartData_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "End Data";
            // 
            // dateTimeEndData
            // 
            this.dateTimeEndData.Location = new System.Drawing.Point(168, 144);
            this.dateTimeEndData.Name = "dateTimeEndData";
            this.dateTimeEndData.Size = new System.Drawing.Size(200, 20);
            this.dateTimeEndData.TabIndex = 6;
            // 
            // buttonSaveEventOcurence
            // 
            this.buttonSaveEventOcurence.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSaveEventOcurence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveEventOcurence.Location = new System.Drawing.Point(168, 245);
            this.buttonSaveEventOcurence.Name = "buttonSaveEventOcurence";
            this.buttonSaveEventOcurence.Size = new System.Drawing.Size(99, 45);
            this.buttonSaveEventOcurence.TabIndex = 7;
            this.buttonSaveEventOcurence.Text = "SAVE";
            this.buttonSaveEventOcurence.UseVisualStyleBackColor = false;
            this.buttonSaveEventOcurence.Click += new System.EventHandler(this.buttonSaveEventOcurence_Click);
            // 
            // intIdEvent
            // 
            this.intIdEvent.Location = new System.Drawing.Point(168, 73);
            this.intIdEvent.Mask = "0000";
            this.intIdEvent.Name = "intIdEvent";
            this.intIdEvent.Size = new System.Drawing.Size(34, 20);
            this.intIdEvent.TabIndex = 8;
            // 
            // AddEventOccurenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(441, 331);
            this.Controls.Add(this.intIdEvent);
            this.Controls.Add(this.buttonSaveEventOcurence);
            this.Controls.Add(this.dateTimeEndData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeStartData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEventOccurenceForm";
            this.Text = "AddEventOccurenceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeStartData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeEndData;
        private System.Windows.Forms.Button buttonSaveEventOcurence;
        private System.Windows.Forms.MaskedTextBox intIdEvent;
    }
}