using System.ComponentModel;
using System.Windows.Forms;

namespace ATC
{
    partial class Main
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
            this.actionsBox = new System.Windows.Forms.GroupBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.changeRateButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.refillBalanceButton = new System.Windows.Forms.Button();
            this.callButton = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.nameBox = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.Label();
            this.rateBox = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.Label();
            this.balanceBox = new System.Windows.Forms.Label();
            this.phBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phNumLabel = new System.Windows.Forms.Label();
            this.actionsBox.SuspendLayout();
            this.infoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionsBox
            // 
            this.actionsBox.Controls.Add(this.logOutButton);
            this.actionsBox.Controls.Add(this.changeRateButton);
            this.actionsBox.Controls.Add(this.billButton);
            this.actionsBox.Controls.Add(this.refillBalanceButton);
            this.actionsBox.Controls.Add(this.callButton);
            this.actionsBox.Location = new System.Drawing.Point(237, 12);
            this.actionsBox.Name = "actionsBox";
            this.actionsBox.Size = new System.Drawing.Size(135, 188);
            this.actionsBox.TabIndex = 0;
            this.actionsBox.TabStop = false;
            this.actionsBox.Text = "Actions";
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(18, 153);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(100, 29);
            this.logOutButton.TabIndex = 2;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // changeRateButton
            // 
            this.changeRateButton.Location = new System.Drawing.Point(18, 119);
            this.changeRateButton.Name = "changeRateButton";
            this.changeRateButton.Size = new System.Drawing.Size(100, 29);
            this.changeRateButton.TabIndex = 5;
            this.changeRateButton.Text = "Change the rate";
            this.changeRateButton.UseVisualStyleBackColor = true;
            this.changeRateButton.Click += new System.EventHandler(this.changeRateButton_Click);
            // 
            // billButton
            // 
            this.billButton.Location = new System.Drawing.Point(18, 84);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(100, 29);
            this.billButton.TabIndex = 4;
            this.billButton.Text = "Get a bill";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // refillBalanceButton
            // 
            this.refillBalanceButton.Location = new System.Drawing.Point(18, 49);
            this.refillBalanceButton.Name = "refillBalanceButton";
            this.refillBalanceButton.Size = new System.Drawing.Size(100, 29);
            this.refillBalanceButton.TabIndex = 3;
            this.refillBalanceButton.Text = "Refill balance";
            this.refillBalanceButton.UseVisualStyleBackColor = true;
            this.refillBalanceButton.Click += new System.EventHandler(this.refillBalanceButton_Click);
            // 
            // callButton
            // 
            this.callButton.Location = new System.Drawing.Point(18, 16);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(100, 29);
            this.callButton.TabIndex = 2;
            this.callButton.Text = "Call";
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.nameBox);
            this.infoBox.Controls.Add(this.nameText);
            this.infoBox.Controls.Add(this.rateBox);
            this.infoBox.Controls.Add(this.rateLabel);
            this.infoBox.Controls.Add(this.loginBox);
            this.infoBox.Controls.Add(this.balanceBox);
            this.infoBox.Controls.Add(this.phBox);
            this.infoBox.Controls.Add(this.label2);
            this.infoBox.Controls.Add(this.label1);
            this.infoBox.Controls.Add(this.phNumLabel);
            this.infoBox.Location = new System.Drawing.Point(10, 12);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(198, 188);
            this.infoBox.TabIndex = 1;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Info";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Location = new System.Drawing.Point(91, 123);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(101, 20);
            this.nameBox.TabIndex = 16;
            this.nameBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(6, 123);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(79, 20);
            this.nameText.TabIndex = 13;
            this.nameText.Text = "Name";
            this.nameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rateBox
            // 
            this.rateBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rateBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rateBox.Location = new System.Drawing.Point(91, 94);
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(101, 20);
            this.rateBox.TabIndex = 15;
            this.rateBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rateLabel
            // 
            this.rateLabel.Location = new System.Drawing.Point(6, 93);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(79, 20);
            this.rateLabel.TabIndex = 12;
            this.rateLabel.Text = "Rate";
            this.rateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBox.Location = new System.Drawing.Point(91, 42);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(101, 20);
            this.loginBox.TabIndex = 14;
            this.loginBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // balanceBox
            // 
            this.balanceBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.balanceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceBox.Location = new System.Drawing.Point(91, 68);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.Size = new System.Drawing.Size(101, 20);
            this.balanceBox.TabIndex = 13;
            this.balanceBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phBox
            // 
            this.phBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phBox.Location = new System.Drawing.Point(91, 16);
            this.phBox.Name = "phBox";
            this.phBox.Size = new System.Drawing.Size(101, 20);
            this.phBox.TabIndex = 12;
            this.phBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Balance";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phNumLabel
            // 
            this.phNumLabel.Location = new System.Drawing.Point(6, 16);
            this.phNumLabel.Name = "phNumLabel";
            this.phNumLabel.Size = new System.Drawing.Size(79, 20);
            this.phNumLabel.TabIndex = 7;
            this.phNumLabel.Text = "Ph. Number";
            this.phNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 205);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.actionsBox);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Main";
            this.Text = "Menu";
            this.actionsBox.ResumeLayout(false);
            this.infoBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Label nameBox;

        private System.Windows.Forms.Button logOutButton;




        private System.Windows.Forms.Button changeRateButton;
        private System.Windows.Forms.Button billButton;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label rateBox;
        private System.Windows.Forms.Label phBox;
        private System.Windows.Forms.Label balanceBox;
        private System.Windows.Forms.Label loginBox;
        private System.Windows.Forms.Button callButton;
        private System.Windows.Forms.Button refillBalanceButton;
        private System.Windows.Forms.Label phNumLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox actionsBox;
        private System.Windows.Forms.GroupBox infoBox;


        #endregion
    }
}