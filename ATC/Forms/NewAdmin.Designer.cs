using System.ComponentModel;

namespace ATC
{
    partial class NewAdmin
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
            this.userChooseBox = new System.Windows.Forms.ComboBox();
            this.userText = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userChooseBox
            // 
            this.userChooseBox.FormattingEnabled = true;
            this.userChooseBox.Location = new System.Drawing.Point(118, 14);
            this.userChooseBox.Name = "userChooseBox";
            this.userChooseBox.Size = new System.Drawing.Size(117, 21);
            this.userChooseBox.TabIndex = 0;
            foreach (var rate in User.LoginPassword)
            {
                this.userChooseBox.Items.Add(rate.Key);
            }
            // 
            // userText
            // 
            this.userText.BackColor = System.Drawing.SystemColors.Menu;
            this.userText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userText.Location = new System.Drawing.Point(12, 17);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(100, 13);
            this.userText.TabIndex = 1;
            this.userText.Text = "Choose the user:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(78, 44);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(73, 26);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // NewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 82);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.userChooseBox);
            this.Name = "NewAdmin";
            this.Text = "Set new admin";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button okButton;

        private System.Windows.Forms.ComboBox userChooseBox;
        private System.Windows.Forms.TextBox userText;

        #endregion
    }
}