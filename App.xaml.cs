using MyFavouritesWPF.ViewModels;
using System.Windows;

namespace MyFavouritesWPF
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MovieViewModel()
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
