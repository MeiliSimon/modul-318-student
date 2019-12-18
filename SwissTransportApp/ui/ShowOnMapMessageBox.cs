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
    public partial class ShowOnMapMessageBox : Form
    {
        private string departureStation;
        private string destinationStation;
        public ShowOnMapMessageBox()
        {
            InitializeComponent();
        }
        public void setDepartureStation(string departureStation)
        {
            this.departureStation = departureStation;
        }
        public void setDestinationStation(string destinationStation)
        {
            this.destinationStation = destinationStation;   
        }
        private void abortButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showOnMapButton_Click(object sender, EventArgs e)
        {
            ShowOnMap map = new ShowOnMap();
            string url="";
            if (showDepartmentStationOnMapRadioButton.Checked)
            {
                url = "https://www.google.de/maps?q=" + departureStation;
            }
            else
            {
                url = "https://www.google.de/maps?q=" + destinationStation;
            }
            map.setUrl(url);
            map.Show();
            this.Close();
        }
    }
}
