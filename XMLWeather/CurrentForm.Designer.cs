namespace XMLWeather
{
    partial class CurrentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.currentWindLabel = new System.Windows.Forms.Label();
            this.currentTempLabel = new System.Windows.Forms.Label();
            this.windDirectLabel = new System.Windows.Forms.Label();
            this.cloudLabel = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.currentWeatherImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.currentWeatherImage)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(41, 141);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(426, 75);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(438, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(62, 46);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "X";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // currentWindLabel
            // 
            this.currentWindLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentWindLabel.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentWindLabel.Location = new System.Drawing.Point(9, 625);
            this.currentWindLabel.Name = "currentWindLabel";
            this.currentWindLabel.Size = new System.Drawing.Size(458, 52);
            this.currentWindLabel.TabIndex = 2;
            // 
            // currentTempLabel
            // 
            this.currentTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentTempLabel.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTempLabel.Location = new System.Drawing.Point(9, 449);
            this.currentTempLabel.Name = "currentTempLabel";
            this.currentTempLabel.Size = new System.Drawing.Size(458, 52);
            this.currentTempLabel.TabIndex = 3;
            // 
            // windDirectLabel
            // 
            this.windDirectLabel.BackColor = System.Drawing.Color.Transparent;
            this.windDirectLabel.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windDirectLabel.Location = new System.Drawing.Point(9, 713);
            this.windDirectLabel.Name = "windDirectLabel";
            this.windDirectLabel.Size = new System.Drawing.Size(458, 52);
            this.windDirectLabel.TabIndex = 4;
            // 
            // cloudLabel
            // 
            this.cloudLabel.BackColor = System.Drawing.Color.Transparent;
            this.cloudLabel.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloudLabel.Location = new System.Drawing.Point(9, 537);
            this.cloudLabel.Name = "cloudLabel";
            this.cloudLabel.Size = new System.Drawing.Size(458, 52);
            this.cloudLabel.TabIndex = 6;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.mainMenuButton.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(186, 0);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(257, 46);
            this.mainMenuButton.TabIndex = 7;
            this.mainMenuButton.Text = "Back to Menu";
            this.mainMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // cityLabel
            // 
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(41, 46);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(426, 75);
            this.cityLabel.TabIndex = 8;
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentWeatherImage
            // 
            this.currentWeatherImage.BackColor = System.Drawing.Color.Transparent;
            this.currentWeatherImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.currentWeatherImage.Location = new System.Drawing.Point(114, 219);
            this.currentWeatherImage.Name = "currentWeatherImage";
            this.currentWeatherImage.Size = new System.Drawing.Size(246, 208);
            this.currentWeatherImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.currentWeatherImage.TabIndex = 22;
            this.currentWeatherImage.TabStop = false;
            // 
            // CurrentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.currentWeatherImage);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.cloudLabel);
            this.Controls.Add(this.windDirectLabel);
            this.Controls.Add(this.currentTempLabel);
            this.Controls.Add(this.currentWindLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nameLabel);
            this.Name = "CurrentForm";
            this.Size = new System.Drawing.Size(500, 807);
            this.Load += new System.EventHandler(this.CurrentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currentWeatherImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Label currentWindLabel;
        private System.Windows.Forms.Label windDirectLabel;
        private System.Windows.Forms.Label currentTempLabel;
        private System.Windows.Forms.Label cloudLabel;
        private System.Windows.Forms.Label mainMenuButton;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.PictureBox currentWeatherImage;
    }
}
