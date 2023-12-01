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
    public partial class MainAdminForm : Form
    {
        public MainAdminForm()
        {
            InitializeComponent();
        }

        
        private void PrimaryAndSecondarybt_Click(object sender, EventArgs e)
        {
            AHPApp AHPApp = new AHPApp();
            AHPApp.Show();
            this.Close();
        }
        private void MainAdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
