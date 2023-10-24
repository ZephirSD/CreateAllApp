using CreateAllApp.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CreateAllApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<FrameworkClass> Frameworks { get; set; } = new ObservableCollection<FrameworkClass>();
        public MainWindowViewModel()
        {
            Frameworks.Add(new FrameworkClass("ReactJS", new Uri("../Assets/avalonia-logo.ico", UriKind.RelativeOrAbsolute), "npx create-react-app {0}"));
            Frameworks.Add(new FrameworkClass("NextJS", new Uri("/Assets/avalonia-logo.ico", UriKind.RelativeOrAbsolute), "npx create-next-app@latest {0}"));
            Frameworks.Add(new FrameworkClass("NuxtJS", new Uri("/Assets/avalonia-logo.ico", UriKind.RelativeOrAbsolute), "npx nuxt@latest init {0}"));
            Frameworks.Add(new FrameworkClass("Flutter", new Uri("/Assets/avalonia-logo.ico", UriKind.RelativeOrAbsolute), "flutter create {0}"));
            Frameworks.Add(new FrameworkClass("Symfony", new Uri("/Assets/avalonia-logo.ico", UriKind.RelativeOrAbsolute), "symfony new {0} --version=\"6.3.*\" --webapp"));
            Frameworks.Add(new FrameworkClass("Laravel", new Uri("/Assets/avalonia-logo.ico", UriKind.RelativeOrAbsolute), "composer create-project laravel/laravel {0}"));
            Frameworks.Add(new FrameworkClass("VueJS", new Uri("/Assets/avalonia-logo.ico", UriKind.RelativeOrAbsolute), "npm create vue@latest {0}"));
            Frameworks.Add(new FrameworkClass("Svelte & Vite", new Uri("/Assets/avalonia-logo.ico", UriKind.RelativeOrAbsolute), "npm create svelte@latest {0}"));
        }

    }
}