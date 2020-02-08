using System;
using System.Windows.Forms;
using System.IO;

namespace GardenPlanner.Tools
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();

            string applicationDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            string myFile = Path.Combine(applicationDirectory, "Help\\index.html");
            webBrowser1.Url = new Uri("file:///" + myFile);
        }
    }
}
