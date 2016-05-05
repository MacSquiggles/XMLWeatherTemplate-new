namespace XMLWeather
{
    partial class MainMenu
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
            this.futureButton = new System.Windows.Forms.Button();
            this.currentButton = new System.Windows.Forms.Button();
            this.cityOutput = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // futureButton
            // 
            this.futureButton.BackColor = System.Drawing.Color.White;
            this.futureButton.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futureButton.Location = new System.Drawing.Point(299, 611);
            this.futureButton.Name = "futureButton";
            this.futureButton.Size = new System.Drawing.Size(165, 129);
            this.futureButton.TabIndex = 5;
            this.futureButton.Text = "Future    Forcast";
            this.futureButton.UseVisualStyleBackColor = false;
            this.futureButton.Click += new System.EventHandler(this.futureButton_Click);
            // 
            // currentButton
            // 
            this.currentButton.BackColor = System.Drawing.Color.White;
            this.currentButton.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentButton.Location = new System.Drawing.Point(30, 611);
            this.currentButton.Name = "currentButton";
            this.currentButton.Size = new System.Drawing.Size(165, 129);
            this.currentButton.TabIndex = 4;
            this.currentButton.Text = "Current Forcast";
            this.currentButton.UseVisualStyleBackColor = false;
            this.currentButton.Click += new System.EventHandler(this.currentButton_Click);
            // 
            // cityOutput
            // 
            this.cityOutput.AutoSize = true;
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Pristina", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(49, 93);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(388, 75);
            this.cityOutput.TabIndex = 3;
            this.cityOutput.Text = "Stratford Weather";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(449, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(51, 46);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "X";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.hip_star;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.futureButton);
            this.Controls.Add(this.currentButton);
            this.Controls.Add(this.cityOutput);
            this.DoubleBuffered = true;
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(500, 807);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button futureButton;
        private System.Windows.Forms.Button currentButton;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label exitButton;
    }
}
