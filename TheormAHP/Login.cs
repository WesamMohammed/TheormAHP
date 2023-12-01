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

    public partial class LoginForm : Form
    {
        static string username = "admin";
        static string password = "password123";
        static string newUser = "newuser";
        static string newPassword = "newpassword123";
        public static bool Login(string inputUsername, string inputPassword, out string currentUser)
        {
            currentUser = "";

            if (inputUsername == username && inputPassword == password)
            {
                currentUser = "admin";
                return true;
            }
            else if (inputUsername == newUser && inputPassword == newPassword)
            {
                currentUser = "newuser";
                return true;
            }
            else
            {
                return false;
            }
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string inputUsername = usernameTextBox.Text;
            string inputPassword = passwordTextBox.Text;

            string currentUser;
            if (Login(inputUsername, inputPassword, out currentUser))
            {
               // MessageBox.Show(String.Format("Login successful. Welcome, {0}!", currentUser));

                if (currentUser == "admin")
                {
                    // افتح النموذج الرئيسي للمستخدم "admin"
                    MainAdminForm adminForm = new MainAdminForm();
                    adminForm.Show();
                }
                else if (currentUser == "newuser")
                {
                    // افتح النموذج الرئيسي للمستخدم "newuser"
                    AHPApp AHPApp = new AHPApp();
                     AHPApp.Show();
                   
                }
                
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        
    }
}