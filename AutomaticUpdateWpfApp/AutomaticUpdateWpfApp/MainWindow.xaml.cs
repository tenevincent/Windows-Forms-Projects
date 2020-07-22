using Squirrel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutomaticUpdateWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_OnLoaded;
        }

        private async void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            using (var updateManager = new UpdateManager(@"C:\SquirrelReleases\Releases"))
            {
                try
                {
                    CurrentVersion.Text = $"Current version: {updateManager.CurrentlyInstalledVersion()}";
                    var releaseEntry = await updateManager.CheckForUpdate();
                    NewVersion.Text = $"Update Version: {releaseEntry?.FutureReleaseEntry?.Version?.ToString() ?? "No update"}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var updateManager = new UpdateManager(@"C:\SquirrelReleases\Releases"))
            {
                try
                {
                    CurrentVersion.Text = $"Current version: {updateManager.CurrentlyInstalledVersion()}";
                    var releaseEntry = await updateManager.UpdateApp();
                    NewVersion.Text = $"Update Version: {releaseEntry?.Version.ToString() ?? "No update"}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
