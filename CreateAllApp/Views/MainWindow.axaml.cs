using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using CreateAllApp.Models;
using CreateAllApp.ViewModels;
using System;
using System.Diagnostics;
using System.Drawing;

namespace CreateAllApp.Views
{
    public partial class MainWindow : Window
    {
        Process process = new Process();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            //this.itcMenu.ItemsSource = FrameworkClass.GetAll();
            string terminal = "cmd.exe";
            string arguments = "/K";

            //process.StartInfo.RedirectStandardOutput = true;
            //process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.FileName = terminal;
            process.StartInfo.Arguments = arguments;
            process.Start();
            Console.WriteLine("Le terminal est en arrière plan");
            //process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            //this.tbxNomProjet.IsEnabled = false;
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
            //string arguments2 = $"cd {dossierSelect}";

            if(!string.IsNullOrEmpty(dossierSelect))
            {
                this.tbxDossier.Text = dossierSelect;
                //process.StandardInput.WriteLine(arguments2);
                //process.StandardInput.WriteLine("code .");
                //process.WaitForExit();
                //this.menu.FindControl("")
            }

        }
        private async void MitClick(object sender, RoutedEventArgs e)
        {
            MenuItem mitSelection = (MenuItem)sender;
            var value = mitSelection.Header;
            //mitSelection.Background =;
        }



    }
}