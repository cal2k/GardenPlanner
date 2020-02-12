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
            this.listBoxJournal = new System.Windows.Forms.ListBox();
            this.listBoxNotes = new System.Windows.Forms.ListBox();
            this.listBoxJobs = new System.Windows.Forms.ListBox();
            this.listBoxSelectedVeg = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoveNote = new System.Windows.Forms.Button();
            this.btnAddPlant = new System.Windows.Forms.Button();
            this.btnCreateTag = new System.Windows.Forms.Button();
            this.btnNewNote1 = new System.Windows.Forms.Button();
            this.btnEditNote = new System.Windows.Forms.Button();
            this.ToolStripUser = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNewJournalEntiry = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNewJob = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNewNote = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSelectVegs = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnNewVegetable = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveJournalTag = new System.Windows.Forms.Button();
            this.cbJournalTags = new System.Windows.Forms.ComboBox();
            this.ToolStripUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxJournal
            // 
            this.listBoxJournal.FormattingEnabled = true;
            this.listBoxJournal.Location = new System.Drawing.Point(15, 81);
            this.listBoxJournal.Name = "listBoxJournal";
            this.listBoxJournal.Size = new System.Drawing.Size(687, 472);
            this.listBoxJournal.TabIndex = 1;
            this.listBoxJournal.SelectedIndexChanged += new System.EventHandler(this.listBoxJournal_SelectedIndexChanged);
            this.listBoxJournal.DoubleClick += new System.EventHandler(this.listBoxJournal_DoubleClick);
            // 
            // listBoxNotes
            // 
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.Location = new System.Drawing.Point(15, 614);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(1032, 186);
            this.listBoxNotes.TabIndex = 6;
            this.listBoxNotes.SelectedIndexChanged += new System.EventHandler(this.listBoxNotes_SelectedIndexChanged);
            // 
            // listBoxJobs
            // 
            this.listBoxJobs.FormattingEnabled = true;
            this.listBoxJobs.Location = new System.Drawing.Point(914, 81);
            this.listBoxJobs.Name = "listBoxJobs";
            this.listBoxJobs.Size = new System.Drawing.Size(339, 472);
            this.listBoxJobs.TabIndex = 11;
            this.listBoxJobs.SelectedIndexChanged += new System.EventHandler(this.listBoxJobs_SelectedIndexChanged);
            // 
            // listBoxSelectedVeg
            // 
            this.listBoxSelectedVeg.FormattingEnabled = true;
            this.listBoxSelectedVeg.Location = new System.Drawing.Point(708, 81);
            this.listBoxSelectedVeg.Name = "listBoxSelectedVeg";
            this.listBoxSelectedVeg.Size = new System.Drawing.Size(200, 472);
            this.listBoxSelectedVeg.TabIndex = 16;
            this.listBoxSelectedVeg.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedVeg_SelectedIndexChanged);
            this.listBoxSelectedVeg.DoubleClick += new System.EventHandler(this.listBoxSelectedVeg_DoubleClick);
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
            this.label3.Location = new System.Drawing.Point(911, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Jobs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(705, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Selected Veg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 565);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Notes";
            // 
            // btnRemoveNote
            // 
            this.btnRemoveNote.Enabled = false;
            this.btnRemoveNote.Location = new System.Drawing.Point(245, 585);
            this.btnRemoveNote.Name = "btnRemoveNote";
            this.btnRemoveNote.Size = new System.Drawing.Size(109, 23);
            this.btnRemoveNote.TabIndex = 30;
            this.btnRemoveNote.Text = "Remove";
            this.btnRemoveNote.UseVisualStyleBackColor = true;
            // 
            // btnAddPlant
            // 
            this.btnAddPlant.Location = new System.Drawing.Point(1541, 4);
            this.btnAddPlant.Name = "btnAddPlant";
            this.btnAddPlant.Size = new System.Drawing.Size(92, 23);
            this.btnAddPlant.TabIndex = 32;
            this.btnAddPlant.Text = "Add new plant";
            this.btnAddPlant.UseVisualStyleBackColor = true;
            // 
            // btnCreateTag
            // 
            this.btnCreateTag.Location = new System.Drawing.Point(1443, 4);
            this.btnCreateTag.Name = "btnCreateTag";
            this.btnCreateTag.Size = new System.Drawing.Size(92, 23);
            this.btnCreateTag.TabIndex = 45;
            this.btnCreateTag.Text = "Create Tag";
            this.btnCreateTag.UseVisualStyleBackColor = true;
            // 
            // btnNewNote1
            // 
            this.btnNewNote1.Enabled = false;
            this.btnNewNote1.Location = new System.Drawing.Point(15, 585);
            this.btnNewNote1.Name = "btnNewNote1";
            this.btnNewNote1.Size = new System.Drawing.Size(109, 23);
            this.btnNewNote1.TabIndex = 53;
            this.btnNewNote1.Text = "New Note";
            this.btnNewNote1.UseVisualStyleBackColor = true;
            this.btnNewNote1.Click += new System.EventHandler(this.btnNewNote_Click);
            // 
            // btnEditNote
            // 
            this.btnEditNote.Enabled = false;
            this.btnEditNote.Location = new System.Drawing.Point(130, 585);
            this.btnEditNote.Name = "btnEditNote";
            this.btnEditNote.Size = new System.Drawing.Size(109, 23);
            this.btnEditNote.TabIndex = 68;
            this.btnEditNote.Text = "Edit Note Details";
            this.btnEditNote.UseVisualStyleBackColor = true;
            this.btnEditNote.Click += new System.EventHandler(this.btnEditNote_Click);
            // 
            // ToolStripUser
            // 
            this.ToolStripUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnNewJournalEntiry,
            this.toolStripSeparator1,
            this.btnNewJob,
            this.toolStripSeparator5,
            this.btnNewNote,
            this.toolStripSeparator6,
            this.btnSelectVegs,
            this.btnHelp,
            this.toolStripSeparator3,
            this.toolStripDropDownButton1,
            this.toolStripSeparator4,
            this.btnDelete});
            this.ToolStripUser.Location = new System.Drawing.Point(0, 0);
            this.ToolStripUser.Name = "ToolStripUser";
            this.ToolStripUser.Size = new System.Drawing.Size(1263, 25);
            this.ToolStripUser.TabIndex = 69;
            this.ToolStripUser.Text = "toolStrip";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNewJournalEntiry
            // 
            this.btnNewJournalEntiry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNewJournalEntiry.Image = ((System.Drawing.Image)(resources.GetObject("btnNewJournalEntiry.Image")));
            this.btnNewJournalEntiry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewJournalEntiry.Name = "btnNewJournalEntiry";
            this.btnNewJournalEntiry.Size = new System.Drawing.Size(109, 22);
            this.btnNewJournalEntiry.Text = "New Journal Entiry";
            this.btnNewJournalEntiry.Click += new System.EventHandler(this.btnNewJournalEntiry_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNewJob
            // 
            this.btnNewJob.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNewJob.Image = ((System.Drawing.Image)(resources.GetObject("btnNewJob.Image")));
            this.btnNewJob.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewJob.Name = "btnNewJob";
            this.btnNewJob.Size = new System.Drawing.Size(56, 22);
            this.btnNewJob.Text = "New Job";
            this.btnNewJob.Click += new System.EventHandler(this.btnNewJob_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNewNote
            // 
            this.btnNewNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNewNote.Image = ((System.Drawing.Image)(resources.GetObject("btnNewNote.Image")));
            this.btnNewNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewNote.Name = "btnNewNote";
            this.btnNewNote.Size = new System.Drawing.Size(64, 22);
            this.btnNewNote.Text = "New Note";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSelectVegs
            // 
            this.btnSelectVegs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSelectVegs.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectVegs.Image")));
            this.btnSelectVegs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectVegs.Name = "btnSelectVegs";
            this.btnSelectVegs.Size = new System.Drawing.Size(96, 22);
            this.btnSelectVegs.Text = "Select Vegetable";
            this.btnSelectVegs.Click += new System.EventHandler(this.btnSelectVegs_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(36, 22);
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewVegetable,
            this.btnNewCategory});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(47, 22);
            this.toolStripDropDownButton1.Text = "Tools";
            this.toolStripDropDownButton1.ToolTipText = "Tools";
            // 
            // btnNewVegetable
            // 
            this.btnNewVegetable.Name = "btnNewVegetable";
            this.btnNewVegetable.Size = new System.Drawing.Size(152, 22);
            this.btnNewVegetable.Text = "New Vegetable";
            this.btnNewVegetable.Click += new System.EventHandler(this.btnNewVegetable_Click);
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(152, 22);
            this.btnNewCategory.Text = "New  Category";
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRemoveJournalTag
            // 
            this.btnRemoveJournalTag.Location = new System.Drawing.Point(593, 52);
            this.btnRemoveJournalTag.Name = "btnRemoveJournalTag";
            this.btnRemoveJournalTag.Size = new System.Drawing.Size(109, 23);
            this.btnRemoveJournalTag.TabIndex = 51;
            this.btnRemoveJournalTag.Text = "Remove Filter";
            this.btnRemoveJournalTag.UseVisualStyleBackColor = true;
            this.btnRemoveJournalTag.Click += new System.EventHandler(this.btnJournalFilterRemove_Click);
            // 
            // cbJournalTags
            // 
            this.cbJournalTags.FormattingEnabled = true;
            this.cbJournalTags.Location = new System.Drawing.Point(360, 54);
            this.cbJournalTags.Name = "cbJournalTags";
            this.cbJournalTags.Size = new System.Drawing.Size(227, 21);
            this.cbJournalTags.TabIndex = 50;
            this.cbJournalTags.Text = "Tags";
            this.cbJournalTags.SelectedIndexChanged += new System.EventHandler(this.cbJournalFilterTags_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 820);
            this.Controls.Add(this.ToolStripUser);
            this.Controls.Add(this.btnEditNote);
            this.Controls.Add(this.btnNewNote1);
            this.Controls.Add(this.btnRemoveJournalTag);
            this.Controls.Add(this.cbJournalTags);
            this.Controls.Add(this.btnCreateTag);
            this.Controls.Add(this.btnAddPlant);
            this.Controls.Add(this.btnRemoveNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSelectedVeg);
            this.Controls.Add(this.listBoxJobs);
            this.Controls.Add(this.listBoxNotes);
            this.Controls.Add(this.listBoxJournal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garden Planner";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ToolStripUser.ResumeLayout(false);
            this.ToolStripUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxJournal;
        private System.Windows.Forms.ListBox listBoxNotes;
        private System.Windows.Forms.ListBox listBoxJobs;
        private System.Windows.Forms.ListBox listBoxSelectedVeg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemoveNote;
        private System.Windows.Forms.Button btnAddPlant;
        private System.Windows.Forms.Button btnCreateTag;
        private System.Windows.Forms.Button btnNewNote1;
        private System.Windows.Forms.Button btnEditNote;
        public System.Windows.Forms.ToolStrip ToolStripUser;
        private System.Windows.Forms.Button btnRemoveJournalTag;
        private System.Windows.Forms.ComboBox cbJournalTags;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripButton btnNewNote;
        private System.Windows.Forms.ToolStripButton btnNewJournalEntiry;
        private System.Windows.Forms.ToolStripButton btnNewJob;
        private System.Windows.Forms.ToolStripButton btnSelectVegs;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnNewVegetable;
        private System.Windows.Forms.ToolStripMenuItem btnNewCategory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnDelete;
    }
}

