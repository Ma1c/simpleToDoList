using CommunityToolkit.Mvvm.ComponentModel;
using simpleToDoList.Models;

namespace simpleToDoList.ViewModels
{
    public class ToDoItemViewModel : ViewModelBase
    {
        private bool _isChecked;
        private string? _content;

        public ToDoItemViewModel()
        {
        }

        public ToDoItemViewModel(ToDoItem item)
        {
            IsChecked = item.IsChecked;
            Content = item.Content;
        }

        public bool IsChecked
        {
            get => _isChecked;
            set => SetProperty(ref _isChecked, value);
        }

        public string? Content
        {
            get => _content;
            set => SetProperty(ref _content, value);
        }

        public ToDoItem GetToDoItem()
        {
            return new ToDoItem()
            {
                IsChecked = this.IsChecked,
                Content = this.Content
            };
        }
    }
}