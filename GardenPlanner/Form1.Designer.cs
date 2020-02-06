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
            this.tbVegDetails = new System.Windows.Forms.RichTextBox();
            this.btnCreateTag = new System.Windows.Forms.Button();
            this.cbJournalTags = new System.Windows.Forms.ComboBox();
            this.btnRemoveJournalTag = new System.Windows.Forms.Button();
            this.btnNewJournal = new System.Windows.Forms.Button();
            this.btnNewNote = new System.Windows.Forms.Button();
            this.btnNewJob = new System.Windows.Forms.Button();
            this.tbNoteContent = new System.Windows.Forms.RichTextBox();
            this.btnSelectVeg = new System.Windows.Forms.Button();
            this.cbVegTags = new System.Windows.Forms.ComboBox();
            this.btnRemoveVegTag = new System.Windows.Forms.Button();
            this.btnRemoveNoteTags = new System.Windows.Forms.Button();
            this.cbNoteTags = new System.Windows.Forms.ComboBox();
            this.tbJournalContent = new System.Windows.Forms.RichTextBox();
            this.btnEditJournal = new System.Windows.Forms.Button();
            this.btnEditJob = new System.Windows.Forms.Button();
            this.btnEditVegDetails = new System.Windows.Forms.Button();
            this.btnEditNote = new System.Windows.Forms.Button();
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
            this.listBoxJournal.Location = new System.Drawing.Point(15, 81);
            this.listBoxJournal.Name = "listBoxJournal";
            this.listBoxJournal.Size = new System.Drawing.Size(340, 472);
            this.listBoxJournal.TabIndex = 1;
            this.listBoxJournal.SelectedIndexChanged += new System.EventHandler(this.listBoxJournal_SelectedIndexChanged);
            // 
            // listBoxNotes
            // 
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.Location = new System.Drawing.Point(1053, 81);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(340, 472);
            this.listBoxNotes.TabIndex = 6;
            this.listBoxNotes.SelectedIndexChanged += new System.EventHandler(this.listBoxNotes_SelectedIndexChanged);
            // 
            // listBoxJobs
            // 
            this.listBoxJobs.FormattingEnabled = true;
            this.listBoxJobs.Location = new System.Drawing.Point(361, 81);
            this.listBoxJobs.Name = "listBoxJobs";
            this.listBoxJobs.Size = new System.Drawing.Size(339, 472);
            this.listBoxJobs.TabIndex = 11;
            this.listBoxJobs.SelectedIndexChanged += new System.EventHandler(this.listBoxJobs_SelectedIndexChanged);
            // 
            // listBoxSelectedVeg
            // 
            this.listBoxSelectedVeg.FormattingEnabled = true;
            this.listBoxSelectedVeg.Location = new System.Drawing.Point(707, 81);
            this.listBoxSelectedVeg.Name = "listBoxSelectedVeg";
            this.listBoxSelectedVeg.Size = new System.Drawing.Size(340, 472);
            this.listBoxSelectedVeg.TabIndex = 16;
            this.listBoxSelectedVeg.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedVeg_SelectedIndexChanged);
            // 
            // btnRemoveVeg
            // 
            this.btnRemoveVeg.Enabled = false;
            this.btnRemoveVeg.Location = new System.Drawing.Point(879, 785);
            this.btnRemoveVeg.Name = "btnRemoveVeg";
            this.btnRemoveVeg.Size = new System.Drawing.Size(168, 23);
            this.btnRemoveVeg.TabIndex = 18;
            this.btnRemoveVeg.Text = "Remove";
            this.btnRemoveVeg.UseVisualStyleBackColor = true;
            this.btnRemoveVeg.Click += new System.EventHandler(this.btnRemoveVeg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Journal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Jobs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(704, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Selected Veg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1050, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Notes";
            // 
            // btnDeleteJournalPost
            // 
            this.btnDeleteJournalPost.Enabled = false;
            this.btnDeleteJournalPost.Location = new System.Drawing.Point(187, 785);
            this.btnDeleteJournalPost.Name = "btnDeleteJournalPost";
            this.btnDeleteJournalPost.Size = new System.Drawing.Size(168, 23);
            this.btnDeleteJournalPost.TabIndex = 29;
            this.btnDeleteJournalPost.Text = "Remove";
            this.btnDeleteJournalPost.UseVisualStyleBackColor = true;
            this.btnDeleteJournalPost.Click += new System.EventHandler(this.btnRemoveJournalPost_Click);
            // 
            // btnRemoveNote
            // 
            this.btnRemoveNote.Enabled = false;
            this.btnRemoveNote.Location = new System.Drawing.Point(1225, 785);
            this.btnRemoveNote.Name = "btnRemoveNote";
            this.btnRemoveNote.Size = new System.Drawing.Size(168, 23);
            this.btnRemoveNote.TabIndex = 30;
            this.btnRemoveNote.Text = "Remove";
            this.btnRemoveNote.UseVisualStyleBackColor = true;
            this.btnRemoveNote.Click += new System.EventHandler(this.btnRemoveNote_Click);
            // 
            // btnRemoveJob
            // 
            this.btnRemoveJob.Enabled = false;
            this.btnRemoveJob.Location = new System.Drawing.Point(591, 52);
            this.btnRemoveJob.Name = "btnRemoveJob";
            this.btnRemoveJob.Size = new System.Drawing.Size(109, 23);
            this.btnRemoveJob.TabIndex = 31;
            this.btnRemoveJob.Text = "Remove";
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
            // tbVegDetails
            // 
            this.tbVegDetails.Location = new System.Drawing.Point(707, 559);
            this.tbVegDetails.MaxLength = 1100;
            this.tbVegDetails.Name = "tbVegDetails";
            this.tbVegDetails.ReadOnly = true;
            this.tbVegDetails.Size = new System.Drawing.Size(340, 220);
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
            this.cbJournalTags.Location = new System.Drawing.Point(103, 54);
            this.cbJournalTags.Name = "cbJournalTags";
            this.cbJournalTags.Size = new System.Drawing.Size(164, 21);
            this.cbJournalTags.TabIndex = 50;
            this.cbJournalTags.Text = "Tags";
            this.cbJournalTags.SelectedIndexChanged += new System.EventHandler(this.cbJournalFilterTags_SelectedIndexChanged);
            // 
            // btnRemoveJournalTag
            // 
            this.btnRemoveJournalTag.Location = new System.Drawing.Point(273, 52);
            this.btnRemoveJournalTag.Name = "btnRemoveJournalTag";
            this.btnRemoveJournalTag.Size = new System.Drawing.Size(82, 23);
            this.btnRemoveJournalTag.TabIndex = 51;
            this.btnRemoveJournalTag.Text = "Remove Filter";
            this.btnRemoveJournalTag.UseVisualStyleBackColor = true;
            this.btnRemoveJournalTag.Click += new System.EventHandler(this.btnJournalFilterRemove_Click);
            // 
            // btnNewJournal
            // 
            this.btnNewJournal.Location = new System.Drawing.Point(15, 52);
            this.btnNewJournal.Name = "btnNewJournal";
            this.btnNewJournal.Size = new System.Drawing.Size(82, 23);
            this.btnNewJournal.TabIndex = 52;
            this.btnNewJournal.Text = "New Entiry";
            this.btnNewJournal.UseVisualStyleBackColor = true;
            this.btnNewJournal.Click += new System.EventHandler(this.btnNewJournal_Click);
            // 
            // btnNewNote
            // 
            this.btnNewNote.Location = new System.Drawing.Point(1053, 52);
            this.btnNewNote.Name = "btnNewNote";
            this.btnNewNote.Size = new System.Drawing.Size(82, 23);
            this.btnNewNote.TabIndex = 53;
            this.btnNewNote.Text = "New Note";
            this.btnNewNote.UseVisualStyleBackColor = true;
            this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
            // 
            // btnNewJob
            // 
            this.btnNewJob.Location = new System.Drawing.Point(361, 52);
            this.btnNewJob.Name = "btnNewJob";
            this.btnNewJob.Size = new System.Drawing.Size(109, 23);
            this.btnNewJob.TabIndex = 54;
            this.btnNewJob.Text = "New Job";
            this.btnNewJob.UseVisualStyleBackColor = true;
            this.btnNewJob.Click += new System.EventHandler(this.btnNewJob_Click);
            // 
            // tbNoteContent
            // 
            this.tbNoteContent.Location = new System.Drawing.Point(1053, 559);
            this.tbNoteContent.MaxLength = 1100;
            this.tbNoteContent.Name = "tbNoteContent";
            this.tbNoteContent.ReadOnly = true;
            this.tbNoteContent.Size = new System.Drawing.Size(340, 220);
            this.tbNoteContent.TabIndex = 55;
            this.tbNoteContent.Text = "";
            // 
            // btnSelectVeg
            // 
            this.btnSelectVeg.Location = new System.Drawing.Point(707, 52);
            this.btnSelectVeg.Name = "btnSelectVeg";
            this.btnSelectVeg.Size = new System.Drawing.Size(82, 23);
            this.btnSelectVeg.TabIndex = 56;
            this.btnSelectVeg.Text = "Select Veg";
            this.btnSelectVeg.UseVisualStyleBackColor = true;
            this.btnSelectVeg.Click += new System.EventHandler(this.btnSelectVeg_Click);
            // 
            // cbVegTags
            // 
            this.cbVegTags.FormattingEnabled = true;
            this.cbVegTags.Location = new System.Drawing.Point(795, 54);
            this.cbVegTags.Name = "cbVegTags";
            this.cbVegTags.Size = new System.Drawing.Size(164, 21);
            this.cbVegTags.TabIndex = 59;
            this.cbVegTags.Text = "Tags";
            this.cbVegTags.SelectedIndexChanged += new System.EventHandler(this.cbVegTags_SelectedIndexChanged);
            // 
            // btnRemoveVegTag
            // 
            this.btnRemoveVegTag.Location = new System.Drawing.Point(965, 52);
            this.btnRemoveVegTag.Name = "btnRemoveVegTag";
            this.btnRemoveVegTag.Size = new System.Drawing.Size(82, 23);
            this.btnRemoveVegTag.TabIndex = 60;
            this.btnRemoveVegTag.Text = "Remove Filter";
            this.btnRemoveVegTag.UseVisualStyleBackColor = true;
            this.btnRemoveVegTag.Click += new System.EventHandler(this.btnRemoveVegTag_Click);
            // 
            // btnRemoveNoteTags
            // 
            this.btnRemoveNoteTags.Location = new System.Drawing.Point(1311, 52);
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
            this.cbNoteTags.Location = new System.Drawing.Point(1141, 54);
            this.cbNoteTags.Name = "cbNoteTags";
            this.cbNoteTags.Size = new System.Drawing.Size(164, 21);
            this.cbNoteTags.TabIndex = 61;
            this.cbNoteTags.Text = "Tags";
            this.cbNoteTags.SelectedIndexChanged += new System.EventHandler(this.cbNoteTags_SelectedIndexChanged);
            // 
            // tbJournalContent
            // 
            this.tbJournalContent.Location = new System.Drawing.Point(15, 559);
            this.tbJournalContent.MaxLength = 1100;
            this.tbJournalContent.Name = "tbJournalContent";
            this.tbJournalContent.ReadOnly = true;
            this.tbJournalContent.Size = new System.Drawing.Size(340, 220);
            this.tbJournalContent.TabIndex = 64;
            this.tbJournalContent.Text = "";
            // 
            // btnEditJournal
            // 
            this.btnEditJournal.Enabled = false;
            this.btnEditJournal.Location = new System.Drawing.Point(15, 785);
            this.btnEditJournal.Name = "btnEditJournal";
            this.btnEditJournal.Size = new System.Drawing.Size(168, 23);
            this.btnEditJournal.TabIndex = 65;
            this.btnEditJournal.Text = "Edit Journal Details";
            this.btnEditJournal.UseVisualStyleBackColor = true;
            this.btnEditJournal.Click += new System.EventHandler(this.btnEditJournal_Click);
            // 
            // btnEditJob
            // 
            this.btnEditJob.Enabled = false;
            this.btnEditJob.Location = new System.Drawing.Point(476, 52);
            this.btnEditJob.Name = "btnEditJob";
            this.btnEditJob.Size = new System.Drawing.Size(109, 23);
            this.btnEditJob.TabIndex = 66;
            this.btnEditJob.Text = "Edit Job Details";
            this.btnEditJob.UseVisualStyleBackColor = true;
            this.btnEditJob.Click += new System.EventHandler(this.btnEditJob_Click);
            // 
            // btnEditVegDetails
            // 
            this.btnEditVegDetails.Enabled = false;
            this.btnEditVegDetails.Location = new System.Drawing.Point(707, 785);
            this.btnEditVegDetails.Name = "btnEditVegDetails";
            this.btnEditVegDetails.Size = new System.Drawing.Size(168, 23);
            this.btnEditVegDetails.TabIndex = 67;
            this.btnEditVegDetails.Text = "Edit Veg Details";
            this.btnEditVegDetails.UseVisualStyleBackColor = true;
            this.btnEditVegDetails.Click += new System.EventHandler(this.btnEditVegDetails_Click);
            // 
            // btnEditNote
            // 
            this.btnEditNote.Enabled = false;
            this.btnEditNote.Location = new System.Drawing.Point(1053, 785);
            this.btnEditNote.Name = "btnEditNote";
            this.btnEditNote.Size = new System.Drawing.Size(168, 23);
            this.btnEditNote.TabIndex = 68;
            this.btnEditNote.Text = "Edit Note Details";
            this.btnEditNote.UseVisualStyleBackColor = true;
            this.btnEditNote.Click += new System.EventHandler(this.btnEditNote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 820);
            this.Controls.Add(this.btnEditNote);
            this.Controls.Add(this.btnEditVegDetails);
            this.Controls.Add(this.btnEditJob);
            this.Controls.Add(this.btnEditJournal);
            this.Controls.Add(this.tbJournalContent);
            this.Controls.Add(this.btnRemoveNoteTags);
            this.Controls.Add(this.cbNoteTags);
            this.Controls.Add(this.btnRemoveVegTag);
            this.Controls.Add(this.cbVegTags);
            this.Controls.Add(this.btnSelectVeg);
            this.Controls.Add(this.tbNoteContent);
            this.Controls.Add(this.btnNewJob);
            this.Controls.Add(this.btnNewNote);
            this.Controls.Add(this.btnNewJournal);
            this.Controls.Add(this.btnRemoveJournalTag);
            this.Controls.Add(this.cbJournalTags);
            this.Controls.Add(this.btnCreateTag);
            this.Controls.Add(this.tbVegDetails);
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
        private System.Windows.Forms.RichTextBox tbVegDetails;
        private System.Windows.Forms.Button btnCreateTag;
        private System.Windows.Forms.ComboBox cbJournalTags;
        private System.Windows.Forms.Button btnRemoveJournalTag;
        private System.Windows.Forms.Button btnNewJournal;
        private System.Windows.Forms.Button btnNewNote;
        private System.Windows.Forms.Button btnNewJob;
        private System.Windows.Forms.RichTextBox tbNoteContent;
        private System.Windows.Forms.Button btnSelectVeg;
        private System.Windows.Forms.ComboBox cbVegTags;
        private System.Windows.Forms.Button btnRemoveVegTag;
        private System.Windows.Forms.Button btnRemoveNoteTags;
        private System.Windows.Forms.ComboBox cbNoteTags;
        private System.Windows.Forms.RichTextBox tbJournalContent;
        private System.Windows.Forms.Button btnEditJournal;
        private System.Windows.Forms.Button btnEditJob;
        private System.Windows.Forms.Button btnEditVegDetails;
        private System.Windows.Forms.Button btnEditNote;
    }
}

