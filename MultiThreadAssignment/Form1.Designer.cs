namespace MultiThreadAssignment
{
    partial class Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ThreadTextBox = new System.Windows.Forms.TextBox();
            this.EntriesTextBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of threads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of generated entries";
            // 
            // ThreadTextBox
            // 
            this.ThreadTextBox.Location = new System.Drawing.Point(37, 47);
            this.ThreadTextBox.Name = "ThreadTextBox";
            this.ThreadTextBox.Size = new System.Drawing.Size(136, 26);
            this.ThreadTextBox.TabIndex = 2;
            // 
            // EntriesTextBox
            // 
            this.EntriesTextBox.Location = new System.Drawing.Point(237, 47);
            this.EntriesTextBox.Name = "EntriesTextBox";
            this.EntriesTextBox.Size = new System.Drawing.Size(202, 26);
            this.EntriesTextBox.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(40, 88);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(404, 41);
            this.progressBar1.TabIndex = 4;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(40, 163);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(133, 68);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(237, 163);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(133, 68);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 270);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.EntriesTextBox);
            this.Controls.Add(this.ThreadTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ThreadTextBox;
        private System.Windows.Forms.TextBox EntriesTextBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

