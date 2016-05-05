namespace XMLWeather
{
    partial class ForecastMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForecastMenu));
            this.mainMenuButton = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dayOneButton = new System.Windows.Forms.Button();
            this.dayThreeButton = new System.Windows.Forms.Button();
            this.dayTwoButton = new System.Windows.Forms.Button();
            this.dayFourButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.mainMenuButton.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(199, 0);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(243, 46);
            this.mainMenuButton.TabIndex = 18;
            this.mainMenuButton.Text = "Back to Menu";
            this.mainMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(448, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(51, 46);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "X";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(38, 73);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(431, 96);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Stratford Weather";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayOneButton
            // 
            this.dayOneButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.dayOneButton.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOneButton.Location = new System.Drawing.Point(14, 209);
            this.dayOneButton.Name = "dayOneButton";
            this.dayOneButton.Size = new System.Drawing.Size(468, 97);
            this.dayOneButton.TabIndex = 19;
            this.dayOneButton.UseVisualStyleBackColor = false;
            this.dayOneButton.Click += new System.EventHandler(this.dayOneButton_Click);
            // 
            // dayThreeButton
            // 
            this.dayThreeButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.dayThreeButton.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayThreeButton.Location = new System.Drawing.Point(14, 531);
            this.dayThreeButton.Name = "dayThreeButton";
            this.dayThreeButton.Size = new System.Drawing.Size(468, 97);
            this.dayThreeButton.TabIndex = 20;
            this.dayThreeButton.UseVisualStyleBackColor = false;
            this.dayThreeButton.Click += new System.EventHandler(this.dayThreeButton_Click);
            // 
            // dayTwoButton
            // 
            this.dayTwoButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.dayTwoButton.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayTwoButton.Location = new System.Drawing.Point(14, 370);
            this.dayTwoButton.Name = "dayTwoButton";
            this.dayTwoButton.Size = new System.Drawing.Size(468, 97);
            this.dayTwoButton.TabIndex = 21;
            this.dayTwoButton.UseVisualStyleBackColor = false;
            this.dayTwoButton.Click += new System.EventHandler(this.dayTwoButton_Click);
            // 
            // dayFourButton
            // 
            this.dayFourButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.dayFourButton.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayFourButton.Location = new System.Drawing.Point(14, 692);
            this.dayFourButton.Name = "dayFourButton";
            this.dayFourButton.Size = new System.Drawing.Size(468, 97);
            this.dayFourButton.TabIndex = 22;
            this.dayFourButton.UseVisualStyleBackColor = false;
            this.dayFourButton.Click += new System.EventHandler(this.dayFourButton_Click);
            // 
            // ForecastMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.dayFourButton);
            this.Controls.Add(this.dayTwoButton);
            this.Controls.Add(this.dayThreeButton);
            this.Controls.Add(this.dayOneButton);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nameLabel);
            this.Name = "ForecastMenu";
            this.Size = new System.Drawing.Size(500, 807);
            this.Load += new System.EventHandler(this.ForecastMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainMenuButton;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button dayOneButton;
        private System.Windows.Forms.Button dayThreeButton;
        private System.Windows.Forms.Button dayTwoButton;
        private System.Windows.Forms.Button dayFourButton;
    }
}
