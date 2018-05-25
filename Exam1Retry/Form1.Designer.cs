namespace Exam1Retry
{
    partial class Form1
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
            this.saveButton = new System.Windows.Forms.Button();
            this.showDataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.displayDataArea = new System.Windows.Forms.ListBox();
            this.fNameInputBox = new System.Windows.Forms.TextBox();
            this.lNameInputBox = new System.Windows.Forms.TextBox();
            this.ageInputBox = new System.Windows.Forms.TextBox();
            this.clearButtonPanel = new System.Windows.Forms.Panel();
            this.sortedButtonPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(56, 232);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showDataButton
            // 
            this.showDataButton.AutoSize = true;
            this.showDataButton.Enabled = false;
            this.showDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDataButton.Location = new System.Drawing.Point(161, 232);
            this.showDataButton.Name = "showDataButton";
            this.showDataButton.Size = new System.Drawing.Size(83, 26);
            this.showDataButton.TabIndex = 1;
            this.showDataButton.Text = "Show Data";
            this.showDataButton.UseVisualStyleBackColor = true;
            this.showDataButton.Click += new System.EventHandler(this.showDataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age:";
            // 
            // displayDataArea
            // 
            this.displayDataArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDataArea.FormattingEnabled = true;
            this.displayDataArea.ItemHeight = 16;
            this.displayDataArea.Location = new System.Drawing.Point(56, 276);
            this.displayDataArea.Name = "displayDataArea";
            this.displayDataArea.Size = new System.Drawing.Size(363, 212);
            this.displayDataArea.TabIndex = 5;
            // 
            // fNameInputBox
            // 
            this.fNameInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameInputBox.Location = new System.Drawing.Point(161, 30);
            this.fNameInputBox.Name = "fNameInputBox";
            this.fNameInputBox.Size = new System.Drawing.Size(100, 22);
            this.fNameInputBox.TabIndex = 6;
            // 
            // lNameInputBox
            // 
            this.lNameInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameInputBox.Location = new System.Drawing.Point(161, 94);
            this.lNameInputBox.Name = "lNameInputBox";
            this.lNameInputBox.Size = new System.Drawing.Size(100, 22);
            this.lNameInputBox.TabIndex = 7;
            // 
            // ageInputBox
            // 
            this.ageInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageInputBox.Location = new System.Drawing.Point(161, 159);
            this.ageInputBox.Name = "ageInputBox";
            this.ageInputBox.Size = new System.Drawing.Size(100, 22);
            this.ageInputBox.TabIndex = 8;
            // 
            // clearButtonPanel
            // 
            this.clearButtonPanel.Location = new System.Drawing.Point(56, 495);
            this.clearButtonPanel.Name = "clearButtonPanel";
            this.clearButtonPanel.Size = new System.Drawing.Size(188, 30);
            this.clearButtonPanel.TabIndex = 9;
            // 
            // sortedButtonPanel
            // 
            this.sortedButtonPanel.Location = new System.Drawing.Point(56, 531);
            this.sortedButtonPanel.Name = "sortedButtonPanel";
            this.sortedButtonPanel.Size = new System.Drawing.Size(188, 30);
            this.sortedButtonPanel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 588);
            this.Controls.Add(this.sortedButtonPanel);
            this.Controls.Add(this.clearButtonPanel);
            this.Controls.Add(this.ageInputBox);
            this.Controls.Add(this.lNameInputBox);
            this.Controls.Add(this.fNameInputBox);
            this.Controls.Add(this.displayDataArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showDataButton);
            this.Controls.Add(this.saveButton);
            this.Name = "Form1";
            this.Text = "Texas State Students";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showDataButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox displayDataArea;
        private System.Windows.Forms.TextBox fNameInputBox;
        private System.Windows.Forms.TextBox lNameInputBox;
        private System.Windows.Forms.TextBox ageInputBox;
        private System.Windows.Forms.Panel clearButtonPanel;
        private System.Windows.Forms.Panel sortedButtonPanel;
    }
}

