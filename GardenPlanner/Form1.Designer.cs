namespace GardenPlanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblUserName = new System.Windows.Forms.Label();
            this.listBoxJournal = new System.Windows.Forms.ListBox();
            this.listBoxNotes = new System.Windows.Forms.ListBox();
            this.listBoxJobs = new System.Windows.Forms.ListBox();
            this.listBoxSelectedVeg = new System.Windows.Forms.ListBox();
            this.btnRemoveVeg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteJournalPost = new System.Windows.Forms.Button();
            this.btnRemoveNote = new System.Windows.Forms.Button();
            this.btnRemoveJob = new System.Windows.Forms.Button();
            this.btnAddPlant = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbVegDetails = new System.Windows.Forms.RichTextBox();
            this.btnCreateTag = new System.Windows.Forms.Button();
            this.cbJournalTags = new System.Windows.Forms.ComboBox();
            this.btnRemoveJournalTag = new System.Windows.Forms.Button();
            this.btnNewJournal = new System.Windows.Forms.Button();
            this.btnNewNote = new System.Windows.Forms.Button();
            this.btnNewJob = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSelectVeg = new System.Windows.Forms.Button();
            this.btnRemoveJobTag = new System.Windows.Forms.Button();
            this.cbJobTags = new System.Windows.Forms.ComboBox();
            this.cbVegTags = new System.Windows.Forms.ComboBox();
            this.btnRemoveVegTag = new System.Windows.Forms.Button();
            this.btnRemoveNoteTags = new System.Windows.Forms.Button();
            this.cbNoteTags = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(35, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "label1";
            // 
            // listBoxJournal
            // 
            this.listBoxJournal.FormattingEnabled = true;
            this.listBoxJournal.Location = new System.Drawing.Point(15, 108);
            this.listBoxJournal.Name = "listBoxJournal";
            this.listBoxJournal.Size = new System.Drawing.Size(295, 472);
            this.listBoxJournal.TabIndex = 1;
            this.listBoxJournal.SelectedIndexChanged += new System.EventHandler(this.listBoxJournal_SelectedIndexChanged);
            this.listBoxJournal.DoubleClick += new System.EventHandler(this.listBoxJournal_DoubleClick);
            // 
            // listBoxNotes
            // 
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.Location = new System.Drawing.Point(15, 632);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(596, 173);
            this.listBoxNotes.TabIndex = 6;
            this.listBoxNotes.SelectedIndexChanged += new System.EventHandler(this.listBoxNotes_SelectedIndexChanged);
            // 
            // listBoxJobs
            // 
            this.listBoxJobs.FormattingEnabled = true;
            this.listBoxJobs.Location = new System.Drawing.Point(316, 108);
            this.listBoxJobs.Name = "listBoxJobs";
            this.listBoxJobs.Size = new System.Drawing.Size(295, 472);
            this.listBoxJobs.TabIndex = 11;
            this.listBoxJobs.SelectedIndexChanged += new System.EventHandler(this.listBoxJobs_SelectedIndexChanged);
            // 
            // listBoxSelectedVeg
            // 
            this.listBoxSelectedVeg.FormattingEnabled = true;
            this.listBoxSelectedVeg.Location = new System.Drawing.Point(617, 108);
            this.listBoxSelectedVeg.Name = "listBoxSelectedVeg";
            this.listBoxSelectedVeg.Size = new System.Drawing.Size(295, 472);
            this.listBoxSelectedVeg.TabIndex = 16;
            this.listBoxSelectedVeg.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedVeg_SelectedIndexChanged);
            // 
            // btnRemoveVeg
            // 
            this.btnRemoveVeg.Enabled = false;
            this.btnRemoveVeg.Location = new System.Drawing.Point(705, 53);
            this.btnRemoveVeg.Name = "btnRemoveVeg";
            this.btnRemoveVeg.Size = new System.Drawing.Size(207, 23);
            this.btnRemoveVeg.TabIndex = 18;
            this.btnRemoveVeg.UseVisualStyleBackColor = true;
            this.btnRemoveVeg.Click += new System.EventHandler(this.btnRemoveVeg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Journal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Jobs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(614, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Selected Veg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 583);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Notes";
            // 
            // btnDeleteJournalPost
            // 
            this.btnDeleteJournalPost.Enabled = false;
            this.btnDeleteJournalPost.Location = new System.Drawing.Point(103, 53);
            this.btnDeleteJournalPost.Name = "btnDeleteJournalPost";
            this.btnDeleteJournalPost.Size = new System.Drawing.Size(119, 23);
            this.btnDeleteJournalPost.TabIndex = 29;
            this.btnDeleteJournalPost.UseVisualStyleBackColor = true;
            this.btnDeleteJournalPost.Click += new System.EventHandler(this.btnRemoveJournalPost_Click);
            // 
            // btnRemoveNote
            // 
            this.btnRemoveNote.Enabled = false;
            this.btnRemoveNote.Location = new System.Drawing.Point(103, 603);
            this.btnRemoveNote.Name = "btnRemoveNote";
            this.btnRemoveNote.Size = new System.Drawing.Size(119, 23);
            this.btnRemoveNote.TabIndex = 30;
            this.btnRemoveNote.UseVisualStyleBackColor = true;
            this.btnRemoveNote.Click += new System.EventHandler(this.btnRemoveNote_Click);
            // 
            // btnRemoveJob
            // 
            this.btnRemoveJob.Enabled = false;
            this.btnRemoveJob.Location = new System.Drawing.Point(404, 53);
            this.btnRemoveJob.Name = "btnRemoveJob";
            this.btnRemoveJob.Size = new System.Drawing.Size(207, 23);
            this.btnRemoveJob.TabIndex = 31;
            this.btnRemoveJob.UseVisualStyleBackColor = true;
            this.btnRemoveJob.Click += new System.EventHandler(this.btnRemoveJob_Click);
            // 
            // btnAddPlant
            // 
            this.btnAddPlant.Location = new System.Drawing.Point(1541, 4);
            this.btnAddPlant.Name = "btnAddPlant";
            this.btnAddPlant.Size = new System.Drawing.Size(92, 23);
            this.btnAddPlant.TabIndex = 32;
            this.btnAddPlant.Text = "Add new plant";
            this.btnAddPlant.UseVisualStyleBackColor = true;
            this.btnAddPlant.Click += new System.EventHandler(this.btnAddPlant_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(918, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Details";
            // 
            // tbVegDetails
            // 
            this.tbVegDetails.Location = new System.Drawing.Point(918, 108);
            this.tbVegDetails.MaxLength = 1100;
            this.tbVegDetails.Name = "tbVegDetails";
            this.tbVegDetails.ReadOnly = true;
            this.tbVegDetails.Size = new System.Drawing.Size(345, 472);
            this.tbVegDetails.TabIndex = 34;
            this.tbVegDetails.Text = "";
            // 
            // btnCreateTag
            // 
            this.btnCreateTag.Location = new System.Drawing.Point(1443, 4);
            this.btnCreateTag.Name = "btnCreateTag";
            this.btnCreateTag.Size = new System.Drawing.Size(92, 23);
            this.btnCreateTag.TabIndex = 45;
            this.btnCreateTag.Text = "Create Tag";
            this.btnCreateTag.UseVisualStyleBackColor = true;
            this.btnCreateTag.Click += new System.EventHandler(this.btnCreateTag_Click);
            // 
            // cbJournalTags
            // 
            this.cbJournalTags.FormattingEnabled = true;
            this.cbJournalTags.Location = new System.Drawing.Point(15, 82);
            this.cbJournalTags.Name = "cbJournalTags";
            this.cbJournalTags.Size = new System.Drawing.Size(207, 21);
            this.cbJournalTags.TabIndex = 50;
            this.cbJournalTags.Text = "Tags";
            this.cbJournalTags.SelectedIndexChanged += new System.EventHandler(this.cbJournalFilterTags_SelectedIndexChanged);
            // 
            // btnRemoveJournalTag
            // 
            this.btnRemoveJournalTag.Location = new System.Drawing.Point(228, 80);
            this.btnRemoveJournalTag.Name = "btnRemoveJournalTag";
            this.btnRemoveJournalTag.Size = new System.Drawing.Size(82, 23);
            this.btnRemoveJournalTag.TabIndex = 51;
            this.btnRemoveJournalTag.Text = "Remove Filter";
            this.btnRemoveJournalTag.UseVisualStyleBackColor = true;
            this.btnRemoveJournalTag.Click += new System.EventHandler(this.btnJournalFilterRemove_Click);
            // 
            // btnNewJournal
            // 
            this.btnNewJournal.Location = new System.Drawing.Point(15, 53);
            this.btnNewJournal.Name = "btnNewJournal";
            this.btnNewJournal.Size = new System.Drawing.Size(82, 23);
            this.btnNewJournal.TabIndex = 52;
            this.btnNewJournal.Text = "New Entiry";
            this.btnNewJournal.UseVisualStyleBackColor = true;
            this.btnNewJournal.Click += new System.EventHandler(this.btnNewJournal_Click);
            // 
            // btnNewNote
            // 
            this.btnNewNote.Location = new System.Drawing.Point(15, 603);
            this.btnNewNote.Name = "btnNewNote";
            this.btnNewNote.Size = new System.Drawing.Size(82, 23);
            this.btnNewNote.TabIndex = 53;
            this.btnNewNote.Text = "New Note";
            this.btnNewNote.UseVisualStyleBackColor = true;
            this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
            // 
            // btnNewJob
            // 
            this.btnNewJob.Location = new System.Drawing.Point(316, 53);
            this.btnNewJob.Name = "btnNewJob";
            this.btnNewJob.Size = new System.Drawing.Size(82, 23);
            this.btnNewJob.TabIndex = 54;
            this.btnNewJob.Text = "New Job";
            this.btnNewJob.UseVisualStyleBackColor = true;
            this.btnNewJob.Click += new System.EventHandler(this.btnNewJob_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(617, 632);
            this.richTextBox1.MaxLength = 1100;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(646, 173);
            this.richTextBox1.TabIndex = 55;
            this.richTextBox1.Text = "";
            // 
            // btnSelectVeg
            // 
            this.btnSelectVeg.Location = new System.Drawing.Point(617, 53);
            this.btnSelectVeg.Name = "btnSelectVeg";
            this.btnSelectVeg.Size = new System.Drawing.Size(82, 23);
            this.btnSelectVeg.TabIndex = 56;
            this.btnSelectVeg.Text = "Select Veg";
            this.btnSelectVeg.UseVisualStyleBackColor = true;
            this.btnSelectVeg.Click += new System.EventHandler(this.btnSelectVeg_Click);
            // 
            // btnRemoveJobTag
            // 
            this.btnRemoveJobTag.Location = new System.Drawing.Point(529, 80);
            this.btnRemoveJobTag.Name = "btnRemoveJobTag";
            this.btnRemoveJobTag.Size = new System.Drawing.Size(82, 23);
            this.btnRemoveJobTag.TabIndex = 57;
            this.btnRemoveJobTag.Text = "Remove Filter";
            this.btnRemoveJobTag.UseVisualStyleBackColor = true;
            this.btnRemoveJobTag.Click += new System.EventHandler(this.btnRemoveJobTag_Click);
            // 
            // cbJobTags
            // 
            this.cbJobTags.FormattingEnabled = true;
            this.cbJobTags.Location = new System.Drawing.Point(316, 82);
            this.cbJobTags.Name = "cbJobTags";
            this.cbJobTags.Size = new System.Drawing.Size(207, 21);
            this.cbJobTags.TabIndex = 58;
            this.cbJobTags.Text = "Tags";
            this.cbJobTags.SelectedIndexChanged += new System.EventHandler(this.bnJobTags_SelectedIndexChanged);
            // 
            // cbVegTags
            // 
            this.cbVegTags.FormattingEnabled = true;
            this.cbVegTags.Location = new System.Drawing.Point(617, 82);
            this.cbVegTags.Name = "cbVegTags";
            this.cbVegTags.Size = new System.Drawing.Size(207, 21);
            this.cbVegTags.TabIndex = 59;
            this.cbVegTags.Text = "Tags";
            this.cbVegTags.SelectedIndexChanged += new System.EventHandler(this.cbVegTags_SelectedIndexChanged);
            // 
            // btnRemoveVegTag
            // 
            this.btnRemoveVegTag.Location = new System.Drawing.Point(830, 80);
            this.btnRemoveVegTag.Name = "btnRemoveVegTag";
            this.btnRemoveVegTag.Size = new System.Drawing.Size(82, 23);
            this.btnRemoveVegTag.TabIndex = 60;
            this.btnRemoveVegTag.Text = "Remove Filter";
            this.btnRemoveVegTag.UseVisualStyleBackColor = true;
            this.btnRemoveVegTag.Click += new System.EventHandler(this.btnRemoveVegTag_Click);
            // 
            // btnRemoveNoteTags
            // 
            this.btnRemoveNoteTags.Location = new System.Drawing.Point(529, 603);
            this.btnRemoveNoteTags.Name = "btnRemoveNoteTags";
            this.btnRemoveNoteTags.Size = new System.Drawing.Size(82, 23);
            this.btnRemoveNoteTags.TabIndex = 62;
            this.btnRemoveNoteTags.Text = "Remove Filter";
            this.btnRemoveNoteTags.UseVisualStyleBackColor = true;
            this.btnRemoveNoteTags.Click += new System.EventHandler(this.btnRemoveNoteTags_Click);
            // 
            // cbNoteTags
            // 
            this.cbNoteTags.FormattingEnabled = true;
            this.cbNoteTags.Location = new System.Drawing.Point(316, 605);
            this.cbNoteTags.Name = "cbNoteTags";
            this.cbNoteTags.Size = new System.Drawing.Size(207, 21);
            this.cbNoteTags.TabIndex = 61;
            this.cbNoteTags.Text = "Tags";
            this.cbNoteTags.SelectedIndexChanged += new System.EventHandler(this.cbNoteTags_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 919);
            this.Controls.Add(this.btnRemoveNoteTags);
            this.Controls.Add(this.cbNoteTags);
            this.Controls.Add(this.btnRemoveVegTag);
            this.Controls.Add(this.cbVegTags);
            this.Controls.Add(this.cbJobTags);
            this.Controls.Add(this.btnRemoveJobTag);
            this.Controls.Add(this.btnSelectVeg);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnNewJob);
            this.Controls.Add(this.btnNewNote);
            this.Controls.Add(this.btnNewJournal);
            this.Controls.Add(this.btnRemoveJournalTag);
            this.Controls.Add(this.cbJournalTags);
            this.Controls.Add(this.btnCreateTag);
            this.Controls.Add(this.tbVegDetails);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddPlant);
            this.Controls.Add(this.btnRemoveJob);
            this.Controls.Add(this.btnRemoveNote);
            this.Controls.Add(this.btnDeleteJournalPost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveVeg);
            this.Controls.Add(this.listBoxSelectedVeg);
            this.Controls.Add(this.listBoxJobs);
            this.Controls.Add(this.listBoxNotes);
            this.Controls.Add(this.listBoxJournal);
            this.Controls.Add(this.lblUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garden Planner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ListBox listBoxJournal;
        private System.Windows.Forms.ListBox listBoxNotes;
        private System.Windows.Forms.ListBox listBoxJobs;
        private System.Windows.Forms.ListBox listBoxSelectedVeg;
        private System.Windows.Forms.Button btnRemoveVeg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteJournalPost;
        private System.Windows.Forms.Button btnRemoveNote;
        private System.Windows.Forms.Button btnRemoveJob;
        private System.Windows.Forms.Button btnAddPlant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox tbVegDetails;
        private System.Windows.Forms.Button btnCreateTag;
        private System.Windows.Forms.ComboBox cbJournalTags;
        private System.Windows.Forms.Button btnRemoveJournalTag;
        private System.Windows.Forms.Button btnNewJournal;
        private System.Windows.Forms.Button btnNewNote;
        private System.Windows.Forms.Button btnNewJob;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSelectVeg;
        private System.Windows.Forms.Button btnRemoveJobTag;
        private System.Windows.Forms.ComboBox cbJobTags;
        private System.Windows.Forms.ComboBox cbVegTags;
        private System.Windows.Forms.Button btnRemoveVegTag;
        private System.Windows.Forms.Button btnRemoveNoteTags;
        private System.Windows.Forms.ComboBox cbNoteTags;
    }
}

