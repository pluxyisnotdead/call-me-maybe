using System.ComponentModel;

namespace ATC
{
    partial class AdminPanel
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
            this.adminLogin = new System.Windows.Forms.Label();
            this.actionsBox = new System.Windows.Forms.GroupBox();
            this.changePassButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.newRateButton = new System.Windows.Forms.Button();
            this.addAdminButton = new System.Windows.Forms.Button();
            this.newUserBotton = new System.Windows.Forms.Button();
            this.loginBox = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.actionsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminLogin
            // 
            this.adminLogin.Location = new System.Drawing.Point(9, 12);
            this.adminLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(77, 18);
            this.adminLogin.TabIndex = 1;
            this.adminLogin.Text = "Admin login:";
            // 
            // actionsBox
            // 
            this.actionsBox.Controls.Add(this.changePassButton);
            this.actionsBox.Controls.Add(this.logOutButton);
            this.actionsBox.Controls.Add(this.newRateButton);
            this.actionsBox.Controls.Add(this.addAdminButton);
            this.actionsBox.Controls.Add(this.newUserBotton);
            this.actionsBox.Location = new System.Drawing.Point(11, 32);
            this.actionsBox.Margin = new System.Windows.Forms.Padding(2);
            this.actionsBox.Name = "actionsBox";
            this.actionsBox.Padding = new System.Windows.Forms.Padding(2);
            this.actionsBox.Size = new System.Drawing.Size(158, 188);
            this.actionsBox.TabIndex = 2;
            this.actionsBox.TabStop = false;
            this.actionsBox.Text = "Actions";
            // 
            // changePassButton
            // 
            this.changePassButton.Location = new System.Drawing.Point(4, 17);
            this.changePassButton.Margin = new System.Windows.Forms.Padding(2);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(150, 30);
            this.changePassButton.TabIndex = 0;
            this.changePassButton.Text = "Change password";
            this.changePassButton.UseVisualStyleBackColor = true;
            this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(4, 153);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(150, 30);
            this.logOutButton.TabIndex = 0;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // newRateButton
            // 
            this.newRateButton.Location = new System.Drawing.Point(4, 119);
            this.newRateButton.Margin = new System.Windows.Forms.Padding(2);
            this.newRateButton.Name = "newRateButton";
            this.newRateButton.Size = new System.Drawing.Size(150, 30);
            this.newRateButton.TabIndex = 0;
            this.newRateButton.Text = "Add new rate";
            this.newRateButton.UseVisualStyleBackColor = true;
            this.newRateButton.Click += new System.EventHandler(this.newRateButton_Click);
            // 
            // addAdminButton
            // 
            this.addAdminButton.Location = new System.Drawing.Point(4, 85);
            this.addAdminButton.Margin = new System.Windows.Forms.Padding(2);
            this.addAdminButton.Name = "addAdminButton";
            this.addAdminButton.Size = new System.Drawing.Size(150, 30);
            this.addAdminButton.TabIndex = 0;
            this.addAdminButton.Text = "Add new admin";
            this.addAdminButton.UseVisualStyleBackColor = true;
            this.addAdminButton.Click += new System.EventHandler(this.addAdminButton_Click);
            // 
            // newUserBotton
            // 
            this.newUserBotton.Location = new System.Drawing.Point(4, 51);
            this.newUserBotton.Margin = new System.Windows.Forms.Padding(2);
            this.newUserBotton.Name = "newUserBotton";
            this.newUserBotton.Size = new System.Drawing.Size(150, 30);
            this.newUserBotton.TabIndex = 0;
            this.newUserBotton.Text = "Add new user";
            this.newUserBotton.UseVisualStyleBackColor = true;
            this.newUserBotton.Click += new System.EventHandler(this.newUserBotton_Click);
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginBox.Location = new System.Drawing.Point(82, 8);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(85, 20);
            this.loginBox.TabIndex = 16;
            this.loginBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(179, 230);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.actionsBox);
            this.Controls.Add(this.adminLogin);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminPanel";
            this.actionsBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;

        private System.Windows.Forms.Button logOutButton;

        private System.Windows.Forms.Label loginBox;

        private System.Windows.Forms.Button addAdminButton;
        private System.Windows.Forms.Button newRateButton;

        private System.Windows.Forms.GroupBox actionsBox;
        private System.Windows.Forms.Button newUserBotton;
        private System.Windows.Forms.Button changePassButton;

        private System.Windows.Forms.Label adminLogin;


        #endregion
    }
}