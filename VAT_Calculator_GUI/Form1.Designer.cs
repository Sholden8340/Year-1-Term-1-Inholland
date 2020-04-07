namespace VAT_Calculator_GUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.vatLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.priceOutput = new System.Windows.Forms.Label();
            this.vatOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(98, 58);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Determine VAT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(60, 214);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price";
            this.priceLabel.Click += new System.EventHandler(this.PriceLabel_Click);
            // 
            // vatLabel
            // 
            this.vatLabel.AutoSize = true;
            this.vatLabel.Location = new System.Drawing.Point(60, 260);
            this.vatLabel.Name = "vatLabel";
            this.vatLabel.Size = new System.Drawing.Size(28, 13);
            this.vatLabel.TabIndex = 5;
            this.vatLabel.Text = "VAT";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(60, 304);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total";
            this.totalLabel.Click += new System.EventHandler(this.Label4_Click);
            // 
            // priceOutput
            // 
            this.priceOutput.AutoSize = true;
            this.priceOutput.Location = new System.Drawing.Point(162, 214);
            this.priceOutput.Name = "priceOutput";
            this.priceOutput.Size = new System.Drawing.Size(22, 13);
            this.priceOutput.TabIndex = 7;
            this.priceOutput.Text = "- - -";
            // 
            // vatOutput
            // 
            this.vatOutput.AutoSize = true;
            this.vatOutput.Location = new System.Drawing.Point(162, 260);
            this.vatOutput.Name = "vatOutput";
            this.vatOutput.Size = new System.Drawing.Size(22, 13);
            this.vatOutput.TabIndex = 7;
            this.vatOutput.Text = "- - -";
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.Location = new System.Drawing.Point(162, 304);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(22, 13);
            this.totalOutput.TabIndex = 7;
            this.totalOutput.Text = "- - -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 379);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.vatOutput);
            this.Controls.Add(this.priceOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.vatLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label vatLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label priceOutput;
        private System.Windows.Forms.Label vatOutput;
        private System.Windows.Forms.Label totalOutput;
    }
}

