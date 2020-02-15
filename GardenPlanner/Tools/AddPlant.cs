using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GardenPlanner
{
    public partial class AddPlant : Form
    {
        SqL SQL = new SqL();
        string name, species, sowingnote, harvestnote, growingnote, common, special, compaion, temp;
        
        int required, sowingStart, sowingEnd, harvestStart, harvestEnd;


        private class RequiredItem
        {
            public TextBox textbox;
            public string name;

            public RequiredItem(string name, TextBox textbox)
            {
                this.textbox = textbox; 
                this.name = name;
            }
        }
        
        List<RequiredItem> Required = new List<RequiredItem>();

        public AddPlant()
        {
            InitializeComponent();

            //building list of required fileds
            Required.Add(new RequiredItem("name", tbName));
            Required.Add(new RequiredItem("species", tbSpecies));
            Required.Add(new RequiredItem("sowingStart", tbSowingStart));
            Required.Add(new RequiredItem("sowingEnd", tbSowingEnd));
            Required.Add(new RequiredItem("harvestStart", tbHarvestStart));
            Required.Add(new RequiredItem("harvestEnd", tbHarvestEnd));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //set textbox colour back to windows
            foreach (RequiredItem item in Required)
            {
                item.textbox.BackColor = Color.White;
            }
            name = tbName.Text;
            temp = name;
            checktext();
            name = temp;

            species = tbSpecial.Text;
            temp = species;
            checktext();
            species = temp;

            sowingStart = Convert.ToInt32(tbSowingStart.Text);
            sowingEnd = Convert.ToInt32(tbSowingEnd.Text);

            sowingnote = tbSowingNotes.Text;
            temp = sowingnote;
            checktext();
            sowingnote = temp;

            growingnote = tbGrowingNotes.Text;
            temp = growingnote;
            checktext();
            growingnote = temp;

            harvestStart = Convert.ToInt32(tbHarvestStart.Text);
            harvestEnd = Convert.ToInt32(tbHarvestEnd.Text);

            harvestnote = tbHarvestNotes.Text;
            temp = harvestnote;
            checktext();
            harvestnote = temp;

            common = tbCommonProblems.Text;
            temp = common;
            checktext();
            common = temp;

            special = tbSpecial.Text;
            temp = special;
            checktext();
            special = temp;

            compaion = tbCompanions.Text;
            temp = compaion;
            checktext();
            compaion = temp;

            if (CheckValid())
            {
                SQL.QUERY = "INSERT INTO Vegs (Name, Species, SowStart, SowEnd, Sowing, Growing, HarvestStart, HarvestEnd, Harvest, CommonProblems, Special, Companion)" +
                    " VALUES ('" + name + "', '" + species + "', '" + sowingStart + "', '" + sowingEnd + "', '" + sowingnote + "', '" + growingnote +"', '" +
                    harvestStart + "', '" + harvestEnd + "', '" + harvestnote + "', '" + common + "', '" + special + "', '" + compaion + "')";

                SQL.queryExecute();

                this.Close();
            }
        }
        private void checktext()
        {
            if(temp.Contains("'"))
            {
                temp = temp.Replace("'", "*A*");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private bool CheckValid()
        {
            int count = 0;
            required = Required.Count();
            bool valid = true;

            StringBuilder errorMessage = new StringBuilder();
            errorMessage.Append("The following textboxes cannot be blank:\n");

            while (count < required)
            {
                if (Required[count].textbox.Text.Length < 1)
                {
                    Required[count].textbox.BackColor = Color.Red;
                    errorMessage.Append(Required[count].name + "\n");
                    valid = false;
                }
                count++;
            }

            if (!valid)
            {
                MessageBox.Show(errorMessage.ToString());
            }

            return valid;
        }
    }
}
