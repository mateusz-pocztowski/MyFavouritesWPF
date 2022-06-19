using MyFavouritesWPF.Stores;
using MyFavouritesWPF.ViewModels;
using System.Windows;

namespace MyFavouritesWPF
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedMovieStore _selectedMovieStore;

        public App()
        {
            _selectedMovieStore = new SelectedMovieStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MovieViewModel(_selectedMovieStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
