using Stallapp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stallapp.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        DateTime currentDate = DateTime.Now;
    }
}
