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
        private readonly MoviesStore _moviesStore;
        private readonly SelectedMovieStore _selectedMovieStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public App()
        {
            _moviesStore = new MoviesStore();
            _selectedMovieStore = new SelectedMovieStore(_moviesStore);
            _modalNavigationStore = new ModalNavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MovieViewModel moviesViewModel = new MovieViewModel(_moviesStore, _selectedMovieStore, _modalNavigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_modalNavigationStore, moviesViewModel)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
