using Avalonia.Controls;
using Avalonia.Interactivity;
using CreateAllApp.Models;
using CreateAllApp.ViewModels;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CreateAllApp.Views
{
    public partial class MainWindow : Window
    {
        Process process = new Process();
        string commandeLineFrame = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            this.caseGestFram.IsEnabled = false;
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var heightPage = e.NewSize.Height;
            this.logConsole.Height = heightPage - 200;
            this.menu.Height = heightPage - 90;
        }
        private async void BtnSelectDossier_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFolderDialog();
            string dossierSelect = await dialog.ShowAsync(this);
            if(!string.IsNullOrEmpty(dossierSelect))
            {
                this.tbxDossier.Text = dossierSelect;
                this.tbxNomProjet.IsEnabled = true;
            }

        }
        private async void MitClick(object sender, RoutedEventArgs e)
        {
            MenuItem mitSelection = (MenuItem)sender;
            var value = mitSelection.Header;
        }

        public void tbxNomProjet_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txtNomProjet = (TextBox)sender;
            FrameworkClass framework = (FrameworkClass)this.menu.SelectedItem;
            string pattern = @"^[a-zA-Z0-9]*$";
            if (txtNomProjet.Text.Trim() != string.Empty && Regex.IsMatch(txtNomProjet.Text, pattern) && txtNomProjet.Text.Length >= 4)
            {
                this.btnLance.IsEnabled = true;
                commandeLineFrame = framework.Commande.Replace("{0}", txtNomProjet.Text);
            }
            else
            {
                this.btnLance.IsEnabled = false;
            }
        }

        public void menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = (ListBox)sender;

            FrameworkClass framework = (FrameworkClass)listBox.SelectedItem;
            if (framework != null)
            {
                this.caseGestFram.IsEnabled = true;
            }
        }

        public void btnLance_Click(object sender, RoutedEventArgs e)
        {
            OperatingSystem osOrdinateur = Environment.OSVersion;
            string terminal = string.Empty;
            if(osOrdinateur.Platform == PlatformID.Win32NT)
            {
                terminal = "cmd.exe";
            }
            else
            {
                terminal = "Terminal.app";
            }
            string arguments = "/K";
            process.StartInfo.FileName = terminal;
            process.StartInfo.Arguments = arguments;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            //process.StartInfo.UseShellExecute = false;
            //process.StartInfo.CreateNoWindow = true;
            //process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();
            process.StandardInput.WriteLine(string.Format("cd {0}", this.tbxDossier.Text));
            process.StandardInput.WriteLine(string.Format(this.commandeLineFrame.ToLower()));
            //process.StandardInput.WriteLine("code .");
            //Console.WriteLine("Le terminal est en arrière plan");
        }
    }
}