namespace Multithreading_Progress_Bar_5
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
            this.firstStart = new System.Windows.Forms.Button();
            this.firstPause = new System.Windows.Forms.Button();
            this.firstStop = new System.Windows.Forms.Button();
            this.secondStart = new System.Windows.Forms.Button();
            this.secondPause = new System.Windows.Forms.Button();
            this.secondStop = new System.Windows.Forms.Button();
            this.thirdStart = new System.Windows.Forms.Button();
            this.thirdPause = new System.Windows.Forms.Button();
            this.thirdStop = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // firstStart
            // 
            this.firstStart.Location = new System.Drawing.Point(64, 97);
            this.firstStart.Name = "firstStart";
            this.firstStart.Size = new System.Drawing.Size(62, 34);
            this.firstStart.TabIndex = 0;
            this.firstStart.Text = "Start";
            this.firstStart.UseVisualStyleBackColor = true;
            this.firstStart.Click += new System.EventHandler(this.firstStart_Click);
            // 
            // firstPause
            // 
            this.firstPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firstPause.Location = new System.Drawing.Point(171, 96);
            this.firstPause.Name = "firstPause";
            this.firstPause.Size = new System.Drawing.Size(65, 33);
            this.firstPause.TabIndex = 1;
            this.firstPause.Text = "||";
            this.firstPause.UseVisualStyleBackColor = true;
            this.firstPause.Click += new System.EventHandler(this.firstPause_Click);
            // 
            // firstStop
            // 
            this.firstStop.Location = new System.Drawing.Point(281, 97);
            this.firstStop.Name = "firstStop";
            this.firstStop.Size = new System.Drawing.Size(65, 33);
            this.firstStop.TabIndex = 3;
            this.firstStop.Text = "Stop";
            this.firstStop.UseVisualStyleBackColor = true;
            this.firstStop.Click += new System.EventHandler(this.firstStop_Click);
            // 
            // secondStart
            // 
            this.secondStart.Location = new System.Drawing.Point(64, 219);
            this.secondStart.Name = "secondStart";
            this.secondStart.Size = new System.Drawing.Size(65, 33);
            this.secondStart.TabIndex = 4;
            this.secondStart.Text = "Start";
            this.secondStart.UseVisualStyleBackColor = true;
            this.secondStart.Click += new System.EventHandler(this.secondStart_Click);
            // 
            // secondPause
            // 
            this.secondPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secondPause.Location = new System.Drawing.Point(171, 219);
            this.secondPause.Name = "secondPause";
            this.secondPause.Size = new System.Drawing.Size(65, 33);
            this.secondPause.TabIndex = 5;
            this.secondPause.Text = "||";
            this.secondPause.UseVisualStyleBackColor = true;
            this.secondPause.Click += new System.EventHandler(this.secondPause_Click);
            // 
            // secondStop
            // 
            this.secondStop.Location = new System.Drawing.Point(281, 220);
            this.secondStop.Name = "secondStop";
            this.secondStop.Size = new System.Drawing.Size(65, 33);
            this.secondStop.TabIndex = 7;
            this.secondStop.Text = "Stop";
            this.secondStop.UseVisualStyleBackColor = true;
            this.secondStop.Click += new System.EventHandler(this.secondStop_Click);
            // 
            // thirdStart
            // 
            this.thirdStart.Location = new System.Drawing.Point(61, 350);
            this.thirdStart.Name = "thirdStart";
            this.thirdStart.Size = new System.Drawing.Size(65, 33);
            this.thirdStart.TabIndex = 8;
            this.thirdStart.Text = "Start";
            this.thirdStart.UseVisualStyleBackColor = true;
            this.thirdStart.Click += new System.EventHandler(this.thirdStart_Click);
            // 
            // thirdPause
            // 
            this.thirdPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.thirdPause.Location = new System.Drawing.Point(171, 350);
            this.thirdPause.Name = "thirdPause";
            this.thirdPause.Size = new System.Drawing.Size(65, 33);
            this.thirdPause.TabIndex = 10;
            this.thirdPause.Text = "||";
            this.thirdPause.UseVisualStyleBackColor = true;
            this.thirdPause.Click += new System.EventHandler(this.thirdPause_Click_1);
            // 
            // thirdStop
            // 
            this.thirdStop.Location = new System.Drawing.Point(281, 350);
            this.thirdStop.Name = "thirdStop";
            this.thirdStop.Size = new System.Drawing.Size(65, 33);
            this.thirdStop.TabIndex = 11;
            this.thirdStop.Text = "Stop";
            this.thirdStop.UseVisualStyleBackColor = true;
            this.thirdStop.Click += new System.EventHandler(this.thirdStop_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(37, 30);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(350, 43);
            this.progressBar1.TabIndex = 12;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(37, 156);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(350, 43);
            this.progressBar2.TabIndex = 13;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(37, 287);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(350, 43);
            this.progressBar3.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 425);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.thirdStop);
            this.Controls.Add(this.thirdPause);
            this.Controls.Add(this.thirdStart);
            this.Controls.Add(this.secondStop);
            this.Controls.Add(this.secondPause);
            this.Controls.Add(this.secondStart);
            this.Controls.Add(this.firstStop);
            this.Controls.Add(this.firstPause);
            this.Controls.Add(this.firstStart);
            this.Name = "Form1";
            this.Text = "Multithreading";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button firstStart;
        private System.Windows.Forms.Button firstPause;
        private System.Windows.Forms.Button firstStop;
        private System.Windows.Forms.Button secondStart;
        private System.Windows.Forms.Button secondPause;
        private System.Windows.Forms.Button secondStop;
        private System.Windows.Forms.Button thirdStart;
        private System.Windows.Forms.Button thirdPause;
        private System.Windows.Forms.Button thirdStop;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
    }
}

