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

        public string Name => _selectedMovieStore.selectedMovie?.Name ?? "-";
        public string Genre => _selectedMovieStore.selectedMovie?.Genre ?? "-";
        public string ReleaseYear => _selectedMovieStore.selectedMovie?.ReleaseYear ?? "-";

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
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(Genre));
            OnPropertyChanged(nameof(ReleaseYear));
        }
    }
}
