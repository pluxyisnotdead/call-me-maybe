using System.ComponentModel;

namespace ATC
{
    partial class NewRate
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
            this.nameText = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(129, 63);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(69, 25);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(12, 9);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(186, 20);
            this.nameText.TabIndex = 7;
            this.nameText.Text = "Name for new rate:";
            this.nameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceText
            // 
            this.priceText.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.priceText.Location = new System.Drawing.Point(12, 38);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(186, 19);
            this.priceText.TabIndex = 8;
            this.priceText.Text = "Price per minute for new rate:";
            // 
            // nameBox
            // 
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Location = new System.Drawing.Point(202, 11);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(110, 20);
            this.nameBox.TabIndex = 9;
            // 
            // priceBox
            // 
            this.priceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceBox.Location = new System.Drawing.Point(202, 36);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(110, 20);
            this.priceBox.TabIndex = 10;
            // 
            // NewRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 100);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.okButton);
            this.Name = "NewRate";
            this.Text = "New Rate";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox priceBox;

        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Label priceText;
        private System.Windows.Forms.Button okButton;

        #endregion
    }
}