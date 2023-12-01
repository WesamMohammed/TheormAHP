using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheormAHP
{
    public partial class AHPPAS : Form
    {
        public class Contents
        {
            public int AorBResult { get; set; }
            public int From1_9Result { get; set; }
        }
        Dictionary<int, Contents> map = new Dictionary<int, Contents>();
        int AorBValue;
        int selectedNum;

        public AHPPAS()
        {
             //InitializeComponent();
            IntializeComp2();


        }
        private void AorB_Enter(object sender, EventArgs e)
        {



        }
        private void from1to9_Enter(object sender, EventArgs e)
        {
        }





        private void Calculatebt_Click(object sender, EventArgs e) {

            if (rb1.Checked == true)
            {
                selectedNum = 1;

            }
            else if (rb2.Checked == true)
            {
                selectedNum = 2;

            }
            else if (rb3.Checked == true)
            {
                selectedNum = 3;

            }
            else if (rb4.Checked == true)
            {
                selectedNum = 4;

            }
            else if (rb5.Checked == true)
            {
                selectedNum = 5;

            }
            else if (rb6.Checked == true)
            {
                selectedNum = 6;

            }
            else if (rb7.Checked == true)
            {
                selectedNum = 7;

            }
            else if (rb8.Checked == true)
            {
                selectedNum = 8;

            }
            else if (rb9.Checked == true)
            {
                selectedNum = 9;

            }

        }


        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            if (rbA.Checked == true)
            {

                AorBValue = 1;

            }
            else if (rbB.Checked == true)
            {

                AorBValue = 2;


            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AHPPAS_Load(object sender, EventArgs e)
        {

        }

        private void Calculatebt_Click_1(object sender, EventArgs e)
        {
            var prA = new PrimaryAndSecondaryAlgorithm();
            double weid1 = 0;
            double weid2 = 0;
            prA.PerformAHP(2, AorBValue, selectedNum, out weid1, out weid2);
            weid1 = 100 * weid1;
            weid2 = 100 * weid2;
            PWF1.Text = weid1.ToString();
            SWF1.Text = weid2.ToString();

        }

        private RadioButton SeTAB(string name, string text, int index, int x, int y)
        {
            var ab = new RadioButton()
            {
                AutoSize = true,
                Name = $"{index}_{name}",
                Size=new System.Drawing.Size(32,17),
                Text = name,
                UseVisualStyleBackColor = true,
                Location=new System.Drawing.Point(x, y),
                TabIndex = 1
               
            };
            ab.CheckedChanged += new EventHandler(ABHandler);
            if (text == "A")
            {
                ab.Checked = true;
            }


            return ab;
        }

        
        public void ABHandler(object sender, EventArgs e)
        {
            var sender2 = (RadioButton)sender;
            var res = sender2.Name.Split('_');
            var key = int.Parse(res.First());
            var value = sender2.Text;
            if (map.TryGetValue(key,out var contents))
            {
                contents.AorBResult = value == "A" ? 1 : 2;
            }
            else
            {
                map[key] = new Contents() { AorBResult = value == "A" ? 1 : 2 };
            }
            
        }

        private RadioButton SetRBNum(string name, string text,int index, int x, int y)
        {
            var num = new RadioButton()
            {
                AutoSize = true,
                Name = $"{index}_{name}",
                Size = new System.Drawing.Size(31, 17),
                Text = name,
                UseVisualStyleBackColor = true,
                Location = new System.Drawing.Point(x, y),
            };
            num.CheckedChanged += new EventHandler(NumHandler);
            if(text == "1")
            {
                num.Checked = true;
            }
            return num;
        }
        public void NumHandler(object sender, EventArgs e)
        {
            var sender2 = (RadioButton)sender;
            var res = sender2.Name.Split('_');
            var key = int.Parse(res.First());
            var value = sender2.Text;
            if (map.TryGetValue(key, out var contents))
            {
                contents.From1_9Result = int.Parse(value);
            }
            else
            {
                map[key] = new Contents() { From1_9Result = int.Parse(value) };
            }
            


        }
        public void AddRBToForm(RadioButton rb)
        {
            
        }
       
    }
    }

    

