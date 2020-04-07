namespace Assignment_9
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
            this.radioButtonFootball = new System.Windows.Forms.RadioButton();
            this.radioButtonHandball = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelFee = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sport";
            // 
            // radioButtonFootball
            // 
            this.radioButtonFootball.AutoSize = true;
            this.radioButtonFootball.Location = new System.Drawing.Point(142, 37);
            this.radioButtonFootball.Name = "radioButtonFootball";
            this.radioButtonFootball.Size = new System.Drawing.Size(62, 17);
            this.radioButtonFootball.TabIndex = 1;
            this.radioButtonFootball.TabStop = true;
            this.radioButtonFootball.Text = "Football";
            this.radioButtonFootball.UseVisualStyleBackColor = true;
            this.radioButtonFootball.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButtonHandball
            // 
            this.radioButtonHandball.AutoSize = true;
            this.radioButtonHandball.Location = new System.Drawing.Point(142, 60);
            this.radioButtonHandball.Name = "radioButtonHandball";
            this.radioButtonHandball.Size = new System.Drawing.Size(67, 17);
            this.radioButtonHandball.TabIndex = 2;
            this.radioButtonHandball.TabStop = true;
            this.radioButtonHandball.Text = "Handball";
            this.radioButtonHandball.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Membership Duration";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(142, 96);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(158, 20);
            this.textBoxAge.TabIndex = 5;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(142, 123);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(158, 20);
            this.textBoxDuration.TabIndex = 6;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(13, 160);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(287, 50);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "Calculate Fee";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // labelFee
            // 
            this.labelFee.AutoSize = true;
            this.labelFee.Location = new System.Drawing.Point(187, 263);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(22, 13);
            this.labelFee.TabIndex = 8;
            this.labelFee.Text = "- - -";
            this.labelFee.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fee to be paid: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 304);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelFee);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonHandball);
            this.Controls.Add(this.radioButtonFootball);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonFootball;
        private System.Windows.Forms.RadioButton radioButtonHandball;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelFee;
        private System.Windows.Forms.Label label4;
    }
}

