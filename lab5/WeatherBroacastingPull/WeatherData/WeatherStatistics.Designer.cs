﻿namespace WeatherBroadcast
{
    partial class WeatherStatistics
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
            this.avgTemp = new System.Windows.Forms.Label();
            this.maxTemp = new System.Windows.Forms.Label();
            this.minTemp = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.unsubscribe = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUpdateCount = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Average Temp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max Temp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Min Temp";
            // 
            // avgTemp
            // 
            this.avgTemp.AutoSize = true;
            this.avgTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgTemp.Location = new System.Drawing.Point(206, 125);
            this.avgTemp.Name = "avgTemp";
            this.avgTemp.Size = new System.Drawing.Size(0, 20);
            this.avgTemp.TabIndex = 3;
            // 
            // maxTemp
            // 
            this.maxTemp.AutoSize = true;
            this.maxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTemp.Location = new System.Drawing.Point(206, 172);
            this.maxTemp.Name = "maxTemp";
            this.maxTemp.Size = new System.Drawing.Size(0, 20);
            this.maxTemp.TabIndex = 4;
            // 
            // minTemp
            // 
            this.minTemp.AutoSize = true;
            this.minTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTemp.Location = new System.Drawing.Point(206, 222);
            this.minTemp.Name = "minTemp";
            this.minTemp.Size = new System.Drawing.Size(0, 20);
            this.minTemp.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(123, 277);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(125, 27);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.register_Click);
            // 
            // unsubscribe
            // 
            this.unsubscribe.Location = new System.Drawing.Point(123, 320);
            this.unsubscribe.Name = "unsubscribe";
            this.unsubscribe.Size = new System.Drawing.Size(125, 30);
            this.unsubscribe.TabIndex = 7;
            this.unsubscribe.Text = "Unsubscribe";
            this.unsubscribe.UseVisualStyleBackColor = true;
            this.unsubscribe.Click += new System.EventHandler(this.unsubscribe_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Weather Statistics";
            // 
            // lblUpdateCount
            // 
            this.lblUpdateCount.AutoSize = true;
            this.lblUpdateCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateCount.Location = new System.Drawing.Point(206, 80);
            this.lblUpdateCount.Name = "lblUpdateCount";
            this.lblUpdateCount.Size = new System.Drawing.Size(0, 20);
            this.lblUpdateCount.TabIndex = 9;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(49, 80);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(108, 20);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "Update Times";
            // 
            // WeatherStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 377);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblUpdateCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.unsubscribe);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.minTemp);
            this.Controls.Add(this.maxTemp);
            this.Controls.Add(this.avgTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WeatherStatistics";
            this.Text = "WeatherStatistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label avgTemp;
        private System.Windows.Forms.Label maxTemp;
        private System.Windows.Forms.Label minTemp;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button unsubscribe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUpdateCount;
        private System.Windows.Forms.Label lblCount;
    }
}