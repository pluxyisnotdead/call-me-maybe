using System.ComponentModel;

namespace ATC
{
    partial class Call
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.timeButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timeButton
            // 
            this.timeButton.Location = new System.Drawing.Point(159, 64);
            this.timeButton.Name = "timeButton";
            this.timeButton.Size = new System.Drawing.Size(69, 25);
            this.timeButton.TabIndex = 1;
            this.timeButton.Text = "Call";
            this.timeButton.UseVisualStyleBackColor = true;
            this.timeButton.Click += new System.EventHandler(this.timeButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.Location = new System.Drawing.Point(24, 32);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(204, 20);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "How many minutes will you talk to?";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeBox
            // 
            this.timeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeBox.Location = new System.Drawing.Point(269, 32);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(74, 20);
            this.timeBox.TabIndex = 4;
            // 
            // Call
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 96);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timeButton);
            this.Name = "Call";
            this.Text = "Call";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox timeBox;

        private System.Windows.Forms.Label timeLabel;

        private System.Windows.Forms.Button timeButton;

        #endregion
    }
}