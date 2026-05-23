using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.ComponentModel;
using simpleToDoList.Models;
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
            // Save when items are added/removed from the collection
            ToDoItems.CollectionChanged += (s, e) => _storageService.SaveToDoItems(ToDoItems);

            // Save when individual item properties change
            foreach (var item in ToDoItems)
            {
                item.PropertyChanged += Item_PropertyChanged;
            }

            // Handle future items added to the collection
            ToDoItems.CollectionChanged += (s, e) =>
            {
                if (e.NewItems != null)
                {
                    foreach (ToDoItemViewModel item in e.NewItems)
                    {
                        item.PropertyChanged += Item_PropertyChanged;
                    }
                }

                if (e.OldItems != null)
                {
                    foreach (ToDoItemViewModel item in e.OldItems)
                    {
                        item.PropertyChanged -= Item_PropertyChanged;
                    }
                }
            };
        }

        private void Item_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            _storageService.SaveToDoItems(ToDoItems);
        }
    }
}
