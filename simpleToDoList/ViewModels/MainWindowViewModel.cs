using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using simpleToDoList.Models;
using System.Collections.Specialized;
using CommunityToolkit.Mvvm.Input;
using simpleToDoList.Services;

namespace simpleToDoList.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<ToDoItemViewModel> ToDoItems { get; } = new ObservableCollection<ToDoItemViewModel>();
        private readonly JsonStorageService _storageService;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(AddItemCommand))]
        private string? _newItemContent;

        public MainWindowViewModel()
        {
            _storageService = new JsonStorageService();
            LoadToDoItems();
            SubscribeToChanges();
        }

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

        private void LoadToDoItems()
        {
            var items = _storageService.LoadToDoItems();
            ToDoItems.Clear();
            foreach (var item in items)
            {
                ToDoItems.Add(item);
            }
        }

        private void SubscribeToChanges()
        {
            ToDoItems.CollectionChanged += (s, e) => _storageService.SaveToDoItems(ToDoItems);
        }
    }
}
