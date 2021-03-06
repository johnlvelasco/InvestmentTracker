namespace InvestmentTracker
{
    partial class Display
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
            this.uxPriceLabel = new System.Windows.Forms.Label();
            this.uxLowLabel = new System.Windows.Forms.Label();
            this.uxHighLabel = new System.Windows.Forms.Label();
            this.uxRateLabel = new System.Windows.Forms.Label();
            this.uxName = new System.Windows.Forms.Label();
            this.uxPrice = new System.Windows.Forms.Label();
            this.uxRate = new System.Windows.Forms.Label();
            this.uxHigh = new System.Windows.Forms.Label();
            this.uxLow = new System.Windows.Forms.Label();
            this.uxVisual = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxVisual)).BeginInit();
            this.SuspendLayout();
            // 
            // uxPriceLabel
            // 
            this.uxPriceLabel.AutoSize = true;
            this.uxPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPriceLabel.Location = new System.Drawing.Point(17, 74);
            this.uxPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxPriceLabel.Name = "uxPriceLabel";
            this.uxPriceLabel.Size = new System.Drawing.Size(67, 25);
            this.uxPriceLabel.TabIndex = 0;
            this.uxPriceLabel.Text = "Price: ";
            // 
            // uxLowLabel
            // 
            this.uxLowLabel.AutoSize = true;
            this.uxLowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLowLabel.Location = new System.Drawing.Point(231, 111);
            this.uxLowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLowLabel.Name = "uxLowLabel";
            this.uxLowLabel.Size = new System.Drawing.Size(54, 25);
            this.uxLowLabel.TabIndex = 1;
            this.uxLowLabel.Text = "Low:";
            // 
            // uxHighLabel
            // 
            this.uxHighLabel.AutoSize = true;
            this.uxHighLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHighLabel.Location = new System.Drawing.Point(231, 74);
            this.uxHighLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxHighLabel.Name = "uxHighLabel";
            this.uxHighLabel.Size = new System.Drawing.Size(58, 25);
            this.uxHighLabel.TabIndex = 2;
            this.uxHighLabel.Text = "High:";
            // 
            // uxRateLabel
            // 
            this.uxRateLabel.AutoSize = true;
            this.uxRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRateLabel.Location = new System.Drawing.Point(17, 111);
            this.uxRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxRateLabel.Name = "uxRateLabel";
            this.uxRateLabel.Size = new System.Drawing.Size(58, 25);
            this.uxRateLabel.TabIndex = 3;
            this.uxRateLabel.Text = "Rate:";
            // 
            // uxName
            // 
            this.uxName.AutoSize = true;
            this.uxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxName.Location = new System.Drawing.Point(179, 11);
            this.uxName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(89, 39);
            this.uxName.TabIndex = 8;
            this.uxName.Text = "ETH";
            // 
            // uxPrice
            // 
            this.uxPrice.AutoSize = true;
            this.uxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPrice.Location = new System.Drawing.Point(95, 74);
            this.uxPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxPrice.Name = "uxPrice";
            this.uxPrice.Size = new System.Drawing.Size(47, 25);
            this.uxPrice.TabIndex = 9;
            this.uxPrice.Text = "text";
            // 
            // uxRate
            // 
            this.uxRate.AutoSize = true;
            this.uxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRate.Location = new System.Drawing.Point(95, 111);
            this.uxRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxRate.Name = "uxRate";
            this.uxRate.Size = new System.Drawing.Size(47, 25);
            this.uxRate.TabIndex = 10;
            this.uxRate.Text = "text";
            // 
            // uxHigh
            // 
            this.uxHigh.AutoSize = true;
            this.uxHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHigh.Location = new System.Drawing.Point(295, 74);
            this.uxHigh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxHigh.Name = "uxHigh";
            this.uxHigh.Size = new System.Drawing.Size(47, 25);
            this.uxHigh.TabIndex = 11;
            this.uxHigh.Text = "text";
            // 
            // uxLow
            // 
            this.uxLow.AutoSize = true;
            this.uxLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLow.Location = new System.Drawing.Point(295, 111);
            this.uxLow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLow.Name = "uxLow";
            this.uxLow.Size = new System.Drawing.Size(47, 25);
            this.uxLow.TabIndex = 12;
            this.uxLow.Text = "text";
            // 
            // uxVisual
            // 
            this.uxVisual.Location = new System.Drawing.Point(16, 156);
            this.uxVisual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxVisual.Name = "uxVisual";
            this.uxVisual.Size = new System.Drawing.Size(441, 199);
            this.uxVisual.TabIndex = 13;
            this.uxVisual.TabStop = false;
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 375);
            this.Controls.Add(this.uxVisual);
            this.Controls.Add(this.uxLow);
            this.Controls.Add(this.uxHigh);
            this.Controls.Add(this.uxRate);
            this.Controls.Add(this.uxPrice);
            this.Controls.Add(this.uxName);
            this.Controls.Add(this.uxRateLabel);
            this.Controls.Add(this.uxHighLabel);
            this.Controls.Add(this.uxLowLabel);
            this.Controls.Add(this.uxPriceLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Display";
            this.Text = "Display";
            this.Load += new System.EventHandler(this.Display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxVisual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxPriceLabel;
        private System.Windows.Forms.Label uxLowLabel;
        private System.Windows.Forms.Label uxHighLabel;
        private System.Windows.Forms.Label uxRateLabel;
        private System.Windows.Forms.Label uxName;
        private System.Windows.Forms.Label uxPrice;
        private System.Windows.Forms.Label uxRate;
        private System.Windows.Forms.Label uxHigh;
        private System.Windows.Forms.Label uxLow;
        private System.Windows.Forms.PictureBox uxVisual;
    }
}