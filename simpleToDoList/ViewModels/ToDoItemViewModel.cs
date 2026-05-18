using CommunityToolkit.Mvvm.ComponentModel;
using simpleToDoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace simpleToDoList.ViewModels
{
    public partial class ToDoItemViewModel : ViewModelBase
    {
        public ToDoItemViewModel()
        {
            //empty
        }

        
        public ToDoItemViewModel(ToDoItem item)
        {
            IsChecked = item.IsChecked;
            Content = item.Content;
        }

        [ObservableProperty]
        private bool _isChecked;

        [ObservableProperty]
        private string? _content;

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
