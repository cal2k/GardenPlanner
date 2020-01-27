namespace GardenPlanner
{
    partial class CreateTag
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
            this.btnAddTag = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.tbTag = new System.Windows.Forms.TextBox();
            this.lblRemaning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddTag
            // 
            this.btnAddTag.Enabled = false;
            this.btnAddTag.Location = new System.Drawing.Point(12, 38);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(75, 23);
            this.btnAddTag.TabIndex = 0;
            this.btnAddTag.Text = "Add tag";
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(89, 38);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // tbTag
            // 
            this.tbTag.Location = new System.Drawing.Point(12, 12);
            this.tbTag.MaxLength = 30;
            this.tbTag.Name = "tbTag";
            this.tbTag.Size = new System.Drawing.Size(121, 20);
            this.tbTag.TabIndex = 2;
            this.tbTag.Click += new System.EventHandler(this.tbTag_Click);
            this.tbTag.TextChanged += new System.EventHandler(this.tbTag_TextChanged);
            // 
            // lblRemaning
            // 
            this.lblRemaning.AutoSize = true;
            this.lblRemaning.Location = new System.Drawing.Point(139, 15);
            this.lblRemaning.Name = "lblRemaning";
            this.lblRemaning.Size = new System.Drawing.Size(25, 13);
            this.lblRemaning.TabIndex = 3;
            this.lblRemaning.Text = "(30)";
            // 
            // CreateTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 73);
            this.Controls.Add(this.lblRemaning);
            this.Controls.Add(this.tbTag);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnAddTag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateTag";
            this.Text = "CreateTag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TextBox tbTag;
        private System.Windows.Forms.Label lblRemaning;
    }
}