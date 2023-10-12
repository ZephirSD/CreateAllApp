using Avalonia.Controls;

namespace CreateAllApp.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var heightPage = e.NewSize.Height;
            this.logConsole.Height = heightPage - 200;
        }
    }
}