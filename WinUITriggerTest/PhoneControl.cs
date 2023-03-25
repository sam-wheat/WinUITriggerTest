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

public sealed class PhoneControl : Control
{

    

    public ICommand TogglePhoneCommand
    {
        get { return (ICommand)GetValue(TogglePhoneCommandProperty); }
        set { SetValue(TogglePhoneCommandProperty, value); }
    }

    public static readonly DependencyProperty TogglePhoneCommandProperty =
        DependencyProperty.Register("TogglePhoneCommand", typeof(ICommand), typeof(PhoneControl), new PropertyMetadata(null));



    public PhoneControl()
    {
        this.DefaultStyleKey = typeof(PhoneControl);

        

        //TogglePhoneCommand = new AsyncRelayCommand<object>(TogglePhoneCommandHandler, (o) =>
        //{
        //    return true;
        //});
    }

    public async Task TogglePhoneCommandHandler(object o)
    {

    }
}
