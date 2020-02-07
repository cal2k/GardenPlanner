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
        string name, species, sowingnote, harvestnote, growingnote, common, special, compaion;
        
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
            special = tbSpecial.Text;
            sowingStart = Convert.ToInt32(tbSowingStart.Text);
            sowingEnd = Convert.ToInt32(tbSowingEnd.Text);
            sowingnote = tbSowingNotes.Text;
            growingnote = tbGrowingNotes.Text;
            harvestStart = Convert.ToInt32(tbHarvestStart.Text);
            harvestEnd = Convert.ToInt32(tbHarvestEnd.Text);
            harvestnote = tbHarvestNotes.Text;
            common = tbCommonProblems.Text;
            species = tbSpecial.Text;
            compaion = tbCompanions.Text;

            if (CheckValid())
            {
                SQL.QUERY = "INSERT INTO Vegs (Name, Species, SowStart, SowEnd, Sowing, Growing, HarvestStart, HarvestEnd, Harvest, CommonProblems, Special, Companion)" +
                    " VALUES ('" + name + "', '" + species + "', '" + sowingStart + "', '" + sowingEnd + "', '" + sowingnote + "', '" + growingnote +"', '" +
                    harvestStart + "', '" + harvestEnd + "', '" + harvestnote + "', '" + common + "', '" + special + "', '" + compaion + "')";

                SQL.queryExecute();

                this.Close();
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
