﻿namespace GardenPlanner.New_Entirys
{
    partial class NewJournal
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
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.lblTitleRemaining = new System.Windows.Forms.Label();
            this.tbContent = new System.Windows.Forms.RichTextBox();
            this.lblContentRemaing = new System.Windows.Forms.Label();
            this.cbTag = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(12, 12);
            this.tbTitle.MaxLength = 50;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(306, 20);
            this.tbTitle.TabIndex = 0;
            this.tbTitle.Text = "Title";
            this.tbTitle.Click += new System.EventHandler(this.tbTitle_Click);
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(243, 235);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // lblTitleRemaining
            // 
            this.lblTitleRemaining.AutoSize = true;
            this.lblTitleRemaining.Location = new System.Drawing.Point(324, 15);
            this.lblTitleRemaining.Name = "lblTitleRemaining";
            this.lblTitleRemaining.Size = new System.Drawing.Size(25, 13);
            this.lblTitleRemaining.TabIndex = 2;
            this.lblTitleRemaining.Text = "(50)";
            // 
            // tbContent
            // 
            this.tbContent.Enabled = false;
            this.tbContent.Location = new System.Drawing.Point(12, 38);
            this.tbContent.MaxLength = 1000;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(306, 164);
            this.tbContent.TabIndex = 3;
            this.tbContent.Text = "Details";
            this.tbContent.Click += new System.EventHandler(this.tbContent_Click);
            this.tbContent.TextChanged += new System.EventHandler(this.tbContent_TextChanged);
            // 
            // lblContentRemaing
            // 
            this.lblContentRemaing.AutoSize = true;
            this.lblContentRemaing.Location = new System.Drawing.Point(324, 41);
            this.lblContentRemaing.Name = "lblContentRemaing";
            this.lblContentRemaing.Size = new System.Drawing.Size(37, 13);
            this.lblContentRemaing.TabIndex = 4;
            this.lblContentRemaing.Text = "(1000)";
            // 
            // cbTag
            // 
            this.cbTag.FormattingEnabled = true;
            this.cbTag.Location = new System.Drawing.Point(12, 208);
            this.cbTag.Name = "cbTag";
            this.cbTag.Size = new System.Drawing.Size(306, 21);
            this.cbTag.TabIndex = 5;
            this.cbTag.Text = "Tags";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // NewJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 270);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbTag);
            this.Controls.Add(this.lblContentRemaing);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.lblTitleRemaining);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.tbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewJournal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewJournal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label lblTitleRemaining;
        private System.Windows.Forms.RichTextBox tbContent;
        private System.Windows.Forms.Label lblContentRemaing;
        private System.Windows.Forms.ComboBox cbTag;
        private System.Windows.Forms.Button btnAdd;
    }
}