namespace SalaryCalculator
{
    partial class calculator
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hoursWeekBefore18 = new System.Windows.Forms.TextBox();
            this.hoursWeekAfter18 = new System.Windows.Forms.TextBox();
            this.hoursSat = new System.Windows.Forms.TextBox();
            this.hoursSun = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hours Worked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(45, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weekdays before 18:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(45, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weekdays after 18:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(123, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 31);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(45, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Saturday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(45, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sunday";
            // 
            // hoursWeekBefore18
            // 
            this.hoursWeekBefore18.Location = new System.Drawing.Point(402, 162);
            this.hoursWeekBefore18.Name = "hoursWeekBefore18";
            this.hoursWeekBefore18.Size = new System.Drawing.Size(49, 22);
            this.hoursWeekBefore18.TabIndex = 6;
            this.hoursWeekBefore18.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // hoursWeekAfter18
            // 
            this.hoursWeekAfter18.Location = new System.Drawing.Point(402, 218);
            this.hoursWeekAfter18.Name = "hoursWeekAfter18";
            this.hoursWeekAfter18.Size = new System.Drawing.Size(49, 22);
            this.hoursWeekAfter18.TabIndex = 7;
            this.hoursWeekAfter18.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // hoursSat
            // 
            this.hoursSat.Location = new System.Drawing.Point(402, 270);
            this.hoursSat.Name = "hoursSat";
            this.hoursSat.Size = new System.Drawing.Size(49, 22);
            this.hoursSat.TabIndex = 8;
            this.hoursSat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // hoursSun
            // 
            this.hoursSun.Location = new System.Drawing.Point(402, 320);
            this.hoursSun.Name = "hoursSun";
            this.hoursSun.Size = new System.Drawing.Size(49, 22);
            this.hoursSun.TabIndex = 9;
            this.hoursSun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.calculateButton.Location = new System.Drawing.Point(390, 374);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(128, 51);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 449);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.hoursSun);
            this.Controls.Add(this.hoursSat);
            this.Controls.Add(this.hoursWeekAfter18);
            this.Controls.Add(this.hoursWeekBefore18);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "calculator";
            this.Text = "calculator";
            this.Load += new System.EventHandler(this.calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hoursWeekBefore18;
        private System.Windows.Forms.TextBox hoursWeekAfter18;
        private System.Windows.Forms.TextBox hoursSat;
        private System.Windows.Forms.TextBox hoursSun;
        private System.Windows.Forms.Button calculateButton;
    }
}