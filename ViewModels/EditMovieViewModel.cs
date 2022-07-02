using MyFavouritesWPF.Commands;
using MyFavouritesWPF.Models;
using MyFavouritesWPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFavouritesWPF.ViewModels
{
    public class EditMovieViewModel : ViewModelBase
    {
        public Guid MovieId { get; }

        public MovieDetailsFormModel MovieDetailsFormModel { get; }

        public EditMovieViewModel(Movie movie, MoviesStore moviesStore, ModalNavigationStore modalNavigationStore)
        {
            MovieId = movie.Id;

            IEnumerable<Genre> genres = moviesStore.Genres;
            ICommand submitCommand = new SubmitEditMovieCommand(this, moviesStore, modalNavigationStore);
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);

            MovieDetailsFormModel = new MovieDetailsFormModel(genres, submitCommand, cancelCommand)
            {
                Name = movie.Name,
                Genre = movie.Genre,
                ReleaseYear = movie.ReleaseYear,
            };
        }
    }
}
