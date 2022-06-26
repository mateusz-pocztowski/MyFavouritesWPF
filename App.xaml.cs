using Microsoft.EntityFrameworkCore;
using MyFavouritesWPF.EntityFramework;
using MyFavouritesWPF.EntityFramework.Commands;
using MyFavouritesWPF.EntityFramework.Queries;
using MyFavouritesWPF.Queries;
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
        private readonly MoviesDbContextFactory _moviesDbContextFactory;

        private readonly IGetAllMoviesQuery _getAllMoviesQuery;
        private readonly ICreateMovieCommand _createMovieCommand;
        private readonly IUpdateMovieCommand _updateMovieCommand;
        private readonly IDeleteMovieCommand _deleteMovieCommand;

        private readonly MoviesStore _moviesStore;
        private readonly SelectedMovieStore _selectedMovieStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public App()
        {
            string _connectionString = "Data Source=Movies.db";
            _moviesDbContextFactory = new MoviesDbContextFactory(new DbContextOptionsBuilder().UseSqlite(_connectionString).Options);

            _getAllMoviesQuery = new GetAllMoviesQuery(_moviesDbContextFactory);
            _createMovieCommand = new CreateMovieCommand(_moviesDbContextFactory);
            _updateMovieCommand = new UpdateMovieCommand(_moviesDbContextFactory);
            _deleteMovieCommand = new DeleteMovieCommand(_moviesDbContextFactory);

            _moviesStore = new MoviesStore(_getAllMoviesQuery, _createMovieCommand, _updateMovieCommand, _deleteMovieCommand);
            _selectedMovieStore = new SelectedMovieStore(_moviesStore);
            _modalNavigationStore = new ModalNavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            using(MoviesDbContext context = _moviesDbContextFactory.Create())
            {
                context.Database.Migrate();
            }

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
