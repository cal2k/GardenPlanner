namespace GardenPlanner.Details
{
    partial class Job
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
            this.tbContent = new System.Windows.Forms.RichTextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbltag = new System.Windows.Forms.Label();
            this.btnRemoveTag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbTag
            // 
            this.cbTag.FormattingEnabled = true;
            this.cbTag.Location = new System.Drawing.Point(12, 91);
            this.cbTag.Name = "cbTag";
            this.cbTag.Size = new System.Drawing.Size(231, 21);
            this.cbTag.TabIndex = 6;
            this.cbTag.Text = "Tags";
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(12, 12);
            this.tbContent.MaxLength = 50;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(312, 73);
            this.tbContent.TabIndex = 5;
            this.tbContent.Text = "";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(249, 118);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 8;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(125, 118);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbltag
            // 
            this.lbltag.AutoSize = true;
            this.lbltag.Location = new System.Drawing.Point(12, 94);
            this.lbltag.Name = "lbltag";
            this.lbltag.Size = new System.Drawing.Size(35, 13);
            this.lbltag.TabIndex = 10;
            this.lbltag.Text = "label1";
            // 
            // btnRemoveTag
            // 
            this.btnRemoveTag.Location = new System.Drawing.Point(249, 91);
            this.btnRemoveTag.Name = "btnRemoveTag";
            this.btnRemoveTag.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTag.TabIndex = 11;
            this.btnRemoveTag.Text = "Remove Tag";
            this.btnRemoveTag.UseVisualStyleBackColor = true;
            this.btnRemoveTag.Click += new System.EventHandler(this.btnRemoveTag_Click);
            // 
            // Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 153);
            this.Controls.Add(this.btnRemoveTag);
            this.Controls.Add(this.lbltag);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbTag);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.btnCancle);
            this.Name = "Job";
            this.Text = "Job";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbTag;
        private System.Windows.Forms.RichTextBox tbContent;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lbltag;
        private System.Windows.Forms.Button btnRemoveTag;
    }
}