
using CommunityToolkit.Mvvm.ComponentModel;
using Todo.Models;
using Todo.Services;


namespace Todo.ViewModels
{
    class MainWindowViewModel : ObservableObject
    {
        ObservableObject content;

        public MainWindowViewModel(Database db)
        {
            Content = List = new TodoListViewModel(db.GetItems());
        }

        public ObservableObject Content
        {
            get => content;
            private set => this.SetProperty(ref content, value);
        }

        public TodoListViewModel List { get; }

        public void AddItem()
        {
            Content = new AddItemViewModel(this);
        }

        public void ItemAdded(string description)
        {
            if (!string.IsNullOrEmpty(description))
            {
                var model = new TodoItem { Description = description };
                List.Items.Add(model);
            }
            Content = List;
        }
    }
}
