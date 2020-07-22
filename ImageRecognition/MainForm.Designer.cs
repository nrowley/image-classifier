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
            this.components = new System.ComponentModel.Container();
            this.beginBtn = new System.Windows.Forms.Button();
            this.fileUploadBtn = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.resultGridView = new System.Windows.Forms.DataGridView();
            this.yoloItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confidenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoloItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // beginBtn
            // 
            this.beginBtn.Location = new System.Drawing.Point(330, 588);
            this.beginBtn.Name = "beginBtn";
            this.beginBtn.Size = new System.Drawing.Size(75, 36);
            this.beginBtn.TabIndex = 0;
            this.beginBtn.Text = "Detect!";
            this.beginBtn.UseVisualStyleBackColor = true;
            this.beginBtn.Click += new System.EventHandler(this.beginBtn_Click);
            // 
            // fileUploadBtn
            // 
            this.fileUploadBtn.Location = new System.Drawing.Point(422, 588);
            this.fileUploadBtn.Name = "fileUploadBtn";
            this.fileUploadBtn.Size = new System.Drawing.Size(72, 36);
            this.fileUploadBtn.TabIndex = 1;
            this.fileUploadBtn.Text = "Upload";
            this.fileUploadBtn.UseVisualStyleBackColor = true;
            this.fileUploadBtn.Click += new System.EventHandler(this.fileUploadBtn_Click);
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(104, 12);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(609, 392);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            // 
            // resultGridView
            // 
            this.resultGridView.AutoGenerateColumns = false;
            this.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.confidenceDataGridViewTextBoxColumn,
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn});
            this.resultGridView.DataSource = this.yoloItemBindingSource;
            this.resultGridView.Location = new System.Drawing.Point(104, 410);
            this.resultGridView.Name = "resultGridView";
            this.resultGridView.Size = new System.Drawing.Size(609, 150);
            this.resultGridView.TabIndex = 3;
            // 
            // yoloItemBindingSource
            // 
            this.yoloItemBindingSource.DataSource = typeof(Alturos.Yolo.Model.YoloItem);
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // confidenceDataGridViewTextBoxColumn
            // 
            this.confidenceDataGridViewTextBoxColumn.DataPropertyName = "Confidence";
            this.confidenceDataGridViewTextBoxColumn.HeaderText = "Confidence";
            this.confidenceDataGridViewTextBoxColumn.Name = "confidenceDataGridViewTextBoxColumn";
            // 
            // xDataGridViewTextBoxColumn
            // 
            this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
            this.xDataGridViewTextBoxColumn.HeaderText = "X";
            this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            // 
            // yDataGridViewTextBoxColumn
            // 
            this.yDataGridViewTextBoxColumn.DataPropertyName = "Y";
            this.yDataGridViewTextBoxColumn.HeaderText = "Y";
            this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.resultGridView);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.fileUploadBtn);
            this.Controls.Add(this.beginBtn);
            this.Name = "MainForm";
            this.Text = "Image Recognition";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoloItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button beginBtn;
        private System.Windows.Forms.Button fileUploadBtn;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.DataGridView resultGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confidenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource yoloItemBindingSource;
    }
}

