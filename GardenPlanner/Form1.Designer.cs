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
            this.btnSaveJournalEntiry = new System.Windows.Forms.Button();
            this.tbJournalTitle = new System.Windows.Forms.TextBox();
            this.tbJournalEntiry = new System.Windows.Forms.RichTextBox();
            this.btnDiscardJournalEntiry = new System.Windows.Forms.Button();
            this.listBoxNotes = new System.Windows.Forms.ListBox();
            this.btnDiscardNote = new System.Windows.Forms.Button();
            this.tbNoteEntiry = new System.Windows.Forms.RichTextBox();
            this.tbNoteTitle = new System.Windows.Forms.TextBox();
            this.btnSaveNote = new System.Windows.Forms.Button();
            this.listBoxJobs = new System.Windows.Forms.ListBox();
            this.tbJobDetails = new System.Windows.Forms.RichTextBox();
            this.tbJobTitle = new System.Windows.Forms.TextBox();
            this.btnSaveJob = new System.Windows.Forms.Button();
            this.btnDiscardJob = new System.Windows.Forms.Button();
            this.listBoxSelectedVeg = new System.Windows.Forms.ListBox();
            this.btnSelectVeg = new System.Windows.Forms.Button();
            this.btnRemoveVeg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxSelecVegName = new System.Windows.Forms.ListBox();
            this.listBoxSelectVegSpecies = new System.Windows.Forms.ListBox();
            this.btnAddSelectedVeg = new System.Windows.Forms.Button();
            this.btnRemoveJournalPost = new System.Windows.Forms.Button();
            this.btnRemoveNote = new System.Windows.Forms.Button();
            this.btnRemoveJob = new System.Windows.Forms.Button();
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
            this.listBoxJournal.Location = new System.Drawing.Point(15, 53);
            this.listBoxJournal.Name = "listBoxJournal";
            this.listBoxJournal.Size = new System.Drawing.Size(1428, 173);
            this.listBoxJournal.TabIndex = 1;
            this.listBoxJournal.SelectedIndexChanged += new System.EventHandler(this.listBoxJournal_SelectedIndexChanged);
            // 
            // btnSaveJournalEntiry
            // 
            this.btnSaveJournalEntiry.Location = new System.Drawing.Point(15, 447);
            this.btnSaveJournalEntiry.Name = "btnSaveJournalEntiry";
            this.btnSaveJournalEntiry.Size = new System.Drawing.Size(118, 23);
            this.btnSaveJournalEntiry.TabIndex = 2;
            this.btnSaveJournalEntiry.Text = "Save Entiry";
            this.btnSaveJournalEntiry.UseVisualStyleBackColor = true;
            this.btnSaveJournalEntiry.Click += new System.EventHandler(this.btnSaveJournalEntiry_Click);
            // 
            // tbJournalTitle
            // 
            this.tbJournalTitle.Location = new System.Drawing.Point(15, 274);
            this.tbJournalTitle.Name = "tbJournalTitle";
            this.tbJournalTitle.Size = new System.Drawing.Size(577, 20);
            this.tbJournalTitle.TabIndex = 3;
            this.tbJournalTitle.Text = "Journal Entiry Title";
            this.tbJournalTitle.Click += new System.EventHandler(this.tbJournalTitle_Click);
            // 
            // tbJournalEntiry
            // 
            this.tbJournalEntiry.Location = new System.Drawing.Point(15, 300);
            this.tbJournalEntiry.Name = "tbJournalEntiry";
            this.tbJournalEntiry.Size = new System.Drawing.Size(577, 141);
            this.tbJournalEntiry.TabIndex = 4;
            this.tbJournalEntiry.Text = "Journal Entiry Details";
            this.tbJournalEntiry.Click += new System.EventHandler(this.tbJournalEntiry_Click);
            // 
            // btnDiscardJournalEntiry
            // 
            this.btnDiscardJournalEntiry.Location = new System.Drawing.Point(139, 447);
            this.btnDiscardJournalEntiry.Name = "btnDiscardJournalEntiry";
            this.btnDiscardJournalEntiry.Size = new System.Drawing.Size(118, 23);
            this.btnDiscardJournalEntiry.TabIndex = 5;
            this.btnDiscardJournalEntiry.Text = "Discard Entiry";
            this.btnDiscardJournalEntiry.UseVisualStyleBackColor = true;
            this.btnDiscardJournalEntiry.Click += new System.EventHandler(this.btnDiscardJournalEntiry_Click);
            // 
            // listBoxNotes
            // 
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.Location = new System.Drawing.Point(15, 493);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(577, 173);
            this.listBoxNotes.TabIndex = 6;
            this.listBoxNotes.SelectedIndexChanged += new System.EventHandler(this.listBoxNotes_SelectedIndexChanged);
            // 
            // btnDiscardNote
            // 
            this.btnDiscardNote.Location = new System.Drawing.Point(474, 887);
            this.btnDiscardNote.Name = "btnDiscardNote";
            this.btnDiscardNote.Size = new System.Drawing.Size(118, 23);
            this.btnDiscardNote.TabIndex = 10;
            this.btnDiscardNote.Text = "Discard Note";
            this.btnDiscardNote.UseVisualStyleBackColor = true;
            this.btnDiscardNote.Click += new System.EventHandler(this.btnDiscardNote_Click);
            // 
            // tbNoteEntiry
            // 
            this.tbNoteEntiry.Location = new System.Drawing.Point(15, 740);
            this.tbNoteEntiry.Name = "tbNoteEntiry";
            this.tbNoteEntiry.Size = new System.Drawing.Size(577, 141);
            this.tbNoteEntiry.TabIndex = 9;
            this.tbNoteEntiry.Text = "Note Details";
            this.tbNoteEntiry.Click += new System.EventHandler(this.tbNoteEntiry_Click);
            // 
            // tbNoteTitle
            // 
            this.tbNoteTitle.Location = new System.Drawing.Point(15, 714);
            this.tbNoteTitle.Name = "tbNoteTitle";
            this.tbNoteTitle.Size = new System.Drawing.Size(577, 20);
            this.tbNoteTitle.TabIndex = 8;
            this.tbNoteTitle.Text = "Note Title";
            this.tbNoteTitle.Click += new System.EventHandler(this.tbNoteTitle_Click);
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.Location = new System.Drawing.Point(15, 887);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(118, 23);
            this.btnSaveNote.TabIndex = 7;
            this.btnSaveNote.Text = "Save Note";
            this.btnSaveNote.UseVisualStyleBackColor = true;
            this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
            // 
            // listBoxJobs
            // 
            this.listBoxJobs.FormattingEnabled = true;
            this.listBoxJobs.Location = new System.Drawing.Point(598, 249);
            this.listBoxJobs.Name = "listBoxJobs";
            this.listBoxJobs.Size = new System.Drawing.Size(341, 420);
            this.listBoxJobs.TabIndex = 11;
            this.listBoxJobs.SelectedIndexChanged += new System.EventHandler(this.listBoxJobs_SelectedIndexChanged);
            // 
            // tbJobDetails
            // 
            this.tbJobDetails.Location = new System.Drawing.Point(598, 740);
            this.tbJobDetails.Name = "tbJobDetails";
            this.tbJobDetails.Size = new System.Drawing.Size(341, 141);
            this.tbJobDetails.TabIndex = 13;
            this.tbJobDetails.Text = "Job Details";
            this.tbJobDetails.Click += new System.EventHandler(this.tbJobDetails_Click);
            // 
            // tbJobTitle
            // 
            this.tbJobTitle.Location = new System.Drawing.Point(598, 714);
            this.tbJobTitle.Name = "tbJobTitle";
            this.tbJobTitle.Size = new System.Drawing.Size(341, 20);
            this.tbJobTitle.TabIndex = 12;
            this.tbJobTitle.Text = "Job Title";
            this.tbJobTitle.Click += new System.EventHandler(this.tbJobTitle_Click);
            // 
            // btnSaveJob
            // 
            this.btnSaveJob.Location = new System.Drawing.Point(598, 887);
            this.btnSaveJob.Name = "btnSaveJob";
            this.btnSaveJob.Size = new System.Drawing.Size(118, 23);
            this.btnSaveJob.TabIndex = 14;
            this.btnSaveJob.Text = "Save Job";
            this.btnSaveJob.UseVisualStyleBackColor = true;
            this.btnSaveJob.Click += new System.EventHandler(this.btnSaveJob_Click);
            // 
            // btnDiscardJob
            // 
            this.btnDiscardJob.Location = new System.Drawing.Point(821, 887);
            this.btnDiscardJob.Name = "btnDiscardJob";
            this.btnDiscardJob.Size = new System.Drawing.Size(118, 23);
            this.btnDiscardJob.TabIndex = 15;
            this.btnDiscardJob.Text = "Discard Job";
            this.btnDiscardJob.UseVisualStyleBackColor = true;
            this.btnDiscardJob.Click += new System.EventHandler(this.btnDiscardJob_Click);
            // 
            // listBoxSelectedVeg
            // 
            this.listBoxSelectedVeg.FormattingEnabled = true;
            this.listBoxSelectedVeg.Location = new System.Drawing.Point(945, 249);
            this.listBoxSelectedVeg.Name = "listBoxSelectedVeg";
            this.listBoxSelectedVeg.Size = new System.Drawing.Size(236, 628);
            this.listBoxSelectedVeg.TabIndex = 16;
            this.listBoxSelectedVeg.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedVeg_SelectedIndexChanged);
            // 
            // btnSelectVeg
            // 
            this.btnSelectVeg.Location = new System.Drawing.Point(945, 887);
            this.btnSelectVeg.Name = "btnSelectVeg";
            this.btnSelectVeg.Size = new System.Drawing.Size(82, 23);
            this.btnSelectVeg.TabIndex = 17;
            this.btnSelectVeg.Text = "Select Veg";
            this.btnSelectVeg.UseVisualStyleBackColor = true;
            this.btnSelectVeg.Click += new System.EventHandler(this.btnSelectVeg_Click);
            // 
            // btnRemoveVeg
            // 
            this.btnRemoveVeg.Enabled = false;
            this.btnRemoveVeg.Location = new System.Drawing.Point(1099, 887);
            this.btnRemoveVeg.Name = "btnRemoveVeg";
            this.btnRemoveVeg.Size = new System.Drawing.Size(82, 23);
            this.btnRemoveVeg.TabIndex = 18;
            this.btnRemoveVeg.Text = "Remove Veg";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "New Journal Entiry:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(595, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Jobs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(942, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Selected Veg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Notes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 698);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "New Note:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(595, 698);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "New Job:";
            // 
            // listBoxSelecVegName
            // 
            this.listBoxSelecVegName.FormattingEnabled = true;
            this.listBoxSelecVegName.Location = new System.Drawing.Point(1187, 249);
            this.listBoxSelecVegName.Name = "listBoxSelecVegName";
            this.listBoxSelecVegName.Size = new System.Drawing.Size(125, 628);
            this.listBoxSelecVegName.TabIndex = 26;
            this.listBoxSelecVegName.SelectedIndexChanged += new System.EventHandler(this.listBoxSelecVegName_SelectedIndexChanged);
            // 
            // listBoxSelectVegSpecies
            // 
            this.listBoxSelectVegSpecies.FormattingEnabled = true;
            this.listBoxSelectVegSpecies.Location = new System.Drawing.Point(1318, 249);
            this.listBoxSelectVegSpecies.Name = "listBoxSelectVegSpecies";
            this.listBoxSelectVegSpecies.Size = new System.Drawing.Size(125, 628);
            this.listBoxSelectVegSpecies.TabIndex = 27;
            this.listBoxSelectVegSpecies.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectVegSpecies_SelectedIndexChanged);
            // 
            // btnAddSelectedVeg
            // 
            this.btnAddSelectedVeg.Enabled = false;
            this.btnAddSelectedVeg.Location = new System.Drawing.Point(1318, 887);
            this.btnAddSelectedVeg.Name = "btnAddSelectedVeg";
            this.btnAddSelectedVeg.Size = new System.Drawing.Size(125, 23);
            this.btnAddSelectedVeg.TabIndex = 28;
            this.btnAddSelectedVeg.Text = "Add veg to list";
            this.btnAddSelectedVeg.UseVisualStyleBackColor = true;
            this.btnAddSelectedVeg.Click += new System.EventHandler(this.btnAddSelectedVeg_Click);
            // 
            // btnRemoveJournalPost
            // 
            this.btnRemoveJournalPost.Enabled = false;
            this.btnRemoveJournalPost.Location = new System.Drawing.Point(15, 232);
            this.btnRemoveJournalPost.Name = "btnRemoveJournalPost";
            this.btnRemoveJournalPost.Size = new System.Drawing.Size(131, 23);
            this.btnRemoveJournalPost.TabIndex = 29;
            this.btnRemoveJournalPost.Text = "Remove Journal Entiry";
            this.btnRemoveJournalPost.UseVisualStyleBackColor = true;
            this.btnRemoveJournalPost.Click += new System.EventHandler(this.btnRemoveJournalPost_Click);
            // 
            // btnRemoveNote
            // 
            this.btnRemoveNote.Enabled = false;
            this.btnRemoveNote.Location = new System.Drawing.Point(15, 672);
            this.btnRemoveNote.Name = "btnRemoveNote";
            this.btnRemoveNote.Size = new System.Drawing.Size(85, 23);
            this.btnRemoveNote.TabIndex = 30;
            this.btnRemoveNote.Text = "Remove Note";
            this.btnRemoveNote.UseVisualStyleBackColor = true;
            this.btnRemoveNote.Click += new System.EventHandler(this.btnRemoveNote_Click);
            // 
            // btnRemoveJob
            // 
            this.btnRemoveJob.Enabled = false;
            this.btnRemoveJob.Location = new System.Drawing.Point(598, 672);
            this.btnRemoveJob.Name = "btnRemoveJob";
            this.btnRemoveJob.Size = new System.Drawing.Size(85, 23);
            this.btnRemoveJob.TabIndex = 31;
            this.btnRemoveJob.Text = "Remove Job";
            this.btnRemoveJob.UseVisualStyleBackColor = true;
            this.btnRemoveJob.Click += new System.EventHandler(this.btnRemoveJob_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 919);
            this.Controls.Add(this.btnRemoveJob);
            this.Controls.Add(this.btnRemoveNote);
            this.Controls.Add(this.btnRemoveJournalPost);
            this.Controls.Add(this.btnAddSelectedVeg);
            this.Controls.Add(this.listBoxSelectVegSpecies);
            this.Controls.Add(this.listBoxSelecVegName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveVeg);
            this.Controls.Add(this.btnSelectVeg);
            this.Controls.Add(this.listBoxSelectedVeg);
            this.Controls.Add(this.btnDiscardJob);
            this.Controls.Add(this.btnSaveJob);
            this.Controls.Add(this.tbJobDetails);
            this.Controls.Add(this.tbJobTitle);
            this.Controls.Add(this.listBoxJobs);
            this.Controls.Add(this.btnDiscardNote);
            this.Controls.Add(this.tbNoteEntiry);
            this.Controls.Add(this.tbNoteTitle);
            this.Controls.Add(this.btnSaveNote);
            this.Controls.Add(this.listBoxNotes);
            this.Controls.Add(this.btnDiscardJournalEntiry);
            this.Controls.Add(this.tbJournalEntiry);
            this.Controls.Add(this.tbJournalTitle);
            this.Controls.Add(this.btnSaveJournalEntiry);
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
        private System.Windows.Forms.Button btnSaveJournalEntiry;
        private System.Windows.Forms.TextBox tbJournalTitle;
        private System.Windows.Forms.RichTextBox tbJournalEntiry;
        private System.Windows.Forms.Button btnDiscardJournalEntiry;
        private System.Windows.Forms.ListBox listBoxNotes;
        private System.Windows.Forms.Button btnDiscardNote;
        private System.Windows.Forms.RichTextBox tbNoteEntiry;
        private System.Windows.Forms.TextBox tbNoteTitle;
        private System.Windows.Forms.Button btnSaveNote;
        private System.Windows.Forms.ListBox listBoxJobs;
        private System.Windows.Forms.RichTextBox tbJobDetails;
        private System.Windows.Forms.TextBox tbJobTitle;
        private System.Windows.Forms.Button btnSaveJob;
        private System.Windows.Forms.Button btnDiscardJob;
        private System.Windows.Forms.ListBox listBoxSelectedVeg;
        private System.Windows.Forms.Button btnSelectVeg;
        private System.Windows.Forms.Button btnRemoveVeg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxSelecVegName;
        private System.Windows.Forms.ListBox listBoxSelectVegSpecies;
        private System.Windows.Forms.Button btnAddSelectedVeg;
        private System.Windows.Forms.Button btnRemoveJournalPost;
        private System.Windows.Forms.Button btnRemoveNote;
        private System.Windows.Forms.Button btnRemoveJob;
    }
}

