using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUITriggerTest
{
    public partial class Selectable<T> : ObservableObject
    {
        [ObservableProperty]
        private bool _IsSelected;

        public T Item { get; set; }

        public Selectable(T item, bool isSelected = false)
        {
            Item = item;
            IsSelected = isSelected;
        }
    }
}
