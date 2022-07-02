using MyFavouritesWPF.Models;
using MyFavouritesWPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.ViewModels
{
    public class MovieDetailsViewModel : ViewModelBase
    {
        private readonly SelectedMovieStore _selectedMovieStore;

        public bool HasSelectedMovie => _selectedMovieStore.SelectedMovie != null;

        public string Name => _selectedMovieStore.SelectedMovie?.Name;
        public string Genre => _selectedMovieStore.SelectedMovie?.Genre?.Name;
        public string ReleaseYear => _selectedMovieStore.SelectedMovie?.ReleaseYear;

        public MovieDetailsViewModel(SelectedMovieStore selectedMovieStore)
        {
            _selectedMovieStore = selectedMovieStore;
            _selectedMovieStore.SelectedMovieChanged += SelectedMovieStore_SelectedMovieChanged;
        }

        protected override void Dispose()
        {
            _selectedMovieStore.SelectedMovieChanged -= SelectedMovieStore_SelectedMovieChanged;

            base.Dispose();
        }

        private void SelectedMovieStore_SelectedMovieChanged()
        {
            OnPropertyChanged(nameof(HasSelectedMovie));
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(Genre));
            OnPropertyChanged(nameof(ReleaseYear));
        }
    }
}
