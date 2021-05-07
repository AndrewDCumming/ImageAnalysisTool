﻿
namespace ImageAnalysisTool
{
    partial class SortingForm
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
            this.manufacturerBox = new System.Windows.Forms.CheckBox();
            this.modelBox = new System.Windows.Forms.CheckBox();
            this.monthBox = new System.Windows.Forms.CheckBox();
            this.dayBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.CheckBox();
            this.locationBox = new System.Windows.Forms.CheckBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manufacturerBox
            // 
            this.manufacturerBox.AutoSize = true;
            this.manufacturerBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manufacturerBox.Location = new System.Drawing.Point(31, 54);
            this.manufacturerBox.Name = "manufacturerBox";
            this.manufacturerBox.Size = new System.Drawing.Size(242, 29);
            this.manufacturerBox.TabIndex = 3;
            this.manufacturerBox.Text = "Equipment Manufacturer";
            this.manufacturerBox.UseVisualStyleBackColor = true;
            // 
            // modelBox
            // 
            this.modelBox.AutoSize = true;
            this.modelBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelBox.Location = new System.Drawing.Point(31, 89);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(181, 29);
            this.modelBox.TabIndex = 4;
            this.modelBox.Text = "Equipment Model";
            this.modelBox.UseVisualStyleBackColor = true;
            // 
            // monthBox
            // 
            this.monthBox.AutoSize = true;
            this.monthBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthBox.Location = new System.Drawing.Point(31, 159);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(87, 29);
            this.monthBox.TabIndex = 5;
            this.monthBox.Text = "Month";
            this.monthBox.UseVisualStyleBackColor = true;
            // 
            // dayBox
            // 
            this.dayBox.AutoSize = true;
            this.dayBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dayBox.Location = new System.Drawing.Point(31, 194);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(63, 29);
            this.dayBox.TabIndex = 6;
            this.dayBox.Text = "Day";
            this.dayBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sort By:";
            // 
            // yearBox
            // 
            this.yearBox.AutoSize = true;
            this.yearBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearBox.Location = new System.Drawing.Point(31, 124);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(67, 29);
            this.yearBox.TabIndex = 8;
            this.yearBox.Text = "Year";
            this.yearBox.UseVisualStyleBackColor = true;
            // 
            // locationBox
            // 
            this.locationBox.AutoSize = true;
            this.locationBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.locationBox.Location = new System.Drawing.Point(31, 229);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(103, 29);
            this.locationBox.TabIndex = 9;
            this.locationBox.Text = "Location";
            this.locationBox.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            this.sortButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortButton.Location = new System.Drawing.Point(58, 326);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(154, 36);
            this.sortButton.TabIndex = 10;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // SortingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 469);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.manufacturerBox);
            this.Name = "SortingForm";
            this.Text = "SortingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox manufacturerBox;
        private System.Windows.Forms.CheckBox modelBox;
        private System.Windows.Forms.CheckBox monthBox;
        private System.Windows.Forms.CheckBox dayBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox yearBox;
        private System.Windows.Forms.CheckBox locationBox;
        private System.Windows.Forms.Button sortButton;
    }
}