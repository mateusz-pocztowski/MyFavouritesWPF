﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.ViewModels
{
    public class EditMovieViewModel : ViewModelBase
    {
        public MovieDetailsFormModel MovieDetailsFormModel { get; }

        public EditMovieViewModel()
        {
            MovieDetailsFormModel = new MovieDetailsFormModel();
        }
    }
}
