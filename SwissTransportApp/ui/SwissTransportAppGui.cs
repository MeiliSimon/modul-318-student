using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using SwissTransportApp.ui;

namespace SwissTransportApp
{
    public partial class SwissTransportAppGui : Form
    {
        private ITransport transport;
        public SwissTransportAppGui()
        {
            InitializeComponent();
            transport = new Transport();
            string timeNow = DateTime.Now.ToString("HH:mm");
            connectionTimeTextBox.Text = timeNow;
            timeTableTextBox.Text = timeNow;
            destinationLabel.Visible = false;

        }

        private void searchConnections(object sender, EventArgs e)
        {
            try
            {
            connectionsListBox.Items.Clear();

            string date = ("&date="+dateTimePicker.Value.Year + "-" + dateTimePicker.Value.Month + "-" + dateTimePicker.Value.Day +"&time="+ connectionTimeTextBox.Text);
         
            foreach (Connection connection in transport.GetConnections(departurePointComboBox.Text, destinationComboBox.Text,date).ConnectionList)
            {
                connectionsListBox.Items.Add(showConnections(connection).Text);
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte gültige Werte angeben.");
            }
        }

        private void departurePointComboBox_TextUpdate(object sender, EventArgs e)
        {
            clearComboBox(departurePointComboBox);
            addItemsToDropdown(departurePointComboBox);
            regexForComboBox(departurePointComboBox);
        }

        private void destinationComboBox_TextUpdate(object sender, EventArgs e)
        {
            clearComboBox(destinationComboBox);
            addItemsToDropdown(destinationComboBox);
            regexForComboBox(destinationComboBox);
        }

        private void stationComboBox_TextUpdate(object sender, EventArgs e)
        {
            clearComboBox(stationComboBox);
            addItemsToDropdown(stationComboBox);
            regexForComboBox(stationComboBox);
        }

        private void connectionTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            timeTextBoxValue(connectionTimeTextBox);
        }

        private void timeTableTextBox_TextChanged(object sender, EventArgs e)
        {
            timeTextBoxValue(timeTableTextBox);
        }

        private void timeTextBoxValue(TextBox textBox)
        {
            if (textBox.Text.Length == 0)
                textBox.Text = "HH:mm";
            if (textBox.TextLength > 5)
            {
                textBox.Text = Regex.Replace(textBox.Text, "[^0-9:]", "");
                textBox.SelectionStart = textBox.TextLength;

            }
        }
        private void clearComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.SelectionStart = comboBox.Text.Length;
            comboBox.SelectionLength = 0;
            
        }

        private void addItemsToDropdown(ComboBox comboBox)
        {
            foreach (Station station in transport.GetStations(comboBox.Text).StationList)
            {
                if (station.Name != null)
                    comboBox.Items.Add(station.Name);
            }
        }

        private void regexForComboBox(ComboBox comboBox)
        {
            comboBox.Text = Regex.Replace(comboBox.Text, "[^a-zA-Z ::blank:,/äöüë]", "");
            comboBox.SelectionStart = comboBox.Text.Length;
        }

        private ListViewItem showConnections(Connection connection)
        {
            string[] connections = { "Von: "+connection.From.Station.Name
                    +" ; Abfahrtszeit: "+connection.From.Departure.Substring(11, 5)
                    +" ; Nach:  "+connection.To.Station.Name
                    +" ; Ankunftszeit: "+connection.To.Arrival.Substring(11, 5)
                    + " ; Dauer: "+ connection.Duration.Substring(3,6)};
            return new ListViewItem(connections);
        }

        private void createTimetableButton_Click(object sender, EventArgs e)
        {
            timetableListBox.Items.Clear();
            destinationLabel.Visible = false;
            try
            {
            string date = "&datetime="+timeTableDateTimePicker.Value.ToString("yyyy-MM-dd")+"" + timeTableTextBox.Text;
            foreach (StationBoard stationBoard in transport.GetStationBoard(stationComboBox.Text, "",date).Entries)
            {

                timetableListBox.Items.Add(showStationBoard(stationBoard).Text);
            }
                destinationLabel.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte gültige Werte angeben");
                stationComboBox.ResetText();
            }
        }

        private ListViewItem showStationBoard(StationBoard stationBoard)
        {
            string[] content = {stationBoard.Category
                    +"" + Regex.Replace(stationBoard.Number, "[^0-9]", "")
                    +"\t" + stationBoard.Stop.Departure.ToString().Substring(11, 5).Replace(':','.')
                    +"\t" +stationBoard.To};
            return new ListViewItem(content);
        }

        private void showOnMapButton_Click(object sender, EventArgs e)
        {
            ShowOnMapMessageBox messageBox = new ShowOnMapMessageBox();
            messageBox.setDepartureStation(getCoordinatsFromStation(departurePointComboBox.Text));
            messageBox.setDestinationStation(getCoordinatsFromStation(destinationComboBox.Text));
            messageBox.Show();
        }
        private string getCoordinatsFromStation(string stationname)
        {
            foreach (Station station in transport.GetStations(stationname).StationList)
            {
                if (station.Name.Equals(stationname))
            return station.Coordinate.XCoordinate.ToString() + "," + station.Coordinate.YCoordinate.ToString();
            }
            return "";
        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            string mailContent = "";
            foreach (string content in connectionsListBox.Items)
            {
                if (content != null)
                {
                    mailContent += content + "%0a";
                }
            }

            if (mailContent != "")
            {
                System.Diagnostics.Process.Start(
                String.Format("mailto:{0}?subject={1}&body={2}",
                  "",
                  "Verbindung von: "+departurePointComboBox.Text + " nach: " + destinationComboBox.Text,
                  mailContent));

            }
            else
            {
                MessageBox.Show("Es wurden keine Verbindungen gefunden");
            }

        }
    }
}
