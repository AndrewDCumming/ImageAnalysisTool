
namespace ImageAnalysisTool
{
    partial class InitialForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.newButton.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.newButton.Location = new System.Drawing.Point(277, 228);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(245, 142);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "Start";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newButton);
            this.Name = "InitialForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newButton;
    }
}

