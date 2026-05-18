using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using simpleToDoList.Models;
using CommunityToolkit.Mvvm.Input;

namespace simpleToDoList.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<ToDoItemViewModel> ToDoItems { get; } = new ObservableCollection<ToDoItemViewModel>();

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(AddItemCommand))]
        private string? _newItemContent;

        private bool CanAddItem() => !string.IsNullOrWhiteSpace(NewItemContent);

        [RelayCommand(CanExecute = nameof(CanAddItem))]
        private void AddItem()
        {
            ToDoItems.Add(new ToDoItemViewModel() { Content = NewItemContent });

            NewItemContent = null;
        }

        [RelayCommand]
        private void RemoveItem(ToDoItemViewModel item)
        {
            ToDoItems.Remove(item);
        }
    }
}
