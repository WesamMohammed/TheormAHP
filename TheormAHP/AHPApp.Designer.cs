namespace TheormAHP
{
    partial class AHPApp
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
            this.ManualButton = new System.Windows.Forms.Button();
            this.AHPButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManualButton
            // 
            this.ManualButton.Location = new System.Drawing.Point(80, 207);
            this.ManualButton.Name = "ManualButton";
            this.ManualButton.Size = new System.Drawing.Size(105, 42);
            this.ManualButton.TabIndex = 0;
            this.ManualButton.Text = "Manualy";
            this.ManualButton.UseVisualStyleBackColor = true;
            this.ManualButton.Click += new System.EventHandler(this.ManualButton_Click);
            // 
            // AHPButton
            // 
            this.AHPButton.Location = new System.Drawing.Point(279, 207);
            this.AHPButton.Name = "AHPButton";
            this.AHPButton.Size = new System.Drawing.Size(105, 42);
            this.AHPButton.TabIndex = 1;
            this.AHPButton.Text = "AHP";
            this.AHPButton.UseVisualStyleBackColor = true;
            this.AHPButton.Click += new System.EventHandler(this.AHPButton_Click);
            // 
            // AHPApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 355);
            this.Controls.Add(this.AHPButton);
            this.Controls.Add(this.ManualButton);
            this.Name = "AHPApp";
            this.Text = "AHPApp";
            this.Load += new System.EventHandler(this.AHPApp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManualButton;
        private System.Windows.Forms.Button AHPButton;
    }
}