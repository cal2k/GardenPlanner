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
            this.btnAddSelectedVeg = new System.Windows.Forms.Button();
            this.btnDeleteJournalPost = new System.Windows.Forms.Button();
            this.btnRemoveNote = new System.Windows.Forms.Button();
            this.btnRemoveJob = new System.Windows.Forms.Button();
            this.btnAddPlant = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbVegDetails = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbVegName = new System.Windows.Forms.ComboBox();
            this.cbVegSpecies = new System.Windows.Forms.ComboBox();
            this.btnCreateTag = new System.Windows.Forms.Button();
            this.cbJournalFilterTags = new System.Windows.Forms.ComboBox();
            this.btnJournalFilterRemove = new System.Windows.Forms.Button();
            this.btnNewJournal = new System.Windows.Forms.Button();
            this.btnNewNote = new System.Windows.Forms.Button();
            this.btnNewJob = new System.Windows.Forms.Button();
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
            this.listBoxJournal.Items.AddRange(new object[] {
            "99999999999999999999999999999999999999999999999999"});
            this.listBoxJournal.Location = new System.Drawing.Point(15, 79);
            this.listBoxJournal.Name = "listBoxJournal";
            this.listBoxJournal.Size = new System.Drawing.Size(383, 498);
            this.listBoxJournal.TabIndex = 1;
            this.listBoxJournal.SelectedIndexChanged += new System.EventHandler(this.listBoxJournal_SelectedIndexChanged);
            this.listBoxJournal.DoubleClick += new System.EventHandler(this.listBoxJournal_DoubleClick);
            // 
            // listBoxNotes
            // 
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.Location = new System.Drawing.Point(827, 404);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(400, 173);
            this.listBoxNotes.TabIndex = 6;
            this.listBoxNotes.SelectedIndexChanged += new System.EventHandler(this.listBoxNotes_SelectedIndexChanged);
            // 
            // listBoxJobs
            // 
            this.listBoxJobs.FormattingEnabled = true;
            this.listBoxJobs.Location = new System.Drawing.Point(1233, 53);
            this.listBoxJobs.Name = "listBoxJobs";
            this.listBoxJobs.Size = new System.Drawing.Size(400, 524);
            this.listBoxJobs.TabIndex = 11;
            this.listBoxJobs.SelectedIndexChanged += new System.EventHandler(this.listBoxJobs_SelectedIndexChanged);
            // 
            // listBoxSelectedVeg
            // 
            this.listBoxSelectedVeg.FormattingEnabled = true;
            this.listBoxSelectedVeg.Location = new System.Drawing.Point(417, 53);
            this.listBoxSelectedVeg.Name = "listBoxSelectedVeg";
            this.listBoxSelectedVeg.Size = new System.Drawing.Size(312, 524);
            this.listBoxSelectedVeg.TabIndex = 16;
            this.listBoxSelectedVeg.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedVeg_SelectedIndexChanged);
            // 
            // btnRemoveVeg
            // 
            this.btnRemoveVeg.Enabled = false;
            this.btnRemoveVeg.Location = new System.Drawing.Point(333, 583);
            this.btnRemoveVeg.Name = "btnRemoveVeg";
            this.btnRemoveVeg.Size = new System.Drawing.Size(312, 23);
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
            this.label3.Location = new System.Drawing.Point(1230, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Jobs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Selected Veg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(827, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Notes";
            // 
            // btnAddSelectedVeg
            // 
            this.btnAddSelectedVeg.Enabled = false;
            this.btnAddSelectedVeg.Location = new System.Drawing.Point(333, 679);
            this.btnAddSelectedVeg.Name = "btnAddSelectedVeg";
            this.btnAddSelectedVeg.Size = new System.Drawing.Size(312, 23);
            this.btnAddSelectedVeg.TabIndex = 28;
            this.btnAddSelectedVeg.UseVisualStyleBackColor = true;
            this.btnAddSelectedVeg.Click += new System.EventHandler(this.btnAddSelectedVeg_Click);
            // 
            // btnDeleteJournalPost
            // 
            this.btnDeleteJournalPost.Enabled = false;
            this.btnDeleteJournalPost.Location = new System.Drawing.Point(15, 583);
            this.btnDeleteJournalPost.Name = "btnDeleteJournalPost";
            this.btnDeleteJournalPost.Size = new System.Drawing.Size(312, 23);
            this.btnDeleteJournalPost.TabIndex = 29;
            this.btnDeleteJournalPost.UseVisualStyleBackColor = true;
            this.btnDeleteJournalPost.Click += new System.EventHandler(this.btnRemoveJournalPost_Click);
            // 
            // btnRemoveNote
            // 
            this.btnRemoveNote.Enabled = false;
            this.btnRemoveNote.Location = new System.Drawing.Point(827, 583);
            this.btnRemoveNote.Name = "btnRemoveNote";
            this.btnRemoveNote.Size = new System.Drawing.Size(400, 23);
            this.btnRemoveNote.TabIndex = 30;
            this.btnRemoveNote.UseVisualStyleBackColor = true;
            this.btnRemoveNote.Click += new System.EventHandler(this.btnRemoveNote_Click);
            // 
            // btnRemoveJob
            // 
            this.btnRemoveJob.Enabled = false;
            this.btnRemoveJob.Location = new System.Drawing.Point(1233, 583);
            this.btnRemoveJob.Name = "btnRemoveJob";
            this.btnRemoveJob.Size = new System.Drawing.Size(400, 23);
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
            this.label8.Location = new System.Drawing.Point(827, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Details";
            // 
            // tbVegDetails
            // 
            this.tbVegDetails.Location = new System.Drawing.Point(827, 53);
            this.tbVegDetails.Name = "tbVegDetails";
            this.tbVegDetails.ReadOnly = true;
            this.tbVegDetails.Size = new System.Drawing.Size(400, 328);
            this.tbVegDetails.TabIndex = 34;
            this.tbVegDetails.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(330, 609);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Select Veg:";
            // 
            // cbVegName
            // 
            this.cbVegName.FormattingEnabled = true;
            this.cbVegName.Location = new System.Drawing.Point(333, 625);
            this.cbVegName.Name = "cbVegName";
            this.cbVegName.Size = new System.Drawing.Size(312, 21);
            this.cbVegName.TabIndex = 36;
            this.cbVegName.Text = "Choose vegetables";
            this.cbVegName.SelectedIndexChanged += new System.EventHandler(this.cbVegName_SelectedIndexChanged);
            // 
            // cbVegSpecies
            // 
            this.cbVegSpecies.Enabled = false;
            this.cbVegSpecies.FormattingEnabled = true;
            this.cbVegSpecies.Location = new System.Drawing.Point(333, 652);
            this.cbVegSpecies.Name = "cbVegSpecies";
            this.cbVegSpecies.Size = new System.Drawing.Size(312, 21);
            this.cbVegSpecies.TabIndex = 37;
            this.cbVegSpecies.SelectedIndexChanged += new System.EventHandler(this.cbVegSpecies_SelectedIndexChanged);
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
            // cbJournalFilterTags
            // 
            this.cbJournalFilterTags.FormattingEnabled = true;
            this.cbJournalFilterTags.Location = new System.Drawing.Point(103, 55);
            this.cbJournalFilterTags.Name = "cbJournalFilterTags";
            this.cbJournalFilterTags.Size = new System.Drawing.Size(207, 21);
            this.cbJournalFilterTags.TabIndex = 50;
            this.cbJournalFilterTags.Text = "999999999999999999999999999999";
            this.cbJournalFilterTags.SelectedIndexChanged += new System.EventHandler(this.cbJournalFilterTags_SelectedIndexChanged);
            // 
            // btnJournalFilterRemove
            // 
            this.btnJournalFilterRemove.Location = new System.Drawing.Point(316, 53);
            this.btnJournalFilterRemove.Name = "btnJournalFilterRemove";
            this.btnJournalFilterRemove.Size = new System.Drawing.Size(82, 23);
            this.btnJournalFilterRemove.TabIndex = 51;
            this.btnJournalFilterRemove.Text = "Remove Filter";
            this.btnJournalFilterRemove.UseVisualStyleBackColor = true;
            this.btnJournalFilterRemove.Click += new System.EventHandler(this.btnJournalFilterRemove_Click);
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
            this.btnNewNote.Location = new System.Drawing.Point(654, 4);
            this.btnNewNote.Name = "btnNewNote";
            this.btnNewNote.Size = new System.Drawing.Size(75, 23);
            this.btnNewNote.TabIndex = 53;
            this.btnNewNote.Text = "New Note";
            this.btnNewNote.UseVisualStyleBackColor = true;
            this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
            // 
            // btnNewJob
            // 
            this.btnNewJob.Location = new System.Drawing.Point(735, 4);
            this.btnNewJob.Name = "btnNewJob";
            this.btnNewJob.Size = new System.Drawing.Size(75, 23);
            this.btnNewJob.TabIndex = 54;
            this.btnNewJob.Text = "New Job";
            this.btnNewJob.UseVisualStyleBackColor = true;
            this.btnNewJob.Click += new System.EventHandler(this.btnNewJob_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 919);
            this.Controls.Add(this.btnNewJob);
            this.Controls.Add(this.btnNewNote);
            this.Controls.Add(this.btnNewJournal);
            this.Controls.Add(this.btnJournalFilterRemove);
            this.Controls.Add(this.cbJournalFilterTags);
            this.Controls.Add(this.btnCreateTag);
            this.Controls.Add(this.cbVegSpecies);
            this.Controls.Add(this.cbVegName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbVegDetails);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddPlant);
            this.Controls.Add(this.btnRemoveJob);
            this.Controls.Add(this.btnRemoveNote);
            this.Controls.Add(this.btnDeleteJournalPost);
            this.Controls.Add(this.btnAddSelectedVeg);
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
        private System.Windows.Forms.Button btnAddSelectedVeg;
        private System.Windows.Forms.Button btnDeleteJournalPost;
        private System.Windows.Forms.Button btnRemoveNote;
        private System.Windows.Forms.Button btnRemoveJob;
        private System.Windows.Forms.Button btnAddPlant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox tbVegDetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbVegName;
        private System.Windows.Forms.ComboBox cbVegSpecies;
        private System.Windows.Forms.Button btnCreateTag;
        private System.Windows.Forms.ComboBox cbJournalFilterTags;
        private System.Windows.Forms.Button btnJournalFilterRemove;
        private System.Windows.Forms.Button btnNewJournal;
        private System.Windows.Forms.Button btnNewNote;
        private System.Windows.Forms.Button btnNewJob;
    }
}

