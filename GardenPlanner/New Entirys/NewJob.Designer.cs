﻿namespace GardenPlanner.New_Entirys
{
    partial class NewJob
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbTag = new System.Windows.Forms.ComboBox();
            this.lblContentRemaing = new System.Windows.Forms.Label();
            this.tbContent = new System.Windows.Forms.RichTextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbTag
            // 
            this.cbTag.FormattingEnabled = true;
            this.cbTag.Location = new System.Drawing.Point(12, 208);
            this.cbTag.Name = "cbTag";
            this.cbTag.Size = new System.Drawing.Size(312, 21);
            this.cbTag.TabIndex = 2;
            this.cbTag.Text = "Tags";
            // 
            // lblContentRemaing
            // 
            this.lblContentRemaing.AutoSize = true;
            this.lblContentRemaing.Location = new System.Drawing.Point(330, 15);
            this.lblContentRemaing.Name = "lblContentRemaing";
            this.lblContentRemaing.Size = new System.Drawing.Size(31, 13);
            this.lblContentRemaing.TabIndex = 11;
            this.lblContentRemaing.Text = "(500)";
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(12, 12);
            this.tbContent.MaxLength = 500;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(312, 190);
            this.tbContent.TabIndex = 1;
            this.tbContent.Text = "";
            this.tbContent.TextChanged += new System.EventHandler(this.tbContent_TextChanged);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(249, 235);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 4;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // NewJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 270);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbTag);
            this.Controls.Add(this.lblContentRemaing);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.btnCancle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewJob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbTag;
        private System.Windows.Forms.Label lblContentRemaing;
        private System.Windows.Forms.RichTextBox tbContent;
        private System.Windows.Forms.Button btnCancle;
    }
}