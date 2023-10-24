using System.ComponentModel;

namespace ATC
{
    partial class ChangePassword
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
            this.okButton = new System.Windows.Forms.Button();
            this.userText = new System.Windows.Forms.TextBox();
            this.userChooseBox = new System.Windows.Forms.ComboBox();
            this.newPasswordBox = new System.Windows.Forms.TextBox();
            this.newPasswordText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(86, 73);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(73, 26);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // userText
            // 
            this.userText.BackColor = System.Drawing.SystemColors.Menu;
            this.userText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userText.Location = new System.Drawing.Point(12, 17);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(100, 13);
            this.userText.TabIndex = 4;
            this.userText.Text = "Choose the user:";
            // 
            // userChooseBox
            // 
            this.userChooseBox.FormattingEnabled = true;
            this.userChooseBox.Location = new System.Drawing.Point(118, 14);
            this.userChooseBox.Name = "userChooseBox";
            this.userChooseBox.Size = new System.Drawing.Size(117, 21);
            this.userChooseBox.TabIndex = 5;
            foreach (var rate in User.LoginPassword)
            {
                this.userChooseBox.Items.Add(rate.Key);
            }
            // 
            // newPasswordBox
            // 
            this.newPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPasswordBox.Location = new System.Drawing.Point(118, 42);
            this.newPasswordBox.Name = "newPasswordBox";
            this.newPasswordBox.Size = new System.Drawing.Size(117, 20);
            this.newPasswordBox.TabIndex = 6;
            // 
            // newPasswordText
            // 
            this.newPasswordText.BackColor = System.Drawing.SystemColors.Menu;
            this.newPasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPasswordText.Location = new System.Drawing.Point(12, 44);
            this.newPasswordText.Name = "newPasswordText";
            this.newPasswordText.Size = new System.Drawing.Size(100, 13);
            this.newPasswordText.TabIndex = 7;
            this.newPasswordText.Text = "Enter new password:";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(244, 111);
            this.Controls.Add(this.newPasswordText);
            this.Controls.Add(this.newPasswordBox);
            this.Controls.Add(this.userChooseBox);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.okButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "ChangePassword";
            this.Text = "Change password";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox newPasswordBox;

        private System.Windows.Forms.ComboBox userChooseBox;
        private System.Windows.Forms.TextBox newPasswordText;

        private System.Windows.Forms.TextBox userText;

        private System.Windows.Forms.Button okButton;

        #endregion
    }
}