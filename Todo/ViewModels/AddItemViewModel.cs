
namespace Todo.ViewModels
{
    class AddItemViewModel : ViewModelBase
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
