using System.Collections.Generic;
using System.Windows.Forms;

namespace TheormAHP
{
    partial class AHPPAS
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
            this.AorB = new System.Windows.Forms.GroupBox();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.from1to9 = new System.Windows.Forms.GroupBox();
            this.rb9 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.Nextbt = new System.Windows.Forms.Button();
            this.Calculatebt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SWF1 = new System.Windows.Forms.TextBox();
            this.PWF1 = new System.Windows.Forms.TextBox();
            this.Savebt = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.AorB.SuspendLayout();
            this.from1to9.SuspendLayout();
            this.SuspendLayout();
            // 
            // AorB
            // 
            this.AorB.Controls.Add(this.rbB);
            this.AorB.Controls.Add(this.rbA);
            this.AorB.Location = new System.Drawing.Point(40, 70);
            this.AorB.Name = "AorB";
            this.AorB.Size = new System.Drawing.Size(72, 30);
            this.AorB.TabIndex = 0;
            this.AorB.TabStop = false;
            this.AorB.Enter += new System.EventHandler(this.AorB_Enter);
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(40, 12);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(31, 17);
            this.rbB.TabIndex = 1;
            this.rbB.TabStop = true;
            this.rbB.Tag = "2";
            this.rbB.Text = "B";
            this.rbB.UseVisualStyleBackColor = true;
            this.rbB.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(7, 12);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(32, 17);
            this.rbA.TabIndex = 0;
            this.rbA.TabStop = true;
            this.rbA.Tag = "1";
            this.rbA.Text = "A";
            this.rbA.UseVisualStyleBackColor = true;
            this.rbA.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // from1to9
            // 
            this.from1to9.Controls.Add(this.rb9);
            this.from1to9.Controls.Add(this.rb8);
            this.from1to9.Controls.Add(this.rb7);
            this.from1to9.Controls.Add(this.rb6);
            this.from1to9.Controls.Add(this.rb5);
            this.from1to9.Controls.Add(this.rb4);
            this.from1to9.Controls.Add(this.rb3);
            this.from1to9.Controls.Add(this.rb2);
            this.from1to9.Controls.Add(this.rb1);
            this.from1to9.Location = new System.Drawing.Point(162, 70);
            this.from1to9.Name = "from1to9";
            this.from1to9.Size = new System.Drawing.Size(325, 30);
            this.from1to9.TabIndex = 2;
            this.from1to9.TabStop = false;
            this.from1to9.Enter += new System.EventHandler(this.from1to9_Enter);
            // 
            // rb9
            // 
            this.rb9.AutoSize = true;
            this.rb9.Location = new System.Drawing.Point(288, 13);
            this.rb9.Name = "rb9";
            this.rb9.Size = new System.Drawing.Size(31, 17);
            this.rb9.TabIndex = 8;
            this.rb9.TabStop = true;
            this.rb9.Tag = "9";
            this.rb9.Text = "9";
            this.rb9.UseVisualStyleBackColor = true;
            this.rb9.CheckedChanged += new System.EventHandler(this.Calculatebt_Click);
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Location = new System.Drawing.Point(253, 13);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(31, 17);
            this.rb8.TabIndex = 7;
            this.rb8.TabStop = true;
            this.rb8.Tag = "8";
            this.rb8.Text = "8";
            this.rb8.UseVisualStyleBackColor = true;
            this.rb8.CheckedChanged += new System.EventHandler(this.Calculatebt_Click);
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.Location = new System.Drawing.Point(220, 13);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(31, 17);
            this.rb7.TabIndex = 6;
            this.rb7.TabStop = true;
            this.rb7.Tag = "7";
            this.rb7.Text = "7";
            this.rb7.UseVisualStyleBackColor = true;
            this.rb7.CheckedChanged += new System.EventHandler(this.Calculatebt_Click);
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Location = new System.Drawing.Point(182, 13);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(31, 17);
            this.rb6.TabIndex = 5;
            this.rb6.TabStop = true;
            this.rb6.Tag = "6";
            this.rb6.Text = "6";
            this.rb6.UseVisualStyleBackColor = true;
            this.rb6.CheckedChanged += new System.EventHandler(this.Calculatebt_Click);
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(144, 13);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(31, 17);
            this.rb5.TabIndex = 4;
            this.rb5.TabStop = true;
            this.rb5.Tag = "5";
            this.rb5.Text = "5";
            this.rb5.UseVisualStyleBackColor = true;
            this.rb5.CheckedChanged += new System.EventHandler(this.Calculatebt_Click);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(113, 13);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(31, 17);
            this.rb4.TabIndex = 3;
            this.rb4.TabStop = true;
            this.rb4.Tag = "4";
            this.rb4.Text = "4";
            this.rb4.UseVisualStyleBackColor = true;
            this.rb4.CheckedChanged += new System.EventHandler(this.Calculatebt_Click);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(78, 13);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(31, 17);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Tag = "3";
            this.rb3.Text = "3";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.Calculatebt_Click);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(40, 13);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(31, 17);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Tag = "2";
            this.rb2.Text = "2";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.Calculatebt_Click);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(6, 13);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(31, 17);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Tag = "1";
            this.rb1.Text = "1";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.Calculatebt_Click);
            // 
            // Nextbt
            // 
            this.Nextbt.Location = new System.Drawing.Point(329, 280);
            this.Nextbt.Name = "Nextbt";
            this.Nextbt.Size = new System.Drawing.Size(86, 34);
            this.Nextbt.TabIndex = 7;
            this.Nextbt.Text = "Next";
            this.Nextbt.UseVisualStyleBackColor = true;
            // 
            // Calculatebt
            // 
            this.Calculatebt.Location = new System.Drawing.Point(47, 280);
            this.Calculatebt.Name = "Calculatebt";
            this.Calculatebt.Size = new System.Drawing.Size(86, 34);
            this.Calculatebt.TabIndex = 6;
            this.Calculatebt.Text = "Calculate";
            this.Calculatebt.UseVisualStyleBackColor = true;
            this.Calculatebt.Click += new System.EventHandler(this.Calculatebt_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "The Final Wight For Secondary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "The Final Wight For Primary";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SWF1
            // 
            this.SWF1.Location = new System.Drawing.Point(349, 202);
            this.SWF1.Name = "SWF1";
            this.SWF1.ReadOnly = true;
            this.SWF1.Size = new System.Drawing.Size(61, 20);
            this.SWF1.TabIndex = 9;
            // 
            // PWF1
            // 
            this.PWF1.Location = new System.Drawing.Point(349, 131);
            this.PWF1.Name = "PWF1";
            this.PWF1.ReadOnly = true;
            this.PWF1.Size = new System.Drawing.Size(61, 20);
            this.PWF1.TabIndex = 8;
            // 
            // Savebt
            // 
            this.Savebt.Location = new System.Drawing.Point(187, 280);
            this.Savebt.Name = "Savebt";
            this.Savebt.Size = new System.Drawing.Size(86, 34);
            this.Savebt.TabIndex = 12;
            this.Savebt.Text = "Save";
            this.Savebt.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(626, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(23, 367);
            this.vScrollBar1.TabIndex = 13;
            // 
            // AHPPAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 376);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.Savebt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SWF1);
            this.Controls.Add(this.PWF1);
            this.Controls.Add(this.Nextbt);
            this.Controls.Add(this.Calculatebt);
            this.Controls.Add(this.from1to9);
            this.Controls.Add(this.AorB);
            this.Name = "AHPPAS";
            this.Text = "AHPPASForm";
            this.Load += new System.EventHandler(this.AHPPAS_Load);
            this.AorB.ResumeLayout(false);
            this.AorB.PerformLayout();
            this.from1to9.ResumeLayout(false);
            this.from1to9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void IntializeComp2()
        {
            List<GroupBox> allGBox = new List<GroupBox>();
          
            this.Nextbt = new System.Windows.Forms.Button();
            this.Calculatebt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SWF1 = new System.Windows.Forms.TextBox();
            this.PWF1 = new System.Windows.Forms.TextBox();
            this.Savebt = new System.Windows.Forms.Button();


         

            SetCalculateBut();
            SetSaveBut();
            SetNextBut();
            


            for (int i = 1;  i <=120;i++)
            {

             var AorB = new System.Windows.Forms.GroupBox();
                var from1to9 = new System.Windows.Forms.GroupBox();





                var defYNum = (12 + 10)*i ;
               
               



                AorB.Controls.Add(SeTAB("A", "A", i, 7, 12));
                AorB.Controls.Add(SeTAB("B", "B", i, 40, 12));
                AorB.Location = new System.Drawing.Point(40, 70*i);
                AorB.Name = $"AorB_{i}";
                AorB.Size = new System.Drawing.Size(72, 30);
                AorB.TabIndex = 0;
                AorB.TabStop = false;
                AorB.Text = i.ToString();
                AorB.Enter += new System.EventHandler(this.AorB_Enter);
                from1to9.Location = new System.Drawing.Point(162, 70 * i);
                from1to9.Name = $"from1to9_{i}";
                from1to9.Size = new System.Drawing.Size(325, 30);
                from1to9.TabIndex = 2;
                from1to9.TabStop = false;
                from1to9.Enter += new System.EventHandler(this.from1to9_Enter);


                for(int j = 1; j <= 9;j++)
                {
                    from1to9.Controls.Add(SetRBNum((j).ToString(), (j).ToString(), i, 6+((j-1)*34), 13));
                    
                }
                ;



                this.Controls.Add(AorB);
                this.Controls.Add(from1to9);
                this.Name = "AHPPAS";
                this.Text = "AHPPASForm";
                this.Load += new System.EventHandler(this.AHPPAS_Load);
                AorB.ResumeLayout(false);
                AorB.PerformLayout();
                from1to9.ResumeLayout(false);
                from1to9.PerformLayout();

            }

            SetAHPPAS();
        }
        private void SetAHPPAS()
        {
            // 
            // AHPPAS
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           /* this.AutoScrollMinSize = new System.Drawing.Size(800, 120 * 70);*/
            this.Controls.Add(this.Savebt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SWF1);
            this.Controls.Add(this.PWF1);
            this.Controls.Add(this.Nextbt);
            this.Controls.Add(this.Calculatebt);
            this.AutoScroll = true;

            this.Name = "AHPPAS";
            this.Text = "AHPPASForm";
            this.Load += new System.EventHandler(this.AHPPAS_Load);
         
            /*this.AorB.ResumeLayout(false);
            this.AorB.PerformLayout();
            this.from1to9.ResumeLayout(false);
            this.from1to9.PerformLayout();
            */
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public void SetNextBut()
        {
            this.Nextbt.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.Nextbt.Location = new System.Drawing.Point(329, this.ClientSize.Height );
            this.Nextbt.Name = "Nextbt";
            this.Nextbt.Size = new System.Drawing.Size(86, 34);
            this.Nextbt.TabIndex = 7;
            this.Nextbt.Text = "Next";
            this.Nextbt.UseVisualStyleBackColor = true;
        }
        public void SetSaveBut()
        {
            this.Savebt.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.Savebt.Location = new System.Drawing.Point(187, this.ClientSize.Height );
            this.Savebt.Name = "Savebt";
            this.Savebt.Size = new System.Drawing.Size(86, 34);
            this.Savebt.TabIndex = 12;
            this.Savebt.Text = "Save";
            this.Savebt.UseVisualStyleBackColor = true;
        }

        public void SetCalculateBut()
        {
            this.Calculatebt.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.Calculatebt.Location = new System.Drawing.Point(47, this.ClientSize.Height );
            this.Calculatebt.Name = "Calculatebt";
            this.Calculatebt.Size = new System.Drawing.Size(86, 34);
            this.Calculatebt.TabIndex = 6;
            this.Calculatebt.Text = "Calculate";
            this.Calculatebt.UseVisualStyleBackColor = true;
            this.Calculatebt.Click += new System.EventHandler(this.Calculatebt_Click_1);
        }
      
      
        

        private GroupBox GetNewGoupBox()
        {
            var gBox = new GroupBox();
            gBox.SuspendLayout();
            return gBox;
        }


        #endregion

        private System.Windows.Forms.GroupBox AorB;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.GroupBox from1to9;
        private System.Windows.Forms.RadioButton rb9;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button Nextbt;
        private System.Windows.Forms.Button Calculatebt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SWF1;
        private System.Windows.Forms.TextBox PWF1;
        private System.Windows.Forms.Button Savebt;
        private VScrollBar vScrollBar1;
    }
}