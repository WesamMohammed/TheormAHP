namespace TheormAHP
{
    partial class MainAdminForm
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
            this.PrimaryAndSecondarybt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrimaryAndSecondarybt
            // 
            this.PrimaryAndSecondarybt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.PrimaryAndSecondarybt.Location = new System.Drawing.Point(103, 120);
            this.PrimaryAndSecondarybt.Name = "PrimaryAndSecondarybt";
            this.PrimaryAndSecondarybt.Size = new System.Drawing.Size(267, 129);
            this.PrimaryAndSecondarybt.TabIndex = 0;
            this.PrimaryAndSecondarybt.Text = "PrimaryAndSecondary";
            this.PrimaryAndSecondarybt.UseVisualStyleBackColor = true;
            this.PrimaryAndSecondarybt.Click += new System.EventHandler(this.PrimaryAndSecondarybt_Click);
            // 
            // MainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 364);
            this.Controls.Add(this.PrimaryAndSecondarybt);
            this.Name = "MainAdminForm";
            this.Text = "PrimaryAndSecondary";
            this.Load += new System.EventHandler(this.MainAdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrimaryAndSecondarybt;
    }
}