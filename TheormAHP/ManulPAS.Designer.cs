namespace TheormAHP
{
    partial class ManulPAS
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
            this.PWF = new System.Windows.Forms.TextBox();
            this.SWF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Savebt = new System.Windows.Forms.Button();
            this.Nextbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PWF
            // 
            this.PWF.Location = new System.Drawing.Point(359, 124);
            this.PWF.Name = "PWF";
            this.PWF.Size = new System.Drawing.Size(61, 20);
            this.PWF.TabIndex = 0;
            // 
            // SWF
            // 
            this.SWF.Location = new System.Drawing.Point(359, 189);
            this.SWF.Name = "SWF";
            this.SWF.Size = new System.Drawing.Size(61, 20);
            this.SWF.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter The Final Wight For Primary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter The Final Wight For Secondary";
            // 
            // Savebt
            // 
            this.Savebt.Location = new System.Drawing.Point(120, 297);
            this.Savebt.Name = "Savebt";
            this.Savebt.Size = new System.Drawing.Size(86, 34);
            this.Savebt.TabIndex = 4;
            this.Savebt.Text = "Save";
            this.Savebt.UseVisualStyleBackColor = true;
            // 
            // Nextbt
            // 
            this.Nextbt.Location = new System.Drawing.Point(338, 297);
            this.Nextbt.Name = "Nextbt";
            this.Nextbt.Size = new System.Drawing.Size(86, 34);
            this.Nextbt.TabIndex = 5;
            this.Nextbt.Text = "Next";
            this.Nextbt.UseVisualStyleBackColor = true;
            // 
            // ManulPAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 361);
            this.Controls.Add(this.Nextbt);
            this.Controls.Add(this.Savebt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SWF);
            this.Controls.Add(this.PWF);
            this.Name = "ManulPAS";
            this.Text = "ManulPASForm";
            this.Load += new System.EventHandler(this.ManulPAS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PWF;
        private System.Windows.Forms.TextBox SWF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Savebt;
        private System.Windows.Forms.Button Nextbt;
    }
}