// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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

namespace WinUITriggerTest;

public sealed class PeopleControl : Control
{

    public ObservableCollection<Person> People { get; set; }
    
    public ICommand TogglePersonCommand
    {
        get { return (ICommand)GetValue(TogglePersonCommandProperty); }
        set { SetValue(TogglePersonCommandProperty, value); }
    }

    public static readonly DependencyProperty TogglePersonCommandProperty =
        DependencyProperty.Register("TogglePersonCommand", typeof(ICommand), typeof(PeopleControl), new PropertyMetadata(null));




    public PeopleControl()
    {
        this.DefaultStyleKey = typeof(PeopleControl);

        People = new() { new Person { Name = "Adam" }, new Person { Name = "Becky" }, new Person { Name = "Charlie" }, new Person { Name = "David" } };

        TogglePersonCommand = new AsyncRelayCommand<object>(TogglePersonCommandHandler, (o) =>
        {
            return true;
        });
    }

    public async Task TogglePersonCommandHandler(object o)
    {

    }
}


