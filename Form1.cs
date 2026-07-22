using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Get input from the text box (trimming surrounding whitespace)
            string userText = txtName.Text.Trim();

            // 2. Validate input with a friendly fallback
            string nameToDisplay = string.IsNullOrEmpty(userText) ? "World" : userText;

            // 3. Check optional checkbox toggle
            string punctuation = chkExclamation.Checked ? " !!!" : ".";

            // 4. Update the greeting label on screen
            lblGreeting.Text = $"Hello, {nameToDisplay}{punctuation}";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Opens your GitHub profile in the default system web browser
            System.Diagnostics.Process.Start("https://github.com/Atul-Arc");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Using string verbatim (@"...") with bullet characters (\u2022)
            //add 
            lblDescription.Text = "Welcome! This simple desktop application was built using C# and .NET Framework 4.8. It demonstrates core Windows Forms common controls and Event Handlers to respond dynamically to user input. This source code can be used for testing: " + Environment.NewLine + Environment.NewLine +
                "\u2022 DevOps & CI/CD Pipeline Validation" + Environment.NewLine +
                "\u2022 Automated Testing Baseline (UI & Regression)" + Environment.NewLine +
                "\u2022 Docker & Windows Server Deployment Testing" + Environment.NewLine +
                "\u2022 Static Code Analysis & Security Scanning" + Environment.NewLine +
                "\u2022 Code Signing & Digital Certificate Testing" + Environment.NewLine +
                "\u2022 Developer Onboarding & IDE Environment Setup" + Environment.NewLine +
                "\u2022 Legacy Framework Migration Benchmarking (.NET 4.8 to .NET 8+)" + Environment.NewLine +
                "\u2022 Enterprise Software Packaging (MSI / MSIX)";
        }
    }
}
