using MyFavouritesWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFavouritesWPF.ViewModels
{
    public class MovieDetailsFormModel : ViewModelBase
    {
        private readonly IEnumerable<Genre> _genres;

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(CanSubmit));
            }
        }

        private Genre _genre;
        public Genre Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                _genre = value;
                OnPropertyChanged(nameof(Genre));
                OnPropertyChanged(nameof(CanSubmit));
            }
        }

        private string _releaseYear;
        public string ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                _releaseYear = value;
                OnPropertyChanged(nameof(ReleaseYear));
            }
        }

        public bool CanSubmit => !string.IsNullOrEmpty(Name) && Genre != null;
        public IEnumerable<Genre> AllGenres => _genres;

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public MovieDetailsFormModel(IEnumerable<Genre> genres, ICommand submitCommand, ICommand cancelCommand)
        {
            _genres = genres;
            SubmitCommand = submitCommand;
            CancelCommand = cancelCommand;
        }
    }
}
