using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace SecuringConnectionStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EncryptConnectionString()
        {
            // Get the configuration file
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Create the provider name
            string provider = "DataProtectionConfigurationProvider";

            //Encrypt the connectionStrings
            ConfigurationSection connstrings = config.ConnectionStrings;
            connstrings.SectionInformation.ProtectSection(provider);
            connstrings.SectionInformation.ForceSave = true;
            config.Save(ConfigurationSaveMode.Full);
        }

        private void DecryptConnectionString()
        {
            //Get the configuration file
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Decrypt the connectionStrings
            ConfigurationSection connstrings = config.ConnectionStrings;
            connstrings.SectionInformation.UnprotectSection();
            connstrings.SectionInformation.ForceSave = true;
            config.Save(ConfigurationSaveMode.Full);
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            EncryptConnectionString();
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            DecryptConnectionString();
        }
    }

}