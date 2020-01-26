using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenPlanner
{
    public partial class DisplayJournal : Form
    {
        string title, details;

        public DisplayJournal()
        {
            InitializeComponent();
        }

        public void load()
        {

        }
        public void save()
        {

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            tbTitle.Enabled = true;
            tbDetails.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
