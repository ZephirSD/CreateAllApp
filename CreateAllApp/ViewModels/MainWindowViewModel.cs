using CreateAllApp.Models;
using System;
using System.Collections.ObjectModel;

namespace CreateAllApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<FrameworkClass> Frameworks { get; set; } = new ObservableCollection<FrameworkClass>();
        public MainWindowViewModel()
        {
            Frameworks.Add(new FrameworkClass("ReactJS", new Uri("../Assets/avalonia-logo.ico", UriKind.RelativeOrAbsolute), "npx create-react-app"));
            Frameworks.Add(new FrameworkClass("NextJS", new Uri("/Assets/avalonia-logo.ico", UriKind.RelativeOrAbsolute), "npx create-next-app@latest"));
            Frameworks.Add(new FrameworkClass("NuxtJS", new Uri("/Assets/avalonia-logo.ico", UriKind.RelativeOrAbsolute), "npx nuxi@latest init"));
            Frameworks.Add(new FrameworkClass("Flutter", new Uri("/Assets/avalonia-logo.ico", UriKind.RelativeOrAbsolute), "flutter create"));
            Frameworks.Add(new FrameworkClass("Symfony", new Uri("/Assets/avalonia-logo.ico", UriKind.RelativeOrAbsolute), "symfony new"));
            Frameworks.Add(new FrameworkClass("Laravel", new Uri("/Assets/avalonia-logo.ico", UriKind.RelativeOrAbsolute), "composer create-project laravel/laravel"));
            Frameworks.Add(new FrameworkClass("VueJS", new Uri("/Assets/avalonia-logo.ico", UriKind.RelativeOrAbsolute), "npm create vue@latest"));
            Frameworks.Add(new FrameworkClass("Svelte", new Uri("/Assets/avalonia-logo.ico", UriKind.RelativeOrAbsolute), "npm create svelte@latest"));
        }
    }
}