using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportApp.ui
{
    public partial class ShowOnMap : Form
    {
        public ShowOnMap()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Set the url for google maps. 
        /// </summary>
        /// <param name="url">Contains the coordinates from the station.</param>
        public void setUrl(string url)
        {
            showOnMapWebBrowser.ScriptErrorsSuppressed = true;
            showOnMapWebBrowser.Url = new Uri(url);
        }
    }
}
