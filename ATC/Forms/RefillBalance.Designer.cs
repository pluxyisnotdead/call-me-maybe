using System.ComponentModel;

namespace ATC
{
    partial class RefillBalance
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
            this.refillLabel = new System.Windows.Forms.Label();
            this.refillBox = new System.Windows.Forms.TextBox();
            this.refillButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // refillLabel
            // 
            this.refillLabel.Location = new System.Drawing.Point(12, 9);
            this.refillLabel.Name = "refillLabel";
            this.refillLabel.Size = new System.Drawing.Size(204, 20);
            this.refillLabel.TabIndex = 3;
            this.refillLabel.Text = "How much money you want to spend?";
            this.refillLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // refillBox
            // 
            this.refillBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refillBox.Location = new System.Drawing.Point(254, 12);
            this.refillBox.Name = "refillBox";
            this.refillBox.Size = new System.Drawing.Size(74, 20);
            this.refillBox.TabIndex = 5;
            // 
            // refillButton
            // 
            this.refillButton.Location = new System.Drawing.Point(156, 39);
            this.refillButton.Name = "refillButton";
            this.refillButton.Size = new System.Drawing.Size(69, 25);
            this.refillButton.TabIndex = 6;
            this.refillButton.Text = "Refill";
            this.refillButton.UseVisualStyleBackColor = true;
            this.refillButton.Click += new System.EventHandler(this.refillButton_Click);
            // 
            // RefillBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 69);
            this.Controls.Add(this.refillButton);
            this.Controls.Add(this.refillBox);
            this.Controls.Add(this.refillLabel);
            this.Name = "RefillBalance";
            this.Text = "Refill Balance";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button refillButton;

        private System.Windows.Forms.TextBox refillBox;

        private System.Windows.Forms.Label refillLabel;

        #endregion
    }
}