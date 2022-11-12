using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Models;
using CommunityToolkit.Mvvm.ComponentModel;


namespace Todo.ViewModels
{
    public class TodoListViewModel : ObservableObject
    {
        public TodoListViewModel(IEnumerable<TodoItem> items)
        {
            Items = new ObservableCollection<TodoItem>(items); 
        }

        public ObservableCollection<TodoItem> Items { get; }
    }
}
