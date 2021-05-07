
namespace ImageAnalysisTool
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAddDir = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox = new System.Windows.Forms.RichTextBox();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.imgNameLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.fileInfoLabel = new System.Windows.Forms.Label();
            this.imageCatLabel = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.catLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "File";
            // 
            // toolStripFile
            // 
            this.toolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddDir});
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripFile.Text = "File";
            // 
            // toolStripAddDir
            // 
            this.toolStripAddDir.Name = "toolStripAddDir";
            this.toolStripAddDir.Size = new System.Drawing.Size(147, 22);
            this.toolStripAddDir.Text = "Add Directory";
            this.toolStripAddDir.Click += new System.EventHandler(this.toolStripAddDir_Click);
            // 
            // listBox
            // 
            this.listBox.Location = new System.Drawing.Point(0, 27);
            this.listBox.Name = "listBox";
            this.listBox.ReadOnly = true;
            this.listBox.Size = new System.Drawing.Size(161, 411);
            this.listBox.TabIndex = 1;
            this.listBox.Text = "";
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(167, 53);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(316, 244);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBox.TabIndex = 2;
            this.imgBox.TabStop = false;
            // 
            // imgNameLabel
            // 
            this.imgNameLabel.AutoSize = true;
            this.imgNameLabel.Location = new System.Drawing.Point(167, 27);
            this.imgNameLabel.Name = "imgNameLabel";
            this.imgNameLabel.Size = new System.Drawing.Size(89, 15);
            this.imgNameLabel.TabIndex = 3;
            this.imgNameLabel.Text = "Current Image: ";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(408, 314);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(167, 314);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 23);
            this.prevButton.TabIndex = 5;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // fileInfoLabel
            // 
            this.fileInfoLabel.AutoSize = true;
            this.fileInfoLabel.Location = new System.Drawing.Point(527, 53);
            this.fileInfoLabel.Name = "fileInfoLabel";
            this.fileInfoLabel.Size = new System.Drawing.Size(0, 15);
            this.fileInfoLabel.TabIndex = 6;
            // 
            // imageCatLabel
            // 
            this.imageCatLabel.AutoSize = true;
            this.imageCatLabel.Location = new System.Drawing.Point(168, 344);
            this.imageCatLabel.Name = "imageCatLabel";
            this.imageCatLabel.Size = new System.Drawing.Size(128, 15);
            this.imageCatLabel.TabIndex = 7;
            this.imageCatLabel.Text = "Put Image in Category:";
            // 
            // categoryBox
            // 
            this.categoryBox.Location = new System.Drawing.Point(168, 363);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(234, 23);
            this.categoryBox.TabIndex = 8;
            // 
            // catLabel
            // 
            this.catLabel.AutoSize = true;
            this.catLabel.Location = new System.Drawing.Point(168, 393);
            this.catLabel.Name = "catLabel";
            this.catLabel.Size = new System.Drawing.Size(66, 15);
            this.catLabel.TabIndex = 9;
            this.catLabel.Text = "Categories:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(409, 363);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(13, 445);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(137, 32);
            this.sortButton.TabIndex = 11;
            this.sortButton.Text = "Sort Options";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.catLabel);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.imageCatLabel);
            this.Controls.Add(this.fileInfoLabel);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.imgNameLabel);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripAddDir;
        private System.Windows.Forms.RichTextBox listBox;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Label imgNameLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Label fileInfoLabel;
        private System.Windows.Forms.Label imageCatLabel;
        private System.Windows.Forms.TextBox categoryBox;
        private System.Windows.Forms.Label catLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button sortButton;
    }
}