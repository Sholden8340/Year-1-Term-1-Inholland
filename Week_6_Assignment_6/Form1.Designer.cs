namespace Assignment_6
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonReference = new System.Windows.Forms.Button();
            this.buttonRefferenceOut = new System.Windows.Forms.Button();
            this.buttonSqValue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonReference
            // 
            this.buttonReference.Location = new System.Drawing.Point(16, 64);
            this.buttonReference.Name = "buttonReference";
            this.buttonReference.Size = new System.Drawing.Size(171, 23);
            this.buttonReference.TabIndex = 2;
            this.buttonReference.Text = "Square By Reference";
            this.buttonReference.UseVisualStyleBackColor = true;
            this.buttonReference.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonRefferenceOut
            // 
            this.buttonRefferenceOut.Location = new System.Drawing.Point(16, 94);
            this.buttonRefferenceOut.Name = "buttonRefferenceOut";
            this.buttonRefferenceOut.Size = new System.Drawing.Size(171, 23);
            this.buttonRefferenceOut.TabIndex = 3;
            this.buttonRefferenceOut.Text = "Square by Reference out";
            this.buttonRefferenceOut.UseVisualStyleBackColor = true;
            this.buttonRefferenceOut.Click += new System.EventHandler(this.ButtonRefferenceOut_Click);
            // 
            // buttonSqValue
            // 
            this.buttonSqValue.Location = new System.Drawing.Point(16, 124);
            this.buttonSqValue.Name = "buttonSqValue";
            this.buttonSqValue.Size = new System.Drawing.Size(171, 23);
            this.buttonSqValue.TabIndex = 4;
            this.buttonSqValue.Text = "Square by Value";
            this.buttonSqValue.UseVisualStyleBackColor = true;
            this.buttonSqValue.Click += new System.EventHandler(this.ButtonSqValue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(152, 199);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(22, 13);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "- - -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 252);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSqValue);
            this.Controls.Add(this.buttonRefferenceOut);
            this.Controls.Add(this.buttonReference);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonReference;
        private System.Windows.Forms.Button buttonRefferenceOut;
        private System.Windows.Forms.Button buttonSqValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResult;
    }
}

