using Stallapp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Stallapp.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {
        [ObservableProperty]
        DateTime currentDate = DateTime.Now;
    }
}
