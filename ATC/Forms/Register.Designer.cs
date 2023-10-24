using System.ComponentModel;

namespace ATC
{
    partial class Register
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
            this.registerButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.phNumBox = new System.Windows.Forms.TextBox();
            this.phNumLabel = new System.Windows.Forms.Label();
            this.rateBox = new System.Windows.Forms.ComboBox();
            this.rateLabel = new System.Windows.Forms.Label();
            this.agreementLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.termsCheck = new System.Windows.Forms.CheckBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(156, 177);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(69, 25);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.Location = new System.Drawing.Point(71, 63);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(79, 20);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Login";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(71, 89);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(79, 20);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginBox
            // 
            this.loginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginBox.Location = new System.Drawing.Point(156, 63);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(110, 20);
            this.loginBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Location = new System.Drawing.Point(156, 89);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(110, 20);
            this.passwordBox.TabIndex = 4;
            // 
            // phNumBox
            // 
            this.phNumBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phNumBox.Location = new System.Drawing.Point(156, 37);
            this.phNumBox.Name = "phNumBox";
            this.phNumBox.Size = new System.Drawing.Size(110, 20);
            this.phNumBox.TabIndex = 5;
            // 
            // phNumLabel
            // 
            this.phNumLabel.Location = new System.Drawing.Point(71, 37);
            this.phNumLabel.Name = "phNumLabel";
            this.phNumLabel.Size = new System.Drawing.Size(79, 20);
            this.phNumLabel.TabIndex = 6;
            this.phNumLabel.Text = "Ph. Number";
            this.phNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rateBox
            // 
            this.rateBox.FormattingEnabled = true;
            this.rateBox.Location = new System.Drawing.Point(156, 115);
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(110, 21);
            this.rateBox.TabIndex = 7;
            // 
            // rateLabel
            // 
            this.rateLabel.Location = new System.Drawing.Point(71, 116);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(79, 20);
            this.rateLabel.TabIndex = 8;
            this.rateLabel.Text = "Rate";
            this.rateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // agreementLabel
            // 
            this.agreementLabel.Location = new System.Drawing.Point(71, 146);
            this.agreementLabel.Name = "agreementLabel";
            this.agreementLabel.Size = new System.Drawing.Size(116, 20);
            this.agreementLabel.TabIndex = 9;
            this.agreementLabel.Text = "I read ";
            this.agreementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(102, 150);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 23);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Terms of Use";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // termsCheck
            // 
            this.termsCheck.Location = new System.Drawing.Point(252, 151);
            this.termsCheck.Name = "termsCheck";
            this.termsCheck.Size = new System.Drawing.Size(14, 13);
            this.termsCheck.TabIndex = 11;
            this.termsCheck.Text = "checkBox1";
            this.termsCheck.UseVisualStyleBackColor = true;
            // 
            // nameBox
            // 
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Location = new System.Drawing.Point(156, 9);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(110, 20);
            this.nameBox.TabIndex = 13;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(71, 9);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(79, 20);
            this.nameText.TabIndex = 14;
            this.nameText.Text = "Name";
            this.nameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 213);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.termsCheck);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.agreementLabel);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.rateBox);
            this.Controls.Add(this.phNumLabel);
            this.Controls.Add(this.phNumBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.registerButton);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label nameText;

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.CheckBox termsCheck;

        private System.Windows.Forms.LinkLabel linkLabel1;

        private System.Windows.Forms.Label agreementLabel;

        private System.Windows.Forms.ComboBox rateBox;
        private System.Windows.Forms.Label rateLabel;


        private System.Windows.Forms.TextBox phNumBox;
        private System.Windows.Forms.Label phNumLabel;

        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;

        private System.Windows.Forms.Label passwordLabel;

        private System.Windows.Forms.Label loginLabel;

        private System.Windows.Forms.Button registerButton;

        #endregion
    }
}