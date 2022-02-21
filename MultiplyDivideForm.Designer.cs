namespace Multiform_Calculator
{
    partial class MultiplyDivideForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.closeButton = new System.Windows.Forms.Button();
            this.resultDescriptionLabel2 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultdescriptionLabel = new System.Windows.Forms.Label();
            this.secondNumberDescriptionLabel = new System.Windows.Forms.Label();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.divideButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.firstNumberDescriptionlabel = new System.Windows.Forms.Label();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(495, 127);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(54, 27);
            this.closeButton.TabIndex = 19;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // resultDescriptionLabel2
            // 
            this.resultDescriptionLabel2.Location = new System.Drawing.Point(388, 41);
            this.resultDescriptionLabel2.Name = "resultDescriptionLabel2";
            this.resultDescriptionLabel2.Size = new System.Drawing.Size(95, 19);
            this.resultDescriptionLabel2.TabIndex = 18;
            this.resultDescriptionLabel2.Text = "Result";
            this.resultDescriptionLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(394, 67);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(89, 16);
            this.resultLabel.TabIndex = 17;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultdescriptionLabel
            // 
            this.resultdescriptionLabel.AutoSize = true;
            this.resultdescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultdescriptionLabel.Location = new System.Drawing.Point(334, 63);
            this.resultdescriptionLabel.Name = "resultdescriptionLabel";
            this.resultdescriptionLabel.Size = new System.Drawing.Size(22, 24);
            this.resultdescriptionLabel.TabIndex = 16;
            this.resultdescriptionLabel.Text = "=";
            // 
            // secondNumberDescriptionLabel
            // 
            this.secondNumberDescriptionLabel.Location = new System.Drawing.Point(211, 41);
            this.secondNumberDescriptionLabel.Name = "secondNumberDescriptionLabel";
            this.secondNumberDescriptionLabel.Size = new System.Drawing.Size(108, 19);
            this.secondNumberDescriptionLabel.TabIndex = 15;
            this.secondNumberDescriptionLabel.Text = "Second Number";
            this.secondNumberDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(226, 63);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(73, 20);
            this.secondNumberTextBox.TabIndex = 14;
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideButton.Location = new System.Drawing.Point(144, 75);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(46, 41);
            this.divideButton.TabIndex = 13;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.Location = new System.Drawing.Point(144, 28);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(46, 41);
            this.multiplyButton.TabIndex = 12;
            this.multiplyButton.Text = "X";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // firstNumberDescriptionlabel
            // 
            this.firstNumberDescriptionlabel.Location = new System.Drawing.Point(36, 41);
            this.firstNumberDescriptionlabel.Name = "firstNumberDescriptionlabel";
            this.firstNumberDescriptionlabel.Size = new System.Drawing.Size(67, 19);
            this.firstNumberDescriptionlabel.TabIndex = 11;
            this.firstNumberDescriptionlabel.Text = "First Number";
            this.firstNumberDescriptionlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(30, 63);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(73, 20);
            this.firstNumberTextBox.TabIndex = 10;
            // 
            // MultiplyDivideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 186);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.resultDescriptionLabel2);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultdescriptionLabel);
            this.Controls.Add(this.secondNumberDescriptionLabel);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.firstNumberDescriptionlabel);
            this.Controls.Add(this.firstNumberTextBox);
            this.Name = "MultiplyDivideForm";
            this.Text = "MultiplyDivide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label resultDescriptionLabel2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label resultdescriptionLabel;
        private System.Windows.Forms.Label secondNumberDescriptionLabel;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Label firstNumberDescriptionlabel;
        private System.Windows.Forms.TextBox firstNumberTextBox;
    }
}