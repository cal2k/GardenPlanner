namespace GardenPlanner.New_Entirys
{
    partial class NewSelectedVeg
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
            this.cbVegSpecies = new System.Windows.Forms.ComboBox();
            this.cbVegName = new System.Windows.Forms.ComboBox();
            this.btnAddSelectedVeg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbVegSpecies
            // 
            this.cbVegSpecies.Enabled = false;
            this.cbVegSpecies.FormattingEnabled = true;
            this.cbVegSpecies.Location = new System.Drawing.Point(12, 39);
            this.cbVegSpecies.Name = "cbVegSpecies";
            this.cbVegSpecies.Size = new System.Drawing.Size(312, 21);
            this.cbVegSpecies.TabIndex = 40;
            this.cbVegSpecies.SelectedIndexChanged += new System.EventHandler(this.cbVegSpecies_SelectedIndexChanged);
            // 
            // cbVegName
            // 
            this.cbVegName.FormattingEnabled = true;
            this.cbVegName.Location = new System.Drawing.Point(12, 12);
            this.cbVegName.Name = "cbVegName";
            this.cbVegName.Size = new System.Drawing.Size(312, 21);
            this.cbVegName.TabIndex = 39;
            this.cbVegName.Text = "Choose vegetables";
            this.cbVegName.SelectedIndexChanged += new System.EventHandler(this.cbVegName_SelectedIndexChanged);
            // 
            // btnAddSelectedVeg
            // 
            this.btnAddSelectedVeg.Enabled = false;
            this.btnAddSelectedVeg.Location = new System.Drawing.Point(12, 66);
            this.btnAddSelectedVeg.Name = "btnAddSelectedVeg";
            this.btnAddSelectedVeg.Size = new System.Drawing.Size(312, 23);
            this.btnAddSelectedVeg.TabIndex = 38;
            this.btnAddSelectedVeg.Text = "Add";
            this.btnAddSelectedVeg.UseVisualStyleBackColor = true;
            this.btnAddSelectedVeg.Click += new System.EventHandler(this.btnAddSelectedVeg_Click);
            // 
            // NewSelectedVeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 103);
            this.Controls.Add(this.cbVegSpecies);
            this.Controls.Add(this.cbVegName);
            this.Controls.Add(this.btnAddSelectedVeg);
            this.Name = "NewSelectedVeg";
            this.Text = "NewSelectedVeg";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVegSpecies;
        private System.Windows.Forms.ComboBox cbVegName;
        private System.Windows.Forms.Button btnAddSelectedVeg;
    }
}