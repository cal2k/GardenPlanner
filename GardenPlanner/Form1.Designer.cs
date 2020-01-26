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
            this.btnRemoveVeg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.listboxVegDetails = new System.Windows.Forms.ListBox();
            this.lblJournalTitleRemaining = new System.Windows.Forms.Label();
            this.lblJournalContentRemaing = new System.Windows.Forms.Label();
            this.lblNoteContentRemaining = new System.Windows.Forms.Label();
            this.lblNoteTitleRemaining = new System.Windows.Forms.Label();
            this.lblJobContentRemaining = new System.Windows.Forms.Label();
            this.lblJobTitleRemaining = new System.Windows.Forms.Label();
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
            this.listBoxJournal.Size = new System.Drawing.Size(400, 524);
            this.listBoxJournal.TabIndex = 1;
            this.listBoxJournal.SelectedIndexChanged += new System.EventHandler(this.listBoxJournal_SelectedIndexChanged);
            // 
            // btnSaveJournalEntiry
            // 
            this.btnSaveJournalEntiry.Enabled = false;
            this.btnSaveJournalEntiry.Location = new System.Drawing.Point(15, 880);
            this.btnSaveJournalEntiry.Name = "btnSaveJournalEntiry";
            this.btnSaveJournalEntiry.Size = new System.Drawing.Size(197, 23);
            this.btnSaveJournalEntiry.TabIndex = 2;
            this.btnSaveJournalEntiry.UseVisualStyleBackColor = true;
            this.btnSaveJournalEntiry.Click += new System.EventHandler(this.btnSaveJournalEntiry_Click);
            // 
            // tbJournalTitle
            // 
            this.tbJournalTitle.Location = new System.Drawing.Point(15, 625);
            this.tbJournalTitle.MaxLength = 50;
            this.tbJournalTitle.Name = "tbJournalTitle";
            this.tbJournalTitle.Size = new System.Drawing.Size(363, 20);
            this.tbJournalTitle.TabIndex = 3;
            this.tbJournalTitle.Text = "Title";
            this.tbJournalTitle.Click += new System.EventHandler(this.tbJournalTitle_Click);
            this.tbJournalTitle.TextChanged += new System.EventHandler(this.tbJournalTitle_TextChanged);
            // 
            // tbJournalEntiry
            // 
            this.tbJournalEntiry.Enabled = false;
            this.tbJournalEntiry.Location = new System.Drawing.Point(15, 651);
            this.tbJournalEntiry.MaxLength = 500;
            this.tbJournalEntiry.Name = "tbJournalEntiry";
            this.tbJournalEntiry.Size = new System.Drawing.Size(363, 223);
            this.tbJournalEntiry.TabIndex = 4;
            this.tbJournalEntiry.Text = "Details";
            this.tbJournalEntiry.Click += new System.EventHandler(this.tbJournalEntiry_Click);
            this.tbJournalEntiry.TextChanged += new System.EventHandler(this.tbJournalEntiry_TextChanged);
            // 
            // btnDiscardJournalEntiry
            // 
            this.btnDiscardJournalEntiry.Enabled = false;
            this.btnDiscardJournalEntiry.Location = new System.Drawing.Point(218, 880);
            this.btnDiscardJournalEntiry.Name = "btnDiscardJournalEntiry";
            this.btnDiscardJournalEntiry.Size = new System.Drawing.Size(197, 23);
            this.btnDiscardJournalEntiry.TabIndex = 5;
            this.btnDiscardJournalEntiry.UseVisualStyleBackColor = true;
            this.btnDiscardJournalEntiry.Click += new System.EventHandler(this.btnDiscardJournalEntiry_Click);
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
            // btnDiscardNote
            // 
            this.btnDiscardNote.Enabled = false;
            this.btnDiscardNote.Location = new System.Drawing.Point(1030, 880);
            this.btnDiscardNote.Name = "btnDiscardNote";
            this.btnDiscardNote.Size = new System.Drawing.Size(197, 23);
            this.btnDiscardNote.TabIndex = 10;
            this.btnDiscardNote.UseVisualStyleBackColor = true;
            this.btnDiscardNote.Click += new System.EventHandler(this.btnDiscardNote_Click);
            // 
            // tbNoteEntiry
            // 
            this.tbNoteEntiry.Enabled = false;
            this.tbNoteEntiry.Location = new System.Drawing.Point(827, 651);
            this.tbNoteEntiry.MaxLength = 500;
            this.tbNoteEntiry.Name = "tbNoteEntiry";
            this.tbNoteEntiry.Size = new System.Drawing.Size(363, 223);
            this.tbNoteEntiry.TabIndex = 9;
            this.tbNoteEntiry.Text = "Details";
            this.tbNoteEntiry.Click += new System.EventHandler(this.tbNoteEntiry_Click);
            this.tbNoteEntiry.TextChanged += new System.EventHandler(this.tbNoteEntiry_TextChanged);
            // 
            // tbNoteTitle
            // 
            this.tbNoteTitle.Location = new System.Drawing.Point(827, 625);
            this.tbNoteTitle.MaxLength = 50;
            this.tbNoteTitle.Name = "tbNoteTitle";
            this.tbNoteTitle.Size = new System.Drawing.Size(363, 20);
            this.tbNoteTitle.TabIndex = 8;
            this.tbNoteTitle.Text = "Title";
            this.tbNoteTitle.Click += new System.EventHandler(this.tbNoteTitle_Click);
            this.tbNoteTitle.TextChanged += new System.EventHandler(this.tbNoteTitle_TextChanged);
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.Enabled = false;
            this.btnSaveNote.Location = new System.Drawing.Point(827, 880);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(197, 23);
            this.btnSaveNote.TabIndex = 7;
            this.btnSaveNote.UseVisualStyleBackColor = true;
            this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
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
            // tbJobDetails
            // 
            this.tbJobDetails.Enabled = false;
            this.tbJobDetails.Location = new System.Drawing.Point(1233, 651);
            this.tbJobDetails.MaxLength = 500;
            this.tbJobDetails.Name = "tbJobDetails";
            this.tbJobDetails.Size = new System.Drawing.Size(363, 223);
            this.tbJobDetails.TabIndex = 13;
            this.tbJobDetails.Text = "Details";
            this.tbJobDetails.Click += new System.EventHandler(this.tbJobDetails_Click);
            this.tbJobDetails.TextChanged += new System.EventHandler(this.tbJobDetails_TextChanged);
            // 
            // tbJobTitle
            // 
            this.tbJobTitle.Location = new System.Drawing.Point(1233, 625);
            this.tbJobTitle.MaxLength = 50;
            this.tbJobTitle.Name = "tbJobTitle";
            this.tbJobTitle.Size = new System.Drawing.Size(363, 20);
            this.tbJobTitle.TabIndex = 12;
            this.tbJobTitle.Text = "Title";
            this.tbJobTitle.Click += new System.EventHandler(this.tbJobTitle_Click);
            this.tbJobTitle.TextChanged += new System.EventHandler(this.tbJobTitle_TextChanged);
            // 
            // btnSaveJob
            // 
            this.btnSaveJob.Enabled = false;
            this.btnSaveJob.Location = new System.Drawing.Point(1233, 880);
            this.btnSaveJob.Name = "btnSaveJob";
            this.btnSaveJob.Size = new System.Drawing.Size(197, 23);
            this.btnSaveJob.TabIndex = 14;
            this.btnSaveJob.UseVisualStyleBackColor = true;
            this.btnSaveJob.Click += new System.EventHandler(this.btnSaveJob_Click);
            // 
            // btnDiscardJob
            // 
            this.btnDiscardJob.Enabled = false;
            this.btnDiscardJob.Location = new System.Drawing.Point(1436, 880);
            this.btnDiscardJob.Name = "btnDiscardJob";
            this.btnDiscardJob.Size = new System.Drawing.Size(197, 23);
            this.btnDiscardJob.TabIndex = 15;
            this.btnDiscardJob.UseVisualStyleBackColor = true;
            this.btnDiscardJob.Click += new System.EventHandler(this.btnDiscardJob_Click);
            // 
            // listBoxSelectedVeg
            // 
            this.listBoxSelectedVeg.FormattingEnabled = true;
            this.listBoxSelectedVeg.Location = new System.Drawing.Point(421, 53);
            this.listBoxSelectedVeg.Name = "listBoxSelectedVeg";
            this.listBoxSelectedVeg.Size = new System.Drawing.Size(400, 719);
            this.listBoxSelectedVeg.TabIndex = 16;
            this.listBoxSelectedVeg.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedVeg_SelectedIndexChanged);
            // 
            // btnRemoveVeg
            // 
            this.btnRemoveVeg.Enabled = false;
            this.btnRemoveVeg.Location = new System.Drawing.Point(421, 778);
            this.btnRemoveVeg.Name = "btnRemoveVeg";
            this.btnRemoveVeg.Size = new System.Drawing.Size(400, 23);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 609);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "New Journal Entiry:";
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
            this.label4.Location = new System.Drawing.Point(418, 33);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(824, 609);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "New Note:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1230, 609);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "New Job:";
            // 
            // btnAddSelectedVeg
            // 
            this.btnAddSelectedVeg.Enabled = false;
            this.btnAddSelectedVeg.Location = new System.Drawing.Point(421, 880);
            this.btnAddSelectedVeg.Name = "btnAddSelectedVeg";
            this.btnAddSelectedVeg.Size = new System.Drawing.Size(400, 23);
            this.btnAddSelectedVeg.TabIndex = 28;
            this.btnAddSelectedVeg.UseVisualStyleBackColor = true;
            this.btnAddSelectedVeg.Click += new System.EventHandler(this.btnAddSelectedVeg_Click);
            // 
            // btnDeleteJournalPost
            // 
            this.btnDeleteJournalPost.Enabled = false;
            this.btnDeleteJournalPost.Location = new System.Drawing.Point(15, 583);
            this.btnDeleteJournalPost.Name = "btnDeleteJournalPost";
            this.btnDeleteJournalPost.Size = new System.Drawing.Size(400, 23);
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
            this.tbVegDetails.Location = new System.Drawing.Point(827, 141);
            this.tbVegDetails.Name = "tbVegDetails";
            this.tbVegDetails.ReadOnly = true;
            this.tbVegDetails.Size = new System.Drawing.Size(400, 149);
            this.tbVegDetails.TabIndex = 34;
            this.tbVegDetails.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(421, 804);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Select Veg:";
            // 
            // cbVegName
            // 
            this.cbVegName.FormattingEnabled = true;
            this.cbVegName.Location = new System.Drawing.Point(421, 820);
            this.cbVegName.Name = "cbVegName";
            this.cbVegName.Size = new System.Drawing.Size(400, 21);
            this.cbVegName.TabIndex = 36;
            this.cbVegName.Text = "Choose vegetables";
            this.cbVegName.SelectedIndexChanged += new System.EventHandler(this.cbVegName_SelectedIndexChanged);
            // 
            // cbVegSpecies
            // 
            this.cbVegSpecies.Enabled = false;
            this.cbVegSpecies.FormattingEnabled = true;
            this.cbVegSpecies.Location = new System.Drawing.Point(421, 853);
            this.cbVegSpecies.Name = "cbVegSpecies";
            this.cbVegSpecies.Size = new System.Drawing.Size(400, 21);
            this.cbVegSpecies.TabIndex = 37;
            this.cbVegSpecies.SelectedIndexChanged += new System.EventHandler(this.cbVegSpecies_SelectedIndexChanged);
            // 
            // listboxVegDetails
            // 
            this.listboxVegDetails.FormattingEnabled = true;
            this.listboxVegDetails.Location = new System.Drawing.Point(827, 53);
            this.listboxVegDetails.Name = "listboxVegDetails";
            this.listboxVegDetails.Size = new System.Drawing.Size(400, 82);
            this.listboxVegDetails.TabIndex = 38;
            // 
            // lblJournalTitleRemaining
            // 
            this.lblJournalTitleRemaining.AutoSize = true;
            this.lblJournalTitleRemaining.Location = new System.Drawing.Point(384, 628);
            this.lblJournalTitleRemaining.Name = "lblJournalTitleRemaining";
            this.lblJournalTitleRemaining.Size = new System.Drawing.Size(25, 13);
            this.lblJournalTitleRemaining.TabIndex = 39;
            this.lblJournalTitleRemaining.Text = "(50)";
            // 
            // lblJournalContentRemaing
            // 
            this.lblJournalContentRemaing.AutoSize = true;
            this.lblJournalContentRemaing.Location = new System.Drawing.Point(384, 654);
            this.lblJournalContentRemaing.Name = "lblJournalContentRemaing";
            this.lblJournalContentRemaing.Size = new System.Drawing.Size(31, 13);
            this.lblJournalContentRemaing.TabIndex = 40;
            this.lblJournalContentRemaing.Text = "(500)";
            // 
            // lblNoteContentRemaining
            // 
            this.lblNoteContentRemaining.AutoSize = true;
            this.lblNoteContentRemaining.Location = new System.Drawing.Point(1196, 654);
            this.lblNoteContentRemaining.Name = "lblNoteContentRemaining";
            this.lblNoteContentRemaining.Size = new System.Drawing.Size(31, 13);
            this.lblNoteContentRemaining.TabIndex = 42;
            this.lblNoteContentRemaining.Text = "(500)";
            // 
            // lblNoteTitleRemaining
            // 
            this.lblNoteTitleRemaining.AutoSize = true;
            this.lblNoteTitleRemaining.Location = new System.Drawing.Point(1196, 628);
            this.lblNoteTitleRemaining.Name = "lblNoteTitleRemaining";
            this.lblNoteTitleRemaining.Size = new System.Drawing.Size(25, 13);
            this.lblNoteTitleRemaining.TabIndex = 41;
            this.lblNoteTitleRemaining.Text = "(50)";
            // 
            // lblJobContentRemaining
            // 
            this.lblJobContentRemaining.AutoSize = true;
            this.lblJobContentRemaining.Location = new System.Drawing.Point(1602, 654);
            this.lblJobContentRemaining.Name = "lblJobContentRemaining";
            this.lblJobContentRemaining.Size = new System.Drawing.Size(31, 13);
            this.lblJobContentRemaining.TabIndex = 44;
            this.lblJobContentRemaining.Text = "(500)";
            // 
            // lblJobTitleRemaining
            // 
            this.lblJobTitleRemaining.AutoSize = true;
            this.lblJobTitleRemaining.Location = new System.Drawing.Point(1602, 628);
            this.lblJobTitleRemaining.Name = "lblJobTitleRemaining";
            this.lblJobTitleRemaining.Size = new System.Drawing.Size(25, 13);
            this.lblJobTitleRemaining.TabIndex = 43;
            this.lblJobTitleRemaining.Text = "(50)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 919);
            this.Controls.Add(this.lblJobContentRemaining);
            this.Controls.Add(this.lblJobTitleRemaining);
            this.Controls.Add(this.lblNoteContentRemaining);
            this.Controls.Add(this.lblNoteTitleRemaining);
            this.Controls.Add(this.lblJournalContentRemaing);
            this.Controls.Add(this.lblJournalTitleRemaining);
            this.Controls.Add(this.listboxVegDetails);
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
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveVeg);
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
        private System.Windows.Forms.Button btnRemoveVeg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.ListBox listboxVegDetails;
        private System.Windows.Forms.Label lblJournalTitleRemaining;
        private System.Windows.Forms.Label lblJournalContentRemaing;
        private System.Windows.Forms.Label lblNoteContentRemaining;
        private System.Windows.Forms.Label lblNoteTitleRemaining;
        private System.Windows.Forms.Label lblJobContentRemaining;
        private System.Windows.Forms.Label lblJobTitleRemaining;
    }
}

