using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMSLibrary;

namespace LMS;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
        ClearButton.Click += ClearButton_Click;
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
        var userName = UserNameTextBox.Text;
        var password = PasswordTextBox.Text;
        bool isAuthenticated = Admin.AuthenticateLogin(userName, password);

        if (isAuthenticated)
        {
            this.Hide();
            MainForm mainForm = new();
            mainForm.Show();
        }
        else
        {
            MessageBox.Show("Invalid credentials! Please try again...");
        }
    }

    private void ClearButton_Click(object sender, EventArgs e)
    {
        UserNameTextBox.Text = "";
        PasswordTextBox.Text = "";
    }
}
