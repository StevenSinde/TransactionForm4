﻿namespace TransactionForm4
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.CityButton = new System.Windows.Forms.Button();
            this.ClearCache = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(159, 90);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Get Names";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(71, 146);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(533, 368);
            this.ListBox.TabIndex = 1;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(293, 93);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(100, 20);
            this.TextBox.TabIndex = 2;
            // 
            // CityButton
            // 
            this.CityButton.Location = new System.Drawing.Point(443, 90);
            this.CityButton.Name = "CityButton";
            this.CityButton.Size = new System.Drawing.Size(75, 23);
            this.CityButton.TabIndex = 3;
            this.CityButton.Text = "Get City";
            this.CityButton.UseVisualStyleBackColor = true;
            this.CityButton.Click += new System.EventHandler(this.CityButton_Click);
            // 
            // ClearCache
            // 
            this.ClearCache.Location = new System.Drawing.Point(308, 45);
            this.ClearCache.Name = "ClearCache";
            this.ClearCache.Size = new System.Drawing.Size(75, 23);
            this.ClearCache.TabIndex = 4;
            this.ClearCache.Text = "Clear Cache";
            this.ClearCache.UseVisualStyleBackColor = true;
            this.ClearCache.Click += new System.EventHandler(this.ClearCache_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 546);
            this.Controls.Add(this.ClearCache);
            this.Controls.Add(this.CityButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.SearchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button CityButton;
        private System.Windows.Forms.Button ClearCache;
    }
}

