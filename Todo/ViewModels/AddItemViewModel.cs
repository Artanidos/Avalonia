using Avalonia.Controls;
using Avalonia.Input;
using Microsoft.CodeAnalysis.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Models;
using CommunityToolkit.Mvvm.Input;
using System.Reflection.Metadata;

namespace Todo.ViewModels
{
    class AddItemViewModel : ObservableObject
    {
        // description should be initialized otherwise the binding will not function
        // IsEnabled="{Binding #description.Text.Length}"
        string description = "";
        MainWindowViewModel parent;

        public AddItemViewModel(MainWindowViewModel parent)
        {
            this.parent = parent;
        }
        public string Description 
        { 
            get => description; 
            set => SetProperty(ref description, value); 
        }

        public void CancelPressed()
        {
            parent.ItemAdded("");
        }

        public void OkPressed(string description)
        {
            parent.ItemAdded(description);
        }
    }
}
