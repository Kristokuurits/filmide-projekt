using CommunityToolkit.Mvvm.ComponentModel;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        [ObservableProperty]
        private Media _trendingMovie;
    }
}
