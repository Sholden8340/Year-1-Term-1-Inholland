namespace Assignment5
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
            this.radioButtonSecond = new System.Windows.Forms.RadioButton();
            this.radioButtonFirst = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTickets = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRailrunner = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButtonSecond
            // 
            this.radioButtonSecond.AutoSize = true;
            this.radioButtonSecond.Location = new System.Drawing.Point(121, 16);
            this.radioButtonSecond.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonSecond.Name = "radioButtonSecond";
            this.radioButtonSecond.Size = new System.Drawing.Size(91, 21);
            this.radioButtonSecond.TabIndex = 1;
            this.radioButtonSecond.TabStop = true;
            this.radioButtonSecond.Text = "2nd Class";
            this.radioButtonSecond.UseVisualStyleBackColor = true;
            // 
            // radioButtonFirst
            // 
            this.radioButtonFirst.AutoSize = true;
            this.radioButtonFirst.Location = new System.Drawing.Point(220, 16);
            this.radioButtonFirst.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonFirst.Name = "radioButtonFirst";
            this.radioButtonFirst.Size = new System.Drawing.Size(86, 21);
            this.radioButtonFirst.TabIndex = 2;
            this.radioButtonFirst.TabStop = true;
            this.radioButtonFirst.Text = "1st Class";
            this.radioButtonFirst.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "No. Of Tickets:";
            // 
            // textBoxTickets
            // 
            this.textBoxTickets.Location = new System.Drawing.Point(121, 52);
            this.textBoxTickets.Name = "textBoxTickets";
            this.textBoxTickets.Size = new System.Drawing.Size(185, 22);
            this.textBoxTickets.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Railrunner:";
            // 
            // textBoxRailrunner
            // 
            this.textBoxRailrunner.Location = new System.Drawing.Point(121, 86);
            this.textBoxRailrunner.Name = "textBoxRailrunner";
            this.textBoxRailrunner.Size = new System.Drawing.Size(185, 22);
            this.textBoxRailrunner.TabIndex = 6;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(121, 127);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(185, 23);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxPrice.Enabled = false;
            this.textBoxPrice.Location = new System.Drawing.Point(121, 167);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(185, 22);
            this.textBoxPrice.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxRailrunner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTickets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonFirst);
            this.Controls.Add(this.radioButtonSecond);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Train - Day Tickets";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonSecond;
        private System.Windows.Forms.RadioButton radioButtonFirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTickets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRailrunner;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrice;
    }
}

