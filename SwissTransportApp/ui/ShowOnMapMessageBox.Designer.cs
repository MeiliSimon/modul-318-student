namespace SwissTransportApp.ui
{
    partial class ShowOnMapMessageBox
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
            this.showOnMapGroupBox = new System.Windows.Forms.GroupBox();
            this.showDestinationStationOnMapRadioButton = new System.Windows.Forms.RadioButton();
            this.showDepartmentStationOnMapRadioButton = new System.Windows.Forms.RadioButton();
            this.showOnMapLabel = new System.Windows.Forms.Label();
            this.abortButton = new System.Windows.Forms.Button();
            this.showOnMapButton = new System.Windows.Forms.Button();
            this.showOnMapGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // showOnMapGroupBox
            // 
            this.showOnMapGroupBox.Controls.Add(this.showDestinationStationOnMapRadioButton);
            this.showOnMapGroupBox.Controls.Add(this.showDepartmentStationOnMapRadioButton);
            this.showOnMapGroupBox.Location = new System.Drawing.Point(12, 50);
            this.showOnMapGroupBox.Name = "showOnMapGroupBox";
            this.showOnMapGroupBox.Size = new System.Drawing.Size(200, 95);
            this.showOnMapGroupBox.TabIndex = 0;
            this.showOnMapGroupBox.TabStop = false;
            // 
            // showDestinationStationOnMapRadioButton
            // 
            this.showDestinationStationOnMapRadioButton.AutoSize = true;
            this.showDestinationStationOnMapRadioButton.Location = new System.Drawing.Point(7, 59);
            this.showDestinationStationOnMapRadioButton.Name = "showDestinationStationOnMapRadioButton";
            this.showDestinationStationOnMapRadioButton.Size = new System.Drawing.Size(101, 21);
            this.showDestinationStationOnMapRadioButton.TabIndex = 1;
            this.showDestinationStationOnMapRadioButton.Text = "Ankunftsort";
            this.showDestinationStationOnMapRadioButton.UseVisualStyleBackColor = true;
            // 
            // showDepartmentStationOnMapRadioButton
            // 
            this.showDepartmentStationOnMapRadioButton.AutoSize = true;
            this.showDepartmentStationOnMapRadioButton.Checked = true;
            this.showDepartmentStationOnMapRadioButton.Location = new System.Drawing.Point(6, 32);
            this.showDepartmentStationOnMapRadioButton.Name = "showDepartmentStationOnMapRadioButton";
            this.showDepartmentStationOnMapRadioButton.Size = new System.Drawing.Size(99, 21);
            this.showDepartmentStationOnMapRadioButton.TabIndex = 0;
            this.showDepartmentStationOnMapRadioButton.TabStop = true;
            this.showDepartmentStationOnMapRadioButton.Text = "Abfahrtsort";
            this.showDepartmentStationOnMapRadioButton.UseVisualStyleBackColor = true;
            // 
            // showOnMapLabel
            // 
            this.showOnMapLabel.AutoSize = true;
            this.showOnMapLabel.Location = new System.Drawing.Point(12, 13);
            this.showOnMapLabel.Name = "showOnMapLabel";
            this.showOnMapLabel.Size = new System.Drawing.Size(137, 34);
            this.showOnMapLabel.TabIndex = 1;
            this.showOnMapLabel.Text = "Was wollen Sie auf \r\nder Karte anzeigen?";
            // 
            // abortButton
            // 
            this.abortButton.Location = new System.Drawing.Point(12, 151);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(75, 32);
            this.abortButton.TabIndex = 2;
            this.abortButton.Text = "Abbrechen";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // showOnMapButton
            // 
            this.showOnMapButton.Location = new System.Drawing.Point(113, 151);
            this.showOnMapButton.Name = "showOnMapButton";
            this.showOnMapButton.Size = new System.Drawing.Size(75, 32);
            this.showOnMapButton.TabIndex = 3;
            this.showOnMapButton.Text = "Anzeigen";
            this.showOnMapButton.UseVisualStyleBackColor = true;
            this.showOnMapButton.Click += new System.EventHandler(this.showOnMapButton_Click);
            // 
            // ShowOnMapMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 194);
            this.ControlBox = false;
            this.Controls.Add(this.showOnMapButton);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.showOnMapLabel);
            this.Controls.Add(this.showOnMapGroupBox);
            this.Name = "ShowOnMapMessageBox";
            this.ShowInTaskbar = false;
            this.showOnMapGroupBox.ResumeLayout(false);
            this.showOnMapGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox showOnMapGroupBox;
        private System.Windows.Forms.RadioButton showDestinationStationOnMapRadioButton;
        private System.Windows.Forms.RadioButton showDepartmentStationOnMapRadioButton;
        private System.Windows.Forms.Label showOnMapLabel;
        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.Button showOnMapButton;
    }
}