namespace Assignment_7
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
            this.textBoxDegrees = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCelsiusKelvin = new System.Windows.Forms.RadioButton();
            this.radioButtonCelsiusFahrenheight = new System.Windows.Forms.RadioButton();
            this.radioButtonFahrenheightCelsius = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Degrees";
            // 
            // textBoxDegrees
            // 
            this.textBoxDegrees.Location = new System.Drawing.Point(66, 6);
            this.textBoxDegrees.Name = "textBoxDegrees";
            this.textBoxDegrees.Size = new System.Drawing.Size(100, 20);
            this.textBoxDegrees.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFahrenheightCelsius);
            this.groupBox1.Controls.Add(this.radioButtonCelsiusFahrenheight);
            this.groupBox1.Controls.Add(this.radioButtonCelsiusKelvin);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion";
            // 
            // radioButtonCelsiusKelvin
            // 
            this.radioButtonCelsiusKelvin.AutoSize = true;
            this.radioButtonCelsiusKelvin.Checked = true;
            this.radioButtonCelsiusKelvin.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCelsiusKelvin.Name = "radioButtonCelsiusKelvin";
            this.radioButtonCelsiusKelvin.Size = new System.Drawing.Size(102, 17);
            this.radioButtonCelsiusKelvin.TabIndex = 0;
            this.radioButtonCelsiusKelvin.TabStop = true;
            this.radioButtonCelsiusKelvin.Text = "Celsius to Kelvin";
            this.radioButtonCelsiusKelvin.UseVisualStyleBackColor = true;
            // 
            // radioButtonCelsiusFahrenheight
            // 
            this.radioButtonCelsiusFahrenheight.AutoSize = true;
            this.radioButtonCelsiusFahrenheight.Location = new System.Drawing.Point(6, 42);
            this.radioButtonCelsiusFahrenheight.Name = "radioButtonCelsiusFahrenheight";
            this.radioButtonCelsiusFahrenheight.Size = new System.Drawing.Size(135, 17);
            this.radioButtonCelsiusFahrenheight.TabIndex = 1;
            this.radioButtonCelsiusFahrenheight.TabStop = true;
            this.radioButtonCelsiusFahrenheight.Text = "Celsius to Fahrenheight";
            this.radioButtonCelsiusFahrenheight.UseVisualStyleBackColor = true;
            // 
            // radioButtonFahrenheightCelsius
            // 
            this.radioButtonFahrenheightCelsius.AutoSize = true;
            this.radioButtonFahrenheightCelsius.Location = new System.Drawing.Point(6, 65);
            this.radioButtonFahrenheightCelsius.Name = "radioButtonFahrenheightCelsius";
            this.radioButtonFahrenheightCelsius.Size = new System.Drawing.Size(136, 17);
            this.radioButtonFahrenheightCelsius.TabIndex = 2;
            this.radioButtonFahrenheightCelsius.TabStop = true;
            this.radioButtonFahrenheightCelsius.Text = "Fahrenheight to Celcius";
            this.radioButtonFahrenheightCelsius.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(12, 163);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(200, 48);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(83, 229);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(22, 13);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "- - -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 296);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxDegrees);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDegrees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFahrenheightCelsius;
        private System.Windows.Forms.RadioButton radioButtonCelsiusFahrenheight;
        private System.Windows.Forms.RadioButton radioButtonCelsiusKelvin;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResult;
    }
}

