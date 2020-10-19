namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentScreen));
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.percipitationLabel = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(60, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(171, 36);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.maxOutput.ForeColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(86, 196);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(98, 25);
            this.maxOutput.TabIndex = 32;
            this.maxOutput.Text = "0/0";
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(89, 36);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(195, 93);
            this.currentOutput.TabIndex = 28;
            this.currentOutput.Text = "0";
            this.currentOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.forecastLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.forecastLabel.Location = new System.Drawing.Point(68, 438);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(136, 15);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "Extended Forecast";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(77, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3, 40);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(190, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(3, 40);
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // percipitationLabel
            // 
            this.percipitationLabel.BackColor = System.Drawing.Color.Transparent;
            this.percipitationLabel.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.percipitationLabel.ForeColor = System.Drawing.Color.White;
            this.percipitationLabel.Location = new System.Drawing.Point(6, 196);
            this.percipitationLabel.Name = "percipitationLabel";
            this.percipitationLabel.Size = new System.Drawing.Size(65, 25);
            this.percipitationLabel.TabIndex = 44;
            this.percipitationLabel.Text = "0";
            this.percipitationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windLabel
            // 
            this.windLabel.BackColor = System.Drawing.Color.Transparent;
            this.windLabel.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.windLabel.ForeColor = System.Drawing.Color.White;
            this.windLabel.Location = new System.Drawing.Point(199, 196);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(65, 25);
            this.windLabel.TabIndex = 45;
            this.windLabel.Text = "0m/s";
            this.windLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(42, 152);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(183, 25);
            this.date.TabIndex = 46;
            this.date.Text = "0";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(52, 287);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(166, 34);
            this.inputBox.TabIndex = 47;
            this.inputBox.Text = "";
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Location = new System.Drawing.Point(216, 287);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(33, 34);
            this.searchButton.TabIndex = 48;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.date);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.percipitationLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.currentOutput);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(287, 470);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label percipitationLabel;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.Button searchButton;
    }
}
