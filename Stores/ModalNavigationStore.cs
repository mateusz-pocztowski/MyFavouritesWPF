﻿using MyFavouritesWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavouritesWPF.Stores
{
    public class ModalNavigationStore
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                CurrentViewModelChanged?.Invoke();
            }
        }

        public event Action CurrentViewModelChanged;
    }
}
