namespace SalaryCalculator
{
    partial class settings
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
            this.hourlyRateBox = new System.Windows.Forms.TextBox();
            this.extraSatBox = new System.Windows.Forms.TextBox();
            this.extraSunBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.extraWeekBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hourlyRateBox
            // 
            this.hourlyRateBox.Location = new System.Drawing.Point(279, 135);
            this.hourlyRateBox.Name = "hourlyRateBox";
            this.hourlyRateBox.Size = new System.Drawing.Size(52, 22);
            this.hourlyRateBox.TabIndex = 0;
            this.hourlyRateBox.Text = "0";
            this.hourlyRateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hourlyRateBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // extraSatBox
            // 
            this.extraSatBox.Location = new System.Drawing.Point(279, 206);
            this.extraSatBox.Name = "extraSatBox";
            this.extraSatBox.Size = new System.Drawing.Size(52, 22);
            this.extraSatBox.TabIndex = 1;
            this.extraSatBox.Text = "0";
            this.extraSatBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.extraSatBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // extraSunBox
            // 
            this.extraSunBox.Location = new System.Drawing.Point(279, 281);
            this.extraSunBox.Name = "extraSunBox";
            this.extraSunBox.Size = new System.Drawing.Size(52, 22);
            this.extraSunBox.TabIndex = 2;
            this.extraSunBox.Text = "0";
            this.extraSunBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.extraSunBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(65, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hourly Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(65, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Extra Saturday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(65, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Extra Sunday";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(385, 352);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(135, 57);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(65, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 62);
            this.label5.TabIndex = 9;
            this.label5.Text = "Extra week \r\nafter 18:00";
            // 
            // extraWeekBox
            // 
            this.extraWeekBox.Location = new System.Drawing.Point(279, 347);
            this.extraWeekBox.Name = "extraWeekBox";
            this.extraWeekBox.Size = new System.Drawing.Size(52, 22);
            this.extraWeekBox.TabIndex = 6;
            this.extraWeekBox.Text = "0";
            this.extraWeekBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.extraWeekBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 431);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.extraWeekBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.extraSunBox);
            this.Controls.Add(this.extraSatBox);
            this.Controls.Add(this.hourlyRateBox);
            this.Name = "settings";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hourlyRateBox;
        private System.Windows.Forms.TextBox extraSatBox;
        private System.Windows.Forms.TextBox extraSunBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox extraWeekBox;
    }
}