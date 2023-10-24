using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace ATC
{
    partial class Bill
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
            this.billLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // billLabel
            // 
            this.billLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.billLabel.Location = new System.Drawing.Point(9, 10);
            this.billLabel.Name = "billLabel";
            this.billLabel.Text += "Login: " + Main.Login + "\n";
            this.billLabel.Text += "Ph. Number: " + User.LoginPhNum[Main.Login] + "\n";
            this.billLabel.Text += "Rate: " + User.LoginRate[Main.Login] + "\n";
            this.billLabel.Text += "\n\nCall history\n______________________________________\n";
            this.billLabel.Text += "Date | Call time | Price\n\n";
            this.billLabel.Text += User.LoginCalls[Main.Login];
            this.billLabel.Text += "\n\n\n\n\nRefill history\n______________________________________\n";
            this.billLabel.Text += "Date | Amount of money\n\n";
            this.billLabel.Text += User.LoginRefills[Main.Login];
            this.billLabel.Size = new System.Drawing.Size(277, 431);
            this.billLabel.TabIndex = 0;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 450);
            this.Controls.Add(this.billLabel);
            this.Name = "Bill";
            this.Text = "Bill";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label billLabel;

        #endregion
    }
}