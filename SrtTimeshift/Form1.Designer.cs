namespace SrtCombiner
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
            this.generateButton = new System.Windows.Forms.Button();
            this.firstSrtTextBox = new System.Windows.Forms.TextBox();
            this.secondSrtTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.videoFileTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstSrtButton = new System.Windows.Forms.Button();
            this.secondSrtButton = new System.Windows.Forms.Button();
            this.videoFileButton = new System.Windows.Forms.Button();
            this.firstSrtOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.secondSrtOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.firstVideoFileOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveCombinedSrtDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Enabled = false;
            this.generateButton.Location = new System.Drawing.Point(436, 113);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(112, 35);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate combined SRT";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // firstSrtTextBox
            // 
            this.firstSrtTextBox.Location = new System.Drawing.Point(131, 9);
            this.firstSrtTextBox.Name = "firstSrtTextBox";
            this.firstSrtTextBox.ReadOnly = true;
            this.firstSrtTextBox.Size = new System.Drawing.Size(285, 20);
            this.firstSrtTextBox.TabIndex = 1;
            // 
            // secondSrtTextBox
            // 
            this.secondSrtTextBox.Location = new System.Drawing.Point(131, 42);
            this.secondSrtTextBox.Name = "secondSrtTextBox";
            this.secondSrtTextBox.ReadOnly = true;
            this.secondSrtTextBox.Size = new System.Drawing.Size(285, 20);
            this.secondSrtTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "first srt subtitle file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "second srt subtitle file";
            // 
            // videoFileTextBox
            // 
            this.videoFileTextBox.Location = new System.Drawing.Point(131, 76);
            this.videoFileTextBox.Name = "videoFileTextBox";
            this.videoFileTextBox.ReadOnly = true;
            this.videoFileTextBox.Size = new System.Drawing.Size(285, 20);
            this.videoFileTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "first video file";
            // 
            // firstSrtButton
            // 
            this.firstSrtButton.Location = new System.Drawing.Point(436, 9);
            this.firstSrtButton.Name = "firstSrtButton";
            this.firstSrtButton.Size = new System.Drawing.Size(112, 20);
            this.firstSrtButton.TabIndex = 7;
            this.firstSrtButton.Text = "Browse";
            this.firstSrtButton.UseVisualStyleBackColor = true;
            this.firstSrtButton.Click += new System.EventHandler(this.firstSrtButton_Click);
            // 
            // secondSrtButton
            // 
            this.secondSrtButton.Location = new System.Drawing.Point(436, 42);
            this.secondSrtButton.Name = "secondSrtButton";
            this.secondSrtButton.Size = new System.Drawing.Size(112, 20);
            this.secondSrtButton.TabIndex = 8;
            this.secondSrtButton.Text = "Browse";
            this.secondSrtButton.UseVisualStyleBackColor = true;
            this.secondSrtButton.Click += new System.EventHandler(this.secondSrtButton_Click);
            // 
            // videoFileButton
            // 
            this.videoFileButton.Location = new System.Drawing.Point(436, 76);
            this.videoFileButton.Name = "videoFileButton";
            this.videoFileButton.Size = new System.Drawing.Size(112, 20);
            this.videoFileButton.TabIndex = 9;
            this.videoFileButton.Text = "Browse";
            this.videoFileButton.UseVisualStyleBackColor = true;
            this.videoFileButton.Click += new System.EventHandler(this.videoFileButton_Click);
            // 
            // firstSrtOpenFileDialog
            // 
            this.firstSrtOpenFileDialog.FileName = "openFileDialog1";
            this.firstSrtOpenFileDialog.Filter = "srt subtitle files|*.srt";
            // 
            // secondSrtOpenFileDialog
            // 
            this.secondSrtOpenFileDialog.FileName = "openFileDialog2";
            this.secondSrtOpenFileDialog.Filter = "srt subtitle files|*.srt";
            // 
            // firstVideoFileOpenFileDialog
            // 
            this.firstVideoFileOpenFileDialog.FileName = "openFileDialog3";
            this.firstVideoFileOpenFileDialog.Filter = "avi video files|*.avi";
            // 
            // saveCombinedSrtDialog
            // 
            this.saveCombinedSrtDialog.Filter = "srt subtitle files|*.srt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 159);
            this.Controls.Add(this.videoFileButton);
            this.Controls.Add(this.secondSrtButton);
            this.Controls.Add(this.firstSrtButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.videoFileTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondSrtTextBox);
            this.Controls.Add(this.firstSrtTextBox);
            this.Controls.Add(this.generateButton);
            this.Name = "Form1";
            this.Text = "srt combiner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox firstSrtTextBox;
        private System.Windows.Forms.TextBox secondSrtTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox videoFileTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button firstSrtButton;
        private System.Windows.Forms.Button secondSrtButton;
        private System.Windows.Forms.Button videoFileButton;
        private System.Windows.Forms.OpenFileDialog firstSrtOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog secondSrtOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog firstVideoFileOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog saveCombinedSrtDialog;
    }
}

