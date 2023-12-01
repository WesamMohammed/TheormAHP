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
    public partial class AHPApp : Form{
        public AHPApp()
        {

            InitializeComponent();
        }

        private void ManualButton_Click(object sender, EventArgs e)
        {
            // قم بتنفيذ الشيفرة المصدرية عند اختيار الإدخال اليدوي
            MessageBox.Show("تم اختيار إدخال الأوزان يدوياً.");
            ManulPAS ManulPAS = new ManulPAS();
            ManulPAS.Show();
            this.Close();
        }

        private void AHPButton_Click(object sender, EventArgs e)
        {
            // قم بتنفيذ الشيفرة المصدرية عند اختيار خوارزمية AHP
            MessageBox.Show("تم اختيار استخدام خوارزمية AHP لحساب الأوزان.");
            AHPPAS AHPPAS = new AHPPAS();
            AHPPAS.Show();
            this.Close();
        }

        private void AHPApp_Load(object sender, EventArgs e)
        {

        }
    }
}
    

