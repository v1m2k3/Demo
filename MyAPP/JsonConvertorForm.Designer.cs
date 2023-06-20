namespace MyAPP
{
    partial class JsonConvertorForm
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
            this.JsonStringtextBox = new System.Windows.Forms.TextBox();
            this.ResulttextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JsonStringtextBox
            // 
            this.JsonStringtextBox.Location = new System.Drawing.Point(12, 12);
            this.JsonStringtextBox.Multiline = true;
            this.JsonStringtextBox.Name = "JsonStringtextBox";
            this.JsonStringtextBox.Size = new System.Drawing.Size(501, 183);
            this.JsonStringtextBox.TabIndex = 0;
            // 
            // ResulttextBox
            // 
            this.ResulttextBox.Location = new System.Drawing.Point(12, 265);
            this.ResulttextBox.Multiline = true;
            this.ResulttextBox.Name = "ResulttextBox";
            this.ResulttextBox.Size = new System.Drawing.Size(501, 183);
            this.ResulttextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // JsonConvertorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResulttextBox);
            this.Controls.Add(this.JsonStringtextBox);
            this.Name = "JsonConvertorForm";
            this.Text = "JsonConvertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox JsonStringtextBox;
        private System.Windows.Forms.TextBox ResulttextBox;
        private System.Windows.Forms.Button button1;
    }
}

