// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUITriggerTest
{
    public sealed class CustomControl1 : Control, INotifyPropertyChanged
    {
        public bool IsExpanded
        {
            get { return (bool)GetValue(IsExpandedProperty); }
            set { SetValue(IsExpandedProperty, value); }
        }

        public static readonly DependencyProperty IsExpandedProperty =
            DependencyProperty.Register("IsExpanded", typeof(bool), typeof(CustomControl1), new PropertyMetadata(false, (s,e) => ((CustomControl1)s).RaisePropertyChanged(nameof(IsExpanded))));



        public ICommand ToggleNodeExpansionCommand
        {
            get { return (ICommand)GetValue(ToggleNodeExpansionCommandProperty); }
            set { SetValue(ToggleNodeExpansionCommandProperty, value); }
        }

        public static readonly DependencyProperty ToggleNodeExpansionCommandProperty =
            DependencyProperty.Register("ToggleNodeExpansionCommand", typeof(ICommand), typeof(CustomControl1), new PropertyMetadata(null));



        public CustomControl1()
        {
            this.DefaultStyleKey = typeof(CustomControl1);

            ToggleNodeExpansionCommand = new RelayCommand(() => {
                IsExpanded = !IsExpanded;
            });
        }


        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler? PropertyChanged;
        public void RaisePropertyChanged([CallerMemberNameAttribute] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public void SetProp<T>(ref T prop, T value, [CallerMemberNameAttribute] string propertyName = "")
        {
            if (!Object.Equals(prop, value))
            {
                prop = value;
                RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
}
