using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUITriggerTest;

public partial class ViewBuilder : ObservableObject
{
    [ObservableProperty]
    private IList<Selectable<Phone>> _Phones;
}
