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
            this.label2 = new System.Windows.Forms.Label();
            this.labelBefore = new System.Windows.Forms.Label();
            this.labelAfter = new System.Windows.Forms.Label();
            this.textBoxCompare = new System.Windows.Forms.TextBox();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Content Table Before";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Content Table After";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // labelBefore
            // 
            this.labelBefore.AutoSize = true;
            this.labelBefore.Location = new System.Drawing.Point(13, 28);
            this.labelBefore.Name = "labelBefore";
            this.labelBefore.Size = new System.Drawing.Size(22, 13);
            this.labelBefore.TabIndex = 1;
            this.labelBefore.Text = "- - -";
            // 
            // labelAfter
            // 
            this.labelAfter.AutoSize = true;
            this.labelAfter.Location = new System.Drawing.Point(245, 28);
            this.labelAfter.Name = "labelAfter";
            this.labelAfter.Size = new System.Drawing.Size(22, 13);
            this.labelAfter.TabIndex = 1;
            this.labelAfter.Text = "- - -";
            // 
            // textBoxCompare
            // 
            this.textBoxCompare.Location = new System.Drawing.Point(13, 304);
            this.textBoxCompare.Name = "textBoxCompare";
            this.textBoxCompare.Size = new System.Drawing.Size(142, 20);
            this.textBoxCompare.TabIndex = 2;
            this.textBoxCompare.Text = "Comparison Number";
            this.textBoxCompare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(248, 301);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(75, 23);
            this.buttonCompare.TabIndex = 3;
            this.buttonCompare.Text = "Compare";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.ButtonCompare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.textBoxCompare);
            this.Controls.Add(this.labelAfter);
            this.Controls.Add(this.labelBefore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBefore;
        private System.Windows.Forms.Label labelAfter;
        private System.Windows.Forms.TextBox textBoxCompare;
        private System.Windows.Forms.Button buttonCompare;
    }
}

