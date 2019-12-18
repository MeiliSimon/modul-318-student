namespace SwissTransportApp
{
    partial class SwissTransportAppGui
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timetableTabPage = new System.Windows.Forms.TabPage();
            this.timetableListBox = new System.Windows.Forms.ListBox();
            this.createTimetableButton = new System.Windows.Forms.Button();
            this.timeTableDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.stationComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.connectionTabPage = new System.Windows.Forms.TabPage();
            this.connectionTimeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.connectionsListBox = new System.Windows.Forms.ListBox();
            this.searchConnectionButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            this.departurePointComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.showOnMapButton = new System.Windows.Forms.Button();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.timeTableTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timetableTabPage.SuspendLayout();
            this.connectionTabPage.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // timetableTabPage
            // 
            this.timetableTabPage.Controls.Add(this.timeTableTextBox);
            this.timetableTabPage.Controls.Add(this.label7);
            this.timetableTabPage.Controls.Add(this.destinationLabel);
            this.timetableTabPage.Controls.Add(this.timetableListBox);
            this.timetableTabPage.Controls.Add(this.createTimetableButton);
            this.timetableTabPage.Controls.Add(this.timeTableDateTimePicker);
            this.timetableTabPage.Controls.Add(this.label6);
            this.timetableTabPage.Controls.Add(this.stationComboBox);
            this.timetableTabPage.Controls.Add(this.label5);
            this.timetableTabPage.Location = new System.Drawing.Point(4, 25);
            this.timetableTabPage.Name = "timetableTabPage";
            this.timetableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.timetableTabPage.Size = new System.Drawing.Size(714, 461);
            this.timetableTabPage.TabIndex = 1;
            this.timetableTabPage.Text = "Abfahrtsplan";
            this.timetableTabPage.UseVisualStyleBackColor = true;
            // 
            // timetableListBox
            // 
            this.timetableListBox.FormattingEnabled = true;
            this.timetableListBox.ItemHeight = 16;
            this.timetableListBox.Location = new System.Drawing.Point(14, 169);
            this.timetableListBox.Name = "timetableListBox";
            this.timetableListBox.Size = new System.Drawing.Size(688, 260);
            this.timetableListBox.TabIndex = 5;
            // 
            // createTimetableButton
            // 
            this.createTimetableButton.Location = new System.Drawing.Point(364, 126);
            this.createTimetableButton.Name = "createTimetableButton";
            this.createTimetableButton.Size = new System.Drawing.Size(239, 33);
            this.createTimetableButton.TabIndex = 4;
            this.createTimetableButton.Text = "Abfahrtsplan erstellen";
            this.createTimetableButton.UseVisualStyleBackColor = true;
            this.createTimetableButton.Click += new System.EventHandler(this.createTimetableButton_Click);
            // 
            // timeTableDateTimePicker
            // 
            this.timeTableDateTimePicker.Location = new System.Drawing.Point(97, 75);
            this.timeTableDateTimePicker.MinimumSize = new System.Drawing.Size(240, 24);
            this.timeTableDateTimePicker.Name = "timeTableDateTimePicker";
            this.timeTableDateTimePicker.Size = new System.Drawing.Size(249, 24);
            this.timeTableDateTimePicker.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Datum";
            // 
            // stationComboBox
            // 
            this.stationComboBox.FormattingEnabled = true;
            this.stationComboBox.Location = new System.Drawing.Point(97, 25);
            this.stationComboBox.Name = "stationComboBox";
            this.stationComboBox.Size = new System.Drawing.Size(249, 24);
            this.stationComboBox.TabIndex = 1;
            this.stationComboBox.TextUpdate += new System.EventHandler(this.stationComboBox_TextUpdate);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bahnhof";
            // 
            // connectionTabPage
            // 
            this.connectionTabPage.Controls.Add(this.connectionTimeTextBox);
            this.connectionTabPage.Controls.Add(this.label4);
            this.connectionTabPage.Controls.Add(this.connectionsListBox);
            this.connectionTabPage.Controls.Add(this.searchConnectionButton);
            this.connectionTabPage.Controls.Add(this.dateTimePicker);
            this.connectionTabPage.Controls.Add(this.destinationComboBox);
            this.connectionTabPage.Controls.Add(this.departurePointComboBox);
            this.connectionTabPage.Controls.Add(this.label3);
            this.connectionTabPage.Controls.Add(this.label2);
            this.connectionTabPage.Controls.Add(this.label1);
            this.connectionTabPage.Location = new System.Drawing.Point(4, 25);
            this.connectionTabPage.Name = "connectionTabPage";
            this.connectionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.connectionTabPage.Size = new System.Drawing.Size(714, 461);
            this.connectionTabPage.TabIndex = 0;
            this.connectionTabPage.Text = "Verbindung";
            this.connectionTabPage.UseVisualStyleBackColor = true;
            // 
            // connectionTimeTextBox
            // 
            this.connectionTimeTextBox.Location = new System.Drawing.Point(451, 78);
            this.connectionTimeTextBox.MinimumSize = new System.Drawing.Size(4, 24);
            this.connectionTimeTextBox.Name = "connectionTimeTextBox";
            this.connectionTimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.connectionTimeTextBox.TabIndex = 4;
            this.connectionTimeTextBox.Text = "HH : mm";
            this.connectionTimeTextBox.TextChanged += new System.EventHandler(this.connectionTimeTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Zeit";
            // 
            // connectionsListBox
            // 
            this.connectionsListBox.FormattingEnabled = true;
            this.connectionsListBox.ItemHeight = 16;
            this.connectionsListBox.Location = new System.Drawing.Point(23, 195);
            this.connectionsListBox.Name = "connectionsListBox";
            this.connectionsListBox.Size = new System.Drawing.Size(667, 260);
            this.connectionsListBox.TabIndex = 6;
            // 
            // searchConnectionButton
            // 
            this.searchConnectionButton.Location = new System.Drawing.Point(391, 123);
            this.searchConnectionButton.Name = "searchConnectionButton";
            this.searchConnectionButton.Size = new System.Drawing.Size(239, 33);
            this.searchConnectionButton.TabIndex = 5;
            this.searchConnectionButton.Text = "Verbindung suchen";
            this.searchConnectionButton.UseVisualStyleBackColor = true;
            this.searchConnectionButton.Click += new System.EventHandler(this.searchConnections);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(104, 78);
            this.dateTimePicker.MinimumSize = new System.Drawing.Size(4, 24);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(239, 24);
            this.dateTimePicker.TabIndex = 3;
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.FormattingEnabled = true;
            this.destinationComboBox.Location = new System.Drawing.Point(451, 36);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.Size = new System.Drawing.Size(239, 24);
            this.destinationComboBox.TabIndex = 2;
            this.destinationComboBox.TextUpdate += new System.EventHandler(this.destinationComboBox_TextUpdate);
            // 
            // departurePointComboBox
            // 
            this.departurePointComboBox.FormattingEnabled = true;
            this.departurePointComboBox.Location = new System.Drawing.Point(104, 36);
            this.departurePointComboBox.Name = "departurePointComboBox";
            this.departurePointComboBox.Size = new System.Drawing.Size(239, 24);
            this.departurePointComboBox.TabIndex = 1;
            this.departurePointComboBox.TextUpdate += new System.EventHandler(this.departurePointComboBox_TextUpdate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zielort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abfahrtsort";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.connectionTabPage);
            this.tabControl.Controls.Add(this.timetableTabPage);
            this.tabControl.Location = new System.Drawing.Point(2, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(722, 490);
            this.tabControl.TabIndex = 0;
            // 
            // showOnMapButton
            // 
            this.showOnMapButton.Location = new System.Drawing.Point(29, 503);
            this.showOnMapButton.Name = "showOnMapButton";
            this.showOnMapButton.Size = new System.Drawing.Size(144, 31);
            this.showOnMapButton.TabIndex = 1;
            this.showOnMapButton.Text = "Auf Karte anzeigen";
            this.showOnMapButton.UseVisualStyleBackColor = true;
            this.showOnMapButton.Click += new System.EventHandler(this.showOnMapButton_Click);
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(146, 134);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(41, 17);
            this.destinationLabel.TabIndex = 5;
            this.destinationLabel.Text = "Nach";
            // 
            // timeTableTextBox
            // 
            this.timeTableTextBox.Location = new System.Drawing.Point(503, 75);
            this.timeTableTextBox.MinimumSize = new System.Drawing.Size(4, 24);
            this.timeTableTextBox.Name = "timeTableTextBox";
            this.timeTableTextBox.Size = new System.Drawing.Size(100, 24);
            this.timeTableTextBox.TabIndex = 3;
            this.timeTableTextBox.Text = "HH : mm";
            this.timeTableTextBox.TextChanged += new System.EventHandler(this.timeTableTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Zeit";
            // 
            // SwissTransportAppGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 538);
            this.Controls.Add(this.showOnMapButton);
            this.Controls.Add(this.tabControl);
            this.Name = "SwissTransportAppGui";
            this.Text = "SBB APP";
            this.timetableTabPage.ResumeLayout(false);
            this.timetableTabPage.PerformLayout();
            this.connectionTabPage.ResumeLayout(false);
            this.connectionTabPage.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage timetableTabPage;
        private System.Windows.Forms.ListBox timetableListBox;
        private System.Windows.Forms.Button createTimetableButton;
        private System.Windows.Forms.DateTimePicker timeTableDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox stationComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage connectionTabPage;
        private System.Windows.Forms.TextBox connectionTimeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox connectionsListBox;
        private System.Windows.Forms.Button searchConnectionButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox destinationComboBox;
        private System.Windows.Forms.ComboBox departurePointComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button showOnMapButton;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.TextBox timeTableTextBox;
        private System.Windows.Forms.Label label7;
    }
}

