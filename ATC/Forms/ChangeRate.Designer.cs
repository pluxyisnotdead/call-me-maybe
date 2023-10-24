using System.ComponentModel;

namespace ATC
{
    partial class ChangeRate
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
            this.agreementLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.termsCheck = new System.Windows.Forms.CheckBox();
            this.newRateLabel = new System.Windows.Forms.Label();
            this.rateBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agreementLabel
            // 
            this.agreementLabel.Location = new System.Drawing.Point(14, 39);
            this.agreementLabel.Name = "agreementLabel";
            this.agreementLabel.Size = new System.Drawing.Size(116, 20);
            this.agreementLabel.TabIndex = 10;
            this.agreementLabel.Text = "I read ";
            this.agreementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(45, 43);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 23);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Terms of Use";
            // 
            // termsCheck
            // 
            this.termsCheck.Location = new System.Drawing.Point(248, 45);
            this.termsCheck.Name = "termsCheck";
            this.termsCheck.Size = new System.Drawing.Size(14, 13);
            this.termsCheck.TabIndex = 12;
            this.termsCheck.Text = "checkBox1";
            this.termsCheck.UseVisualStyleBackColor = true;
            // 
            // newRateLabel
            // 
            this.newRateLabel.Location = new System.Drawing.Point(14, 18);
            this.newRateLabel.Name = "newRateLabel";
            this.newRateLabel.Size = new System.Drawing.Size(102, 21);
            this.newRateLabel.TabIndex = 13;
            this.newRateLabel.Text = "New rate:";
            // 
            // rateBox
            // 
            this.rateBox.FormattingEnabled = true;
            this.rateBox.Location = new System.Drawing.Point(166, 15);
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(96, 21);
            this.rateBox.TabIndex = 14;

            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(106, 69);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(73, 26);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ChangeRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 103);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.rateBox);
            this.Controls.Add(this.newRateLabel);
            this.Controls.Add(this.termsCheck);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.agreementLabel);
            this.Name = "ChangeRate";
            this.Text = "Change Rate";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button okButton;

        private System.Windows.Forms.CheckBox termsCheck;
        private System.Windows.Forms.Label newRateLabel;
        private System.Windows.Forms.ComboBox rateBox;

        private System.Windows.Forms.LinkLabel linkLabel1;

        private System.Windows.Forms.Label agreementLabel;

        #endregion
    }
}