namespace ImageRecognition
{
    partial class MainForm
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
            this.beginBtn = new System.Windows.Forms.Button();
            this.fileUploadBtn = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // beginBtn
            // 
            this.beginBtn.Location = new System.Drawing.Point(324, 425);
            this.beginBtn.Name = "beginBtn";
            this.beginBtn.Size = new System.Drawing.Size(75, 36);
            this.beginBtn.TabIndex = 0;
            this.beginBtn.Text = "Detect!";
            this.beginBtn.UseVisualStyleBackColor = true;
            this.beginBtn.Click += new System.EventHandler(this.beginBtn_Click);
            // 
            // fileUploadBtn
            // 
            this.fileUploadBtn.Location = new System.Drawing.Point(416, 425);
            this.fileUploadBtn.Name = "fileUploadBtn";
            this.fileUploadBtn.Size = new System.Drawing.Size(72, 36);
            this.fileUploadBtn.TabIndex = 1;
            this.fileUploadBtn.Text = "Upload";
            this.fileUploadBtn.UseVisualStyleBackColor = true;
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(104, 12);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(609, 392);
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.fileUploadBtn);
            this.Controls.Add(this.beginBtn);
            this.Name = "MainForm";
            this.Text = "Image Recognition";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button beginBtn;
        private System.Windows.Forms.Button fileUploadBtn;
        private System.Windows.Forms.PictureBox imageBox;
    }
}

