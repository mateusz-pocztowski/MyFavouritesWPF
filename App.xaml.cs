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
        private readonly ModalNavigationStore _modalNavigationStore;

        public App()
        {
            _selectedMovieStore = new SelectedMovieStore();
            _modalNavigationStore = new ModalNavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_modalNavigationStore, new MovieViewModel(_selectedMovieStore, _modalNavigationStore))
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
